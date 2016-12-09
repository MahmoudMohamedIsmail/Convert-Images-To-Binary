namespace Convert_Images_To_Binary
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
            this.Image = new System.Windows.Forms.Button();
            this.FolderByFolderb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.Silver;
            this.Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Image.Location = new System.Drawing.Point(12, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(260, 73);
            this.Image.TabIndex = 0;
            this.Image.Text = "Image By Image";
            this.Image.UseVisualStyleBackColor = false;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // FolderByFolderb
            // 
            this.FolderByFolderb.BackColor = System.Drawing.Color.Silver;
            this.FolderByFolderb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderByFolderb.Location = new System.Drawing.Point(12, 108);
            this.FolderByFolderb.Name = "FolderByFolderb";
            this.FolderByFolderb.Size = new System.Drawing.Size(260, 73);
            this.FolderByFolderb.TabIndex = 1;
            this.FolderByFolderb.Text = "Folder By Folder";
            this.FolderByFolderb.UseVisualStyleBackColor = false;
            this.FolderByFolderb.Click += new System.EventHandler(this.FolderByFolderb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.FolderByFolderb);
            this.Controls.Add(this.Image);
            this.Name = "Form1";
            this.Text = "Convert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.Button FolderByFolderb;
    }
}

