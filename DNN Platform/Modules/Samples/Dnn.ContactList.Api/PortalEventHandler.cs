using System.ComponentModel.Composition;
using DotNetNuke.Entities.Portals;

namespace Dnn.ContactList.Api
{
    [Export(typeof(IPortalEventHandlers))]
    public class PortalEventHandler : IPortalEventHandlers
    {
        public void PortalCreated(object sender, PortalCreatedEventArgs args)
        {
            var portalId = args.PortalId;
            ContactRepository.Instance.InitializePortal(portalId);
        }
    }
}
