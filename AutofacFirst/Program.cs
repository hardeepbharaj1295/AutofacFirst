using System;
using Autofac;
using DemoLibrary;

namespace AutofacFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  @container variable store the instance of containerbuilder
             */
            
            var container = ContainerConfig.Configure();

            /*
             * BeginLifeTimeDcope define the how long the service instance will live in
             * your application.
             */

            using(var scope = container.BeginLifetimeScope())
            {
                /*
                 * We should have to resolve the first or topmost instance.
                 * The container will handle creating all other instances based on dependency injection 
                 * through constructor parameters.
                 */
         
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
