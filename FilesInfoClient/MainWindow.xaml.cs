using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FilesInfoClient.ServiceReference1;
using System.IO;

namespace FilesInfoClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FilesInfoServiceClient proxy;

        public MainWindow()
        {
            InitializeComponent();
            proxy = new FilesInfoServiceClient();
        }

        private void bGetDiskInfo_Click(object sender, RoutedEventArgs e)
        {
            lbDiskInfo.Items.Clear();
            DriveInfo dInfo = proxy.GetDiskDInfo();
            string dName = "Name: " + dInfo.Name;
            string dLabel = "Label: " + dInfo.VolumeLabel;
            string dType = "Type: " + dInfo.DriveType;            
            string dSize = "Total size: " + dInfo.TotalSize + " bytes";
            string dFreeSpace = "Free space: " + dInfo.TotalFreeSpace + " bytes";
            lbDiskInfo.Items.Add(dName);
            lbDiskInfo.Items.Add(dLabel);
            lbDiskInfo.Items.Add(dType);
            lbDiskInfo.Items.Add(dSize);
            lbDiskInfo.Items.Add(dFreeSpace);
        }

        private void bGetFilesInfo_Click(object sender, RoutedEventArgs e)
        {
            lbFilesInfo.Items.Clear();
            DirectoryInfo dirInfo = proxy.GetFilesInfo();

            lbFilesInfo.Items.Add("Folders:");
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            foreach(DirectoryInfo d in dirs)
            {
                string dirName = "  " + d.Name;
                lbFilesInfo.Items.Add(dirName);
            }
            
            lbFilesInfo.Items.Add("Files:");
            FileInfo[] files = dirInfo.GetFiles();
            foreach(FileInfo f in files)
            {
                string fileName = "  " + f.Name;
                lbFilesInfo.Items.Add(fileName);
            }
        }
    }
}
