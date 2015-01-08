// Simple DES ebcryption Method


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cryptik
{
    public class simpleDes : CSFile
    {
        private static byte[] IV = { 0x00, 0X00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        private static byte[] keyBytes;
        private static string _filename;

        public static void getFileName(string file)
        {
            _filename = file;
        }

        public static void _setKey(string _key)
        {
            // key has to be 8 characters is length
            if (_key.Length < 8)
            {
                int count = 0;
                while (_key.Length < 8)
                {
                    _key += _key[count];
                    count++;
                }
            }
            else if (_key.Length > 8)
                _key = _key.Substring(0, 8);

            keyBytes = Encoding.UTF8.GetBytes(_key);
        }

        public static byte[] EncryptInfo(byte[] secreteBytes)
        {
            byte[] encryptedText;
            using (var desCrypto = new DESCryptoServiceProvider())
            {
                desCrypto.Key = keyBytes; // set the key from user inputed key
                IV = desCrypto.IV; //{remove} // Intialization vector is randomly generatyed

                // Encryptor object is created using user key and IV (initialization vector). Preforms stream transform. 
                ICryptoTransform encryptor = desCrypto.CreateEncryptor(desCrypto.Key, desCrypto.IV);

                // memory stream
                using (var msEncrypt = new MemoryStream())
                {
                    // crypto stream
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // stream writer 
                        using (var swEncrypt = new BinaryWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(secreteBytes);
                            swEncrypt.Flush();
                        }
                        encryptedText = msEncrypt.ToArray(); // create array of bytes of encrypted data from stream
                    }
                }
            }

            return encryptedText;
        }


        // Decrypts encrypted array of bytes and returns the decrypted string 
        public static string decrypt_text(byte[] encryptedText)
        {
            string plainText = null;
            try
            {
                using (var desDec = new DESCryptoServiceProvider())
                {
                    desDec.Key = keyBytes; // user inputed key
                    desDec.IV = IV; // IV is stored with the encrypted text

                    // create decryptor object. Uses key and IV to decrypt stream
                    ICryptoTransform decryptor = desDec.CreateDecryptor(desDec.Key, desDec.IV);

                    using (var msDecrypt = new MemoryStream(encryptedText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                plainText = srDecrypt.ReadToEnd(); // read decrypted text from stream into string
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Passcode incorrect or corrupted data");
            }

            //return decryptred string 
            return plainText;
        }

        // Takes array of encrypted bytes returns array of the decrypted bytes
        public static byte[] DecBytes(byte[] encryptedBytes)
        {
            var decryptedBytes = new byte[0];
            try
            {
                using (var desDec = new DESCryptoServiceProvider())
                {
                    desDec.Key = keyBytes; // user inputed key
                    desDec.IV = IV; // IV is stored with the encrypted text

                    // create decryptor object. Uses key and IV to decrypt stream
                    ICryptoTransform decryptor = desDec.CreateDecryptor(desDec.Key, desDec.IV);

                    using (var msDecrypt = new MemoryStream(encryptedBytes))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var binaryDec = new BinaryReader(csDecrypt))
                            {
                                //Write all data to the stream.
                                decryptedBytes = binaryDec.ReadBytes(encryptedBytes.Length);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Passcode incorrect or corrupted data");
            }

            //return decryptred string 
            return decryptedBytes;
        }

        // Retrieve encrypted text from file
        public static byte[] GetEncryptedText(string encrypted)
        {
            byte[] encryptedBytes = null;
            int count = 0;

            encryptedBytes = Convert.FromBase64String(encrypted); // retrieve encrypted information from base64 string

            IEnumerable<byte> retrivedIV = encryptedBytes.Take(8); // IV is stored at first 8 bytes of text string
            foreach (byte byteIV in retrivedIV) // fill IV byte array
            {
                IV[count++] = byteIV;
            }
            //get just the encrypted text without the IV
            var encryptedText = new byte[encryptedBytes.Length - IV.Length];
            Array.Copy(encryptedBytes, 8, encryptedText, 0, (encryptedBytes.Length - IV.Length));

            return encryptedText;
        }


        // Write encrypted text to file
        public static string WriteEncryptedText(byte[] encryptedText)
        {
            string text = "";
            var IVAndEncryptedText = new byte[IV.Length + encryptedText.Length];

            IV.CopyTo(IVAndEncryptedText, 0);
            encryptedText.CopyTo(IVAndEncryptedText, IV.Length);
            text = Convert.ToBase64String(IVAndEncryptedText);  // convert encrypted bytes to base64 string
            // ran into a data loss problem when this wasn't done
            // When decrypting Error: Length of data is invalid
            return text;
        }

        // places Initialization Vector at begining of encrypted byte array
        public static byte[] insertIV(byte[] encryptedText)
        {
            var ivAndEncryptedText = new byte[IV.Length + encryptedText.Length];

            IV.CopyTo(ivAndEncryptedText, 0);
            encryptedText.CopyTo(ivAndEncryptedText, IV.Length);
            return ivAndEncryptedText;
        }

        public static byte[] GetIV(byte[] encryptedBytes)
        {
            int count = 0;
            IEnumerable<byte> retrivedIV = encryptedBytes.Take(8); // IV is stored at first 8 bytes of text string
            foreach (byte byteIV in retrivedIV) // fill IV byte array
            {
                IV[count++] = byteIV;
            }
            //get just the encrypted text without the IV
            var encryptedText = new byte[encryptedBytes.Length - IV.Length];
            Array.Copy(encryptedBytes, 8, encryptedText, 0, (encryptedBytes.Length - IV.Length));

            return encryptedText;
        }
    }
}