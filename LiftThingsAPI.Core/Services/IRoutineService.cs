using System;
using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public interface IRoutineService
    {
        Routine Add(Routine newRoutine);
        Routine Update(Routine updatedRoutine);
        Routine Get(int id);
        IEnumerable<Routine> GetAll();
        void Remove(int id);
    }
}
