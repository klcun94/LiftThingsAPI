using System;
using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public interface IRoutineRepository
    {
        Routine Add(Routine Routine);
        Routine Get(int id);
        Routine Update(Routine Routine);
        void Remove(int id);
        IEnumerable<Routine> GetAll();
    }
}
