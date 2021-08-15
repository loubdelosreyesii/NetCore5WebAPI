using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore5WebAPI.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "EmailAddress", "Name" },
                values: new object[] { 1, "kandental@gmail.com", "Kan Dental Clinic" });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "EmailAddress", "Name" },
                values: new object[] { 2, "totdental@gmail.com", "Tot Dental Clinic" });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "EmailAddress", "Name" },
                values: new object[] { 3, "3timesdental@gmail.com", "3Times Dental Clinic" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ClinicId", "FirstName", "LastName", "MiddleName", "Rating" },
                values: new object[] { 1, 1, "Lou II", "de los Reyes", "Bohol", 5.0 });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ClinicId", "FirstName", "LastName", "MiddleName", "Rating" },
                values: new object[] { 3, 2, "Jackou", "Perez", "Lim", 3.5 });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ClinicId", "FirstName", "LastName", "MiddleName", "Rating" },
                values: new object[] { 2, 3, "Louie", "Cruz", "Santos", 4.2999999999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
