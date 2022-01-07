using System.Collections.Generic;
using Cross.Model.Common;

namespace Cross.Model
{
    public class Discipline : DbEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Race> Races { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
