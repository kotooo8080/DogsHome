using System;
using DogsHome.DAL.Interfaces;
using DogsHome.DAL.Repositories;
using Ninject.Modules;

namespace DogsHome.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<DogsHomeUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
