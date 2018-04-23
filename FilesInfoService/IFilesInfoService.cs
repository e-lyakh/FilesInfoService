using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;

namespace FilesInfoService
{
    [ServiceContract]
    public interface IFilesInfoService
    {
        [OperationContract]
        DriveInfo GetDiskDInfo();

        [OperationContract]
        DirectoryInfo GetFilesInfo();
    }
}
