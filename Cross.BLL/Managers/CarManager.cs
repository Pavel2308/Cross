using Cross.DAL;
using Cross.Model;
using System.Linq;

namespace Cross.BLL.Managers
{
    public class CarManager : DbEntityManager<Car>
    {
        private readonly CrossContext _dbContext;

        public CarManager(CrossContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ExistLicensePlate(string licensePlate, int raceTypeId, int disciplineId)
        {
            if (_dbContext.Cars.Any(c => c.LicensePlate == licensePlate
            && c.RaceTypeId == raceTypeId && c.DisciplineId == disciplineId))
                return true;

            return false;
        }
    }
}
