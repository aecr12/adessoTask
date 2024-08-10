using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace adessoTaskApi.Migrations
{
    public partial class GeneratedTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneratorPeople",
                columns: table => new
                {
                    GeneratorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GeneratorName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GeneratorSurname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GenerationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratorPeople", x => x.GeneratorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneratorPeople");
        }
    }
}
