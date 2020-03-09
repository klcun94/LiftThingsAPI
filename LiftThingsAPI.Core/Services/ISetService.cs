using System.Collections.Generic;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.Core.Services
{
    public interface ISetService
    {
        Set Add(Set Set);
        Set Update(Set Set);
        Set Get(int id);
        IEnumerable<Set> GetAll();
        void Remove(int id);
    }
}