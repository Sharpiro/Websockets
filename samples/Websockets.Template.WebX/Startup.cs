﻿using System;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Websockets.Template.CoreX;

namespace Websockets.Template.WebX
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            var application = new CardApplication(new SocketServer());
            application.Start();
        }
    }
}
