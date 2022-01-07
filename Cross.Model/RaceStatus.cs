using System.Collections.Generic;
using Cross.Model.Common;

namespace Cross.Model
{
    public class RaceStatus : DbEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Race> Races { get; set; }
    }
}
