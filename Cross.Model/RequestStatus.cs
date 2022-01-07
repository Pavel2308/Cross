using System.Collections.Generic;
using Cross.Model.Common;
using Cross.Model.RequestSystem;

namespace Cross.Model
{
    public class RequestStatus : DbEntity, IRequestStatus
    {
        public string Name { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<RequestAction> ActionSets { get; set; }

        public virtual ICollection<RequestActionStatus> ActionStatuses { get; set; }
    }
}
