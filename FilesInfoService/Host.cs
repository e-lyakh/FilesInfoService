using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FilesInfoService
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.Title = "Service";
            ServiceHost sh = new ServiceHost(typeof(Service));
            sh.Open();
            Console.WriteLine("To stop the service press Enter");
            Console.ReadLine();
            sh.Close();
        }
    }
}
