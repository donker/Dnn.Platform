// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Common.Internal
{
    using System;
    using System.Linq;

    using DotNetNuke.Instrumentation;
    using DotNetNuke.Services.Cache;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>Manages http routes for services (WebAPI, MVC, etc.).</summary>
    public static class ServicesRoutingManager
    {
        private static readonly ILogger Logger = DnnLoggingController.GetLogger(typeof(ServicesRoutingManager));

        /// <summary>Registers all the service routes.</summary>
        public static void RegisterServiceRoutes()
        {
            try
            {
                var managers = Globals.GetCurrentServiceProvider().GetServices<IRoutingManager>().ToList();

                // #region agent log
                try
                {
                    var names = string.Join(", ", managers.Select(m => m.GetType().FullName));
                    var line = "{\"sessionId\":\"858381\",\"runId\":\"pre-fix\",\"hypothesisId\":\"B\",\"location\":\"ServicesRoutingManager.RegisterServiceRoutes\",\"message\":\"Registering routing managers\",\"data\":{\"count\":" + managers.Count + ",\"types\":\"" + names.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"},\"timestamp\":" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + "}\n";
                    System.IO.File.AppendAllText(@"D:\DNN\debug-858381.log", line);
                }
                catch
                {
                }

                // #endregion
                foreach (var routingManager in managers)
                {
                    // #region agent log
                    try
                    {
                        var line = "{\"sessionId\":\"858381\",\"runId\":\"pre-fix\",\"hypothesisId\":\"B\",\"location\":\"ServicesRoutingManager.RegisterServiceRoutes\",\"message\":\"Calling RegisterRoutes\",\"data\":{\"type\":\"" + routingManager.GetType().FullName + "\"},\"timestamp\":" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + "}\n";
                        System.IO.File.AppendAllText(@"D:\DNN\debug-858381.log", line);
                    }
                    catch
                    {
                    }

                    // #endregion
                    routingManager.RegisterRoutes();
                }
            }
            catch (Exception e)
            {
                // #region agent log
                try
                {
                    var line = "{\"sessionId\":\"858381\",\"runId\":\"pre-fix\",\"hypothesisId\":\"B\",\"location\":\"ServicesRoutingManager.RegisterServiceRoutes\",\"message\":\"RegisterServiceRoutes failed\",\"data\":{\"error\":\"" + e.GetType().Name + ":" + (e.Message ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"},\"timestamp\":" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + "}\n";
                    System.IO.File.AppendAllText(@"D:\DNN\debug-858381.log", line);
                }
                catch
                {
                }

                // #endregion
                Logger.ServicesRoutingManagerUnableToRegisterServiceRoutes(e);
            }
        }

        /// <summary>Re-registers all the routes while the site is still running.</summary>
        public static void ReRegisterServiceRoutesWhileSiteIsRunning()
        {
            // by clearing a "fake" key on the caching provider we can echo this
            // command to all the members of a web farm
            // the caching provider will call to make the actual registration of new routes
            CachingProvider.Instance().Clear("ServiceFrameworkRoutes", "-1");
        }
    }
}
