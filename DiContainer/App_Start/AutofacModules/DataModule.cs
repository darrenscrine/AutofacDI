using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Data;

namespace DiContainer.App_Start.AutofacModules
{
    public class DataModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Logger2>().As<ILogger>();
            builder.RegisterType<Repository>().As<IRepository>();
        }
    }
}