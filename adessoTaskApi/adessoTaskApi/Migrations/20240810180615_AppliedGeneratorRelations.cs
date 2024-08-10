using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace adessoTaskApi.Migrations
{
    public partial class AppliedGeneratorRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneratorPeople",
                table: "GeneratorPeople");

            migrationBuilder.RenameTable(
                name: "GeneratorPeople",
                newName: "GeneratorPersons");

            migrationBuilder.AddColumn<int>(
                name: "GeneratorPersonId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "GeneratorPersons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneratorPersons",
                table: "GeneratorPersons",
                column: "GeneratorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneratorPersons",
                table: "GeneratorPersons");

            migrationBuilder.DropColumn(
                name: "GeneratorPersonId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "GeneratorPersons");

            migrationBuilder.RenameTable(
                name: "GeneratorPersons",
                newName: "GeneratorPeople");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneratorPeople",
                table: "GeneratorPeople",
                column: "GeneratorId");
        }
    }
}
