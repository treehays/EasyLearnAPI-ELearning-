﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyLearn.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AcceptedNigerianBanks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    BankName = table.Column<string>(type: "longtext", nullable: false),
                    BankCode = table.Column<string>(type: "longtext", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedNigerianBanks", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CategoryImage = table.Column<string>(type: "longtext", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleName = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    ProfilePicture = table.Column<string>(type: "longtext", nullable: true),
                    Biography = table.Column<string>(type: "longtext", nullable: true),
                    Skill = table.Column<string>(type: "longtext", nullable: true),
                    Interest = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    StudentshipStatus = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmailToken = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Country = table.Column<string>(type: "longtext", nullable: false),
                    State = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    Language = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Moderators",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Biography = table.Column<string>(type: "longtext", nullable: false),
                    Skill = table.Column<string>(type: "longtext", nullable: false),
                    Interest = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moderators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    NotificationType = table.Column<string>(type: "longtext", nullable: false),
                    Subject = table.Column<string>(type: "longtext", nullable: false),
                    Body = table.Column<string>(type: "longtext", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false),
                    Priority = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    BankCode = table.Column<string>(type: "longtext", nullable: false),
                    AccountNumber = table.Column<string>(type: "longtext", nullable: false),
                    AccountName = table.Column<string>(type: "longtext", nullable: false),
                    AccountType = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Biography = table.Column<string>(type: "longtext", nullable: false),
                    Skill = table.Column<string>(type: "longtext", nullable: false),
                    Interest = table.Column<string>(type: "longtext", nullable: false),
                    VerifyBy = table.Column<string>(type: "longtext", nullable: true),
                    VerifyOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ModeratorId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Moderators_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "Moderators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    ShortDescription = table.Column<string>(type: "longtext", nullable: false),
                    CourseLanguage = table.Column<int>(type: "int", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    Requirement = table.Column<string>(type: "longtext", nullable: false),
                    CourseDuration = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumbersOfEnrollment = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CourseLogo = table.Column<string>(type: "longtext", nullable: false),
                    InstructorId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Coupon = table.Column<string>(type: "longtext", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InstructorReviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Rating = table.Column<string>(type: "longtext", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false),
                    Reported = table.Column<string>(type: "longtext", nullable: false),
                    Visibility = table.Column<string>(type: "longtext", nullable: false),
                    InstructorId = table.Column<string>(type: "varchar(255)", nullable: false),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorReviews_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorReviews_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CategoryId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseReviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false),
                    Rating = table.Column<string>(type: "longtext", nullable: false),
                    IsReported = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerifiedPurchase = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVisibile = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseReviews_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseReviews_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Resources = table.Column<string>(type: "longtext", nullable: false),
                    Prerequisites = table.Column<string>(type: "longtext", nullable: false),
                    Objective = table.Column<string>(type: "longtext", nullable: false),
                    ModuleDuration = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    SequenceOfModule = table.Column<int>(type: "int", nullable: false),
                    VideoSequence = table.Column<string>(type: "longtext", nullable: false),
                    TemplateId = table.Column<string>(type: "longtext", nullable: false),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VideoPath = table.Column<string>(type: "longtext", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    ReferrenceNumber = table.Column<string>(type: "longtext", nullable: false),
                    AuthorizationUri = table.Column<string>(type: "longtext", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    IsPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enrolments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    CompletionStatus = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "longtext", nullable: false),
                    CertificateNumber = table.Column<string>(type: "longtext", nullable: false),
                    IsPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessExpiration = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PaymentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrolments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrolments_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrolments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CategoryId",
                table: "CourseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CourseId",
                table: "CourseCategories",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseReviews_CourseId",
                table: "CourseReviews",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseReviews_StudentId",
                table: "CourseReviews",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolments_CourseId",
                table: "Enrolments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolments_PaymentId",
                table: "Enrolments",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolments_StudentId",
                table: "Enrolments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorReviews_InstructorId",
                table: "InstructorReviews",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorReviews_StudentId",
                table: "InstructorReviews",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ModeratorId",
                table: "Instructors",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Moderators_UserId",
                table: "Moderators",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_UserId",
                table: "PaymentDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CourseId",
                table: "Payments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StudentId",
                table: "Payments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptedNigerianBanks");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "CourseReviews");

            migrationBuilder.DropTable(
                name: "Enrolments");

            migrationBuilder.DropTable(
                name: "InstructorReviews");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Moderators");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
