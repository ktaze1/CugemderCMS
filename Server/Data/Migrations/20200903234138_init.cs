using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CugemderPortal.Server.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomClaim",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "group",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jobTitle",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "notifications",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "photoUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "points",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "position",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "referencedBy",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "speciality",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "surName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomClaim",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "company",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "group",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "jobTitle",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "notifications",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "photoUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "points",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "position",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "referencedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "speciality",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "surName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "AspNetUsers");
        }
    }
}
