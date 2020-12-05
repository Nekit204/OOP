using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB13
{
    class Program
    {
        static void Main(string[] args)
        {
            ZNRDiskInfo info=new ZNRDiskInfo();
            Console.WriteLine("----------------------");
            info.GetFileSystemInfo("D:\\");
            Console.WriteLine("----------------------");
            info.GetFreeSpace("C:\\");
            Console.WriteLine("----------------------");
            info.GetInfoAllDisk();
            Console.WriteLine("----------------------");
            ZNRFileInfo info1 = new ZNRFileInfo();
            info1.GetFullPath();
            Console.WriteLine("----------------------");
            info1.GetSomeInfo();
            Console.WriteLine("----------------------");
            info1.GetSomeInfo2();
            ZNRDirInfo info2 = new ZNRDirInfo();
            Console.WriteLine("----------------------");
            info2.CountFiles();
            Console.WriteLine("----------------------");
            info2.Get_Time_of_Creation();
            Console.WriteLine("----------------------");
            info2.CountSubdirectories();
            Console.WriteLine("----------------------");
            info2.Get_List_of_Parentsdirectory();
            Console.WriteLine("----------------------");
            ZNRFileManager file = new ZNRFileManager();
            file.Something_do();
            file.Something_do2(@"C:\Users\User\Desktop\учеба\2 курс\ООТП\Лабораторные\LP_Lab12", ".txt");
            file.Something_do3();
            ZNRLog.SearchWord("папках");
            ZNRLog.SearchDateDay("05");
            ZNRLog.SearchPartTime("13:00-15:00");
            Console.ReadKey(true);

        }
    }
}
