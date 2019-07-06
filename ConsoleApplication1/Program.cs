using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            WindowsServiceController controller = new WindowsServiceController("Photon Socket Server: CasinoVR-SocialHub");

            controller.StopServiceIfRunning();

            //System.Diagnostics.Process.Start("net", "stop Photon Socket Server: CasinoVR-SocialHub").WaitForExit();
            Console.WriteLine("Stop Service has been called");
            Console.ReadKey();
            controller.StartService();
            Console.WriteLine("Start Service has been called");
            Console.ReadKey();
            //System.Diagnostics.Process.Start("net", "start Photon Socket Server: CasinoVR-SocialHub");
        }
    }
}
