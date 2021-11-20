using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business;
using DataAccess;
using DataAccess.Model;
using IOCDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOCDemo.Utilities
{
    public class AutofacConfig: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<MyService>().As<IService>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<AppleService>().As<IAppleService>();
        }

    }
}
