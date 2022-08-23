using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Data.Services;

namespace Food.WebUI
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            //tell what we want injected inside other containers - such as our db
            var builder = new ContainerBuilder();

            //uses autofact to register all controllers in controller folder
            //MvcApplication is what represents this applicaiton
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // now when IRestaurantData called it loads in "InMemoryRestaurantData" - makes for one area to change vs all the places to update
            // SINGLE INSTANCE WILL NEVER WORK FOR MULTIPLE USERS as currently set up
            builder.RegisterType<InMemoryRestaurantData>().As<IRestaurantData>().SingleInstance();

            
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}