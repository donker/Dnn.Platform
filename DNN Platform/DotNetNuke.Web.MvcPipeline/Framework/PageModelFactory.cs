// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.MvcPipeline.Framework
{
    using System.Threading;
    using System.Web.Helpers;

    using DotNetNuke.Abstractions;
    using DotNetNuke.Common;
    using DotNetNuke.ContentSecurityPolicy;
    using DotNetNuke.Entities.Portals;
    using DotNetNuke.UI.Internals;
    using DotNetNuke.Web.MvcPipeline.Models;

    public class PageModelFactory
    {
        private readonly IContentSecurityPolicy contentSecurityPolicy;
        private readonly INavigationManager navigationManager;
        private readonly IPortalController portalController;

        public PageModelFactory(IContentSecurityPolicy contentSecurityPolicy, INavigationManager navigationManager, IPortalController portalController)
        {
            this.contentSecurityPolicy = contentSecurityPolicy;
            this.navigationManager = navigationManager;
            this.portalController = portalController;
        }

        public PageModel CreatePageModel(PortalSettings portalSettings)
        {
            return new PageModel
            {
                IsEditMode = Globals.IsEditMode(),
                AntiForgery = AntiForgery.GetHtml().ToHtmlString(),
                PortalId = portalSettings.PortalId,
                TabId = portalSettings.ActiveTab.TabID,
                Language = Thread.CurrentThread.CurrentCulture.Name,
                ContentSecurityPolicy = this.contentSecurityPolicy,
                NavigationManager = this.navigationManager,
                FavIconLink = FavIcon.GetHeaderLink(portalSettings.PortalId),
            };
        }
    }
}
