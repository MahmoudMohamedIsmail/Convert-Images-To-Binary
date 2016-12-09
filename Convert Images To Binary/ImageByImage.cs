using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Images_To_Binary
{
    public partial class ImageByImage : Form
    {
        Brwose select=new Brwose();
        Convert image;
        public ImageByImage()
        {
            InitializeComponent();
        }

        private void ImagePathb_Click(object sender, EventArgs e)
        {
            ImagePath.Text= select.SelectImage();
        }

        private void Binarypathb_Click(object sender, EventArgs e)
        {
            BinaryPath.Text = select.SelectFolder();
        }

        private void ConvertImage_Click(object sender, EventArgs e)
        {
            if (ImagePath.Text == "" || BinaryPath.Text =="")
            {
                MessageBox.Show("Plz Enter Path");
            }
            if (Widthb.Text == "" || Heightb.Text == "")
            {
                image = new Convert(ImagePath.Text, 0, 0);
            }
            else if (Widthb.Text != "" || Heightb.Text != "")
            {
                image = new Convert(ImagePath.Text, int.Parse(Widthb.Text), int.Parse(Heightb.Text));
            }
            image.Get_Pixel();
            image.Write_In_Text(BinaryPath.Text);
            MessageBox.Show("DONE..");
        }

        private void Exitb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
