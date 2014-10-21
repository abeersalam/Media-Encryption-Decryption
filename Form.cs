using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace @new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            System.IO.FileStream myStream = null;                                   
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            lblFileName.Visible = true;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPath.Visible = true;
                lblFileName.Text = openFileDialog1.FileName;
                string line = null;
                System.IO.StreamReader file = new System.IO.StreamReader(lblFileName.Text);
                line = file.ReadLine();
                txtBoxOriginal.Text = line;
                txtBoxOriginal.Visible = true;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            btnFile.Visible = false;
            btnPhoto.Visible = false;
            label1.Visible = false;
            btnFileUpload.Visible = true;
            cmbEncriptFile.Visible = true;
            lblOriginalFile.Visible = true;
            lblDecriptedFile.Visible = true;
            btnEncriptDocument.Visible = true;
            photoPreview.Visible = true;
            picDecriptPreview.Visible = true;
            cmbDecriptFile.Visible = true;
            btnDecriptFile.Visible = true;
        }

        private void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            System.IO.FileStream myStream = null;
            OpenFileDialog openPhotoDialog = new OpenFileDialog();
            openPhotoDialog.InitialDirectory = "c:\\";
            openPhotoDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openPhotoDialog.FilterIndex = 2;
            openPhotoDialog.RestoreDirectory = true;
            
            
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Visible = true;
                lblFileName.Text = openPhotoDialog.FileName;
                lblFileName.Visible = true;
                photoPreview.Load(openPhotoDialog.FileName);
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
            cmbEncriptPicture.Visible = true;
            photoPreview.Visible = true;
            picDecriptPreview.Visible = true;
            lblOriginalPhoto.Visible = true;
            lblDecriptedPhoto.Visible = true;
            btnEncriptPhoto.Visible = true;
            cmbDecriptPhoto.Visible = true;
            btnDecriptPhoto.Visible = true;
        }

        private void btnEncriptPhoto_click(object sender, EventArgs e)
        {
            picDecriptPreview.Load("c:\\Users\\jaridgoodwin\\Pictures\\20060130uru4000encrypted.jpg");
            picDecriptPreview.Visible = true;
            lblArrow.Visible = true;
        }

        private void btnEncriptDocument_Click(object sender, EventArgs e)
        {
            
        }
    }
}
