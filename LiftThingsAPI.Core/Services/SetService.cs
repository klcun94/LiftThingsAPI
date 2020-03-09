using System;
using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public class SetService : ISetService
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IRoutineRepository _routineRepository;
        private readonly IUserService _userService;
        private readonly ISetRepository _setRepository;

        public SetService(IExerciseRepository exerciseRepository, IRoutineRepository routineRepository, IUserService userService, ISetRepository setRepository)
        {
            _exerciseRepository = exerciseRepository;
            _routineRepository = routineRepository;
            _userService = userService;
            _setRepository = setRepository;
        }

        public Set Add(Set newSet)
        {
            return _setRepository.Add(newSet);
        }

        public Set Get(int id)
        {
            return _setRepository.Get(id);
        }

        public IEnumerable<Set> GetAll()
        {
            return _setRepository.GetAll();
        }

        public void Remove(int id)
        {
            _setRepository.Remove(id);
        }

        public Set Update(Set updatedSet)
        {
            return _setRepository.Update(updatedSet);
        }
    }
}
