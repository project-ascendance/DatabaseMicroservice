using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class spelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fragment",
                columns: table => new
                {
                    BelongsTo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FragmentId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextFragmentId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextBelongsTo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextFragmentBelongsTo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextFragmentFragmentId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalFragmentCount = table.Column<int>(type: "int", nullable: false),
                    FragmentType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActiveFrom = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ActiveTo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ExcernalType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExternalId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Body = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fragment", x => new { x.BelongsTo, x.FragmentId });
                    table.ForeignKey(
                        name: "FK_Fragment_Fragment_NextFragmentBelongsTo_NextFragmentFragment~",
                        columns: x => new { x.NextFragmentBelongsTo, x.NextFragmentFragmentId },
                        principalTable: "Fragment",
                        principalColumns: new[] { "BelongsTo", "FragmentId" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fragment_NextFragmentBelongsTo_NextFragmentFragmentId",
                table: "Fragment",
                columns: new[] { "NextFragmentBelongsTo", "NextFragmentFragmentId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fragment");
        }
    }
}
