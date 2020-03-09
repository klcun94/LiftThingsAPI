using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiftThingsAPI.Core.Models
{
    public class Exercise : IEntity<int>
    {
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        [Required]
        public string MuscleGroup { get; set; }
        public string Notes { get; set; }
        public string RoutineId { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}
