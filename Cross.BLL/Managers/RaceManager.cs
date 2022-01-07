using Cross.DAL;
using Cross.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cross.BLL.Managers
{
    public class RaceManager : CancellationDbEntityManager<Race>
    {
        private readonly CrossContext _dbContext;

        public RaceManager(CrossContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Race> GetRacesByEventId(int eventId)
        {
            return _dbContext.Races.Where(r => r.EventId == eventId);
        }
    }
}
