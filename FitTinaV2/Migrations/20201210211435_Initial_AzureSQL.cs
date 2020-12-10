using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitTinaV2.Migrations
{
    public partial class Initial_AzureSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Effort = table.Column<string>(nullable: true),
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
