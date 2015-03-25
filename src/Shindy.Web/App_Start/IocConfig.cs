using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Shindy.Data.SqlServer;

namespace Shindy.Web
{
    public static class IocConfig
    {
        public static void Configure()
        {
            // Create the container builder.
            var builder = new ContainerBuilder();

            // Register the Web API controllers.
            var asm = Assembly.GetExecutingAssembly();
            builder.RegisterApiControllers(asm);
            

            // Register other dependencies.
            builder.RegisterType<ShindyContext>().As<IShindyContext>().InstancePerRequest();
            
            // Build the container.
            var container = builder.Build();

            // Create the depenedency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        } 
    }
}