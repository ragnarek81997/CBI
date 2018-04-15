using Ninject;
using CBI.Domain.Interfaces;
using CBI.Infrastructure.Business;
using CBI.Infrastructure.Data;
using CBI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CBI.Domain.Entities.Infrastructure;
using Ninject.Web.Common;

namespace CBI.Web.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //configuration

            // repository
            kernel.Bind<IUserRepository>().To<UserRepository>();

            // service
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IAccountService>().To<AccountService>();

            kernel.Bind<ApplicationDbContext>().ToSelf().InRequestScope();

        }
    }
}