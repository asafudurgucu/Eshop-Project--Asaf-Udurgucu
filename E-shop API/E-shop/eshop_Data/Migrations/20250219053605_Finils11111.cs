using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop_Data.Migrations
{
    /// <inheritdoc />
    public partial class Finils11111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78800330-7ba7-446a-aadd-9cbf7c78e186", new DateTime(2025, 2, 19, 8, 36, 5, 592, DateTimeKind.Local).AddTicks(4240), "AQAAAAIAAYagAAAAEI9NaL2OG9zg8sxaVPFN9SfY6AQjpVM37E6z0o0MQ4snKenvQWsPTPu5kL7o+n6jCg==", "d4c28845-3f7a-4469-a1e4-26528bd6f4de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586ba6ff-682b-4f31-a2db-1487c66b944a", new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4401), "AQAAAAIAAYagAAAAEL7c3AE4nu80y11UF5kt1/yARFv1K5Pt2TxupMczktFz+EgCX8gzDCwQtX/rKHUZLw==", "b653dac3-2d60-46ec-8d4b-e9114f20200d" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 633, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 633, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 633, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 633, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 633, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 1 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 6 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 9 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 11 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 14 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 15 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 16 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 17 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 19 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 20 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 22 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 24 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 25 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 26 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 27 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 28 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 31 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 32 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 33 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 34 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 35 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 36 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 37 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 38 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 39 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 40 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 41 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 42 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 43 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 44 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 45 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 46 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 47 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 48 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 49 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 50 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 19, 8, 36, 5, 552, DateTimeKind.Local).AddTicks(4143));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "ModifiedDate", "Name", "Price", "Properties", "isActive" },
                values: new object[,]
                {
                    { 36, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8805), "/images/product-36.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Watch GT 3", 249.99m, "Huawei Watch GT 3, 46mm ekran, 14 güne kadar pil ömrü, fitness ve sağlık takibi.", true },
                    { 37, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8806), "/images/product-37.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Xperia 5 III", 1049.99m, "Sony Xperia 5 III, 128GB, 6.1 inç OLED ekran, 120Hz yenileme hızı ve mükemmel video çekim özellikleri.", true },
                    { 38, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8808), "/images/product-38.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iMac 24\" M1", 1299.99m, "Apple iMac 24\" M1, 8GB RAM, 256GB SSD, parlak ve canlı renklerle tasarlanmış masaüstü bilgisayar.", true },
                    { 39, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8809), "/images/product-39.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Note 20 Ultra", 1299.99m, "Samsung Galaxy Note 20 Ultra, 256GB, 108MP ana kamera, 5G desteği ile hızlı bağlantı.", true },
                    { 40, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8811), "/images/product-40.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Redmi Note 11 Pro", 249.99m, "Xiaomi Redmi Note 11 Pro, 128GB, 6.67 inç AMOLED ekran, 108MP kamera.", true },
                    { 41, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8812), "/images/product-41.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Yoga 9i", 1899.99m, "Lenovo Yoga 9i, 16GB RAM, 512GB SSD, 14 inç 4K ekran, dönüştürülebilir dizüstü bilgisayar.", true },
                    { 42, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8813), "/images/product-42.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Magic Mouse", 79.99m, "Apple Magic Mouse, kablosuz, çoklu dokunmatik yüzey, zarif ve kompakt tasarım.", true },
                    { 43, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8839), "/images/product-43.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony WH-XB900N", 249.99m, "Sony WH-XB900N, Kablosuz kulaklık, ekstra bass özelliği ve gürültü engelleme.", true },
                    { 44, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8840), "/images/product-44.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple HomePod Mini", 99.99m, "Apple HomePod Mini, Akıllı hoparlör, yüksek kaliteli ses ve Apple ekosistemine uyum.", true },
                    { 45, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8842), "/images/product-45.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung T7 Touch SSD", 149.99m, "Samsung T7 Touch, 1TB SSD, parmak izi güvenliği, ultra hızlı veri transferi.", true },
                    { 46, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8843), "/images/product-46.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Mi 11 Lite", 369.99m, "Xiaomi Mi 11 Lite, 128GB, Snapdragon 732G, 6.55 inç AMOLED ekran, ince ve şık tasarım.", true },
                    { 47, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8844), "/images/product-47.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo IdeaPad Flex 5", 849.99m, "Lenovo IdeaPad Flex 5, 8GB RAM, 512GB SSD, 14 inç ekran, dönüştürülebilir laptop.", true },
                    { 48, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8846), "/images/product-48.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony Bravia A80J", 2199.99m, "Sony Bravia A80J, 65 inç OLED, 4K, Google TV ile akıllı özellikler ve mükemmel görüntü kalitesi.", true },
                    { 49, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8847), "/images/product-49.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Pencil 2. Nesil", 129.99m, "Apple Pencil 2. Nesil, iPad Pro ve iPad Air için hassas çizim ve not alma aracı.", true },
                    { 50, new DateTime(2025, 2, 19, 8, 20, 12, 633, DateTimeKind.Local).AddTicks(8848), "/images/product-50.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Z Fold 4", 1799.99m, "Samsung Galaxy Z Fold 4, katlanabilir ekran, 12GB RAM, 512GB depolama alanı ile güçlü bir cihaz.", true }
                });
        }
    }
}
