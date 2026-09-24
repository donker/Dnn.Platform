// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.MvcPipeline
{
    using System;
    using System.Web.Mvc;

    using DotNetNuke.Common;
    using DotNetNuke.Common.Internal;
    using DotNetNuke.ContentSecurityPolicy;
    using DotNetNuke.DependencyInjection;
    using DotNetNuke.Instrumentation;
    using DotNetNuke.Web.MvcPipeline.Extensions;
    using DotNetNuke.Web.MvcPipeline.ModelFactories;
    using DotNetNuke.Web.MvcPipeline.Routing;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Configures services and MVC controllers used by the DNN MVC pipeline.
    /// </summary>
    public class Startup : IDnnStartup
    {
        private readonly ILogger logger = DnnLoggingController.GetLogger<Startup>();

        /// <inheritdoc/>
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddEnumerable(new ServiceDescriptor(typeof(IRoutingManager), typeof(MvcRoutingManager), ServiceLifetime.Singleton));

            // #region agent log
            try
            {
                var line = "{\"sessionId\":\"858381\",\"runId\":\"post-fix\",\"hypothesisId\":\"B\",\"location\":\"MvcPipeline.Startup.ConfigureServices\",\"message\":\"MvcPipeline Startup registering IRoutingManager\",\"data\":{},\"timestamp\":" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + "}\n";
                System.IO.File.AppendAllText(@"D:\DNN\debug-858381.log", line);
            }
            catch
            {
            }

            // #endregion
            services.AddMvcControllers(this.logger);
            services.AddTransient<IPageModelFactory, PageModelFactory>();
            services.AddTransient<ISkinModelFactory, SkinModelFactory>();
            services.AddTransient<IPaneModelFactory, PaneModelFactory>();
            services.AddTransient<IContainerModelFactory, ContainerModelFactory>();

            DependencyResolver.SetResolver(new DnnMvcPipelineDependencyResolver(Globals.DependencyProvider));

            services.AddScoped<IContentSecurityPolicy, ContentSecurityPolicy>();
        }
    }
}
