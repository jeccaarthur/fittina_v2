using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitTinaV2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    EquipmentRequired = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Feet = table.Column<int>(nullable: false),
                    Inches = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    FitnessGoal = table.Column<string>(nullable: true),
                    EquipmentPref = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Sets = table.Column<int>(nullable: false),
                    Reps = table.Column<int>(nullable: false),
                    Exercise1ExerciseID = table.Column<int>(nullable: true),
                    Exercise2ExerciseID = table.Column<int>(nullable: true),
                    Exercise3ExerciseID = table.Column<int>(nullable: true),
                    Exercise4ExerciseID = table.Column<int>(nullable: true),
                    Exercise5ExerciseID = table.Column<int>(nullable: true),
                    Exercise6ExerciseID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutID);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise1ExerciseID",
                        column: x => x.Exercise1ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise2ExerciseID",
                        column: x => x.Exercise2ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise3ExerciseID",
                        column: x => x.Exercise3ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise4ExerciseID",
                        column: x => x.Exercise4ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise5ExerciseID",
                        column: x => x.Exercise5ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_Exercise6ExerciseID",
                        column: x => x.Exercise6ExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 1, "Dumbbells", "Alternating Bicep Curl", "Upper Body", "https://www.youtube.com/watch?v=xxgxVU1NsNc" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 82, "Dumbbells", "Push-Up to Row", "Compound", "https://www.youtube.com/watch?v=NW7d5SLOtiI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 81, "Dumbbells", "Kettlebell Swing", "Compound", "https://www.youtube.com/watch?v=YSxHifyI6s8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 80, "Bodyweight", "Floor Toe Taps", "Core", "https://www.youtube.com/watch?v=Ml2xTP45jVQ" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 79, "Bodyweight", "Cross-Body Mountain Climber", "Core", "https://www.youtube.com/watch?v=luRruRjECm8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 78, "Bodyweight", "Bird Dog", "Core", "https://www.youtube.com/watch?v=zs82fV88_lM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 77, "Bodyweight", "Butterfly Sit-Ups", "Core", "https://www.youtube.com/watch?v=hdXsuDt2PKE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 76, "Bodyweight", "Flutter Kicks", "Core", "https://www.youtube.com/watch?v=ZB1SwBRVLCc" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 75, "Bodyweight", "Standing Oblique Crunch", "Core", "https://www.youtube.com/watch?v=YH_2t6Hh7GQ" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 74, "Bodyweight", "Jack Knife Sit-Ups", "Core", "https://www.youtube.com/watch?v=GI4S_zkJJkM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 73, "Bodyweight", "Plank with Shoulder Taps", "Core", "https://www.youtube.com/watch?v=ztpXZm7Dv80" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 72, "Bodyweight", "Walkouts", "Core", "https://www.youtube.com/watch?v=R6SMJ-TzgZo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 83, "Dumbbells", "Dumbbell Burpee", "Compound", "https://www.youtube.com/watch?v=vxZM3dR9deg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 71, "Bodyweight", "Bicycle Crunches", "Core", "https://www.youtube.com/watch?v=1we3bh9uhqY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 69, "Bodyweight", "Mountain Climbers", "Core", "https://www.youtube.com/watch?v=cnyTQDSE884" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 68, "Bodyweight", "Sit-Ups", "Core", "https://www.youtube.com/watch?v=1fbU_MkV7NE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 67, "Bodyweight", "Reverse Crunch", "Core", "https://www.youtube.com/watch?v=YDvaOlhaA1U" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 66, "Bodyweight", "V Sit-Up", "Core", "https://www.youtube.com/watch?v=WTmnP0xIdq8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 65, "Bodyweight", "Spider Crawl", "Core", "https://www.youtube.com/watch?v=_K7rv_vFOWM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 64, "Bodyweight", "Forearm Plank Jacks", "Core", "https://www.youtube.com/watch?v=UmbhcRt-s58" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 63, "Bodyweight", "Side Plank", "Core", "https://www.youtube.com/watch?v=IkMmABQ9SkM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 62, "Bodyweight", "Plank", "Core", "https://www.youtube.com/watch?v=B296mZDhrP4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 61, "Bodyweight", "Lying Leg Raises", "Core", "https://www.youtube.com/watch?v=UvcTNVbjTYo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 60, "Bodyweight", "Russian Twists", "Core", "https://www.youtube.com/watch?v=JyUqwkVpsi8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 59, "Bodyweight", "3D Air Lunge", "Lower Body", "https://www.youtube.com/watch?v=p2rVtx5nCL8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 70, "Bodyweight", "Hip Dip Plank", "Core", "https://www.youtube.com/watch?v=XAT8SDAj5EM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 58, "Bodyweight", "Clamshell", "Lower Body", "https://www.youtube.com/watch?v=EG5_gXcfozw" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 84, "Dumbbells", "Alternating Dumbbell Snatch", "Compound", "https://www.youtube.com/watch?v=OktkfRlGcns" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 86, "Dumbbells", "Squat Press", "Compound", "https://www.youtube.com/watch?v=y29Cs067sD8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 110, "Bodyweight", "Toe Taps", "Cardio", "https://www.youtube.com/watch?v=l5V0BJJFNoY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 109, "Bodyweight", "Standing Long Jump", "Cardio", "https://www.youtube.com/watch?v=yFdHdQ_fXSo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 108, "Bodyweight", "Step-Ups with Knee Raise", "Cardio", "https://www.youtube.com/watch?v=df-HaATHVnQ" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 107, "Bodyweight", "Burpees", "Cardio", "https://www.youtube.com/watch?v=tJrdJBWBu08" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 106, "Bodyweight", "Sprints", "Cardio", "https://www.youtube.com/watch?v=3nbjhpcZ9_g" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 105, "Bodyweight", "High Knees", "Cardio", "https://www.youtube.com/watch?v=oDdkytliOqE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 104, "Bodyweight", "Jumping Jacks", "Cardio", "https://www.youtube.com/watch?v=iRVzVa0GSYY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 103, "Bodyweight", "Alternating Split Squat Jump", "Cardio", "https://www.youtube.com/watch?v=ZiupDCper-M" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 102, "Bodyweight", "Jump Squat with Tuck", "Cardio", "https://www.youtube.com/watch?v=lh5W0vzT4oE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 101, "Bodyweight", "Jump Squat", "Cardio", "https://www.youtube.com/watch?v=J6Y520KkwOA" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 100, "Bodyweight", "Spiderman Push-Up", "Compound", "https://www.youtube.com/watch?v=vo_Dvi8ktIE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 85, "Dumbbells", "Lunge to Curl", "Compound", "https://www.youtube.com/watch?v=fIvr9ootgos" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 99, "Bodyweight", "Bear Crunch", "Compound", "https://www.youtube.com/watch?v=YMj_2GYROvg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 97, "Bodyweight", "Single Leg Side Plank", "Compound", "https://www.youtube.com/watch?v=lFzJQXiljF4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 96, "Bodyweight", "Wall Walk", "Compound", "https://www.youtube.com/watch?v=cjY1xl-ddwo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 95, "Bodyweight", "Fire Hydrant", "Compound", "https://www.youtube.com/watch?v=CAZZz7uP-Ok" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 94, "Bodyweight", "T Push-Ups", "Compound", "https://www.youtube.com/watch?v=vKaLCCNxMho" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 93, "Dumbbells", "Reverse Lunge to Single-Arm Press", "Compound", "https://www.youtube.com/watch?v=OEozeabd-oA" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 92, "Dumbbells", "Kneeling Wood Chop", "Compound", "https://www.youtube.com/watch?v=2lpkNhQR_Aw" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 91, "Dumbbells", "Suitcase Carry", "Compound", "https://www.youtube.com/watch?v=qp4PeLphg6M" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 90, "Dumbbells", "Loaded Carry", "Compound", "https://www.youtube.com/watch?v=0LVcc8620qo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 89, "Dumbbells", "Step-Up to Press", "Compound", "https://www.youtube.com/watch?v=v-WOS5l81SY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 88, "Dumbbells", "Renegade Row", "Compound", "https://www.youtube.com/watch?v=LccyTxiUrhg" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 87, "Dumbbells", "Clean and Press", "Compound", "https://www.youtube.com/watch?v=4MKfeQDkkNY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 98, "Bodyweight", "T-Rotation", "Compound", "https://www.youtube.com/watch?v=yaM8hDcSyH4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 57, "Bodyweight", "Side Leg Raise", "Lower Body", "https://www.youtube.com/watch?v=jgh6sGwtTwk" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 56, "Bodyweight", "Arms-Overhead Air Squat", "Lower Body", "https://www.youtube.com/watch?v=02uirDvXUUo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 55, "Bodyweight", "Lateral Squat Walk", "Lower Body", "https://www.youtube.com/watch?v=NK57EZP_v34" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 25, "Dumbbells", "Pulse Squat", "Lower Body", "https://www.youtube.com/watch?v=j4yJvxvlqXw" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 24, "Dumbbells", "Squat", "Lower Body", "https://www.youtube.com/watch?v=v_c67Omje48" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 23, "Bodyweight", "Incline Push-Ups", "Upper Body", "https://www.youtube.com/watch?v=Gvm5Q29UHbk" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 22, "Bodyweight", "Triangle Push-Ups", "Upper Body", "https://www.youtube.com/watch?v=hfIQ5V4Tcgo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 21, "Bodyweight", "Superman Hold", "Upper Body", "https://www.youtube.com/watch?v=cc6UVRS7PW4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 20, "Bodyweight", "Bench Dips", "Upper Body", "https://www.youtube.com/watch?v=IODxDxX7oi4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 19, "Bodyweight", "Push-Ups", "Upper Body", "https://www.youtube.com/watch?v=IODxDxX7oi4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 18, "Dumbbells", "Bus Driver", "Upper Body", "https://www.youtube.com/watch?v=25g1bRCOoHc" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 17, "Dumbbells", "Single Arm Overhead Press", "Upper Body", "https://www.youtube.com/watch?v=NVnyDQqmhPo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 16, "Dumbbells", "Hang Clean", "Upper Body", "https://www.youtube.com/watch?v=hFXPxXkYr_o" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 15, "Dumbbells", "Seesaw Press", "Upper Body", "https://www.youtube.com/watch?v=jn2aqML1FIs" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 26, "Dumbbells", "Goblet Squat", "Lower Body", "https://www.youtube.com/watch?v=MJao9o7ROs0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 14, "Dumbbells", "Single Arm Kneeling Row", "Upper Body", "https://www.youtube.com/watch?v=l_qeCPJMU9o" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 12, "Dumbbells", "Rear Delt Fly", "Upper Body", "https://www.youtube.com/watch?v=dA4iqyTgx5I" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 11, "Dumbbells", "Hammer Curl", "Upper Body", "https://www.youtube.com/watch?v=P5sXHLmXmBM" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 10, "Dumbbells", "Military Press", "Upper Body", "https://www.youtube.com/watch?v=B-aVuyhvLHU" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 9, "Dumbbells", "Chest Fly", "Upper Body", "https://www.youtube.com/watch?v=y_Z2LftZDvk" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 8, "Dumbbells", "Single Arm Chest Press", "Upper Body", "https://www.youtube.com/watch?v=6tbjm5FjhB0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 7, "Dumbbells", "Chest Press", "Upper Body", "https://www.youtube.com/watch?v=jRUC6IVav30" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 6, "Dumbbells", "Tricep Extension", "Upper Body", "https://www.youtube.com/watch?v=nRiJVZDpdL0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 5, "Dumbbells", "Bent Over Row", "Upper Body", "https://www.youtube.com/watch?v=ZXpZu_fmheU" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 4, "Dumbbells", "Rear Delt Raise", "Upper Body", "https://www.youtube.com/watch?v=p1yQnTNE808" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 3, "Dumbbells", "Lateral Delt Raise", "Upper Body", "https://www.youtube.com/watch?v=Q4SMoasiMI0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 2, "Dumbbells", "Front Delt Raise", "Upper Body", "https://www.youtube.com/watch?v=2aoEWSvPBeI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 13, "Dumbbells", "Tricep Kickback", "Upper Body", "https://www.youtube.com/watch?v=ZO81bExngMI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 27, "Dumbbells", "Reverse Lunge", "Lower Body", "https://www.youtube.com/watch?v=ZK-O_aS3GdY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 28, "Dumbbells", "Romanian Deadlfit", "Lower Body", "https://www.youtube.com/watch?v=UsOjCcxSJaI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 29, "Dumbbells", "Bulgarian Split Squat", "Lower Body", "https://www.youtube.com/watch?v=TwsAe8xrnqE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 54, "Bodyweight", "Air Curtsy Lunge", "Lower Body", "https://www.youtube.com/watch?v=4nUxVn0K6d4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 53, "Bodyweight", "Single Leg Air RDL", "Lower Body", "https://www.youtube.com/watch?v=2SoSzhDkoXA" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 52, "Bodyweight", "Pulse Air Squat", "Lower Body", "https://www.youtube.com/watch?v=N4fzbBv4BFI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 51, "Bodyweight", "Walking Air Lunges", "Lower Body", "https://www.youtube.com/watch?v=r49nFlyDvTc" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 50, "Bodyweight", "Sumo Air Squat", "Lower Body", "https://www.youtube.com/watch?v=mhcEWu-0pzs" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 49, "Bodyweight", "Glute Kickbacks", "Lower Body", "https://www.youtube.com/watch?v=BNDw4ciQoQI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 48, "Bodyweight", "Pistol Squat", "Lower Body", "https://www.youtube.com/watch?v=vq5-vdgJc0I" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 47, "Bodyweight", "Glute Bridge", "Lower Body", "https://www.youtube.com/watch?v=9NkNgFc_-Ys" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 46, "Bodyweight", "Single Leg Glute Bridge", "Lower Body", "https://www.youtube.com/watch?v=Y-6Gonx2Wpo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 45, "Bodyweight", "Bulgarian Air Split Squat", "Lower Body", "https://www.youtube.com/watch?v=aSJbKnDRIiQ" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 44, "Bodyweight", "Lateral Air Lunge", "Lower Body", "https://www.youtube.com/watch?v=gwWv7aPcD88" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 43, "Bodyweight", "Reverse Air Lunge", "Lower Body", "https://www.youtube.com/watch?v=tpVhJNQURk4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 42, "Bodyweight", "Air Squat", "Lower Body", "https://www.youtube.com/watch?v=jcyoiT98jdk" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 41, "Dumbbells", "3D Lunge", "Lower Body", "https://www.youtube.com/watch?v=p2rVtx5nCL8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 40, "Dumbbells", "Hamstring Curl", "Lower Body", "https://www.youtube.com/watch?v=cSzoVHHnuu0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 39, "Dumbbells", "Lateral Lunge", "Lower Body", "https://www.youtube.com/watch?v=ktdMS7WBwck" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 38, "Dumbbells", "Offset Squat", "Lower Body", "https://www.youtube.com/watch?v=PsCuU0Fs49I" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 37, "Dumbbells", "Deadlift", "Lower Body", "https://www.youtube.com/watch?v=Ipi8_vz8_z0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 36, "Dumbbells", "Curtsy Lunge", "Lower Body", "https://www.youtube.com/watch?v=Mqkcr0LeNR4" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 35, "Dumbbells", "Standing Calf Raise", "Lower Body", "https://www.youtube.com/watch?v=wxwY7GXxL4k" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 34, "Dumbbells", "Single Leg RDL", "Lower Body", "https://www.youtube.com/watch?v=IlOrGu1qzWs" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 33, "Dumbbells", "Walking Lunges", "Lower Body", "https://www.youtube.com/watch?v=SniKHGKDJyU" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 32, "Dumbbells", "Sumo Squat", "Lower Body", "https://www.youtube.com/watch?v=3eMBG2-lD4I" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 31, "Dumbbells", "Hip Thrust", "Lower Body", "https://www.youtube.com/watch?v=1Yezfp-YWc8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 30, "Dumbbells", "Weighted Glute Bridge", "Lower Body", "https://www.youtube.com/watch?v=iiu7ArCUjF8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 111, "Bodyweight", "Ski Jump", "Cardio", "https://www.youtube.com/watch?v=yk7yXdzabxY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "EquipmentRequired", "Name", "Type", "VideoUrl" },
                values: new object[] { 112, "Bodyweight", "Squat Jacks", "Cardio", "https://www.youtube.com/watch?v=LK3jSsdQ7M4" });

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise1ExerciseID",
                table: "Workouts",
                column: "Exercise1ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise2ExerciseID",
                table: "Workouts",
                column: "Exercise2ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise3ExerciseID",
                table: "Workouts",
                column: "Exercise3ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise4ExerciseID",
                table: "Workouts",
                column: "Exercise4ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise5ExerciseID",
                table: "Workouts",
                column: "Exercise5ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_Exercise6ExerciseID",
                table: "Workouts",
                column: "Exercise6ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
