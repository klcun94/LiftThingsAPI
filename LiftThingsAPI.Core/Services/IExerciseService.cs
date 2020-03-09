using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public interface IExerciseService
    {
        Exercise Add(Exercise Exercise);
        Exercise Update(Exercise Exercise);
        Exercise Get(int id);
        IEnumerable<Exercise> GetAll();
        void Remove(int id);
        IEnumerable<Exercise> GetAllRoutinesForUser(string userId);
    }
}