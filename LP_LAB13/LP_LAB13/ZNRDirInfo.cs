using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LP_LAB13
{
    class ZNRDirInfo
    {
        static string path = @"C:\Users\User\Desktop\учеба\2 курс\ООТП\Лабораторные\LP_LAB13";
        DirectoryInfo dirinfo = new DirectoryInfo(path);
        
        public void CountFiles()
        {
            ZNRLog.WriteMessage("Вывод инфомации о папке: " + dirinfo.Name + ". В классе :" + GetType().Name);
            var files = dirinfo.GetFiles();
            int count=files.Length;
            Console.WriteLine("Number of files:" + count);

        }
        public void Get_Time_of_Creation()
        {
            var time = dirinfo.CreationTime;
            Console.WriteLine("Date of creation:" + time);

        }
        public void CountSubdirectories()
        {
            var subdir = dirinfo.GetDirectories();
            int count = subdir.Length;
            Console.WriteLine("Number of subdirectories:" + count);

        }
        public void Get_List_of_Parentsdirectory()
        {
            ZNRLog.WriteMessage("Вывод списка родительских папок , папки: " + dirinfo.Name + ". В классе :" + GetType().Name);
            var pardir = dirinfo.Parent;
            Console.WriteLine("Parent directory:" + pardir);

        }
    }
}
