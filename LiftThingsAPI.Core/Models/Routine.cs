using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiftThingsAPI.Core.Models
{
    public class Routine : IEntity<int>
    {
        public int Id { get; set; }

        [Required]
        public string RoutineName { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}