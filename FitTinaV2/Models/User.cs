using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitTinaV2.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        public int Weight { get; set; }
        public string FitnessGoal { get; set; }
        public string EquipmentPref { get; set; }

        public int FeetInchesToTotalHeight(int feet, int inches)
        {
            int totalInches = (feet * 12) + inches;

            return totalInches;
        }
    }
}