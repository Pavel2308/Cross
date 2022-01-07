using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cross.Model.Common;
using Cross.Model.RequestSystem;

namespace Cross.Model
{
    public class RequestAction : DbEntity, IRequestAction<int>
    {
        public string Name { get; set; }

        public string NameMUI { get; set; }

        public string ConfirmationMUI { get; set; }

        public string SuccessMUI { get; set; }

        [ForeignKey("SetStatus")]
        public int SetStatusId { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual RequestStatus SetStatus { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<RequestActionStatus> ActionStatuses { get; set; }
    }
}
