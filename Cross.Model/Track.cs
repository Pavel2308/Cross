using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cross.Model.Common;

namespace Cross.Model
{
    public class Track : DbEntity
    {
        public string Name { get; set; }

        [ForeignKey("Venue")]
        public int VenueId { get; set; }

        public virtual Venue Venue { get; set; }

        public virtual ICollection<Race> Races { get; set; }
    }
}
