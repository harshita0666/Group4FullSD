using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group4FullSD.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adopter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adoption_History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Donor_ID = table.Column<int>(type: "int", nullable: false),
                    DonorId = table.Column<int>(type: "int", nullable: true),
                    Donation_Amount = table.Column<double>(type: "float", nullable: false),
                    Donation_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donation_Adopter_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Adopter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Donation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adoption_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Health_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Personality_Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Location_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopPetSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pricing = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPetSupplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopPetSupplies_Location_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Join_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Location_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Assigned_Location_ID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volunteer_Location_Assigned_Location_ID",
                        column: x => x.Assigned_Location_ID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionPreferenceSurvey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adopter_ID = table.Column<int>(type: "int", nullable: false),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Submission_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdopterId = table.Column<int>(type: "int", nullable: true),
                    PetId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionPreferenceSurvey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionPreferenceSurvey_Adopter_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "Adopter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdoptionPreferenceSurvey_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PetMedicalRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    Vaccination_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medical_Conditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Checkup_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medical_History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetMedicalRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetMedicalRecord_Pet_Pet_ID",
                        column: x => x.Pet_ID,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetTrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: true),
                    Program_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Trainer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetTrainingProgram_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adopter_ID = table.Column<int>(type: "int", nullable: false),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    Added_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlist_Adopter_Adopter_ID",
                        column: x => x.Adopter_ID,
                        principalTable: "Adopter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlist_Pet_Pet_ID",
                        column: x => x.Pet_ID,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adopter_ID = table.Column<int>(type: "int", nullable: false),
                    AdopterId = table.Column<int>(type: "int", nullable: true),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: true),
                    Application_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Submission_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approval_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Staff_Reviewed_By = table.Column<int>(type: "int", nullable: false),
                    ReviewedById = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_Adopter_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "Adopter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_Staff_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adopter_ID = table.Column<int>(type: "int", nullable: false),
                    Pet_ID = table.Column<int>(type: "int", nullable: false),
                    Staff_Reviewed_By = table.Column<int>(type: "int", nullable: false),
                    Adoption_Cost = table.Column<double>(type: "float", nullable: false),
                    Adoption_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Submission_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approval_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cost_Adopter_Adopter_ID",
                        column: x => x.Adopter_ID,
                        principalTable: "Adopter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cost_Pet_Pet_ID",
                        column: x => x.Pet_ID,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cost_Staff_Staff_Reviewed_By",
                        column: x => x.Staff_Reviewed_By,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adopter_ID = table.Column<int>(type: "int", nullable: false),
                    Supply_ID = table.Column<int>(type: "int", nullable: false),
                    ShopPetSuppliesId = table.Column<int>(type: "int", nullable: true),
                    Order_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total_Price = table.Column<double>(type: "float", nullable: false),
                    Staff_ID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Adopter_Adopter_ID",
                        column: x => x.Adopter_ID,
                        principalTable: "Adopter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_ShopPetSupplies_ShopPetSuppliesId",
                        column: x => x.ShopPetSuppliesId,
                        principalTable: "ShopPetSupplies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Staff_Staff_ID",
                        column: x => x.Staff_ID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adopter",
                columns: new[] { "Id", "Address", "Adoption_History", "CreatedBy", "DateCreated", "DateUpdated", "Date_Of_Birth", "Email", "Name", "Phone_Number", "Registration_Date", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "123 Maple Street, Springfield", "Adopted 2 pets in the past", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8508), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8509), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John Doe", "1234567890", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, "456 Oak Avenue, Metropolis", "First-time adopter", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8512), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8513), new DateTime(1985, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "janesmith@example.com", "Jane Smith", "9876543210", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, "789 Pine Road, Gotham", "Adopted 1 pet last year", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8516), new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "alicejohnson@example.com", "Alice Johnson", "1122334455", new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "AdoptionApplication",
                columns: new[] { "Id", "AdopterId", "Adopter_ID", "Application_Status", "Approval_Date", "CreatedBy", "DateCreated", "DateUpdated", "PetId", "Pet_ID", "ReviewedById", "Staff_Reviewed_By", "Submission_Date", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, 1, "Approved", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9416), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9417), null, 1, null, 1, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, null, 2, "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9420), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9421), null, 2, null, 2, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, null, 3, "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9423), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9424), null, 3, null, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "AdoptionPreferenceSurvey",
                columns: new[] { "Id", "AdopterId", "Adopter_ID", "Answer", "CreatedBy", "DateCreated", "DateUpdated", "PetId", "Pet_ID", "Question", "Submission_Date", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, 1, "Small-sized, friendly dog suitable for an apartment.", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9966), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9967), null, 1, "What type of pet are you looking for?", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, null, 2, "Prefer a playful and energetic cat.", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9969), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9970), null, 2, "Do you have any preferences for the pet's behavior or training?", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, null, 3, "Medium-sized dog with good health and obedience training.", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9972), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9972), null, 3, "Are there any specific characteristics you prefer?", new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Donation_Amount", "Donation_Date", "DonorId", "Donor_ID", "LocationId", "Location_ID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9859), 100.0, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, 1, "System" },
                    { 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9862), 200.0, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null, 2, "System" },
                    { 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9865), 50.0, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, null, 3, "System" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "Contact_Number", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "123 Main Street, Downtown", "123-456-7890", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8165), "Downtown Animal Shelter", "System" },
                    { 2, "456 Uptown Avenue, Uptown", "987-654-3210", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8171), "Uptown Animal Shelter", "System" },
                    { 3, "789 Suburban Road, Suburbia", "555-555-5555", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8174), "Suburban Animal Shelter", "System" }
                });

            migrationBuilder.InsertData(
                table: "PetTrainingProgram",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "End_Date", "PetId", "Pet_ID", "Program_Name", "Start_Date", "Status", "Trainer_Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9763), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9764), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Basic Obedience Training", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "John Doe", "System" },
                    { 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9768), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Agility Training", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ongoing", "Jane Smith", "System" },
                    { 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9771), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9771), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Socialization Program", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Alice Johnson", "System" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Adoption_Status", "Age", "Breed", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Health_Status", "Location_ID", "Name", "Personality_Traits", "Size", "Species", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Available", 3, "Golden Retriever", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9515), "Male", "Healthy", 1, "Buddy", "Friendly, Playful", "Large", "Dog", "System" },
                    { 2, "Adopted", 2, "Siamese", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9519), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9519), "Female", "Healthy", 2, "Whiskers", "Affectionate, Curious", "Small", "Cat", "System" },
                    { 3, "Pending", 4, "Beagle", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9522), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9523), "Male", "Healthy", 3, "Charlie", "Energetic, Loyal", "Medium", "Dog", "System" }
                });

            migrationBuilder.InsertData(
                table: "ShopPetSupplies",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Location_ID", "Name", "Pricing", "Quantity", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Food", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8603), 1, "Dog Food - Premium", 50.0, 100, "System" },
                    { 2, "Toys", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8606), 2, "Cat Toy - Feather Wand", 15.0, 50, "System" },
                    { 3, "Accessories", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8608), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8609), 3, "Aquarium Filter", 75.0, 25, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Join_Date", "Location_ID", "Name", "Phone_Number", "Role", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8399), "john.doe@example.com", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John Doe", "123-456-7890", "Manager", "System" },
                    { 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8406), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8406), "jane.smith@example.com", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Jane Smith", "987-654-3210", "Veterinarian", "System" },
                    { 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8409), "alice.johnson@example.com", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Alice Johnson", "555-555-5555", "Adoption Coordinator", "System" }
                });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "Id", "Assigned_Location_ID", "Availability", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Phone_Number", "Registration_Date", "Role", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "Weekends", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8893), "emily.brown@example.com", "Emily Brown", "123-456-7890", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helper", "System" },
                    { 2, 2, "Full-time", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8897), "david.wilson@example.com", "David Wilson", "987-654-3210", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinator", "System" },
                    { 3, 3, "Weekdays", "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8900), "sophia.martinez@example.com", "Sophia Martinez", "555-555-5555", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assistant", "System" }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Adopter_ID", "Adoption_Cost", "Adoption_Status", "Approval_Date", "CreatedBy", "DateCreated", "DateUpdated", "Pet_ID", "Staff_Reviewed_By", "Submission_Date", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 150.0, "Paid", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9310), 1, 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, 2, 200.0, "Pending", null, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9313), 2, 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, 3, 120.0, "Rejected", null, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9316), 3, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Adopter_ID", "CreatedBy", "DateCreated", "DateUpdated", "Order_Date", "ShopPetSuppliesId", "Staff_ID", "Supply_ID", "Total_Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 50.0, "System" },
                    { 2, 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8802), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, 75.5, "System" },
                    { 3, 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8805), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, 100.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "PetMedicalRecord",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Last_Checkup_Date", "Medical_Conditions", "Medical_History", "Pet_ID", "UpdatedBy", "Vaccination_Status" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9608), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9609), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", "Routine vaccinations completed, no major issues.", 1, "System", "Up-to-date" },
                    { 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9612), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allergies to certain foods", "Routine checkups show minor food allergies.", 2, "System", "Up-to-date" },
                    { 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9614), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", "All vaccinations completed, healthy overall.", 3, "System", "Up-to-date" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "Id", "Added_Date", "Adopter_ID", "CreatedBy", "DateCreated", "DateUpdated", "Pet_ID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8984), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8985), 1, "System" },
                    { 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8987), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8988), 2, "System" },
                    { 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "System", new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8989), new DateTime(2025, 1, 18, 5, 33, 27, 170, DateTimeKind.Utc).AddTicks(8990), 3, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_AdopterId",
                table: "AdoptionApplication",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_PetId",
                table: "AdoptionApplication",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_ReviewedById",
                table: "AdoptionApplication",
                column: "ReviewedById");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPreferenceSurvey_AdopterId",
                table: "AdoptionPreferenceSurvey",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionPreferenceSurvey_PetId",
                table: "AdoptionPreferenceSurvey",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cost_Adopter_ID",
                table: "Cost",
                column: "Adopter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cost_Pet_ID",
                table: "Cost",
                column: "Pet_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cost_Staff_Reviewed_By",
                table: "Cost",
                column: "Staff_Reviewed_By");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_DonorId",
                table: "Donation",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_LocationId",
                table: "Donation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Adopter_ID",
                table: "Order",
                column: "Adopter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShopPetSuppliesId",
                table: "Order",
                column: "ShopPetSuppliesId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Staff_ID",
                table: "Order",
                column: "Staff_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_Location_ID",
                table: "Pet",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PetMedicalRecord_Pet_ID",
                table: "PetMedicalRecord",
                column: "Pet_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PetTrainingProgram_PetId",
                table: "PetTrainingProgram",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPetSupplies_Location_ID",
                table: "ShopPetSupplies",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Location_ID",
                table: "Staff",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_Assigned_Location_ID",
                table: "Volunteer",
                column: "Assigned_Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_Adopter_ID",
                table: "Wishlist",
                column: "Adopter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_Pet_ID",
                table: "Wishlist",
                column: "Pet_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionApplication");

            migrationBuilder.DropTable(
                name: "AdoptionPreferenceSurvey");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cost");

            migrationBuilder.DropTable(
                name: "Donation");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PetMedicalRecord");

            migrationBuilder.DropTable(
                name: "PetTrainingProgram");

            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ShopPetSupplies");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Adopter");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
