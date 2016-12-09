using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace Convert_Images_To_Binary
{
    class Convert
    {
        Bitmap Image;
        int[,] Pixels;
        int Background=0,Foreground=1;
        string Path = "";

        public Convert(string path,int Width,int Height)
        {
            Image = new Bitmap(path, true);
            Path = path;
            if (Height != 0 && Width != 0)
            {
                Image = new Bitmap(Image, new Size(Width, Height));
            }
        }
        public void Get_Pixel()
        {
            Pixels = new int[Image.Width, Image.Height];
            for (int x= 0; x <Image.Width; x++)
            {
                for (int y= 0; y < Image.Height; y++)
                {
                    Color pixelColor = Image.GetPixel(x, y);
                    Pixels[x, y] = Background_Or_Foreground(pixelColor);
                }
            }
        
        }

        public int Background_Or_Foreground(Color pixel) //To cheak if Pixel background or Foreground
        {
            if((pixel.R + pixel.G + pixel.B) / 3 >= 127) //To Check if Pixel White or Black .... white(255,255,255), black(0,0,0)
            {
                return Foreground;
            }
            else{
                return Background;
            }
        }

        public string Get_Name(string Path)
        {
            string[] field;
            field = Path.Split('\\');
            string[] change = field[field.Length - 1].Split('.');
            change[1] = ".txt";//To Change from jpg to txt
            return "\\"+change[0]+change[1];
        }
        public void Write_In_Text(string Folder)
        {
            Folder = Folder + Get_Name(Path); //To save Text By the Same name of .jpg
            FileStream f = new FileStream(Folder, FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    sw.Write(Pixels[y, x].ToString() + " ");

                }
                sw.WriteLine();
            }
            sw.Close();
            f.Close();
        }
    }
}
