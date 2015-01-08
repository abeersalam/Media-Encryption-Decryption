namespace Cryptik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhotoUpload = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.photoPreview = new System.Windows.Forms.PictureBox();
            this.photoFileName = new System.Windows.Forms.Label();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblOriginalPhoto = new System.Windows.Forms.Label();
            this.lblModifiedPhoto = new System.Windows.Forms.Label();
            this.picModPreview = new System.Windows.Forms.PictureBox();
            this.btnEncryptPhoto = new System.Windows.Forms.Button();
            this.lblModifiedFile = new System.Windows.Forms.Label();
            this.lblOriginalFile = new System.Windows.Forms.Label();
            this.cmbEncryptPicture = new System.Windows.Forms.ComboBox();
            this.cmbEncryptFile = new System.Windows.Forms.ComboBox();
            this.btnEncryptDocument = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.cmbDecryptFile = new System.Windows.Forms.ComboBox();
            this.cmbDecryptPhoto = new System.Windows.Forms.ComboBox();
            this.btnDecryptPhoto = new System.Windows.Forms.Button();
            this.txtBoxOriginal = new System.Windows.Forms.RichTextBox();
            this.txtMod = new System.Windows.Forms.RichTextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblOutFile = new System.Windows.Forms.Label();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Location = new System.Drawing.Point(32, 442);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(75, 23);
            this.btnFileUpload.TabIndex = 0;
            this.btnFileUpload.Text = "Upload File";
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Visible = false;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would you like to encrypt/decrypt a photo or a file?";
            // 
            // btnPhotoUpload
            // 
            this.btnPhotoUpload.Location = new System.Drawing.Point(32, 442);
            this.btnPhotoUpload.Name = "btnPhotoUpload";
            this.btnPhotoUpload.Size = new System.Drawing.Size(84, 23);
            this.btnPhotoUpload.TabIndex = 2;
            this.btnPhotoUpload.Text = "Upload Photo";
            this.btnPhotoUpload.UseVisualStyleBackColor = true;
            this.btnPhotoUpload.Visible = false;
            this.btnPhotoUpload.Click += new System.EventHandler(this.btnPhotoUpload_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(308, 51);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(74, 32);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.Location = new System.Drawing.Point(466, 51);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(74, 32);
            this.btnPhoto.TabIndex = 4;
            this.btnPhoto.Text = "Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // photoPreview
            // 
            this.photoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPreview.Location = new System.Drawing.Point(18, 51);
            this.photoPreview.Name = "photoPreview";
            this.photoPreview.Size = new System.Drawing.Size(355, 374);
            this.photoPreview.TabIndex = 5;
            this.photoPreview.TabStop = false;
            this.photoPreview.Visible = false;
            // 
            // photoFileName
            // 
            this.photoFileName.AutoSize = true;
            this.photoFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoFileName.Location = new System.Drawing.Point(144, 45);
            this.photoFileName.Name = "photoFileName";
            this.photoFileName.Size = new System.Drawing.Size(0, 20);
            this.photoFileName.TabIndex = 6;
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openPhotoDialog";
            // 
            // lblOriginalPhoto
            // 
            this.lblOriginalPhoto.AllowDrop = true;
            this.lblOriginalPhoto.AutoSize = true;
            this.lblOriginalPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPhoto.Location = new System.Drawing.Point(108, 19);
            this.lblOriginalPhoto.Name = "lblOriginalPhoto";
            this.lblOriginalPhoto.Size = new System.Drawing.Size(171, 25);
            this.lblOriginalPhoto.TabIndex = 9;
            this.lblOriginalPhoto.Text = "Original Image:";
            this.lblOriginalPhoto.Visible = false;
            // 
            // lblModifiedPhoto
            // 
            this.lblModifiedPhoto.AllowDrop = true;
            this.lblModifiedPhoto.AutoSize = true;
            this.lblModifiedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedPhoto.Location = new System.Drawing.Point(546, 19);
            this.lblModifiedPhoto.Name = "lblModifiedPhoto";
            this.lblModifiedPhoto.Size = new System.Drawing.Size(179, 25);
            this.lblModifiedPhoto.TabIndex = 11;
            this.lblModifiedPhoto.Text = "Modified Image:";
            this.lblModifiedPhoto.Visible = false;
            // 
            // picModPreview
            // 
            this.picModPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picModPreview.Location = new System.Drawing.Point(466, 51);
            this.picModPreview.Name = "picModPreview";
            this.picModPreview.Size = new System.Drawing.Size(355, 374);
            this.picModPreview.TabIndex = 10;
            this.picModPreview.TabStop = false;
            this.picModPreview.Visible = false;
            // 
            // btnEncryptPhoto
            // 
            this.btnEncryptPhoto.Location = new System.Drawing.Point(32, 509);
            this.btnEncryptPhoto.Name = "btnEncryptPhoto";
            this.btnEncryptPhoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEncryptPhoto.Size = new System.Drawing.Size(121, 38);
            this.btnEncryptPhoto.TabIndex = 12;
            this.btnEncryptPhoto.Text = "Cryptify Photo";
            this.btnEncryptPhoto.UseVisualStyleBackColor = true;
            this.btnEncryptPhoto.Visible = false;
            this.btnEncryptPhoto.Click += new System.EventHandler(this.btnEncryptPhoto_click);
            // 
            // lblModifiedFile
            // 
            this.lblModifiedFile.AllowDrop = true;
            this.lblModifiedFile.AutoSize = true;
            this.lblModifiedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedFile.Location = new System.Drawing.Point(558, 20);
            this.lblModifiedFile.Name = "lblModifiedFile";
            this.lblModifiedFile.Size = new System.Drawing.Size(155, 25);
            this.lblModifiedFile.TabIndex = 14;
            this.lblModifiedFile.Text = "Modified File:";
            this.lblModifiedFile.Visible = false;
            // 
            // lblOriginalFile
            // 
            this.lblOriginalFile.AllowDrop = true;
            this.lblOriginalFile.AutoSize = true;
            this.lblOriginalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalFile.Location = new System.Drawing.Point(108, 20);
            this.lblOriginalFile.Name = "lblOriginalFile";
            this.lblOriginalFile.Size = new System.Drawing.Size(147, 25);
            this.lblOriginalFile.TabIndex = 13;
            this.lblOriginalFile.Text = "Original File:";
            this.lblOriginalFile.Visible = false;
            // 
            // cmbEncryptPicture
            // 
            this.cmbEncryptPicture.FormattingEnabled = true;
            this.cmbEncryptPicture.Items.AddRange(new object[] {
            "ACS",
            "DES"});
            this.cmbEncryptPicture.Location = new System.Drawing.Point(32, 482);
            this.cmbEncryptPicture.Name = "cmbEncryptPicture";
            this.cmbEncryptPicture.Size = new System.Drawing.Size(121, 21);
            this.cmbEncryptPicture.TabIndex = 16;
            this.cmbEncryptPicture.Text = "Select Algorithm";
            this.cmbEncryptPicture.Visible = false;
            // 
            // cmbEncryptFile
            // 
            this.cmbEncryptFile.FormattingEnabled = true;
            this.cmbEncryptFile.Items.AddRange(new object[] {
            "MSE",
            "DES"});
            this.cmbEncryptFile.Location = new System.Drawing.Point(32, 481);
            this.cmbEncryptFile.Name = "cmbEncryptFile";
            this.cmbEncryptFile.Size = new System.Drawing.Size(121, 21);
            this.cmbEncryptFile.TabIndex = 17;
            this.cmbEncryptFile.Text = "Select Algorithm";
            this.cmbEncryptFile.Visible = false;
            // 
            // btnEncryptDocument
            // 
            this.btnEncryptDocument.Location = new System.Drawing.Point(32, 509);
            this.btnEncryptDocument.Name = "btnEncryptDocument";
            this.btnEncryptDocument.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEncryptDocument.Size = new System.Drawing.Size(121, 38);
            this.btnEncryptDocument.TabIndex = 18;
            this.btnEncryptDocument.Text = "Cryptify File";
            this.btnEncryptDocument.UseVisualStyleBackColor = true;
            this.btnEncryptDocument.Visible = false;
            this.btnEncryptDocument.Click += new System.EventHandler(this.btnEncryptDocument_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(387, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 57);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cryptik Solutions";
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(168, 508);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDecryptFile.Size = new System.Drawing.Size(121, 38);
            this.btnDecryptFile.TabIndex = 23;
            this.btnDecryptFile.Text = "De-Cryptify File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Visible = false;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // cmbDecryptFile
            // 
            this.cmbDecryptFile.FormattingEnabled = true;
            this.cmbDecryptFile.Items.AddRange(new object[] {
            "MSE",
            "DES"});
            this.cmbDecryptFile.Location = new System.Drawing.Point(168, 481);
            this.cmbDecryptFile.Name = "cmbDecryptFile";
            this.cmbDecryptFile.Size = new System.Drawing.Size(121, 21);
            this.cmbDecryptFile.TabIndex = 22;
            this.cmbDecryptFile.Text = "Select Algorithm";
            this.cmbDecryptFile.Visible = false;
            // 
            // cmbDecryptPhoto
            // 
            this.cmbDecryptPhoto.FormattingEnabled = true;
            this.cmbDecryptPhoto.Items.AddRange(new object[] {
            "ACS",
            "DES"});
            this.cmbDecryptPhoto.Location = new System.Drawing.Point(168, 482);
            this.cmbDecryptPhoto.Name = "cmbDecryptPhoto";
            this.cmbDecryptPhoto.Size = new System.Drawing.Size(121, 21);
            this.cmbDecryptPhoto.TabIndex = 21;
            this.cmbDecryptPhoto.Text = "Select Algorithm";
            this.cmbDecryptPhoto.Visible = false;
            // 
            // btnDecryptPhoto
            // 
            this.btnDecryptPhoto.Location = new System.Drawing.Point(168, 509);
            this.btnDecryptPhoto.Name = "btnDecryptPhoto";
            this.btnDecryptPhoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDecryptPhoto.Size = new System.Drawing.Size(121, 38);
            this.btnDecryptPhoto.TabIndex = 20;
            this.btnDecryptPhoto.Text = "De-Cryptify Photo";
            this.btnDecryptPhoto.UseVisualStyleBackColor = true;
            this.btnDecryptPhoto.Visible = false;
            this.btnDecryptPhoto.Click += new System.EventHandler(this.btnDecryptPhoto_Click);
            // 
            // txtBoxOriginal
            // 
            this.txtBoxOriginal.Enabled = false;
            this.txtBoxOriginal.Location = new System.Drawing.Point(18, 51);
            this.txtBoxOriginal.Name = "txtBoxOriginal";
            this.txtBoxOriginal.Size = new System.Drawing.Size(355, 374);
            this.txtBoxOriginal.TabIndex = 24;
            this.txtBoxOriginal.Text = "";
            this.txtBoxOriginal.Visible = false;
            // 
            // txtMod
            // 
            this.txtMod.Enabled = false;
            this.txtMod.Location = new System.Drawing.Point(466, 51);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(355, 374);
            this.txtMod.TabIndex = 25;
            this.txtMod.Text = "";
            this.txtMod.Visible = false;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(335, 468);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(204, 20);
            this.txtpass.TabIndex = 26;
            this.txtpass.Visible = false;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(331, 442);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(83, 20);
            this.lblpass.TabIndex = 27;
            this.lblpass.Text = "Passcode:";
            this.lblpass.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(2, 4);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(61, 13);
            this.lblPath.TabIndex = 8;
            this.lblPath.Text = "File Path:";
            this.lblPath.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(69, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(33, 7);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "fileName";
            this.lblFileName.Visible = false;
            // 
            // lblOutFile
            // 
            this.lblOutFile.AutoSize = true;
            this.lblOutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutFile.Location = new System.Drawing.Point(331, 507);
            this.lblOutFile.Name = "lblOutFile";
            this.lblOutFile.Size = new System.Drawing.Size(131, 20);
            this.lblOutFile.TabIndex = 29;
            this.lblOutFile.Text = "Output Filename:";
            this.lblOutFile.Visible = false;
            // 
            // txtOutFile
            // 
            this.txtOutFile.Location = new System.Drawing.Point(335, 530);
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(204, 20);
            this.txtOutFile.TabIndex = 28;
            this.txtOutFile.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 106);
            this.button2.TabIndex = 31;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOutFile);
            this.Controls.Add(this.txtOutFile);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtBoxOriginal);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.cmbDecryptFile);
            this.Controls.Add(this.cmbDecryptPhoto);
            this.Controls.Add(this.btnDecryptPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncryptDocument);
            this.Controls.Add(this.cmbEncryptFile);
            this.Controls.Add(this.cmbEncryptPicture);
            this.Controls.Add(this.lblModifiedFile);
            this.Controls.Add(this.lblOriginalFile);
            this.Controls.Add(this.btnEncryptPhoto);
            this.Controls.Add(this.lblModifiedPhoto);
            this.Controls.Add(this.picModPreview);
            this.Controls.Add(this.lblOriginalPhoto);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.photoFileName);
            this.Controls.Add(this.photoPreview);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPhotoUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFileUpload);
            this.Name = "Form1";
            this.Text = "Cryptify It!";
            ((System.ComponentModel.ISupportInitialize)(this.photoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhotoUpload;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox photoPreview;
        private System.Windows.Forms.Label photoFileName;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
        private System.Windows.Forms.Label lblOriginalPhoto;
        private System.Windows.Forms.Label lblModifiedPhoto;
        private System.Windows.Forms.PictureBox picModPreview;
        private System.Windows.Forms.Button btnEncryptPhoto;
        private System.Windows.Forms.Label lblModifiedFile;
        private System.Windows.Forms.Label lblOriginalFile;
        private System.Windows.Forms.ComboBox cmbEncryptPicture;
        private System.Windows.Forms.ComboBox cmbEncryptFile;
        private System.Windows.Forms.Button btnEncryptDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.ComboBox cmbDecryptFile;
        private System.Windows.Forms.ComboBox cmbDecryptPhoto;
        private System.Windows.Forms.Button btnDecryptPhoto;
        private System.Windows.Forms.RichTextBox txtBoxOriginal;
        private System.Windows.Forms.RichTextBox txtMod;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblOutFile;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Button button2;

    }
}