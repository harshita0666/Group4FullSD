using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4FullSD.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8508), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8512), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Adopter",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9416), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9420), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "AdoptionApplication",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9423), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9966), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9969), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "AdoptionPreferenceSurvey",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9972), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9519), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9522), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9608), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "PetMedicalRecord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9614), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9763), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "PetTrainingProgram",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9771), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "ShopPetSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8608), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8406), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8984), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8987), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8989), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8990) });
        }
    }
}
