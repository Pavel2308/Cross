using Cross.DAL;
using Cross.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cross.BLL.Managers
{
    public class ActionManager : DbEntityManager<RequestAction>
    {
        private readonly CrossContext _dbContext;

        public ActionManager(CrossContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<RequestAction> GetFirstActions(int userId, int raceId)
        {
            if (userId == 0)
                return new List<RequestAction>();

            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (_dbContext.Requests.AsEnumerable().Any(r => user.Cars.Any(c=>c.Id == r.CarId) && r.RaceId == raceId))
                return new List<RequestAction>();

            var race = _dbContext.Races.Find(raceId);

            if (!user.Cars.Any(c=> c.DisciplineId == race.DisciplineId && c.RaceTypeId == race.Event.RaceTypeId))
                return new List<RequestAction>();

            var roleIds = _dbContext.UserRoles.Where(ur => ur.UserId == userId).Select(ur => ur.RoleId);
            var actions = _dbContext.Actions
                .Where(a => !a.ActionStatuses.Any() && roleIds.Contains(a.RoleId));
            return actions;
        }

        public IEnumerable<RequestAction> GetActions(int userId, int statusId)
        {
            var roleIds = _dbContext.UserRoles.Where(ur => ur.UserId == userId).Select(ur => ur.RoleId);
            var actionStatuses = _dbContext.ActionStatuses.Where(a => a.StatusId == statusId);
            var actions = actionStatuses.Select(a => a.Action).Where(a => roleIds.Contains(a.RoleId));

            return actions;
        }
    }
}
