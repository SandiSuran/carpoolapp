using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace carpoolapp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    LicensePlate = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    NumberOfSeats = table.Column<int>(nullable: false),
                    CurrentLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.LicensePlate);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    IsDriver = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Travels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartLocation = table.Column<string>(nullable: false),
                    EndLocation = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Info = table.Column<string>(type: "ntext", nullable: true),
                    CarLicensePlate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Travels_Cars_CarLicensePlate",
                        column: x => x.CarLicensePlate,
                        principalTable: "Cars",
                        principalColumn: "LicensePlate",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TravelEmployees",
                columns: table => new
                {
                    TravelId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelEmployees", x => new { x.TravelId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_TravelEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelEmployees_Travels_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Travels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA000PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA001PA", "Limousine", "Metalic", "Zagreb", "Ford Focus", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA002PA", "Limousine", "Metalic", "Zagreb", "Ferrari", 2 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA003PA", "Compact", "Metalic", "Zagreb", "Renault Clio", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA004PA", "Compact", "Metalic", "Zagreb", "Toyota Yaris", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA005PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA006PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA007PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA008PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "CarType", "Color", "CurrentLocation", "Name", "NumberOfSeats" },
                values: new object[] { "DA009PA", "Limousine", "Metalic", "Zagreb", "Ford Mondeo", 4 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 16, "Lionel", false, "Botelho" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 17, "Shala", true, "Kimbrough" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 18, "Xenia", false, "Pass" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 19, "Tod", false, "Messineo" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 20, "Janis", true, "Kingery" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 25, "Elliott", true, "Pass" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 22, "Samantha", true, "Beauford" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 23, "Johnna", true, "Clem" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 24, "Elfriede", true, "Mcbee" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 15, "Lakisha", false, "Julius" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 21, "Perry", true, "HuberPass" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 14, "Tatum", true, "Branton" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 9, "Micki", false, "Bustillos" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 12, "Dylan", true, "Kaczmarski" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 11, "Darell", true, "Wetherby" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 10, "Kathey", true, "Hogue" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 26, "Annemarie", true, "Mook" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 8, "Keren", true, "Jacobo" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 7, "Mauricio", true, "Tung" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 6, "Robby", true, "Nehls" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 5, "Dorene", true, "Rudnick" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 4, "Wendie", true, "Jacquet" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 3, "Isis", true, "Booe" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 2, "Angela", false, "Wolter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 1, "Xenia", true, "Pass" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 13, "Helen", true, "Marcello" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsDriver", "LastName" },
                values: new object[] { 27, "Edwardo", true, "Broadwater" });

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "ID", "CarLicensePlate", "EndDate", "EndLocation", "Info", "StartDate", "StartLocation" },
                values: new object[] { 1, "DA000PA", new DateTime(2019, 11, 23, 18, 58, 1, 550, DateTimeKind.Local).AddTicks(6966), "Pula", null, new DateTime(2019, 11, 23, 14, 58, 1, 547, DateTimeKind.Local).AddTicks(2160), "Zagreb" });

            migrationBuilder.InsertData(
                table: "TravelEmployees",
                columns: new[] { "TravelId", "EmployeeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "TravelEmployees",
                columns: new[] { "TravelId", "EmployeeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "TravelEmployees",
                columns: new[] { "TravelId", "EmployeeId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "TravelEmployees",
                columns: new[] { "TravelId", "EmployeeId" },
                values: new object[] { 1, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_TravelEmployees_EmployeeId",
                table: "TravelEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_CarLicensePlate",
                table: "Travels",
                column: "CarLicensePlate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelEmployees");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Travels");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
