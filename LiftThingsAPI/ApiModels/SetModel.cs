using System;
namespace LiftThingsAPI.ApiModels
{
    public class SetModel
    {
        public int Id { get; set; }
        public string RoutineId { get; set; }
        public string ExcerciseId { get; set; }
        public decimal Weight { get; set; }
        public int RepetitionsCount { get; set; }
    }
}
