using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesInfoService
{
    class Service : IFilesInfoService
    {
        DriveInfo diskInfo;

        public DriveInfo GetDiskDInfo()
        {
            diskInfo = new DriveInfo("D");
            Console.WriteLine("Disk info is requested");
            return diskInfo;
        }

        public DirectoryInfo GetFilesInfo()
        {
            DirectoryInfo dirD = new DirectoryInfo("D://");            
            Console.WriteLine("Files info is requested");            
            return dirD;
        }
    }
}