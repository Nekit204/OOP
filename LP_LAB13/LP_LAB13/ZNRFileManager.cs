using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
namespace LP_LAB13
{
    class ZNRFileManager
    {
        static string path = @"C:\Users\User\Desktop\учеба\2 курс\ООТП\Лабораторные\LP_LAB13";
        DirectoryInfo dir = new DirectoryInfo(path);
        public void Something_do()
        {
            ZNRLog.WriteMessage("Создание папки,файла,заполнение,копирование,удаления");
            var file = dir.GetFiles();
            Directory.CreateDirectory(@"ZNRInspect");
            using (StreamWriter sw = new StreamWriter(@"ZNRInspect\ZNRdirinfo.txt"))
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                    sw.WriteLine(d.Name);

                foreach (FileInfo f in file)
                    sw.WriteLine(f.Name);
            }
            File.Copy(@"ZNRInspect\ZNRdirinfo.txt", @"ZNRInspect\ZNRdirinfo_renamed.txt");
            File.Delete(@"ZNRInspect\ZNRdirinfo.txt");
        }
        public void Something_do2(string path, string ext)
        {
            ZNRLog.WriteMessage("Создание папки,перемещение файлов с заданым расширение из одной папки в другую");
            string dirpath = @"ZNRFiles";
            Directory.CreateDirectory(dirpath);
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.GetFiles();

            foreach (FileInfo file in files)
            {
                if (file.Extension == ext)
                    file.CopyTo($@"{dirpath}\{file.Name}");
            }
            Directory.Move(@"ZNRFiles", @"ZNRInspect\ZNRFiles");
        }
        public  void Something_do3()
        {
            ZNRLog.WriteMessage("Архивирование папки");
            string dirpath = @"ZNRInspect\ZNRFiles";
            string zippath = @"ZNRInspect\ZNRFiles.zip";
            string unzippath = @"Unzipped";

            ZipFile.CreateFromDirectory(dirpath, zippath);
            ZipFile.ExtractToDirectory(zippath, unzippath);
        }
    }
}
