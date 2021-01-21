using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagement.Data.Migrations
{
    public partial class TeamManagementMigration : Migration
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

            migrationBuilder.InsertData(
                table: "BusinessUnitLocation",
                columns: new[] { "Id", "Name", "PhysicalCode", "PhysicalLine1", "PhysicalLine2", "PhysicalTown" },
                values: new object[,]
                {
                    { 1, "Loftus Versfeld Stadium", "0007", "416 Kirkness St", "Arcadia", "Pretoria" },
                    { 2, "Ellis Park Stadium", "2094", "S Park Ln", "New Doornfontein", "Johannesburg" },
                    { 3, "Toyota Stadium", "9320", "Willows", "", "Bloemfontein" },
                    { 4, "Newlands Rugby Stadium", "7700", "8 Boundary Rd", "Newlands", "Cape Town" },
                    { 5, "Jonsson Kings Park", "4025", "Jacko Jackson Dr", "Stamford Hill", "Durban" }
                });

            migrationBuilder.InsertData(
                table: "BusinessUnitType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Management" },
                    { 2, "RugbyTeam" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Management" },
                    { 2, "Admin" },
                    { 3, "Coach" },
                    { 4, "Physiotherapist" },
                    { 5, "Player" }
                });

            migrationBuilder.InsertData(
                table: "BusinessUnit",
                columns: new[] { "Id", "BusinessUnitLocationId", "BusinessUnitTypeId", "Name", "ParentBusinessUnitId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Blue Bulls", null },
                    { 2, 1, 2, "Super Rugby", 1 },
                    { 3, 1, 2, "Currie Cup", 1 },
                    { 4, 1, 2, "Under 21", 1 },
                    { 5, 1, 2, "Under 18", 1 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BusinessUnitId", "CellNumber", "Email", "EmployeeTypeId", "Firstnames", "Initials", "Surname" },
                values: new object[] { 1, 2, "1234567890", "test@gmail.com", 3, "Jake", "jw", "White" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BusinessUnitId", "CellNumber", "Email", "EmployeeTypeId", "Firstnames", "Initials", "Surname" },
                values: new object[] { 2, 2, "1234567890", "test@gmail.com", 5, "Handrè", "hp", "Pollard" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BusinessUnitId", "CellNumber", "Email", "EmployeeTypeId", "Firstnames", "Initials", "Surname" },
                values: new object[] { 3, 2, "1234567890", "test@gmail.com", 5, "Warrick", "wg", "Gelant" });

            migrationBuilder.InsertData(
                table: "PlayerData",
                columns: new[] { "Id", "Age", "EmployeeId", "Height", "Weight" },
                values: new object[] { 1, 26, 2, 1.8799999999999999, 96.0 });

            migrationBuilder.InsertData(
                table: "PlayerData",
                columns: new[] { "Id", "Age", "EmployeeId", "Height", "Weight" },
                values: new object[] { 2, 25, 3, 1.78, 85.0 });

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
