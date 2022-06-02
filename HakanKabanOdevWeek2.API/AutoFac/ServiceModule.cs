using Autofac;
using HakanKabanOdevWeek2.Core.Repository;
using HakanKabanOdevWeek2.Core.Service;
using HakanKabanOdevWeek2.Core.Unitofwork;
using HakanKabanOdevWeek2.Repository.Context;
using HakanKabanOdevWeek2.Repository.Repositories;
using HakanKabanOdevWeek2.Repository.UnitOfWork;
using HakanKabanOdevWeek2.Service;
using HakanKabanOdevWeek2.Service.Service;
using System.Reflection;
using Module= Autofac.Module;

namespace HakanKabanOdevWeek2.API.AutoFac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            //builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitofwork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var reposAssembly = Assembly.GetAssembly(typeof(MyContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(Deneme));

            builder.RegisterAssemblyTypes(apiAssembly, reposAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, reposAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


        }
    }
}
