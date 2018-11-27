using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hopper.WebMVC.Startup))]

namespace Hopper.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
