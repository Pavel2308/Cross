using System.Collections.Generic;
using Cross.Model.Common;

namespace Cross.Model
{
    public class RaceType : DbEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
