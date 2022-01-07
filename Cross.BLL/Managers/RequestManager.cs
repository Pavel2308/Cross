using Cross.DAL;
using Cross.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cross.BLL.Managers
{
    public class RequestManager : DbEntityManager<Request>
    {
        private readonly CrossContext _dbContext;

        public RequestManager(CrossContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Request> GetRequestsByCars(IEnumerable<Car> cars)
        {
            if (!cars.Any() || !_dbContext.Requests.Any())
                return Enumerable.Empty<Request>();

            return FilterByCars(_dbContext.Requests, cars);
        }

        public IEnumerable<Request> GetRequestsByRaceId(int raceId)
        {
            return FilterByRaceId(_dbContext.Requests, raceId);
        }

        public IEnumerable<Request> GetRequestsByRaceIdAndCars(int raceId, IEnumerable<Car> cars)
        {
            var requests = FilterByRaceId(_dbContext.Requests, raceId);
            return FilterByCars(requests, cars);
        }

        private IQueryable<Request> FilterByCars(IQueryable<Request> requests, IEnumerable<Car> cars)
        {
            var carIds = cars.Select(x => x.Id);
            return requests.Where(r => carIds.Contains(r.CarId));
        }

        private IQueryable<Request> FilterByRaceId(IQueryable<Request> requests, int raceId)
        {
            return requests.Where(r => r.RaceId == raceId);
        }
    }
}
