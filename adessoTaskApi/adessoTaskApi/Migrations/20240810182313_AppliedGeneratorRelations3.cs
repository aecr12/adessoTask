using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace adessoTaskApi.Migrations
{
    public partial class AppliedGeneratorRelations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "GeneratorPersons");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Teams",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Teams",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "GeneratorPersons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
