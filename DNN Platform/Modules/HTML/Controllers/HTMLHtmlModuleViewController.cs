// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.Html.Controllers
{
    using System;
    using System.Linq;

    using DotNetNuke.Abstractions;
    using DotNetNuke.ContentSecurityPolicy;
    using DotNetNuke.Entities.Content.Workflow;
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.Modules.Html;
    using DotNetNuke.Modules.Html.Models;
    using DotNetNuke.Services.Personalization;
    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.MvcPipeline.Controllers;

    public class HTMLHtmlModuleViewController : ModuleViewControllerBase
    {
        private readonly HtmlTextController htmlTextController;
        private readonly INavigationManager navigationManager;
        private readonly IContentSecurityPolicy contentSecurityPolicy;
        private readonly IWorkflowManager workflowManager;

        public HTMLHtmlModuleViewController(IContentSecurityPolicy csp, INavigationManager navigationManager, IWorkflowManager workflowManager)
        {
            this.navigationManager = navigationManager;
            this.workflowManager = workflowManager;
            this.contentSecurityPolicy = csp;
            this.htmlTextController = new HtmlTextController(this.navigationManager);
        }

        protected override object ViewModel(ModuleInfo module)
        {
            int workflowID = this.htmlTextController.GetWorkflow(module.ModuleID, module.TabID, module.PortalID).Value;
            this.ModuleActionPublish(module, workflowID);
            HtmlTextInfo content = this.htmlTextController.GetTopHtmlText(module.ModuleID, true, workflowID);

            var html = string.Empty;
            if (content != null)
            {
                html = System.Web.HttpUtility.HtmlDecode(content.Content);
            }

            return new HtmlModuleModel()
            {
                Html = html,
            };
        }

        private void ModuleActionPublish(ModuleInfo module, int workflowID)
        {
            try
            {
                if (this.Request.QueryString["act"]?.ToString() == "publish" && this.Request.QueryString["mod"]?.ToString() == module.ModuleID.ToString())
                {
                    var moduleContext = new ModuleInstanceContext();
                    moduleContext.Configuration = module;

                    // verify security
                    if (moduleContext.IsEditable && Personalization.GetUserMode() == DotNetNuke.Entities.Portals.PortalSettings.Mode.Edit)
                    {
                        // get content
                        var objHTML = new HtmlTextController(this.navigationManager);
                        var workflow = this.workflowManager.GetWorkflow(workflowID);
                        HtmlTextInfo objContent = objHTML.GetTopHtmlText(module.ModuleID, false, workflowID);
                        if (objContent.StateID == workflow.FirstState.StateID)
                        {
                            // if not direct publish workflow
                            if (workflow.States.Count() > 1)
                            {
                                // publish content
                                objContent.StateID = workflow.LastState.StateID;

                                // save the content
                                objHTML.UpdateHtmlText(objContent, objHTML.GetMaximumVersionHistory(this.PortalSettings.PortalId));
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                // Exceptions.ProcessModuleLoadException(this, exc);
                throw new Exception("HTML Module Publish", exc);
            }
        }
    }
}
