using System;
using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IRoutineRepository _routineRepository;
        private readonly IUserService _userService;

        public ExerciseService(IExerciseRepository exerciseRepository, IRoutineRepository routineRepository, IUserService userService)
        {
            _exerciseRepository = exerciseRepository;
            _routineRepository = routineRepository;
            _userService = userService;
        }

        public Exercise Add(Exercise newExercise)
        {
            return _exerciseRepository.Add(newExercise);
        }

        public Exercise Get(int id)
        {
            return _exerciseRepository.Get(id);
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _exerciseRepository.GetAll();
        }

        public IEnumerable<Exercise> GetAllRoutinesForUser(string userId)
        {
            return _exerciseRepository.GetAllRoutinesForUser(userId);
        }

        public void Remove(int id)
        {
            _exerciseRepository.Remove(id);
        }

        public Exercise Update(Exercise updatedExercise)
        {
            return _exerciseRepository.Update(updatedExercise);
        }
    }
}
