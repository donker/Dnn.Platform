// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.Html.Controllers
{
  /// <summary>
  /// Specifies the type of workflow for HTML module.
  /// </summary>
  public enum WorkflowType
  {
    /// <summary>
    /// Directly publish the content.
    /// </summary>
    DirectPublish = 1,

    /// <summary>
    /// Save the content as a draft.
    /// </summary>
    SaveDraft = 2,

    /// <summary>
    /// Content requires approval before publishing.
    /// </summary>
    ContentApproval = 3,

    /// <summary>
    /// Content staging before publishing.
    /// </summary>
    ContentStaging = 4,
  }
}
