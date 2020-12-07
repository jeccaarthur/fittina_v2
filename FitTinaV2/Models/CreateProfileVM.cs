using System;
namespace FitTinaV2.Models
{
    public class CreateProfileVM
    {
        // needs from user:
        // name, age, feet, inches, weight, fitnessgoal, equipmentpref

        public string Name { get; set; }
        public int Age { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        public int Weight { get; set; }
        public string FitnessGoal { get; set; }
        public string EquipmentPref { get; set; }
    }
}
