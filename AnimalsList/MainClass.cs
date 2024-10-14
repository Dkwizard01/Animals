using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Daenet_OOP
{
    internal class MainClass
    {
        public static void Main()
        {
       
            var svcLoc = RegisterServices();
            IMyTracer Tracer = svcLoc.GetService<IMyTracer>();
            IOOPInputP process = svcLoc.GetService<IOOPInputP>();
            var animals = process.Processor();
            IAnimalPrinter animalP = svcLoc.GetService<IAnimalPrinter>();
            animalP.printAnimal(animals);

        }
        private static IServiceProvider RegisterServices(string[]? args = null)
        {
            var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            services
                .AddSingleton(typeof(IOOPInputP), typeof(OOPInputP))
                .AddSingleton(typeof(IAnimalPrinter), typeof(FileAnimalPrinter))
                .AddSingleton(typeof(IMyTracer), typeof(FileTracer))
                )
            .Build();
            return host.Services;

        }
    }
}
