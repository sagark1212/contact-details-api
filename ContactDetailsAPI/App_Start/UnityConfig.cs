using BussinessLayer;
using Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ContactDetailsAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IContactService, ContactService>();
            container.RegisterType<IContactRepo, ContactRepo>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}