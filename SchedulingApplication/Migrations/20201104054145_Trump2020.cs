using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulingApplication.Migrations
{
    public partial class Trump2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "ID",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "ID", "Color", "EndTime", "EventType", "Location", "NumOfPeople", "PocPhoneNumber", "PocRankName", "StartTime" },
                values: new object[] { 1, "Purple", new DateTime(2020, 11, 3, 21, 26, 50, 609, DateTimeKind.Local).AddTicks(8445), 0, 53, 95, "972-523-4343", "phil", new DateTime(2020, 11, 3, 21, 26, 50, 608, DateTimeKind.Local).AddTicks(507) });
        }
    }
}
