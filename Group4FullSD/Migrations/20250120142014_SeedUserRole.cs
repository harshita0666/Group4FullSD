using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4FullSD.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8765), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8770), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8773), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9557), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9565), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(56), new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(60), new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 1, 20, 14, 20, 13, 313, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9422), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9426), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9429), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9963), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9966), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9969), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8388), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9100), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9104), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9107), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9663), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9672), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9770), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9776), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8997), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9000), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8651), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8655), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9212), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9216), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9319), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9321), new DateTime(2025, 1, 20, 14, 20, 13, 312, DateTimeKind.Utc).AddTicks(9322) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6530), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6534), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6537), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7843), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7849), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7179), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7182), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7185), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6181), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6188), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6870), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6873), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6876), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7371), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7375), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7464), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7467), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7470), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7558), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6772), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6425), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6429), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6432), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6964), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6968), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6971), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7089), new DateTime(2025, 1, 20, 14, 8, 50, 772, DateTimeKind.Utc).AddTicks(7090) });
        }
    }
}
