using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitTinaV2.Models;
using Microsoft.EntityFrameworkCore;

namespace FitTinaV2.Models
{
    public class FitTinaDbContext : DbContext
    {
        public FitTinaDbContext(DbContextOptions<FitTinaDbContext> options) : base(options) { }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed data
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    ExerciseID = 1,
                    Name = "Alternating Bicep Curl",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=xxgxVU1NsNc"
                },
                new Exercise
                {
                    ExerciseID = 2,
                    Name = "Front Delt Raise",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=2aoEWSvPBeI"
                },
                new Exercise
                {
                    ExerciseID = 3,
                    Name = "Lateral Delt Raise",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=Q4SMoasiMI0"
                },
                new Exercise
                {
                    ExerciseID = 4,
                    Name = "Rear Delt Raise",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=p1yQnTNE808"
                },
                new Exercise
                {
                    ExerciseID = 5,
                    Name = "Bent Over Row",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=ZXpZu_fmheU"
                },
                new Exercise
                {
                    ExerciseID = 6,
                    Name = "Tricep Extension",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=nRiJVZDpdL0"
                },
                new Exercise
                {
                    ExerciseID = 7,
                    Name = "Chest Press",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=jRUC6IVav30"
                },
                new Exercise
                {
                    ExerciseID = 8,
                    Name = "Single Arm Chest Press",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=6tbjm5FjhB0"
                },
                new Exercise
                {
                    ExerciseID = 9,
                    Name = "Chest Fly",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=y_Z2LftZDvk"
                },
                new Exercise
                {
                    ExerciseID = 10,
                    Name = "Military Press",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=B-aVuyhvLHU"
                },
                new Exercise
                {
                    ExerciseID = 11,
                    Name = "Hammer Curl",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=P5sXHLmXmBM"
                },
                new Exercise
                {
                    ExerciseID = 12,
                    Name = "Rear Delt Fly",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=dA4iqyTgx5I"
                },
                new Exercise
                {
                    ExerciseID = 13,
                    Name = "Tricep Kickback",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=ZO81bExngMI"
                },
                new Exercise
                {
                    ExerciseID = 14,
                    Name = "Single Arm Kneeling Row",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=l_qeCPJMU9o"
                },
                new Exercise
                {
                    ExerciseID = 15,
                    Name = "Seesaw Press",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=jn2aqML1FIs"
                },
                new Exercise
                {
                    ExerciseID = 16,
                    Name = "Hang Clean",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=hFXPxXkYr_o"
                },
                new Exercise
                {
                    ExerciseID = 17,
                    Name = "Single Arm Overhead Press",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=NVnyDQqmhPo"
                },
                new Exercise
                {
                    ExerciseID = 18,
                    Name = "Bus Driver",
                    Type = "Upper Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=25g1bRCOoHc"
                },
                new Exercise
                {
                    ExerciseID = 19,
                    Name = "Push-Ups",
                    Type = "Upper Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=IODxDxX7oi4"
                },
                new Exercise
                {
                    ExerciseID = 20,
                    Name = "Bench Dips",
                    Type = "Upper Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=IODxDxX7oi4"
                },
                new Exercise
                {
                    ExerciseID = 21,
                    Name = "Superman Hold",
                    Type = "Upper Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=cc6UVRS7PW4"
                },
                new Exercise
                {
                    ExerciseID = 22,
                    Name = "Triangle Push-Ups",
                    Type = "Upper Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=hfIQ5V4Tcgo"
                },
                new Exercise
                {
                    ExerciseID = 23,
                    Name = "Incline Push-Ups",
                    Type = "Upper Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=Gvm5Q29UHbk"
                },
                new Exercise
                {
                    ExerciseID = 24,
                    Name = "Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=v_c67Omje48"
                },
                new Exercise
                {
                    ExerciseID = 25,
                    Name = "Pulse Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=j4yJvxvlqXw"
                },
                new Exercise
                {
                    ExerciseID = 26,
                    Name = "Goblet Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=MJao9o7ROs0"
                },
                new Exercise
                {
                    ExerciseID = 27,
                    Name = "Reverse Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=ZK-O_aS3GdY"
                },
                new Exercise
                {
                    ExerciseID = 28,
                    Name = "Romanian Deadlfit",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=UsOjCcxSJaI"
                },
                new Exercise
                {
                    ExerciseID = 29,
                    Name = "Bulgarian Split Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=TwsAe8xrnqE"
                },
                new Exercise
                {
                    ExerciseID = 30,
                    Name = "Weighted Glute Bridge",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=iiu7ArCUjF8"
                },
                new Exercise
                {
                    ExerciseID = 31,
                    Name = "Hip Thrust",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=1Yezfp-YWc8"
                },
                new Exercise
                {
                    ExerciseID = 32,
                    Name = "Sumo Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=3eMBG2-lD4I"
                },
                new Exercise
                {
                    ExerciseID = 33,
                    Name = "Walking Lunges",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=SniKHGKDJyU"
                },
                new Exercise
                {
                    ExerciseID = 34,
                    Name = "Single Leg RDL",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=IlOrGu1qzWs"
                },
                new Exercise
                {
                    ExerciseID = 35,
                    Name = "Standing Calf Raise",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=wxwY7GXxL4k"
                },
                new Exercise
                {
                    ExerciseID = 36,
                    Name = "Curtsy Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=Mqkcr0LeNR4"
                },
                new Exercise
                {
                    ExerciseID = 37,
                    Name = "Deadlift",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=Ipi8_vz8_z0"
                },
                new Exercise
                {
                    ExerciseID = 38,
                    Name = "Offset Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=PsCuU0Fs49I"
                },
                new Exercise
                {
                    ExerciseID = 39,
                    Name = "Lateral Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=ktdMS7WBwck"
                },
                new Exercise
                {
                    ExerciseID = 40,
                    Name = "Hamstring Curl",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=cSzoVHHnuu0"
                },
                new Exercise
                {
                    ExerciseID = 41,
                    Name = "3D Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=p2rVtx5nCL8"
                },
                new Exercise
                {
                    ExerciseID = 42,
                    Name = "Air Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=jcyoiT98jdk"
                },
                new Exercise
                {
                    ExerciseID = 43,
                    Name = "Reverse Air Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=tpVhJNQURk4"
                },
                new Exercise
                {
                    ExerciseID = 44,
                    Name = "Lateral Air Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=gwWv7aPcD88"
                },
                new Exercise
                {
                    ExerciseID = 45,
                    Name = "Bulgarian Air Split Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=aSJbKnDRIiQ"
                },
                new Exercise
                {
                    ExerciseID = 46,
                    Name = "Single Leg Glute Bridge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=Y-6Gonx2Wpo"
                },
                new Exercise
                {
                    ExerciseID = 47,
                    Name = "Glute Bridge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=9NkNgFc_-Ys"
                },
                new Exercise
                {
                    ExerciseID = 48,
                    Name = "Pistol Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=vq5-vdgJc0I"
                },
                new Exercise
                {
                    ExerciseID = 49,
                    Name = "Glute Kickbacks",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=BNDw4ciQoQI"
                },
                new Exercise
                {
                    ExerciseID = 50,
                    Name = "Sumo Air Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=mhcEWu-0pzs"
                },
                new Exercise
                {
                    ExerciseID = 51,
                    Name = "Walking Air Lunges",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=r49nFlyDvTc"
                },
                new Exercise
                {
                    ExerciseID = 52,
                    Name = "Pulse Air Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=N4fzbBv4BFI"
                },
                new Exercise
                {
                    ExerciseID = 53,
                    Name = "Single Leg Air RDL",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=2SoSzhDkoXA"
                },
                new Exercise
                {
                    ExerciseID = 54,
                    Name = "Air Curtsy Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=4nUxVn0K6d4"
                },
                new Exercise
                {
                    ExerciseID = 55,
                    Name = "Lateral Squat Walk",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=NK57EZP_v34"
                },
                new Exercise
                {
                    ExerciseID = 56,
                    Name = "Arms-Overhead Air Squat",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=02uirDvXUUo"
                },
                new Exercise
                {
                    ExerciseID = 57,
                    Name = "Side Leg Raise",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=jgh6sGwtTwk"
                },
                new Exercise
                {
                    ExerciseID = 58,
                    Name = "Clamshell",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=EG5_gXcfozw"
                },
                new Exercise
                {
                    ExerciseID = 59,
                    Name = "3D Air Lunge",
                    Type = "Lower Body",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=p2rVtx5nCL8"
                },
                new Exercise
                {
                    ExerciseID = 60,
                    Name = "Russian Twists",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=JyUqwkVpsi8"
                },
                new Exercise
                {
                    ExerciseID = 61,
                    Name = "Lying Leg Raises",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=UvcTNVbjTYo"
                },
                new Exercise
                {
                    ExerciseID = 62,
                    Name = "Plank",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=B296mZDhrP4"
                },
                new Exercise
                {
                    ExerciseID = 63,
                    Name = "Side Plank",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=IkMmABQ9SkM"
                },
                new Exercise
                {
                    ExerciseID = 64,
                    Name = "Forearm Plank Jacks",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=UmbhcRt-s58"
                },
                new Exercise
                {
                    ExerciseID = 65,
                    Name = "Spider Crawl",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=_K7rv_vFOWM"
                },
                new Exercise
                {
                    ExerciseID = 66,
                    Name = "V Sit-Up",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=WTmnP0xIdq8"
                },
                new Exercise
                {
                    ExerciseID = 67,
                    Name = "Reverse Crunch",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=YDvaOlhaA1U"
                },
                new Exercise
                {
                    ExerciseID = 68,
                    Name = "Sit-Ups",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=1fbU_MkV7NE"
                },
                new Exercise
                {
                    ExerciseID = 69,
                    Name = "Mountain Climbers",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=cnyTQDSE884"
                },
                new Exercise
                {
                    ExerciseID = 70,
                    Name = "Hip Dip Plank",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=XAT8SDAj5EM"
                },
                new Exercise
                {
                    ExerciseID = 71,
                    Name = "Bicycle Crunches",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=1we3bh9uhqY"
                },
                new Exercise
                {
                    ExerciseID = 72,
                    Name = "Walkouts",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=R6SMJ-TzgZo"
                },
                new Exercise
                {
                    ExerciseID = 73,
                    Name = "Plank with Shoulder Taps",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=ztpXZm7Dv80"
                },
                new Exercise
                {
                    ExerciseID = 74,
                    Name = "Jack Knife Sit-Ups",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=GI4S_zkJJkM"
                },
                new Exercise
                {
                    ExerciseID = 75,
                    Name = "Standing Oblique Crunch",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=YH_2t6Hh7GQ"
                },
                new Exercise
                {
                    ExerciseID = 76,
                    Name = "Flutter Kicks",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=ZB1SwBRVLCc"
                },
                new Exercise
                {
                    ExerciseID = 77,
                    Name = "Butterfly Sit-Ups",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=hdXsuDt2PKE"
                },
                new Exercise
                {
                    ExerciseID = 78,
                    Name = "Bird Dog",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=zs82fV88_lM"
                },
                new Exercise
                {
                    ExerciseID = 79,
                    Name = "Cross-Body Mountain Climber",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=luRruRjECm8"
                },
                new Exercise
                {
                    ExerciseID = 80,
                    Name = "Floor Toe Taps",
                    Type = "Core",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=Ml2xTP45jVQ"
                },
                new Exercise
                {
                    ExerciseID = 81,
                    Name = "Kettlebell Swing",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=YSxHifyI6s8"
                },
                new Exercise
                {
                    ExerciseID = 82,
                    Name = "Push-Up to Row",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=NW7d5SLOtiI"
                },
                new Exercise
                {
                    ExerciseID = 83,
                    Name = "Dumbbell Burpee",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=vxZM3dR9deg"
                },
                new Exercise
                {
                    ExerciseID = 84,
                    Name = "Alternating Dumbbell Snatch",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=OktkfRlGcns"
                },
                new Exercise
                {
                    ExerciseID = 85,
                    Name = "Lunge to Curl",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=fIvr9ootgos"
                },
                new Exercise
                {
                    ExerciseID = 86,
                    Name = "Squat Press",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=y29Cs067sD8"
                },
                new Exercise
                {
                    ExerciseID = 87,
                    Name = "Clean and Press",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=4MKfeQDkkNY"
                },
                new Exercise
                {
                    ExerciseID = 88,
                    Name = "Renegade Row",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=LccyTxiUrhg"
                },
                new Exercise
                {
                    ExerciseID = 89,
                    Name = "Step-Up to Press",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=v-WOS5l81SY"
                },
                new Exercise
                {
                    ExerciseID = 90,
                    Name = "Loaded Carry",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=0LVcc8620qo"
                },
                new Exercise
                {
                    ExerciseID = 91,
                    Name = "Suitcase Carry",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=qp4PeLphg6M"
                },
                new Exercise
                {
                    ExerciseID = 92,
                    Name = "Kneeling Wood Chop",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=2lpkNhQR_Aw"
                },
                new Exercise
                {
                    ExerciseID = 93,
                    Name = "Reverse Lunge to Single-Arm Press",
                    Type = "Compound",
                    EquipmentRequired = "Dumbbells",
                    VideoUrl = "https://www.youtube.com/watch?v=OEozeabd-oA"
                },
                new Exercise
                {
                    ExerciseID = 94,
                    Name = "T Push-Ups",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=vKaLCCNxMho"
                },
                new Exercise
                {
                    ExerciseID = 95,
                    Name = "Fire Hydrant",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=CAZZz7uP-Ok"
                },
                new Exercise
                {
                    ExerciseID = 96,
                    Name = "Wall Walk",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=cjY1xl-ddwo"
                },
                new Exercise
                {
                    ExerciseID = 97,
                    Name = "Single Leg Side Plank",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=lFzJQXiljF4"
                },
                new Exercise
                {
                    ExerciseID = 98,
                    Name = "T-Rotation",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=yaM8hDcSyH4"
                },
                new Exercise
                {
                    ExerciseID = 99,
                    Name = "Bear Crunch",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=YMj_2GYROvg"
                },
                new Exercise
                {
                    ExerciseID = 100,
                    Name = "Spiderman Push-Up",
                    Type = "Compound",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=vo_Dvi8ktIE"
                },
                new Exercise
                {
                    ExerciseID = 101,
                    Name = "Jump Squat",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=J6Y520KkwOA"
                },
                new Exercise
                {
                    ExerciseID = 102,
                    Name = "Jump Squat with Tuck",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=lh5W0vzT4oE"
                },
                new Exercise
                {
                    ExerciseID = 103,
                    Name = "Alternating Split Squat Jump",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=ZiupDCper-M"
                },
                new Exercise
                {
                    ExerciseID = 104,
                    Name = "Jumping Jacks",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=iRVzVa0GSYY"
                },
                new Exercise
                {
                    ExerciseID = 105,
                    Name = "High Knees",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=oDdkytliOqE"
                },
                new Exercise
                {
                    ExerciseID = 106,
                    Name = "Sprints",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=3nbjhpcZ9_g"
                },
                new Exercise
                {
                    ExerciseID = 107,
                    Name = "Burpees",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=tJrdJBWBu08"
                },
                new Exercise
                {
                    ExerciseID = 108,
                    Name = "Step-Ups with Knee Raise",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=df-HaATHVnQ"
                },
                new Exercise
                {
                    ExerciseID = 109,
                    Name = "Standing Long Jump",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=yFdHdQ_fXSo"
                },
                new Exercise
                {
                    ExerciseID = 110,
                    Name = "Toe Taps",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=l5V0BJJFNoY"
                },
                new Exercise
                {
                    ExerciseID = 111,
                    Name = "Ski Jump",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=yk7yXdzabxY"
                },
                new Exercise
                {
                    ExerciseID = 112,
                    Name = "Squat Jacks",
                    Type = "Cardio",
                    EquipmentRequired = "Bodyweight",
                    VideoUrl = "https://www.youtube.com/watch?v=LK3jSsdQ7M4"
                }
            );
        }
    }
}
