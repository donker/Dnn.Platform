// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.MvcPipeline
{
    using System.Web.Mvc;

    using DotNetNuke.Common;
    using DotNetNuke.Common.Internal;
    using DotNetNuke.ContentSecurityPolicy;
    using DotNetNuke.DependencyInjection;
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
        private readonly ILogger<Startup> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="logger">
        /// The <see cref="ILogger{TCategoryName}"/> used to record startup and configuration events for the MVC pipeline.
        /// This logger is provided by the application's dependency injection container.
        /// </param>
        public Startup(ILogger<Startup> logger)
        {
            this.logger = logger;
        }

        /// <inheritdoc/>
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddEnumerable(new ServiceDescriptor(typeof(IRoutingManager), typeof(MvcRoutingManager), ServiceLifetime.Singleton));

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
