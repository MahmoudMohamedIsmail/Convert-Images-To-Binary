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

namespace Convert_Images_To_Binary
{
    public partial class FolderByFolder : Form
    {
        Brwose select = new Brwose();
        Convert image;
        FolderDirectory Folder;
        public FolderByFolder()
        {
            InitializeComponent();
        }

        private void ImagePathb_Click(object sender, EventArgs e)
        {
            FolderPath.Text = select.SelectFolder();
        }

        private void Binarypathb_Click(object sender, EventArgs e)
        {
            BinaryPath.Text = select.SelectFolder();
        }

        private void ConvertImage_Click(object sender, EventArgs e)
        {
            if (FolderPath.Text == "" || BinaryPath.Text == "")
            {
                MessageBox.Show("Plz Enter Path");
            }
         
            Folder = new FolderDirectory(FolderPath.Text);
            int items = Folder.dirs.Count;
            for (int i = 0; i < items; i++)
            {
                if (Widthb.Text == "" || Heightb.Text == "")
                {
                    image = new Convert(Folder.dirs[i], 0, 0);
                }
                else if (Widthb.Text != "" || Heightb.Text != "")
                {
                    image = new Convert(Folder.dirs[i], int.Parse(Widthb.Text), int.Parse(Heightb.Text));
                }
                image.Get_Pixel();
                image.Write_In_Text(BinaryPath.Text);
            
            }
            MessageBox.Show("DONE..");
        }

        private void Exitb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
