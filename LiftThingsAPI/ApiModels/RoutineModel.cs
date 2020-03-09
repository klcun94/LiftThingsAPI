using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiftThingsAPI.Core.Models;

namespace LiftThingsAPI.ApiModels
{
    public class RoutineModel
    {
        public int Id { get; set; }
        [Required]
        public string RoutineName { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
