using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProcessor processor = new MainProcessor();

            Console.WriteLine("processor starting.");
            processor.Start();
            Console.WriteLine("processor started.");

            Thread.Sleep(5 * 1000);

            Console.WriteLine("processor stopping.");
            processor.Stop();
            Console.WriteLine("processor stopped.");

            Console.Read();
        }
    }
}
