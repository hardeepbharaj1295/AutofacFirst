using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutofacFirst
{
    public static class ContainerConfig
    {
        /*
         *  IContainer Interface creates, wires dependencies and manage lifetime for a set
         *  of components.
         */
        public static IContainer Configure()
        {

            /*
             * Creation of IConainer using ContainerBuilder
             * Create the builder with which components/services are registered.
             */

            var builder = new ContainerBuilder();

            /*
             * Register types that expose interfaces
             * Components register with appropriate services exposed
             */

            builder.RegisterType<Application>().As<IApplication>();
            
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            /*
             * RegisterAssemblyTypes can register a set of types from an assembly according to user defined rules
             */

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            /*
             *  Build the Container to finalize registrations 
             */

            return builder.Build();

        }
    }
}
