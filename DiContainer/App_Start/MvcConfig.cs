using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Autofac;
using DiContainer.Controllers;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Autofac.Core;
using Data;
namespace DiContainer
{
    public static class MvcConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new Autofac.ContainerBuilder();

            // You can register controllers all at once using assembly scanning...
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // ...or you can register individual controlllers manually.
            builder.RegisterType<HomeController>().InstancePerRequest();

            builder.RegisterType<Logger2>().As<ILogger>();
            builder.RegisterType<Repository>().As<IRepository>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
