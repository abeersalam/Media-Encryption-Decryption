using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Cryptik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string inFileName;
        public string outFileName;

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:/";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            lblFileName.Visible = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                lblFileName.Text = openFileDialog1.FileName;
                inFileName = openFileDialog1.FileName;
                string[] file_ext = inFileName.Split('.');
                lblPath.Visible = true;
                if (file_ext[1].ToLower() == "txt")
                {
                    string line = null;
                    System.IO.StreamReader file = new System.IO.StreamReader(inFileName);
                    line = file.ReadToEnd();
                    txtBoxOriginal.Text = line;
                    txtBoxOriginal.Enabled = true;
                    file.Close();
                }else
                {
                    txtBoxOriginal.Text = "Feature only available with text documents";
                }
                txtBoxOriginal.Visible = true;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            btnFile.Visible = false;
            btnPhoto.Visible = false;
            label1.Visible = false;
            btnFileUpload.Visible = true;
            cmbEncryptFile.Visible = true;
            lblOriginalFile.Visible = true;
            lblModifiedFile.Visible = true;
            btnEncryptDocument.Visible = true;
            cmbDecryptFile.Visible = true;
            btnDecryptFile.Visible = true;
            lblpass.Visible = true;
            txtpass.Visible = true;
            txtBoxOriginal.Visible = true;
            txtMod.Visible = true;
            lblOutFile.Visible = true;
            txtOutFile.Visible = true;
        }

        private void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog();
            openPhotoDialog.InitialDirectory = "c:/";
            openPhotoDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openPhotoDialog.FilterIndex = 2;
            openPhotoDialog.RestoreDirectory = true;


            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Visible = true;
                lblFileName.Text = openPhotoDialog.FileName;
                inFileName = openPhotoDialog.FileName;
                lblFileName.Visible = true;
                photoPreview.Load(inFileName);
                photoPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            btnPhotoUpload.Visible = true;
            photoFileName.Visible = true;
            btnFile.Visible = false;
            btnPhoto.Visible = false;
            label1.Visible = false;
            cmbEncryptPicture.Visible = true;
            photoPreview.Visible = true;
            picModPreview.Visible = true;
            lblOriginalPhoto.Visible = true;
            lblModifiedPhoto.Visible = true;
            btnEncryptPhoto.Visible = true;
            cmbDecryptPhoto.Visible = true;
            btnDecryptPhoto.Visible = true;
            lblpass.Visible = true;
            txtpass.Visible = true;

            lblOutFile.Visible = true;
            txtOutFile.Visible = true;
        }

        private void btnEncryptPhoto_click(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                MessageBox.Show("No passcode entered");
            }
            else if (cmbEncryptPicture.SelectedIndex == -1)
            {
                MessageBox.Show("No Algorithm selected");
            }
            else
            {
                int alg = cmbEncryptPicture.SelectedIndex + 1;
                string[] file_ext = inFileName.Split('.');
                string outPath = "C:/" + txtOutFile.Text + "." + file_ext[1];
                string pass = txtpass.Text;
                picModPreview.Visible = true;
                
                program(inFileName, true, alg, outPath, pass);
                picModPreview.Load(outPath);
                picModPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnEncryptDocument_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                MessageBox.Show("No passcode entered");
            }
             else if (cmbEncryptFile.SelectedIndex == -1)
            {
                MessageBox.Show("No Algorithm selected");
            }
            else
            {
                int alg = cmbEncryptFile.SelectedIndex + 1;
                string[] file_ext = inFileName.Split('.');
                string outPath = "C:/" + txtOutFile.Text + "." + file_ext[1];
                string pass = txtpass.Text;
                program(inFileName, true, alg, outPath, pass);
                if (file_ext[1].ToLower() == "txt")
                {
                    string line2 = null;
                    System.IO.StreamReader file = new System.IO.StreamReader(outPath);
                    line2 = file.ReadToEnd();
                    txtMod.Text = line2;
                    txtMod.Enabled = true;
                    file.Close();
                }else{
                    txtMod.Text = "Feature only available witfh text documents";
                }
                txtMod.Visible = true;
                
            }
        }

        public void program(string input_filename, bool encrypt, int encryptionType, string output_file, string key) 
        {
            if (File.Exists(input_filename))
            {
                string[] file_ext = input_filename.Split('.');
                file_ext[1] = file_ext[1].ToLower();

                CSFile test;
                if (file_ext[1] == "doc" || file_ext[1] == "docx" || file_ext[1] == "txt" || file_ext[1] == "xls" ||
                    file_ext[1] == "xlsx")
                {
                    // Documents
                    test = new CSDocument();
                    test.import(encryptionType, input_filename);
                    test.setKey(key);

                    if (encrypt == true)
                    {
                        test.encrypt(encryptionType);
                    }
                    else
                    {
                        test.decrypt(encryptionType);
                    }

                    test.export(encrypt, encryptionType, output_file);
                }
                else if (file_ext[1] == "png" || file_ext[1] == "bmp" || file_ext[1] == "jpg" || file_ext[1] == "jpeg")
                {
                    // Images
                    test = new CSImage();
                    test.import(encryptionType, input_filename);
                    test.setKey(key);

                    if (encrypt == true)
                    {
                        test.encrypt(encryptionType);
                    }
                    else
                    {
                        test.decrypt(encryptionType);
                    }

                    test.export(encrypt, encryptionType, output_file);
                }
            }
           }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                MessageBox.Show("No passcode entered");
            }
            else if (cmbDecryptFile.SelectedIndex == -1)
            {
                MessageBox.Show("No Algorithm selected");
            }
            else
            {
                int alg = cmbDecryptFile.SelectedIndex + 1;
                string[] file_ext = inFileName.Split('.');
                string outPath = "C:/" + txtOutFile.Text + "." + file_ext[1];
                string pass = txtpass.Text;
                program(inFileName, false, alg, outPath, pass);

                if (file_ext[1].ToLower() == "txt")
                {
                    string line2 = null;
                    System.IO.StreamReader file = new System.IO.StreamReader(outPath);
                    line2 = file.ReadToEnd();
                    txtMod.Text = line2;
                    txtMod.Enabled = true;
                    txtMod.Text = line2;
                }
                else
                {
                    txtMod.Text = "Feature only available with text documents";
                }
                txtMod.Visible = true;
            }
        }

        private void btnDecryptPhoto_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                MessageBox.Show("No passcode entered");
            }
            else if (cmbDecryptPhoto.SelectedIndex == -1)
            {
                MessageBox.Show("No Algorithm selected");
            }
            else
            {
                int alg = cmbDecryptPhoto.SelectedIndex + 1;
                string[] file_ext = inFileName.Split('.');
                string outPath = "C:/" + txtOutFile.Text + "." + file_ext[1];
                string pass = txtpass.Text;
                picModPreview.Visible = true;
                
                program(inFileName, false, alg, outPath, pass);
                picModPreview.Load(outPath);
                picModPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}