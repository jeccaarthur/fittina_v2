using System;
using System.ComponentModel.DataAnnotations.Schema;
using FitTinaV2.Models;

namespace FitTinaV2.Models
{
    public class Workout
    {
        public Workout() { }

        public int WorkoutID { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public Exercise Exercise1 { get; set; }
        public Exercise Exercise2 { get; set; }
        public Exercise Exercise3 { get; set; }
        public Exercise Exercise4 { get; set; }
        public Exercise Exercise5 { get; set; }
        public Exercise Exercise6 { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
