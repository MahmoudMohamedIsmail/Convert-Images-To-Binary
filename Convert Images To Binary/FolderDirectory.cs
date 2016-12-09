using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Convert_Images_To_Binary
{
    class FolderDirectory
    {
       public List<string> dirs;
        public FolderDirectory(string path)
        {
          
            string [] allowedExtensions = new string[] { ".jpg", ".jpe", ".gif", ".png", ".pcd", ".wmf" };
              dirs = Directory
                .GetFiles(path)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .ToList();
        }


        public void Write_all_images(string path,int Width,int Height)
        {
            int Folder = dirs.Count;
            for (int image = 0; image < Folder; image++)
            {
                Convert Images = new Convert(dirs[image],Width,Height);
                Images.Get_Pixel();
                Images.Write_In_Text(path);
            }
        
        }
    }
}
