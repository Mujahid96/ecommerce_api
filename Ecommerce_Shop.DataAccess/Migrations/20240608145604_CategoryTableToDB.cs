using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce_Shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CategoryTableToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Attribute1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
