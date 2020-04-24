using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            using (ServiceHost Host = new ServiceHost(typeof(EventService.Service1)))
            {
                Host.Open();
                Console.WriteLine("Host Started at:" + DateTime.Now.ToString());
                Console.WriteLine();
            }

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
