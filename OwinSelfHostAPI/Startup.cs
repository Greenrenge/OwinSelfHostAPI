using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

//[assembly: OwinStartup(typeof(OwinSelfHostAPI.Startup))]
namespace OwinSelfHostAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)  
        {
            HttpConfiguration httpConfig = new HttpConfiguration(); //สร้าง Config ของ Host 
            httpConfig.Routes.MapHttpRoute( //สร้าง route 
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            //app.Use<>
            app.UseWebApi(httpConfig);//extension method
        }
    }
}
