using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitTinaV2.Models
{
    public class User
    {
        [NotMapped]
        public int Feet;

        [NotMapped]
        public int Inches;

        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string FitnessGoal { get; set; }
        public string EquipmentPref { get; set; }
    }
}