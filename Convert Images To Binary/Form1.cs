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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            ImageByImage form = new ImageByImage();
            form.Show();
        }

        private void FolderByFolderb_Click(object sender, EventArgs e)
        {
            FolderByFolder form = new FolderByFolder();
            form.Show();
           
        }
    }
}
