using System;
using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IRoutineRepository _routineRepository;

        public RoutineService(IRoutineRepository routineRepository)
        {
            _routineRepository = routineRepository;
        }

        public Routine Add(Routine newRoutine)
        {
            newRoutine.Date = DateTime.Now;
            return _routineRepository.Add(newRoutine);
        }

        public Routine Get(int id)
        {
            return _routineRepository.Get(id);
        }

        public IEnumerable<Routine> GetAll()
        {
            return _routineRepository.GetAll();
        }

        public void Remove(int id)
        {
            _routineRepository.Remove(id);
        }

        public Routine Update(Routine updatedRoutine)
        {
            return _routineRepository.Update(updatedRoutine);
        }
    }
}
