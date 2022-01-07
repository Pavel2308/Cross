using System.Collections.Generic;
using Cross.Model.Common;

namespace Cross.Model
{
    public class Venue : DbEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
