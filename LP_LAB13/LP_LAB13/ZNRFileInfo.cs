using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LP_LAB13
{
    class ZNRFileInfo
    {
        FileInfo inf = new FileInfo(path);
        public ZNRFileInfo(string name = null)
        {
            ZNRLog.WriteMessage("Вызов конструктора класса: " + GetType().Name);
            if (name != null)
            {
                inf = new FileInfo(name);
            }
        }
        static string path = @"C:\Users\User\Desktop\учеба\2 курс\ООТП\Лабораторные\LP_Lab12.txt";
        public void GetFullPath()
        {
            ZNRLog.WriteMessage("Вывод инфомации о файле: " + inf.Name + ". В классе :" + GetType().Name);
            var fullpath = inf.FullName;
            Console.WriteLine("Full path:" + fullpath);
        }
        public void GetSomeInfo()
        {
            var name =inf.Name;
            var size =inf.Length;
            var expansion =inf.Extension;
            Console.WriteLine("File name:" + name);
            Console.WriteLine("File size:" + size);
            Console.WriteLine("File expansion:" + expansion);
        }
        public void GetSomeInfo2()
        {
            var time_of_creation = inf.CreationTime;
            var time_of_change = inf.LastWriteTime;
            Console.WriteLine("Time of creation:" +time_of_creation);
            Console.WriteLine("Time of change:" +time_of_change);

        }

    }
}
