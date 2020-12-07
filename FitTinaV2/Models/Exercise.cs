using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FitTinaV2.Models;

namespace FitTina.Models
{
    public class Exercise
    {
        public Exercise() { }

        public int ExerciseID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string EquipmentRequired { get; set; }
        public string VideoUrl { get; set; }
    }
}