using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4FullSD.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8530), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8534), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8537), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9507), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9511), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9998), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 746, DateTimeKind.Utc).AddTicks(2), new DateTime(2025, 1, 20, 14, 29, 25, 746, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 746, DateTimeKind.Utc).AddTicks(4), new DateTime(2025, 1, 20, 14, 29, 25, 746, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9410), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9416), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9889), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9892), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8835), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8838), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9599), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9604), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9608), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9695), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9699), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9701), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9793), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9798), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9801), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8630), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8633), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8636), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8403), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9203), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9211), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9311), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 1, 20, 14, 29, 25, 745, DateTimeKind.Utc).AddTicks(9317) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
