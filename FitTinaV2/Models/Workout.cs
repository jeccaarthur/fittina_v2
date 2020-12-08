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

        [NotMapped]
        public string Effort { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [NotMapped]
        public string UserName { get; set; }


        // convert effort to sets
        public int GetSets(string effort)
        {
            int sets = 1;

            if (effort == "easy")
            {
                sets = 2;
            }
            else if (effort == "medium")
            {
                sets = 3;
            }
            else if (effort == "challenging")
            {
                sets = 4;
            }

            return sets;
        }


        // convert effort to reps
        public int GetReps(string effort)
        {
            int reps = 8;

            if (effort == "easy")
            {
                reps = 10;
            }
            else if (effort == "medium")
            {
                reps = 12;
            }
            else if (effort == "challenging")
            {
                reps = 15;
            }

            return reps;
        }
    }
}
