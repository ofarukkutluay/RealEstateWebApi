using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newstart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<long>(type: "bigint", nullable: false),
                    TaxAdministration = table.Column<string>(type: "text", nullable: false),
                    StartingYear = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeedStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeedStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityKey = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntryTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    Storage = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    OuterPropertyListingId = table.Column<string>(type: "text", nullable: true),
                    SortIndex = table.Column<int>(type: "integer", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyPhoto_SortIndex = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fronts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fronts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeatingTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeatingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternetTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DistrictKey = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Alias = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OuterPropertyListings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DescriptionHtml = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    PropertyCategory = table.Column<string>(type: "text", nullable: true),
                    PropertyStatus = table.Column<string>(type: "text", nullable: true),
                    PropertyType = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: true),
                    PriceCurrency = table.Column<string>(type: "text", nullable: true),
                    GrossSquareMeter = table.Column<int>(type: "integer", nullable: true),
                    UsableSquareMeter = table.Column<int>(type: "integer", nullable: true),
                    LocationLat = table.Column<string>(type: "text", nullable: true),
                    LocationLon = table.Column<string>(type: "text", nullable: true),
                    ListingStoreName = table.Column<string>(type: "text", nullable: true),
                    ListingUserName = table.Column<string>(type: "text", nullable: true),
                    ListingPhoneNumbers = table.Column<string>(type: "text", nullable: true),
                    FromProfile = table.Column<string>(type: "text", nullable: true),
                    ListiningLink = table.Column<string>(type: "text", nullable: true),
                    PhotoLinks = table.Column<string>(type: "text", nullable: true),
                    PhotoPaths = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<double>(type: "double precision", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    BuildingAge = table.Column<string>(type: "text", nullable: true),
                    BuildingTotalFloor = table.Column<string>(type: "text", nullable: true),
                    BuildingFloor = table.Column<string>(type: "text", nullable: true),
                    HeatingType = table.Column<string>(type: "text", nullable: true),
                    BathroomCount = table.Column<int>(type: "integer", nullable: true),
                    IsBalcony = table.Column<bool>(type: "boolean", nullable: true),
                    IsElevator = table.Column<bool>(type: "boolean", nullable: true),
                    Garage = table.Column<string>(type: "text", nullable: true),
                    IsFurnished = table.Column<bool>(type: "boolean", nullable: true),
                    UsingStatus = table.Column<string>(type: "text", nullable: true),
                    Fees = table.Column<double>(type: "double precision", nullable: true),
                    FeesCurrency = table.Column<string>(type: "text", nullable: true),
                    IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: true),
                    DeedStatus = table.Column<string>(type: "text", nullable: true),
                    IsBarter = table.Column<bool>(type: "boolean", nullable: true),
                    IsOnSite = table.Column<bool>(type: "boolean", nullable: true),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    Deposit = table.Column<double>(type: "double precision", nullable: true),
                    DepositCurrency = table.Column<string>(type: "text", nullable: true),
                    SpaceSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    RemainingPaymentAmount = table.Column<double>(type: "double precision", nullable: true),
                    RemainingInstallment = table.Column<int>(type: "integer", nullable: true),
                    ReconstructionStatus = table.Column<string>(type: "text", nullable: true),
                    BlockNo = table.Column<int>(type: "integer", nullable: true),
                    PlotNo = table.Column<int>(type: "integer", nullable: true),
                    LayoutNo = table.Column<int>(type: "integer", nullable: true),
                    FloorAreaRatio = table.Column<double>(type: "double precision", nullable: true),
                    Gabari = table.Column<double>(type: "double precision", nullable: true),
                    ExchangeForBuilding = table.Column<bool>(type: "boolean", nullable: true),
                    OutdoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    IndoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    SectionAndRoomCount = table.Column<double>(type: "double precision", nullable: true),
                    HeatingTypeId = table.Column<long>(type: "bigint", nullable: true),
                    UsingStatusId = table.Column<long>(type: "bigint", nullable: true),
                    DeedStatusId = table.Column<long>(type: "bigint", nullable: true),
                    BuildingStatus = table.Column<string>(type: "text", nullable: true),
                    PumpCount = table.Column<int>(type: "integer", nullable: true),
                    DailySaleFuelLiter = table.Column<int>(type: "integer", nullable: true),
                    EntryHeightMeters = table.Column<int>(type: "integer", nullable: true),
                    ElevatorCount = table.Column<int>(type: "integer", nullable: true),
                    BuildingType = table.Column<string>(type: "text", nullable: true),
                    AlcoholLicense = table.Column<bool>(type: "boolean", nullable: true),
                    GroundSurvey = table.Column<string>(type: "text", nullable: true),
                    TableCapacity = table.Column<int>(type: "integer", nullable: true),
                    PeopleCapacity = table.Column<int>(type: "integer", nullable: true),
                    BuildingCount = table.Column<int>(type: "integer", nullable: true),
                    MiningLicense = table.Column<bool>(type: "boolean", nullable: true),
                    VehicleCapacity = table.Column<int>(type: "integer", nullable: true),
                    CeilingHeightMeters = table.Column<int>(type: "integer", nullable: true),
                    StarCount = table.Column<int>(type: "integer", nullable: true),
                    BedCount = table.Column<int>(type: "integer", nullable: true),
                    ApartCount = table.Column<int>(type: "integer", nullable: true),
                    TotalLandAcres = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuterPropertyListings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NeighborhoodKey = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    RefreshTokenExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsingStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntrySubTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntryTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrySubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntrySubTypes_EntryTypes_EntryTypeId",
                        column: x => x.EntryTypeId,
                        principalTable: "EntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    FacebookUrl = table.Column<string>(type: "text", nullable: true),
                    InstagramUrl = table.Column<string>(type: "text", nullable: true),
                    TwitterUrl = table.Column<string>(type: "text", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "text", nullable: true),
                    ContactNumber = table.Column<string>(type: "text", nullable: false),
                    ContactEmail = table.Column<string>(type: "text", nullable: false),
                    ContactAddress = table.Column<string>(type: "text", nullable: false),
                    About = table.Column<string>(type: "text", nullable: true),
                    SummaryInfo = table.Column<string>(type: "text", nullable: true),
                    ViewName = table.Column<string>(type: "text", nullable: false),
                    Dns = table.Column<string>(type: "text", nullable: false),
                    LogoImgFileId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Files_LogoImgFileId",
                        column: x => x.LogoImgFileId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CitizenNumber = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PassHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PassSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    ProfileImgFileId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Files_ProfileImgFileId",
                        column: x => x.ProfileImgFileId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    MobileNumber2 = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    StatusKey = table.Column<string>(type: "text", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CitizenNumber = table.Column<long>(type: "bigint", nullable: true),
                    RegisterUserId = table.Column<long>(type: "bigint", nullable: false),
                    AssignedUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PropertyCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyStatuses_PropertyCategories_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTypes_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    SenderName = table.Column<string>(type: "text", nullable: false),
                    SenderEmail = table.Column<string>(type: "text", nullable: true),
                    SenderMobile = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    JobTitleId = table.Column<long>(type: "bigint", nullable: false),
                    ViewMobileNumber = table.Column<string>(type: "text", nullable: true),
                    ViewPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    FacebookUrl = table.Column<string>(type: "text", nullable: true),
                    InstagramUrl = table.Column<string>(type: "text", nullable: true),
                    TwitterUrl = table.Column<string>(type: "text", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "text", nullable: true),
                    YoutubeProfileUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agents_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agents_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agents_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    OperationClaimId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSearchProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSearchProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSearchProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    EntryTypeId = table.Column<long>(type: "bigint", nullable: false),
                    EntrySubTypeId = table.Column<long>(type: "bigint", nullable: false),
                    EntrySubTitle = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entries_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                        column: x => x.EntrySubTypeId,
                        principalTable: "EntrySubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entries_EntryTypes_EntryTypeId",
                        column: x => x.EntryTypeId,
                        principalTable: "EntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyTypes_PropertyStatuses_PropertyStatusId",
                        column: x => x.PropertyStatusId,
                        principalTable: "PropertyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    BlogPageImgFileId = table.Column<long>(type: "bigint", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
                    BlogTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_BlogTypes_BlogTypeId",
                        column: x => x.BlogTypeId,
                        principalTable: "BlogTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Files_BlogPageImgFileId",
                        column: x => x.BlogPageImgFileId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReminderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntryId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminder_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reminder_Entries_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reminder_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: false),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    PriceCurrency = table.Column<string>(type: "text", nullable: false),
                    GrossSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    UsableSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    ClientId = table.Column<long>(type: "bigint", nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    LocationLat = table.Column<double>(type: "double precision", nullable: false),
                    LocationLon = table.Column<double>(type: "double precision", nullable: false),
                    YoutubeLink = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    OutdoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    IndoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    SectionAndRoomCount = table.Column<double>(type: "double precision", nullable: true),
                    BathroomCount = table.Column<int>(type: "integer", nullable: true),
                    BuildingTotalFloor = table.Column<int>(type: "integer", nullable: true),
                    BuildingFloor = table.Column<int>(type: "integer", nullable: true),
                    Fees = table.Column<double>(type: "double precision", nullable: true),
                    FeesCurrency = table.Column<string>(type: "text", nullable: true),
                    BuildingAge = table.Column<int>(type: "integer", nullable: true),
                    HeatingTypeId = table.Column<long>(type: "bigint", nullable: true),
                    UsingStatusId = table.Column<long>(type: "bigint", nullable: true),
                    DeedStatusId = table.Column<long>(type: "bigint", nullable: true),
                    BuildingStatus = table.Column<string>(type: "text", nullable: true),
                    IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: true),
                    IsBarter = table.Column<bool>(type: "boolean", nullable: true),
                    PumpCount = table.Column<int>(type: "integer", nullable: true),
                    DailySaleFuelLiter = table.Column<int>(type: "integer", nullable: true),
                    EntryHeightMeters = table.Column<int>(type: "integer", nullable: true),
                    ElevatorCount = table.Column<int>(type: "integer", nullable: true),
                    BuildingType = table.Column<string>(type: "text", nullable: true),
                    AlcoholLicense = table.Column<bool>(type: "boolean", nullable: true),
                    GroundSurvey = table.Column<string>(type: "text", nullable: true),
                    TableCapacity = table.Column<int>(type: "integer", nullable: true),
                    PeopleCapacity = table.Column<int>(type: "integer", nullable: true),
                    BuildingCount = table.Column<int>(type: "integer", nullable: true),
                    MiningLicense = table.Column<bool>(type: "boolean", nullable: true),
                    VehicleCapacity = table.Column<int>(type: "integer", nullable: true),
                    CeilingHeightMeters = table.Column<int>(type: "integer", nullable: true),
                    Commercial_Deposit = table.Column<double>(type: "double precision", nullable: true),
                    Commercial_DepositCurrency = table.Column<string>(type: "text", nullable: true),
                    ReconstructionStatus = table.Column<string>(type: "text", nullable: true),
                    BlockNo = table.Column<int>(type: "integer", nullable: true),
                    PlotNo = table.Column<int>(type: "integer", nullable: true),
                    LayoutNo = table.Column<int>(type: "integer", nullable: true),
                    FloorAreaRatio = table.Column<double>(type: "double precision", nullable: true),
                    Gabari = table.Column<double>(type: "double precision", nullable: true),
                    ExchangeForBuilding = table.Column<bool>(type: "boolean", nullable: true),
                    Deposit = table.Column<double>(type: "double precision", nullable: true),
                    DepositCurrency = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<double>(type: "double precision", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    Residential_BuildingAge = table.Column<int>(type: "integer", nullable: true),
                    Residential_BuildingTotalFloor = table.Column<int>(type: "integer", nullable: true),
                    Residential_BuildingFloor = table.Column<int>(type: "integer", nullable: true),
                    Residential_HeatingTypeId = table.Column<long>(type: "bigint", nullable: true),
                    BathRoomCount = table.Column<int>(type: "integer", nullable: true),
                    IsBalcony = table.Column<bool>(type: "boolean", nullable: true),
                    IsElevator = table.Column<bool>(type: "boolean", nullable: true),
                    GarageCount = table.Column<int>(type: "integer", nullable: true),
                    IsFurnished = table.Column<bool>(type: "boolean", nullable: true),
                    Residential_UsingStatusId = table.Column<long>(type: "bigint", nullable: true),
                    Residential_Fees = table.Column<double>(type: "double precision", nullable: true),
                    Residential_FeesCurrency = table.Column<string>(type: "text", nullable: true),
                    Residential_IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: true),
                    Residential_DeedStatusId = table.Column<long>(type: "bigint", nullable: true),
                    Residential_IsBarter = table.Column<bool>(type: "boolean", nullable: true),
                    IsOnSite = table.Column<bool>(type: "boolean", nullable: true),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    Residential_Deposit = table.Column<double>(type: "double precision", nullable: true),
                    Residential_DepositCurrency = table.Column<string>(type: "text", nullable: true),
                    SpaceSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    RemainingPaymentAmount = table.Column<double>(type: "double precision", nullable: true),
                    RemainingInstallment = table.Column<int>(type: "integer", nullable: true),
                    StarCount = table.Column<int>(type: "integer", nullable: true),
                    Tourism_RoomCount = table.Column<int>(type: "integer", nullable: true),
                    BedCount = table.Column<int>(type: "integer", nullable: true),
                    Tourism_BuildingTotalFloor = table.Column<int>(type: "integer", nullable: true),
                    Tourism_BuildingAge = table.Column<int>(type: "integer", nullable: true),
                    Tourism_IndoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    Tourism_OutdoorSquareMeters = table.Column<int>(type: "integer", nullable: true),
                    Tourism_GroundSurvey = table.Column<string>(type: "text", nullable: true),
                    Tourism_IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: true),
                    Tourism_BuildingStatus = table.Column<string>(type: "text", nullable: true),
                    ApartCount = table.Column<int>(type: "integer", nullable: true),
                    TotalLandAcres = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyCategories_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyStatuses_PropertyStatusId",
                        column: x => x.PropertyStatusId,
                        principalTable: "PropertyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerOwnedProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    OuterPropertyListingId = table.Column<string>(type: "text", nullable: true),
                    PropertyCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: true),
                    RoomCount = table.Column<double>(type: "double precision", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ShLink = table.Column<string>(type: "text", nullable: true),
                    EjLink = table.Column<string>(type: "text", nullable: true),
                    HeLink = table.Column<string>(type: "text", nullable: true),
                    OtherLink = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOwnedProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedProperties_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "DeedStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kat Mülkiyetli", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kat İrtifaklı", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Arsa", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Tarla", null }
                });

            migrationBuilder.InsertData(
                table: "EntryTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "GRSM", "Görüşme", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "PTNSYL", "Potansiyel", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "ILAN", "İlan", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "TKLF", "Teklif", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "SZLSM", "Sözleşme", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "ULSLMD", "Ulaşılamadı", null }
                });

            migrationBuilder.InsertData(
                table: "Fronts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Kuzey", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kuzey Doğu", null },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Doğu", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Güney Doğu", null },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Güney", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Güney Batı", null },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Batı", null },
                    { 8L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kuzey Batı", null }
                });

            migrationBuilder.InsertData(
                table: "HeatingTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Doğalgaz Sobalı", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Sobalı", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Yerden Isıtma", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kombili", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Merkezi Sistem", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "FuelOil", null }
                });

            migrationBuilder.InsertData(
                table: "InternetTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Adsl/Vdsl", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Fiber", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Uydu", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Altyapı Yok", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Alias", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "ADMIN", new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Admin account", true, false, "Admin", null },
                    { 2L, "USER", new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), "User account", true, false, "User", null },
                    { 3L, "AGENT", new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Agent account", true, false, "Agent", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategories",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Konut", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "İşyeri", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Arsa", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Bina", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Turistik Tesis", null }
                });

            migrationBuilder.InsertData(
                table: "UsingStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Boş", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Mülk Sahibi", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "Kiracılı", null }
                });

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 1L, true, false, "TLFN", "Telefon", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 1L, true, false, "ZYRT", "Ziyaret", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, "TAKIP", "Takip", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, "GRSM", "Görüşme", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, "DOWN", "İstemiyor", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 3L, true, false, "GIRME", "Girmeden Çalış", null },
                    { 7L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 3L, true, false, "YETKI", "Yetkili", null },
                    { 8L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 3L, true, false, "YETKISIZ", "Yetkisiz", null },
                    { 9L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 3L, true, false, "PDOWN", "Vazgeçti", null },
                    { 10L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 4L, true, false, "GLN", "Gelen", null },
                    { 11L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 4L, true, false, "TAKIP", "Takip", null },
                    { 12L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 4L, true, false, "IDOWN", "Kabul Etmedi", null },
                    { 13L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 5L, true, false, "STLDI", "Satıldı", null },
                    { 14L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 5L, true, false, "KRLND", "Kiralandı", null },
                    { 15L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 6L, true, false, "ULSLMD", "Ulaşılamadı", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PropertyCategoryId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Satılık", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Kiralık", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Günlük Kiralık", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Devren Satılık Konut", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Satılık", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Kiralık", null },
                    { 7L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Devren Satılık", null },
                    { 8L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Devren Kiralık", null },
                    { 9L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Satılık", null },
                    { 10L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Kiralık", null },
                    { 11L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 4L, "Satılık", null },
                    { 12L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 4L, "Kiralık", null },
                    { 13L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Satılık", null },
                    { 14L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Kiralık", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PropertyStatusId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Daire", null },
                    { 2L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Residence", null },
                    { 3L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Müstakil Ev", null },
                    { 4L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Villa", null },
                    { 5L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Çiftlik Evi", null },
                    { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Köşk & Konak", null },
                    { 7L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Yalı", null },
                    { 8L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Yalı Dairesi", null },
                    { 9L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Yazlık", null },
                    { 10L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Prefabrik Ev", null },
                    { 11L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 1L, "Kooperatif", null },
                    { 12L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Daire", null },
                    { 13L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Residence", null },
                    { 14L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Müstakil Ev", null },
                    { 15L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Villa", null },
                    { 16L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Çiftlik Evi", null },
                    { 17L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Köşk & Konak", null },
                    { 18L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Yalı", null },
                    { 19L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 2L, "Yalı Dairesi", null },
                    { 20L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Daire", null },
                    { 21L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Residence", null },
                    { 22L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Müstakil Ev", null },
                    { 23L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Villa", null },
                    { 24L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Çiftlik Evi", null },
                    { 25L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Köşk & Konak", null },
                    { 26L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Yalı", null },
                    { 27L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 3L, "Yalı Dairesi", null },
                    { 28L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 4L, "Daire", null },
                    { 29L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 4L, "Villa", null },
                    { 30L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Akaryakıt İstasyonu", null },
                    { 31L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Apartman Dairesi", null },
                    { 32L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Atölye ", null },
                    { 33L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "AVM", null },
                    { 34L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Büfe", null },
                    { 35L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Büro & Ofis", null },
                    { 36L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Cafe & Bar", null },
                    { 37L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Çiftlik", null },
                    { 38L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Depo & Antrepo", null },
                    { 39L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Düğün Salonu", null },
                    { 40L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Dükkan & Mağaza", null },
                    { 41L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Enerji Santralleri", null },
                    { 42L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Fabrika", null },
                    { 43L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Garaj & Park Yeri", null },
                    { 44L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "İmalathane ", null },
                    { 45L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "İş Hanı Katı & Ofisi", null },
                    { 46L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Kantin", null },
                    { 47L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Kır & Kahvaltı Bahçesi", null },
                    { 48L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Kıraathane", null },
                    { 49L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Komple Bina", null },
                    { 50L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Maden Ocağı", null },
                    { 51L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Otopark", null },
                    { 52L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Pastane & Fırın", null },
                    { 53L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Pazar Yeri", null },
                    { 54L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Plaza", null },
                    { 55L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Plaza Katı", null },
                    { 56L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Prefabrik Yapı", null },
                    { 57L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Radyo İstasyonu", null },
                    { 58L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Residence Katı & Ofisi", null },
                    { 59L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Restoran & Lokanta", null },
                    { 60L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Sağlık Merkezi", null },
                    { 61L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Sinema & Konferans Salonu", null },
                    { 62L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "SPA, Hamam & Sauna", null },
                    { 63L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Spor Tesisi ", null },
                    { 64L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Villa", null },
                    { 65L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 5L, "Yurt", null },
                    { 66L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Akaryakıt İstasyonu", null },
                    { 67L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Apartman Dairesi", null },
                    { 68L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Atölye", null },
                    { 69L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "AVM", null },
                    { 70L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Büfe", null },
                    { 71L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Büro & Ofis", null },
                    { 72L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Cafe & Bar", null },
                    { 73L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Çiftlik", null },
                    { 74L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Depo & Antrepo", null },
                    { 75L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Düğün Salonu", null },
                    { 76L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Dükkan & Mağaza", null },
                    { 77L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Eczane & Medikal", null },
                    { 78L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Fabrika", null },
                    { 79L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Fotoğraf Stüdyosu", null },
                    { 80L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Garaj", null },
                    { 81L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Hazır & Sanal Ofis", null },
                    { 82L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "İmalathane", null },
                    { 83L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "İş Hanı Katı & Ofisi", null },
                    { 84L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Kantin", null },
                    { 85L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Kır & Kahvaltı Bahçesi ", null },
                    { 86L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Kıraathane", null },
                    { 87L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Komple Bina", null },
                    { 88L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Kuaför & Güzellik Merkezi", null },
                    { 89L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Maden Ocağı", null },
                    { 90L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Market", null },
                    { 91L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Muayenehane", null },
                    { 92L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Okul & Kurs", null },
                    { 93L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Otopark", null },
                    { 94L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Oto Yıkama & Kuaför", null },
                    { 95L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Pastane & Fırın", null },
                    { 96L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Pazar Yeri", null },
                    { 97L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Plaza", null },
                    { 98L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Plaza Katı & Ofisi", null },
                    { 99L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Prova & Kayıt Stüdyosu", null },
                    { 100L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Radyo İstasyonu & TV Kanalı", null },
                    { 101L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Residence Katı & Ofisi", null },
                    { 102L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Restoran & Lokanta", null },
                    { 103L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Sağlık Merkezi", null },
                    { 104L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Sinema & Konferans Salonu", null },
                    { 105L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Spa, Hamam & Sauna", null },
                    { 106L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Spor Tesisi", null },
                    { 107L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Taksi Durağı", null },
                    { 108L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Tamirhane", null },
                    { 109L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Villa", null },
                    { 110L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 6L, "Yurt", null },
                    { 111L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Acente", null },
                    { 112L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Akaryakıt İstasyonu", null },
                    { 113L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Aktar & Baharatçı", null },
                    { 114L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Anaokulu & Kreş", null },
                    { 115L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Apartman Dairesi", null },
                    { 116L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Araç Showroom & Servis", null },
                    { 117L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Atölye", null },
                    { 118L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "AVM Standı", null },
                    { 119L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Balıkçı", null },
                    { 120L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Bar", null },
                    { 121L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Bijuteri", null },
                    { 122L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Börekçi", null },
                    { 123L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Büfe", null },
                    { 124L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Büro & Ofis", null },
                    { 125L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Cafe", null },
                    { 126L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "CD & DVD Dükkanı", null },
                    { 127L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Cep Telefonu Dükkanı", null },
                    { 128L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Çamaşırhane", null },
                    { 129L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Çay Ocağı", null },
                    { 130L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Çiçekçi & Fidanlık", null },
                    { 131L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Çiftlik", null },
                    { 132L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Depo & Antrepo", null },
                    { 133L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Düğün Salonu", null },
                    { 134L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Dükkan & Mağaza", null },
                    { 135L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Eczane & Medikal", null },
                    { 136L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Elektrikçi & Hırdavatçı", null },
                    { 137L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Elektronik Mağazası", null },
                    { 138L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Etkinlik & Performans Salonu", null },
                    { 139L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Fabrika & Üretim Tesisi", null },
                    { 140L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Fatura Merkezi", null },
                    { 141L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Fotoğraf Stüdyosu", null },
                    { 142L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Gece Kulübü & Disko", null },
                    { 143L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Giyim Mağazası", null },
                    { 144L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Gözlükçü", null },
                    { 145L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Halı Yıkama", null },
                    { 146L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Huzur Evi", null },
                    { 147L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "İmalathane", null },
                    { 148L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "İnternet & Oyun Cafe", null },
                    { 149L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "İş Hanı", null },
                    { 150L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "İş Hanı Katı & Ofisi", null },
                    { 151L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kantin", null },
                    { 152L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kasap", null },
                    { 153L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kır & Kahvaltı Bahçesi ", null },
                    { 154L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kıraathane", null },
                    { 155L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kırtasiye", null },
                    { 156L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kozmetik Mağazası", null },
                    { 157L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kuaför & Güzellik Merkezi", null },
                    { 158L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kurs & Eğitim Merkezi", null },
                    { 159L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kuru Temizleme", null },
                    { 160L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kuruyemişçi", null },
                    { 161L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Kuyumcu", null },
                    { 162L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Lunapark", null },
                    { 163L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Maden Ocağı", null },
                    { 164L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Manav", null },
                    { 165L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Market", null },
                    { 166L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Matbaa", null },
                    { 167L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Modaevi", null },
                    { 168L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Muayenehane", null },
                    { 169L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Nakliyat & Kargo", null },
                    { 170L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Nalbur", null },
                    { 171L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Okul", null },
                    { 172L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Otopark / Garaj", null },
                    { 173L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Oto Servis & Bakım", null },
                    { 174L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Oto Yedek Parça", null },
                    { 175L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Oto Yıkama & Kuaför", null },
                    { 176L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Öğrenci Yurdu", null },
                    { 177L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Pastane & Fırın & Tatlıcı", null },
                    { 178L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Pazar Yeri", null },
                    { 179L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Pet Shop", null },
                    { 180L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Plaza", null },
                    { 181L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Plaza Katı & Ofisi", null },
                    { 182L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Prova & Kayıt Stüdyosu", null },
                    { 183L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Radyo İstasyonu & TV Kanalı", null },
                    { 184L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Residence Katı & Ofisi", null },
                    { 185L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Restoran & Lokanta", null },
                    { 186L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Saat Mağazası", null },
                    { 187L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Sağlık Merkezi", null },
                    { 188L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Sebze & Meyve Hali", null },
                    { 189L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Sinema & Konferans Salonu", null },
                    { 190L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Soğuk Hava Deposu", null },
                    { 191L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "SPA, Hamam & Sauna", null },
                    { 192L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Spor Tesisi", null },
                    { 193L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Su & Tüp Bayi", null },
                    { 194L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Şans Oyunları Bayisi", null },
                    { 195L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Şarküteri", null },
                    { 196L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Taksi Durağı", null },
                    { 197L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Tamirhane", null },
                    { 198L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Tekel Bayi", null },
                    { 199L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Teknik Servis", null },
                    { 200L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Terzi", null },
                    { 201L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Tuhafiye", null },
                    { 202L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Veteriner", null },
                    { 203L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 7L, "Züccaciye", null },
                    { 204L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Acente", null },
                    { 205L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Akaryakıt İstasyonu", null },
                    { 206L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Aktar & Baharatçı", null },
                    { 207L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Anaokulu & Kreş", null },
                    { 208L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Apartman Dairesi", null },
                    { 209L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Araç Showroom & Servis", null },
                    { 210L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Atölye", null },
                    { 211L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "AVM Standı", null },
                    { 212L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Balıkçı", null },
                    { 213L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Bar", null },
                    { 214L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Bijuteri", null },
                    { 215L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Börekçi", null },
                    { 216L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Büfe", null },
                    { 217L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Büro & Ofis", null },
                    { 218L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Cafe", null },
                    { 219L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "CD & DVD Dükkanı", null },
                    { 220L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Cep Telefonu Dükkanı", null },
                    { 221L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Çamaşırhane", null },
                    { 222L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Çay Ocağı", null },
                    { 223L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Çiçekçi & Fidanlık", null },
                    { 224L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Çiftlik", null },
                    { 225L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Depo & Antrepo", null },
                    { 226L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Düğün Salonu", null },
                    { 227L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Dükkan & Mağaza", null },
                    { 228L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Eczane", null },
                    { 229L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Elektrikçi & Hırdavatçı", null },
                    { 230L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Elektronik", null },
                    { 231L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Fabrika", null },
                    { 232L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Fatura Merkezi", null },
                    { 233L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Fotoğraf Stüdyosu", null },
                    { 234L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Gece Kulübü & Disko", null },
                    { 235L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Giyim Mağazası", null },
                    { 236L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Gözlükçü", null },
                    { 237L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Halı Yıkama", null },
                    { 238L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Huzur Evi", null },
                    { 239L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "İmalathane", null },
                    { 240L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "İnternet & Oyun Cafe", null },
                    { 241L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "İş Hanı", null },
                    { 242L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "İş Hanı Katı & Ofisi", null },
                    { 243L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kasap", null },
                    { 244L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kır & Kahvaltı Bahçesi ", null },
                    { 245L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kıraathane", null },
                    { 246L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kırtasiye", null },
                    { 247L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kozmetik Mağazası", null },
                    { 248L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kuaför & Güzellik Merkezi", null },
                    { 249L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kurs & Eğitim Merkezi", null },
                    { 250L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kuru Temizleme", null },
                    { 251L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kuruyemişçi", null },
                    { 252L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Kuyumcu", null },
                    { 253L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Lunapark", null },
                    { 254L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Maden Ocağı", null },
                    { 255L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Manav", null },
                    { 256L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Market", null },
                    { 257L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Matbaa", null },
                    { 258L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Medikal Market", null },
                    { 259L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Modaevi", null },
                    { 260L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Muayenehane", null },
                    { 261L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Nakliyat & Kargo", null },
                    { 262L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Nalbur", null },
                    { 263L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Okul", null },
                    { 264L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Otopark / Garaj", null },
                    { 265L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Oto Servis & Bakım", null },
                    { 266L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Oto Yedek Parça", null },
                    { 267L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Oto Yıkama & Kuaför", null },
                    { 268L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Öğrenci Yurdu", null },
                    { 269L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Pastane & Fırın", null },
                    { 270L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Pazar Yeri", null },
                    { 271L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Pet Shop", null },
                    { 272L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Plaza", null },
                    { 273L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Plaza Katı & Ofisi", null },
                    { 274L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Prova & Kayıt Stüdyosu", null },
                    { 275L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Radyo İstasyonu & TV Kanalı", null },
                    { 276L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Residence Katı & Ofisi", null },
                    { 277L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Restoran & Lokanta", null },
                    { 278L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Saat Mağazası", null },
                    { 279L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Sağlık Merkezi", null },
                    { 280L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Sebze & Meyve Hali", null },
                    { 281L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Sinema & Konferans Salonu", null },
                    { 282L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Soğuk Hava Deposu", null },
                    { 283L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "SPA, Hamam & Sauna", null },
                    { 284L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Spor Tesisi", null },
                    { 285L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Su & Tüp Bayi", null },
                    { 286L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Şans Oyunları Bayisi", null },
                    { 287L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Şarküteri", null },
                    { 288L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Taksi Durağı", null },
                    { 289L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Tamirhane", null },
                    { 290L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Tekel Bayi", null },
                    { 291L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Teknik Servis", null },
                    { 292L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Terzi", null },
                    { 293L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Tuhafiye", null },
                    { 294L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Tuvalet", null },
                    { 295L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Veteriner", null },
                    { 296L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 8L, "Züccaciye", null },
                    { 297L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Otel", null },
                    { 298L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Apart Otel", null },
                    { 299L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Butik Otel", null },
                    { 300L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Motel", null },
                    { 301L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Pansiyon", null },
                    { 302L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Kamp Yeri (Mocamp)", null },
                    { 303L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 13L, "Tatil Köyü", null },
                    { 304L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Otel", null },
                    { 305L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Apart Otel", null },
                    { 306L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Butik Otel", null },
                    { 307L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Motel", null },
                    { 308L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Pansiyon", null },
                    { 309L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Kamp Yeri (Mocamp)", null },
                    { 310L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Tatil Köyü", null },
                    { 311L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, 14L, "Plaj", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_CompanyId",
                table: "Agents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_JobTitleId",
                table: "Agents",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AgentId",
                table: "Blogs",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogPageImgFileId",
                table: "Blogs",
                column: "BlogPageImgFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogTypeId",
                table: "Blogs",
                column: "BlogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_ClientId",
                table: "Blogs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CompanyId",
                table: "Blogs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTypes_ClientId",
                table: "BlogTypes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CompanyId",
                table: "Clients",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_LogoImgFileId",
                table: "Clients",
                column: "LogoImgFileId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedProperties_CustomerId",
                table: "CustomerOwnedProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedProperties_PropertyId",
                table: "CustomerOwnedProperties",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DistrictId",
                table: "Customers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_NeighborhoodId",
                table: "Customers",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchProperties_CustomerId",
                table: "CustomerSearchProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_CustomerId",
                table: "Entries",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_EntrySubTypeId",
                table: "Entries",
                column: "EntrySubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_EntryTypeId",
                table: "Entries",
                column: "EntryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_UserId",
                table: "Entries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EntrySubTypes_EntryTypeId",
                table: "EntrySubTypes",
                column: "EntryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_CompanyId",
                table: "JobTitles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ClientId",
                table: "Messages",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CompanyId",
                table: "Messages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentId",
                table: "Properties",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CityId",
                table: "Properties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ClientId",
                table: "Properties",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CompanyId",
                table: "Properties",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_DistrictId",
                table: "Properties",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_NeighborhoodId",
                table: "Properties",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyCategoryId",
                table: "Properties",
                column: "PropertyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyStatusId",
                table: "Properties",
                column: "PropertyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_StreetId",
                table: "Properties",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_PropertyCategoryId",
                table: "PropertyStatuses",
                column: "PropertyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_PropertyStatusId",
                table: "PropertyTypes",
                column: "PropertyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_CustomerId",
                table: "Reminder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_EntryId",
                table: "Reminder",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_UserId",
                table: "Reminder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfileImgFileId",
                table: "Users",
                column: "ProfileImgFileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "CustomerOwnedProperties");

            migrationBuilder.DropTable(
                name: "CustomerSearchProperties");

            migrationBuilder.DropTable(
                name: "DeedStatuses");

            migrationBuilder.DropTable(
                name: "Fronts");

            migrationBuilder.DropTable(
                name: "HeatingTypes");

            migrationBuilder.DropTable(
                name: "InternetTypes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OuterPropertyListings");

            migrationBuilder.DropTable(
                name: "Reminder");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "UsingStatuses");

            migrationBuilder.DropTable(
                name: "BlogTypes");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "EntrySubTypes");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PropertyStatuses");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "EntryTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "PropertyCategories");
        }
    }
}
