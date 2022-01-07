using System.ComponentModel.DataAnnotations.Schema;
using Cross.Model.Common;
using Cross.Model.RequestSystem;

namespace Cross.Model
{
    public class RequestActionStatus : DbEntity, IRequestActionStatus
    {
        [ForeignKey("Action")]
        public int ActionId { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }

        public virtual RequestAction Action { get; set; }

        public virtual RequestStatus Status { get; set; }
    }
}
