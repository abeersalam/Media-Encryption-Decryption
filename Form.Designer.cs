namespace @new
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblOriginalPhoto = new System.Windows.Forms.Label();
            this.lblDecriptedPhoto = new System.Windows.Forms.Label();
            this.picDecriptPreview = new System.Windows.Forms.PictureBox();
            this.btnEncriptPhoto = new System.Windows.Forms.Button();
            this.lblDecriptedFile = new System.Windows.Forms.Label();
            this.lblOriginalFile = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.cmbEncriptPicture = new System.Windows.Forms.ComboBox();
            this.cmbEncriptFile = new System.Windows.Forms.ComboBox();
            this.btnEncriptDocument = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecriptFile = new System.Windows.Forms.Button();
            this.cmbDecriptFile = new System.Windows.Forms.ComboBox();
            this.cmbDecriptPhoto = new System.Windows.Forms.ComboBox();
            this.btnDecriptPhoto = new System.Windows.Forms.Button();
            this.txtBoxOriginal = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDecriptPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Location = new System.Drawing.Point(22, 246);
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
            this.label1.Font = new System.Drawing.Font("Moire", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would you like to encript/decript a photo or a file?";
            // 
            // btnPhotoUpload
            // 
            this.btnPhotoUpload.Location = new System.Drawing.Point(22, 246);
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
            this.btnFile.Location = new System.Drawing.Point(158, 51);
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
            this.btnPhoto.Location = new System.Drawing.Point(351, 51);
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
            this.photoPreview.Location = new System.Drawing.Point(25, 45);
            this.photoPreview.Name = "photoPreview";
            this.photoPreview.Size = new System.Drawing.Size(176, 195);
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
            // lblOriginalPhoto
            // 
            this.lblOriginalPhoto.AllowDrop = true;
            this.lblOriginalPhoto.AutoSize = true;
            this.lblOriginalPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPhoto.Location = new System.Drawing.Point(17, 17);
            this.lblOriginalPhoto.Name = "lblOriginalPhoto";
            this.lblOriginalPhoto.Size = new System.Drawing.Size(171, 25);
            this.lblOriginalPhoto.TabIndex = 9;
            this.lblOriginalPhoto.Text = "Original Image:";
            this.lblOriginalPhoto.Visible = false;
            // 
            // lblDecriptedPhoto
            // 
            this.lblDecriptedPhoto.AllowDrop = true;
            this.lblDecriptedPhoto.AutoSize = true;
            this.lblDecriptedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecriptedPhoto.Location = new System.Drawing.Point(355, 17);
            this.lblDecriptedPhoto.Name = "lblDecriptedPhoto";
            this.lblDecriptedPhoto.Size = new System.Drawing.Size(190, 25);
            this.lblDecriptedPhoto.TabIndex = 11;
            this.lblDecriptedPhoto.Text = "Decripted Image:";
            this.lblDecriptedPhoto.Visible = false;
            // 
            // picDecriptPreview
            // 
            this.picDecriptPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDecriptPreview.Location = new System.Drawing.Point(361, 45);
            this.picDecriptPreview.Name = "picDecriptPreview";
            this.picDecriptPreview.Size = new System.Drawing.Size(176, 195);
            this.picDecriptPreview.TabIndex = 10;
            this.picDecriptPreview.TabStop = false;
            this.picDecriptPreview.Visible = false;
            // 
            // btnEncriptPhoto
            // 
            this.btnEncriptPhoto.Location = new System.Drawing.Point(22, 313);
            this.btnEncriptPhoto.Name = "btnEncriptPhoto";
            this.btnEncriptPhoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEncriptPhoto.Size = new System.Drawing.Size(121, 23);
            this.btnEncriptPhoto.TabIndex = 12;
            this.btnEncriptPhoto.Text = "Encript Photo";
            this.btnEncriptPhoto.UseVisualStyleBackColor = true;
            this.btnEncriptPhoto.Visible = false;
            this.btnEncriptPhoto.Click += new System.EventHandler(this.btnEncriptPhoto_click);
            // 
            // lblDecriptedFile
            // 
            this.lblDecriptedFile.AllowDrop = true;
            this.lblDecriptedFile.AutoSize = true;
            this.lblDecriptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecriptedFile.Location = new System.Drawing.Point(355, 20);
            this.lblDecriptedFile.Name = "lblDecriptedFile";
            this.lblDecriptedFile.Size = new System.Drawing.Size(166, 25);
            this.lblDecriptedFile.TabIndex = 14;
            this.lblDecriptedFile.Text = "Decripted File:";
            this.lblDecriptedFile.Visible = false;
            // 
            // lblOriginalFile
            // 
            this.lblOriginalFile.AllowDrop = true;
            this.lblOriginalFile.AutoSize = true;
            this.lblOriginalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalFile.Location = new System.Drawing.Point(20, 20);
            this.lblOriginalFile.Name = "lblOriginalFile";
            this.lblOriginalFile.Size = new System.Drawing.Size(147, 25);
            this.lblOriginalFile.TabIndex = 13;
            this.lblOriginalFile.Text = "Original File:";
            this.lblOriginalFile.Visible = false;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Moire", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(207, 85);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(148, 116);
            this.lblArrow.TabIndex = 15;
            this.lblArrow.Text = "->";
            this.lblArrow.Visible = false;
            // 
            // cmbEncriptPicture
            // 
            this.cmbEncriptPicture.FormattingEnabled = true;
            this.cmbEncriptPicture.Items.AddRange(new object[] {
            "AES",
            "Nightstale"});
            this.cmbEncriptPicture.Location = new System.Drawing.Point(22, 286);
            this.cmbEncriptPicture.Name = "cmbEncriptPicture";
            this.cmbEncriptPicture.Size = new System.Drawing.Size(121, 21);
            this.cmbEncriptPicture.TabIndex = 16;
            this.cmbEncriptPicture.Text = "Select Algorithm";
            this.cmbEncriptPicture.Visible = false;
            // 
            // cmbEncriptFile
            // 
            this.cmbEncriptFile.FormattingEnabled = true;
            this.cmbEncriptFile.Items.AddRange(new object[] {
            "XOR Vigenere Cipher",
            "Number 2",
            "Number 3"});
            this.cmbEncriptFile.Location = new System.Drawing.Point(22, 286);
            this.cmbEncriptFile.Name = "cmbEncriptFile";
            this.cmbEncriptFile.Size = new System.Drawing.Size(121, 21);
            this.cmbEncriptFile.TabIndex = 17;
            this.cmbEncriptFile.Text = "Select Algorithm";
            this.cmbEncriptFile.Visible = false;
            // 
            // btnEncriptDocument
            // 
            this.btnEncriptDocument.Location = new System.Drawing.Point(23, 313);
            this.btnEncriptDocument.Name = "btnEncriptDocument";
            this.btnEncriptDocument.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEncriptDocument.Size = new System.Drawing.Size(121, 23);
            this.btnEncriptDocument.TabIndex = 18;
            this.btnEncriptDocument.Text = "Encript File";
            this.btnEncriptDocument.UseVisualStyleBackColor = true;
            this.btnEncriptDocument.Visible = false;
            this.btnEncriptDocument.Click += new System.EventHandler(this.btnEncriptDocument_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 56);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cryptik Solutions";
            // 
            // btnDecriptFile
            // 
            this.btnDecriptFile.Location = new System.Drawing.Point(156, 313);
            this.btnDecriptFile.Name = "btnDecriptFile";
            this.btnDecriptFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDecriptFile.Size = new System.Drawing.Size(121, 23);
            this.btnDecriptFile.TabIndex = 23;
            this.btnDecriptFile.Text = "Decript File";
            this.btnDecriptFile.UseVisualStyleBackColor = true;
            this.btnDecriptFile.Visible = false;
            // 
            // cmbDecriptFile
            // 
            this.cmbDecriptFile.FormattingEnabled = true;
            this.cmbDecriptFile.Items.AddRange(new object[] {
            "XOR Vigenere Cipher",
            "Number 2",
            "Number 3"});
            this.cmbDecriptFile.Location = new System.Drawing.Point(158, 286);
            this.cmbDecriptFile.Name = "cmbDecriptFile";
            this.cmbDecriptFile.Size = new System.Drawing.Size(121, 21);
            this.cmbDecriptFile.TabIndex = 22;
            this.cmbDecriptFile.Text = "Select Algorithm";
            this.cmbDecriptFile.Visible = false;
            // 
            // cmbDecriptPhoto
            // 
            this.cmbDecriptPhoto.FormattingEnabled = true;
            this.cmbDecriptPhoto.Items.AddRange(new object[] {
            "AES",
            "Nightstale"});
            this.cmbDecriptPhoto.Location = new System.Drawing.Point(158, 286);
            this.cmbDecriptPhoto.Name = "cmbDecriptPhoto";
            this.cmbDecriptPhoto.Size = new System.Drawing.Size(121, 21);
            this.cmbDecriptPhoto.TabIndex = 21;
            this.cmbDecriptPhoto.Text = "Select Algorithm";
            this.cmbDecriptPhoto.Visible = false;
            // 
            // btnDecriptPhoto
            // 
            this.btnDecriptPhoto.Location = new System.Drawing.Point(158, 313);
            this.btnDecriptPhoto.Name = "btnDecriptPhoto";
            this.btnDecriptPhoto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDecriptPhoto.Size = new System.Drawing.Size(121, 23);
            this.btnDecriptPhoto.TabIndex = 20;
            this.btnDecriptPhoto.Text = "Decript Photo";
            this.btnDecriptPhoto.UseVisualStyleBackColor = true;
            this.btnDecriptPhoto.Visible = false;
            // 
            // txtBoxOriginal
            // 
            this.txtBoxOriginal.Location = new System.Drawing.Point(25, 45);
            this.txtBoxOriginal.Name = "txtBoxOriginal";
            this.txtBoxOriginal.Size = new System.Drawing.Size(176, 195);
            this.txtBoxOriginal.TabIndex = 24;
            this.txtBoxOriginal.Text = "";
            this.txtBoxOriginal.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(361, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 195);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 423);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtBoxOriginal);
            this.Controls.Add(this.btnDecriptFile);
            this.Controls.Add(this.cmbDecriptFile);
            this.Controls.Add(this.cmbDecriptPhoto);
            this.Controls.Add(this.btnDecriptPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncriptDocument);
            this.Controls.Add(this.cmbEncriptFile);
            this.Controls.Add(this.cmbEncriptPicture);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblDecriptedFile);
            this.Controls.Add(this.lblOriginalFile);
            this.Controls.Add(this.btnEncriptPhoto);
            this.Controls.Add(this.lblDecriptedPhoto);
            this.Controls.Add(this.picDecriptPreview);
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
            this.Text = "Photo/File Encript and Decript";
            ((System.ComponentModel.ISupportInitialize)(this.photoPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDecriptPreview)).EndInit();
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
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblOriginalPhoto;
        private System.Windows.Forms.Label lblDecriptedPhoto;
        private System.Windows.Forms.PictureBox picDecriptPreview;
        private System.Windows.Forms.Button btnEncriptPhoto;
        private System.Windows.Forms.Label lblDecriptedFile;
        private System.Windows.Forms.Label lblOriginalFile;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.ComboBox cmbEncriptPicture;
        private System.Windows.Forms.ComboBox cmbEncriptFile;
        private System.Windows.Forms.Button btnEncriptDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecriptFile;
        private System.Windows.Forms.ComboBox cmbDecriptFile;
        private System.Windows.Forms.ComboBox cmbDecriptPhoto;
        private System.Windows.Forms.Button btnDecriptPhoto;
        private System.Windows.Forms.RichTextBox txtBoxOriginal;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}

