using System;
using System.Collections.Generic;
using System.Linq;
using LiftThingsAPI.Core.Models;
using LiftThingsAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace LiftThingsAPI.Infrastructure.Data
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly AppDbContext _dbContext;

        public ExerciseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Exercise Add(Exercise newExercise)
        {
            _dbContext.Exercises.Add(newExercise);
            _dbContext.SaveChanges();
            return newExercise;
        }

        public Exercise Get(int id)
        {
            return _dbContext.Exercises
                .Include(exercise => exercise.Id).SingleOrDefault(Exercise => Exercise.Id == id);
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _dbContext.Exercises
                .ToList();
        }

        public IEnumerable<Exercise> GetAllRoutinesForUser(string userId)
        {
            return _dbContext.Exercises
                .Include(x => x.RoutineId)
            .Where(x => x.RoutineId == userId)
            .ToList();
        }

        public void Remove(int id)
        {
            var exercise = _dbContext.Exercises.FirstOrDefault(b => b.Id == id);

            if (exercise != null)
            {
                _dbContext.Exercises.Remove(exercise);
                _dbContext.SaveChanges();
            }
        }

        public Exercise Update(Exercise exercise)
        {
            var currentExercise = _dbContext.Exercises.FirstOrDefault(x => x.Id == exercise.Id);

            if (currentExercise == null) return null;

            _dbContext.Entry(currentExercise)
                .CurrentValues
                .SetValues(exercise);

            _dbContext.Update(currentExercise);
            _dbContext.SaveChanges();
            return currentExercise;
        }
    }
}
