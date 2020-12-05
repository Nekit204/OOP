using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LP_LAB13
{
    class ZNRDiskInfo
    {
        public void GetFreeSpace(string name_of_disk)
        {
            var Info = DriveInfo.GetDrives();
            foreach(var d in Info)
            {
             
                if (d.Name == name_of_disk)
                {
                    ZNRLog.WriteMessage("Метод для вывода информации о свободном месте на диске: " + name_of_disk);
                    Console.WriteLine("Free Space:" + d.TotalFreeSpace);
                }
            }
        }
        public void GetFileSystemInfo(string name_of_disk)
        {
            var Info = DriveInfo.GetDrives();
            foreach (var d in Info)
            {
                if (d.Name == name_of_disk)
                {
                    ZNRLog.WriteMessage("Метод для вывода информации о файловой системе: " + name_of_disk);
                    Console.WriteLine("File System:" + d.DriveFormat);
                }
            }
        }
        public void GetInfoAllDisk()
        {
            var Info = DriveInfo.GetDrives();
           ZNRLog.WriteMessage("Метод для вывода информации о дисках компьютера: ");
            foreach (var d in Info)
            {
                Console.WriteLine("File System:" + d.Name);
                Console.WriteLine("Space:" + d.TotalSize);
                Console.WriteLine("Free space:" + d.TotalFreeSpace);
                Console.WriteLine("Volume Label:" + d.VolumeLabel);

            }
        }

    }
}
