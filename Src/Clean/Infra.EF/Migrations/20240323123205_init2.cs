﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.EF.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Citys_CityId",
                table: "Persons");

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
                table: "Persons",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Citys_CityId",
                table: "Persons",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Citys_CityId",
                table: "Persons");

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
                table: "Persons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Citys_CityId",
                table: "Persons",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
