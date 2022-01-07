using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cross.Model.Common;

namespace Cross.Model
{
    public class Car : DbEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        public string LicensePlate { get; set; }

        [ForeignKey("RaceType")]
        public int RaceTypeId { get; set; }

        [ForeignKey("Discipline")]
        public int DisciplineId { get; set; }

        public virtual User User { get; set; }

        public virtual RaceType RaceType { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
