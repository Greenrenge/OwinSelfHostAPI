using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinSelfHostAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var startOption = new StartOptions("http://localhost:1234/");
            startOption.Urls.Add("http://www.green.com:80/");
            using (WebApp.Start<Startup>(startOption))
            {
                //https://stackoverflow.com/questions/4019466/httplistener-access-denied
                //view all user in computer-> wmic useraccount list full
                //To Reserve URL (run as Admin)
                //netsh http add urlacl http://localhost:1234/ user=green
                //netsh http add urlacl http://www.green.com:80/ user=green
                Console.WriteLine("Server is currently running");
                Console.ReadLine();
            }
        }
    }
}
