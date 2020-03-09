using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;
using LiftThingsAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace LiftThingsAPI.Infrastructure.Data
{
    public class RoutineRepository : IRoutineRepository
    {
        private readonly AppDbContext _dbContext;

        public RoutineRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Routine Add(Routine newRoutine)
        {
            _dbContext.Routines.Add(newRoutine);
            _dbContext.SaveChanges();
            return newRoutine;
        }

        public Routine Get(int id)
        {
            return _dbContext.Routines
                .Include(routine => routine.User)
                .Include(activity => activity.Exercises)
                .SingleOrDefault(routine => routine.Id == id);
        }

        public IEnumerable<Routine> GetAll()
        {
            return _dbContext.Routines
                .Include(routine => routine.User)
                .Include(rotine => rotine.Exercises)
                .ToList();
        }

        public void Remove(int id)
        {
            var routine = _dbContext.Routines.FirstOrDefault(b => b.Id == id);

            if (routine != null)
            {
                _dbContext.Routines.Remove(routine);
                _dbContext.SaveChanges();
            }
        }

        public Routine Update(Routine updatedRoutine)
        {
            var currentRoutine = _dbContext.Routines.FirstOrDefault(x => x.Id == updatedRoutine.Id);

            if (currentRoutine == null) return null;

            _dbContext.Entry(currentRoutine)
                .CurrentValues
                .SetValues(updatedRoutine);

            _dbContext.Update(currentRoutine);
            _dbContext.SaveChanges();
            return currentRoutine;
        }
        public IEnumerable<Routine> UsersforRoutine(int userId)
        {
            return _dbContext.Routines
                .Include(routine => routine.User)
                .Include(routine => routine.Exercises)
                .Where(a => a.Id == userId).ToList();
        }
    }
}
