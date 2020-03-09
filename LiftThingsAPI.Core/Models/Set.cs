using System;
namespace LiftThingsAPI.Core.Models
{
    public class Set : IEntity<int>
    {
        public int Id { get; set; }
        public string RoutineId { get; set; }
        public string ExcerciseId { get; set; }
        public decimal Weight { get; set; }
        public int RepetitionsCount { get; set; }
    }
}
