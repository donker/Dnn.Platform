// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.MvcPipeline
{
    using System.Web.Mvc;

    using DotNetNuke.Common;
    using DotNetNuke.DependencyInjection;
    using DotNetNuke.Web.Mvc.Extensions;
    using DotNetNuke.Web.MvcPipeline.Framework;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup : IDnnStartup
    {
        /// <inheritdoc/>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcControllers();
            services.AddTransient<IPageModelFactory, PageModelFactory>();
            services.AddTransient<ISkinModelFactory, SkinModelFactory>();
            services.AddTransient<IPaneModelFactory, PaneModelFactory>();
            services.AddTransient<IContainerModelFactory, ContainerModelFactory>();

            DependencyResolver.SetResolver(new DnnMvcPipelineDependencyResolver(Globals.DependencyProvider));
        }
    }
}
