using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Cryptik
{
    internal class CSImage : CSFile
    {
        /******************************************
         * Private Variables specific to this class
         ******************************************/
        private int height;
        private int width;
        private Bitmap image;
        private string filenameHelper;
        private byte[] imageBytes;
        private byte[] encryptedBytes;

        /******************************************
         * Public Methods
         *****************************************/

        /******************************************
         * CONSTRUCTOR 
         *****************************************/
        public CSImage()
        {
            height = width = 0;
            image = null;
            filename = extension = key = filepath = null;
            imageBytes = encryptedBytes = null;
        }

        /******************************************
         * READ FILE
         *****************************************/
        public override void import(int encryptionType, string _filename)
        {
            if (encryptionType == 1)
            {
                string[] file_ext = _filename.Split('.');
                filename = file_ext[0];
                extension = file_ext[1];
                image = (Bitmap)Bitmap.FromFile(_filename);
                height = image.Height;
                width = image.Width;

            }
            else if (encryptionType == 2)
            {
                filenameHelper = _filename;
                imageBytes = File.ReadAllBytes(_filename);
            }
        }

        /******************************************
         * ENCRYPTION HELPER METHOD
         *****************************************/
        public override void encrypt(int encryptionType)
        {
            if (encryptionType == 1)
            {
                AaliEncrypt();
            }
            else if (encryptionType == 2)
            {
                KyleEncrypt();
            }
        }

        /******************************************
         * DECRYPTION HELPER METHOD
         *****************************************/
        public override void decrypt(int encryptionType)
        {
            if (encryptionType == 1)
            {
                AaliDecrypt();
            }
            else if (encryptionType == 2)
            {
                KyleDecrypt();
            }
        }

        /******************************************
         * SAVE TO FILE
         *****************************************/
        public override void export(bool encrypt, int encryptionType, string _filename)
        {
            if (encryptionType == 1)
            {
                //Graphics g = Graphics.FromImage(image);
                //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                image.Save(_filename);
            }
            else if (encryptionType == 2)
            {
                if (encrypt == true)
                {
                    saveEncrypted(_filename, encryptedBytes);
                }
                else
                {
                    SaveDecrypted(_filename, imageBytes);
                }
            }
        }

        /******************************************
         * Initialize key for encryption/decryption
         *****************************************/
        public override void setKey(string _key)
        {

            key = _key;

            simpleDes._setKey(key);
        }

        /******************************************
         * PRIVATE METHODS
         *****************************************/

        /******************************************
         * ENCRYPTION METHODS
         *****************************************/
        private void AaliEncrypt()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        Color pixel = new Color();
                        Color pixel2 = new Color();
                        pixel = image.GetPixel(w, h);
                        pixel2 = image.GetPixel((w + key[w % key.Length]) % width, (h + key[h % key.Length]) % height);

                        image.SetPixel(w, h, pixel2);
                        image.SetPixel((w + key[w % key.Length]) % width, (h + key[h % key.Length]) % height, pixel);
                    }
                }
            }

            // XOR with key
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = new Color();
                    pixel = image.GetPixel(i, j);
                    int value = pixel.ToArgb();
                    value = value * (-1);
                    value = value ^ key[j % key.Length];
                    image.SetPixel(i, j, Color.FromArgb(value));
                }
            }
        }

        private void KyleEncrypt()
        {
            encryptedBytes = simpleDes.EncryptInfo(imageBytes);  // returns an array of encrypted bytes
            encryptedBytes = simpleDes.insertIV(encryptedBytes); // save IV to begining of encrypted byte array
            bitmapWidthHeight();
        }

        /******************************************
         * DES HELPER METHODS
         *****************************************/
        private byte[] ExportBytesEncrypted()
        {
            byte[] encryptedImageBytes;

            using (var file = new FileStream(filenameHelper, FileMode.Open, FileAccess.Read))
            {
                int total_bytes_to_read = (int)file.Length - 64;
                int current_bytes_read = 0;
                int buffer_bytes_read = 0;             // total number of bytes read into buffer
                encryptedImageBytes = new byte[total_bytes_to_read];
                file.Seek(64, SeekOrigin.Begin);

                while (total_bytes_to_read > 0)
                {
                    buffer_bytes_read = file.Read(encryptedImageBytes, current_bytes_read, total_bytes_to_read);

                    if (buffer_bytes_read == 0)        // all bytes have been read
                        break;

                    total_bytes_to_read -= buffer_bytes_read;
                    current_bytes_read += buffer_bytes_read;
                }
            }
            return encryptedImageBytes;
        }

        private void saveEncrypted(string filename2, byte[] array)
        {
            var t = new Bitmap(width, height);
            t.Save(filename2, ImageFormat.Bmp);
            t.Dispose();

            using (var ms = new MemoryStream(array))
            {
                using (var fileS = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fileS.Seek(64, SeekOrigin.Begin);
                    ms.WriteTo(fileS);

                }
            }
        }

        private void SaveDecrypted(string filename2, byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                using (var fileS = new FileStream(filename2, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    ms.WriteTo(fileS);
                }
            }

        }

        // Set dimensons of encrypted image to insure that decryption doesn't fail
        private void bitmapWidthHeight()
        {
            FileInfo file = new FileInfo(filenameHelper);
            long filesize = (file.Length / 1512);
            double x;
            x = (long)(Math.Sqrt(((filesize * 8 * 1024) / 32)));
            width = (int)x;
            height = (int)x;

        }

        /******************************************
         * DECRYPTION METHODS
         *****************************************/
        private void AaliDecrypt()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int h = height - 1; h >= 0; h--)
                {
                    for (int w = width - 1; w >= 0; w--)
                    {
                        Color pixel = new Color();
                        Color pixel2 = new Color();
                        pixel = image.GetPixel(w, h);
                        pixel2 = image.GetPixel((w + key[w % key.Length]) % width, (h + key[h % key.Length]) % height);

                        image.SetPixel(w, h, pixel2);
                        image.SetPixel((w + key[w % key.Length]) % width, (h + key[h % key.Length]) % height, pixel);
                    }
                }
            }

            // XOR with key
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = new Color();
                    pixel = image.GetPixel(i, j);
                    int value = pixel.ToArgb();
                    value = value ^ key[j % key.Length];
                    value = value * (-1);
                    image.SetPixel(i, j, Color.FromArgb(value));
                }
            }
        }

        private void KyleDecrypt()
        {
            imageBytes = ExportBytesEncrypted();                // grapbs the encrypted picture bytes 
            imageBytes = simpleDes.GetIV(imageBytes);            // get IV from array and save encryptedBytes         
            imageBytes = simpleDes.DecBytes(imageBytes);    // pass the encrypted bytes into function and get the decrypted byte array
        }
    }
}
