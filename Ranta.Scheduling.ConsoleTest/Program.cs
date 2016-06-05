using Ranta.Scheduling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                JobFactory factory = new JobFactory();

                var path = @"D:\SavoryWorkspace\Ranta\Scheduling\Ranta.Scheduling.JobLibrary\bin\Debug\Ranta.Scheduling.JobLibrary.dll";

                var typeName = "Ranta.Scheduling.JobLibrary.WriteJob";

                var job = factory.CreateJob(path, typeName);

                job.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("...");
            Console.Read();
        }
    }
}
