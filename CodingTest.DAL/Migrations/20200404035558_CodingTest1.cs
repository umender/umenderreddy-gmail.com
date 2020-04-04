using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingTest.DAL.Migrations
{
    public partial class CodingTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recruiter",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Operations = table.Column<string>(nullable: true),
                    BusinessUnit = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiter", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "SourcingDefinition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SearchCriteria = table.Column<string>(nullable: true),
                    TargetCompanies = table.Column<string>(nullable: true),
                    OpenPositions = table.Column<int>(nullable: false),
                    OpenFrom = table.Column<DateTime>(nullable: false),
                    CloseBy = table.Column<DateTime>(nullable: false),
                    SourcingStratergy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcingDefinition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CandiateTracker",
                columns: table => new
                {
                    CandidateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandiateName = table.Column<string>(nullable: true),
                    CandiateExpertise = table.Column<string>(nullable: true),
                    SourcingDefinition = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: true),
                    RecruiterEmployeeId = table.Column<int>(nullable: true),
                    Stratergy = table.Column<string>(nullable: true),
                    CurrentStatus = table.Column<string>(nullable: true),
                    ContactedOn = table.Column<DateTime>(nullable: false),
                    InterviewedOn = table.Column<DateTime>(nullable: false),
                    JoiningOrderSenton = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandiateTracker", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_CandiateTracker_Recruiter_RecruiterEmployeeId",
                        column: x => x.RecruiterEmployeeId,
                        principalTable: "Recruiter",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandiateTracker_RecruiterEmployeeId",
                table: "CandiateTracker",
                column: "RecruiterEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandiateTracker");

            migrationBuilder.DropTable(
                name: "SourcingDefinition");

            migrationBuilder.DropTable(
                name: "Recruiter");
        }
    }
}
