using AutoMapper;
using Microsoft.Practices.Unity.Mvc;
using System.Linq;
using System.Web.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BuildUp.Example.Web.UI.App_Start.AutomapperMvcActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(BuildUp.Example.Web.UI.App_Start.AutomapperMvcActivator), "Shutdown")]

namespace BuildUp.Example.Web.UI.App_Start
{
    public static class AutomapperMvcActivator
    {
        public static void Start()
        {
            // Marker types for assemblies
            Mapper.Initialize(cfg => cfg.AddProfiles(new[] { typeof(PropertyMapper) }));
        }

        /// <summary>Disposes the Unity container when the application is shut down.</summary>
        public static void Shutdown()
        {
        }
    }
}