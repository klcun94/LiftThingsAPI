using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;
using LiftThingsAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace LiftThingsAPI.Infrastructure.Data
{
    public class SetRepository : ISetRepository
    {
        private readonly AppDbContext _dbContext;

        public SetRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Set Add(Set newSet)
        {
            _dbContext.Sets.Add(newSet);
            _dbContext.SaveChanges();
            return newSet;
        }

        public Set Get(int id)
        {
            return _dbContext.Sets
                .Include(set => set.Id).SingleOrDefault(Set => Set.Id == id);
        }

        public IEnumerable<Set> GetAll()
        {
            return _dbContext.Sets
                .ToList();
        }

        public void Remove(Set set)
        {
            _dbContext.Sets.Remove(set);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Set Update(Set set)
        {
            var currentSet = _dbContext.Sets.FirstOrDefault(x => x.Id == set.Id);

            if (currentSet == null) return null;

            _dbContext.Entry(currentSet)
                .CurrentValues
                .SetValues(set);

            _dbContext.Update(currentSet);
            _dbContext.SaveChanges();
            return currentSet;
        }
    }
}
