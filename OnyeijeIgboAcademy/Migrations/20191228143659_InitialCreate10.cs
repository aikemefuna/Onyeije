using Microsoft.EntityFrameworkCore.Migrations;

namespace OnyeijeIgboAcademy.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
