namespace Convert_Images_To_Binary
{
    partial class FolderByFolder
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
            this.Exitb = new System.Windows.Forms.Button();
            this.ConvertImage = new System.Windows.Forms.Button();
            this.ScaleBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Heightb = new System.Windows.Forms.TextBox();
            this.Widthb = new System.Windows.Forms.TextBox();
            this.dirBox = new System.Windows.Forms.GroupBox();
            this.Binarypathb = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.FolderPathb = new System.Windows.Forms.Button();
            this.BinaryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaleBox.SuspendLayout();
            this.dirBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exitb
            // 
            this.Exitb.Location = new System.Drawing.Point(185, 148);
            this.Exitb.Name = "Exitb";
            this.Exitb.Size = new System.Drawing.Size(75, 23);
            this.Exitb.TabIndex = 17;
            this.Exitb.Text = "Exit";
            this.Exitb.UseVisualStyleBackColor = true;
            this.Exitb.Click += new System.EventHandler(this.Exitb_Click);
            // 
            // ConvertImage
            // 
            this.ConvertImage.Location = new System.Drawing.Point(185, 112);
            this.ConvertImage.Name = "ConvertImage";
            this.ConvertImage.Size = new System.Drawing.Size(75, 23);
            this.ConvertImage.TabIndex = 16;
            this.ConvertImage.Text = "Convert";
            this.ConvertImage.UseVisualStyleBackColor = true;
            this.ConvertImage.Click += new System.EventHandler(this.ConvertImage_Click);
            // 
            // ScaleBox
            // 
            this.ScaleBox.Controls.Add(this.label3);
            this.ScaleBox.Controls.Add(this.label4);
            this.ScaleBox.Controls.Add(this.Heightb);
            this.ScaleBox.Controls.Add(this.Widthb);
            this.ScaleBox.Location = new System.Drawing.Point(8, 97);
            this.ScaleBox.Name = "ScaleBox";
            this.ScaleBox.Size = new System.Drawing.Size(131, 75);
            this.ScaleBox.TabIndex = 15;
            this.ScaleBox.TabStop = false;
            this.ScaleBox.Text = "Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // Heightb
            // 
            this.Heightb.Location = new System.Drawing.Point(47, 48);
            this.Heightb.Name = "Heightb";
            this.Heightb.Size = new System.Drawing.Size(70, 20);
            this.Heightb.TabIndex = 4;
            // 
            // Widthb
            // 
            this.Widthb.Location = new System.Drawing.Point(47, 22);
            this.Widthb.Name = "Widthb";
            this.Widthb.Size = new System.Drawing.Size(70, 20);
            this.Widthb.TabIndex = 5;
            // 
            // dirBox
            // 
            this.dirBox.Controls.Add(this.Binarypathb);
            this.dirBox.Controls.Add(this.FolderPath);
            this.dirBox.Controls.Add(this.FolderPathb);
            this.dirBox.Controls.Add(this.BinaryPath);
            this.dirBox.Controls.Add(this.label1);
            this.dirBox.Controls.Add(this.label2);
            this.dirBox.Location = new System.Drawing.Point(8, 3);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(264, 88);
            this.dirBox.TabIndex = 14;
            this.dirBox.TabStop = false;
            this.dirBox.Text = "Directory";
            // 
            // Binarypathb
            // 
            this.Binarypathb.Location = new System.Drawing.Point(177, 51);
            this.Binarypathb.Name = "Binarypathb";
            this.Binarypathb.Size = new System.Drawing.Size(75, 20);
            this.Binarypathb.TabIndex = 10;
            this.Binarypathb.Text = "Browse";
            this.Binarypathb.UseVisualStyleBackColor = true;
            this.Binarypathb.Click += new System.EventHandler(this.Binarypathb_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(47, 24);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(124, 20);
            this.FolderPath.TabIndex = 2;
            // 
            // FolderPathb
            // 
            this.FolderPathb.Location = new System.Drawing.Point(177, 24);
            this.FolderPathb.Name = "FolderPathb";
            this.FolderPathb.Size = new System.Drawing.Size(75, 20);
            this.FolderPathb.TabIndex = 9;
            this.FolderPathb.Text = "Browse";
            this.FolderPathb.UseVisualStyleBackColor = true;
            this.FolderPathb.Click += new System.EventHandler(this.ImagePathb_Click);
            // 
            // BinaryPath
            // 
            this.BinaryPath.Location = new System.Drawing.Point(47, 51);
            this.BinaryPath.Name = "BinaryPath";
            this.BinaryPath.Size = new System.Drawing.Size(124, 20);
            this.BinaryPath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SaveTo";
            // 
            // FolderByFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 179);
            this.Controls.Add(this.Exitb);
            this.Controls.Add(this.ConvertImage);
            this.Controls.Add(this.ScaleBox);
            this.Controls.Add(this.dirBox);
            this.Name = "FolderByFolder";
            this.Text = "Folder By Folder";
            this.ScaleBox.ResumeLayout(false);
            this.ScaleBox.PerformLayout();
            this.dirBox.ResumeLayout(false);
            this.dirBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitb;
        private System.Windows.Forms.Button ConvertImage;
        private System.Windows.Forms.GroupBox ScaleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Heightb;
        private System.Windows.Forms.TextBox Widthb;
        private System.Windows.Forms.GroupBox dirBox;
        private System.Windows.Forms.Button Binarypathb;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button FolderPathb;
        private System.Windows.Forms.TextBox BinaryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}