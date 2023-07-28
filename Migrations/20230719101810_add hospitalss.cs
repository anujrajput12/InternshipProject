using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipProject.Migrations
{
    /// <inheritdoc />
    public partial class addhospitalss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitalss",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentialAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    IpdCheckOutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationCharges = table.Column<int>(type: "int", nullable: true),
                    IpdFileCharges = table.Column<int>(type: "int", nullable: true),
                    AdmissionCancellationCharges = table.Column<int>(type: "int", nullable: true),
                    EmergencyVisitTimingFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmergencyVisitTimingTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tagline1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tagline2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    PhoneNo = table.Column<int>(type: "int", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultationChargeValidityDays = table.Column<int>(type: "int", nullable: true),
                    BillCancellationUpdationTimeLimit = table.Column<TimeSpan>(type: "time", nullable: true),
                    FueLCharge = table.Column<int>(type: "int", nullable: true),
                    AllSeviceDiscount = table.Column<int>(type: "int", nullable: true),
                    OpdTimingFrom = table.Column<TimeSpan>(type: "time", nullable: true),
                    OpdTimingTo = table.Column<TimeSpan>(type: "time", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactNo = table.Column<int>(type: "int", nullable: true),
                    WhatsappNo = table.Column<int>(type: "int", nullable: true),
                    HospitalGmapUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToReachUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalss", x => x.HospitalId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospitalss");
        }
    }
}
