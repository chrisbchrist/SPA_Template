
using DotNetNuke.Web.Api;
using System.Web.Http;

namespace Chris.SPA.SPA_Template.Services
{

    /// <summary>
    /// The ServiceRouteMapper tells the DNN Web API Framework what routes this module uses
    /// </summary>
    public class ServiceRouteMapper : IServiceRouteMapper
    {
        /// <summary>
        /// RegisterRoutes is used to register the module's routes
        /// </summary>
        /// <param name="mapRouteManager"></param>
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            //mapRouteManager.MapHttpRoute(
            //     moduleFolderName: "SPA_Template",
            //     routeName: "default",
            //     url: "{controller}/{itemId}",
            //     defaults: new { itemId = RouteParameter.Optional },
            //    namespaces: new[] { "Chris.SPA.SPA_Template.Services" });

            mapRouteManager.MapHttpRoute("SPA_Template", "default", "{controller}/{action}", new[] { "Chris.SPA.SPA_Template.Services" });
        }
    }

}