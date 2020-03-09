using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.ApiModels
{
    public class ExerciseModel
    {
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }
        [Required]
        public string MuscleGroup { get; set; }
        public string Notes { get; set; }
        public string RoutineId { get; set; }
        public ICollection<Routine> Routines { get; set; }

        //public ICollection<Set> Sets { get; set; }
    }
}
