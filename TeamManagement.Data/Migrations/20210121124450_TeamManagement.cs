using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagement.Data.Migrations
{
    public partial class TeamManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUnitLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnitType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentBusinessUnitId = table.Column<int>(type: "int", nullable: true),
                    BusinessUnitTypeId = table.Column<int>(type: "int", nullable: false),
                    BusinessUnitLocationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessUnit_BusinessUnitLocation_BusinessUnitLocationId",
                        column: x => x.BusinessUnitLocationId,
                        principalTable: "BusinessUnitLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessUnit_BusinessUnitType_BusinessUnitTypeId",
                        column: x => x.BusinessUnitTypeId,
                        principalTable: "BusinessUnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstnames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_BusinessUnit_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerData_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnit_BusinessUnitLocationId",
                table: "BusinessUnit",
                column: "BusinessUnitLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnit_BusinessUnitTypeId",
                table: "BusinessUnit",
                column: "BusinessUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BusinessUnitId",
                table: "Employee",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerData_EmployeeId",
                table: "PlayerData",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerData");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "BusinessUnit");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "BusinessUnitLocation");

            migrationBuilder.DropTable(
                name: "BusinessUnitType");
        }
    }
}
