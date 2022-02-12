using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[] { 1, "System", new DateTime(2022, 2, 12, 19, 57, 53, 885, DateTimeKind.Local).AddTicks(8165), new DateTime(2022, 2, 12, 19, 57, 53, 886, DateTimeKind.Local).AddTicks(7217), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[] { 2, "System", new DateTime(2022, 2, 12, 19, 57, 53, 886, DateTimeKind.Local).AddTicks(8064), new DateTime(2022, 2, 12, 19, 57, 53, 886, DateTimeKind.Local).AddTicks(8068), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
