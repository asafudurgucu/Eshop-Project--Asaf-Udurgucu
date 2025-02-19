using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eshop_Data.Migrations
{
    /// <inheritdoc />
    public partial class Finils1111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f9e60e-8699-49cd-9fbc-081429d040fc", new DateTime(2025, 2, 19, 8, 20, 12, 676, DateTimeKind.Local).AddTicks(9945), "AQAAAAIAAYagAAAAEMWw6yk/u190U2COOoV5dhJSUPbHzA75N0sEuYYNfjUm+SiLTW49MxGKf4aEwHPL1A==", "c918fee9-6799-470e-8560-8772f80f7f41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11feac47-7da3-474e-a0d5-023708fdc177", new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(9140), "AQAAAAIAAYagAAAAEFW0EluYZ6aYsN7AJSYcSF3hI2dNRyo7W9VBc5JKdqF8IffIn4GwuU1ATGdKMCOgCA==", "989fe26a-c265-4ed6-89ea-0f9bc7436cc7" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 720, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 720, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 720, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 720, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 720, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 1 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 6 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 9 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 11 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 14 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 15 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 16 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 17 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 19 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 20 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 22 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 24 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 25 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 26 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 27 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 28 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 31 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 32 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 33 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 34 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 35 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 36 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 37 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 38 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 39 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 40 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 41 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 42 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 43 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 44 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 45 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 46 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 47 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 48 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 49 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 50 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AboutBannerPath", "AboutPhotoPath", "AboutText", "AboutTextTitle", "Banner1Path", "Banner2Path", "Banner3Path", "ContactBannerPath", "FooterLogoPath", "LogoPath", "SliderText" },
                values: new object[] { "images/0f28bbb8-1897-43b0-aef1-0598efcfccc4.png", "images/f3651d17-2c1e-4fe8-8bc6-9a4922a29043.png", "Biz, geniş ürün yelpazesi sunan lider bir e-ticaret şirketiyiz.", "Hakkımızda", "images/e809f6cf-8fd0-4217-bbd9-60b52dd0620c.png", "images/deb0b266-1e12-49d2-97ff-fd19c2ebb8b8.png", "images/232d72b1-c24c-41f0-bc0f-c396e0a16347.png", "images/eefaa8e9-e2b7-4cb8-85e1-345994ef9420.png", "images/9a0ca075-205b-439e-ac0e-6a607b52a09b.png", "images/18e44284-f31f-497b-81a1-62da2a31fea9.png", "E-ticaret sitemize hoş geldiniz! Sizin için en iyi ürünleri burada bulabilirsiniz." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc517fc2-95a7-4c3a-a9c5-a9c80786a874", new DateTime(2025, 2, 19, 8, 15, 8, 649, DateTimeKind.Local).AddTicks(9236), "AQAAAAIAAYagAAAAEHamxIwoLC+S9lu+kblHjpI2CqAQV/gycei1yj9WuMzP03pKj+Qg1R1LbsENJV4tnQ==", "d5cfe718-e95f-4d5a-afb6-2b4f31d4bf84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15e2eeac-1ce1-4247-a46b-adb93b112422", new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4606), "AQAAAAIAAYagAAAAEF7k3zW0JGMFjg+1OZ8AvNX5+NHUn2dcSYl/o4+FtCPh5EsBQbGB/9JnytM6mYVzfw==", "747b0138-1696-41c6-a87f-7f1e710cac92" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 690, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 690, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 690, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 690, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 690, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 1 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 6 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 9 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 11 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 14 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 15 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 16 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 17 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 19 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 20 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 22 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 24 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 25 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 26 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 27 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 28 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 31 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 32 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 33 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 34 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 35 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 36 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 37 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 38 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 39 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 40 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 41 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 42 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 43 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 44 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 45 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 46 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 47 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 48 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 49 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 50 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 15, 8, 607, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AboutBannerPath", "AboutPhotoPath", "AboutText", "AboutTextTitle", "Banner1Path", "Banner2Path", "Banner3Path", "ContactBannerPath", "FooterLogoPath", "LogoPath", "SliderText" },
                values: new object[] { "0f28bbb8-1897-43b0-aef1-0598efcfccc4", "f3651d17-2c1e-4fe8-8bc6-9a4922a29043", "We are a leading e-commerce company that offers a wide range of products.", "About Us", "e809f6cf-8fd0-4217-bbd9-60b52dd0620c", "deb0b266-1e12-49d2-97ff-fd19c2ebb8b8", "232d72b1-c24c-41f0-bc0f-c396e0a16347", "eefaa8e9-e2b7-4cb8-85e1-345994ef9420", "9a0ca075-205b-439e-ac0e-6a607b52a09b", "18e44284-f31f-497b-81a1-62da2a31fea9", "Welcome to our e-commerce site!" });
        }
    }
}
