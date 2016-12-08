using Autofac;
using Data;

namespace DiContainer.AutofacModules
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