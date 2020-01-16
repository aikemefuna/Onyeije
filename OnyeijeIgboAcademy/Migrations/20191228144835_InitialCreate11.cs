using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnyeijeIgboAcademy.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTopic_Modules_ModulesModuleId",
                table: "StudentTopic");

            migrationBuilder.DropIndex(
                name: "IX_StudentTopic_ModulesModuleId",
                table: "StudentTopic");

            migrationBuilder.DropColumn(
                name: "ModulesModuleId",
                table: "StudentTopic");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StudentTopic",
                newName: "StudentTopicId");

            migrationBuilder.CreateTable(
                name: "StudentModules",
                columns: table => new
                {
                    StudentModulesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsCompleted = table.Column<bool>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: true),
                    CompletedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModules", x => x.StudentModulesId);
                    table.ForeignKey(
                        name: "FK_StudentModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentModules_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentModules_ModuleId",
                table: "StudentModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentModules_StudentId",
                table: "StudentModules",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentModules");

            migrationBuilder.RenameColumn(
                name: "StudentTopicId",
                table: "StudentTopic",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ModulesModuleId",
                table: "StudentTopic",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentTopic_ModulesModuleId",
                table: "StudentTopic",
                column: "ModulesModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTopic_Modules_ModulesModuleId",
                table: "StudentTopic",
                column: "ModulesModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
