using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eshop_Data.Migrations
{
    /// <inheritdoc />
    public partial class Finils11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AboutBannerPath", "AboutPhotoPath", "AboutText", "AboutTextTitle", "Banner1Path", "Banner2Path", "Banner3Path", "ContactBannerPath", "FooterLogoPath", "FooterText", "LogoPath", "MapLocation", "SliderText", "SocialMediaUrl", "SocialMediaUrl2", "SocialMediaUrl3" },
                values: new object[] { 3, "0f28bbb8-1897-43b0-aef1-0598efcfccc4", "f3651d17-2c1e-4fe8-8bc6-9a4922a29043", "We are a leading e-commerce company that offers a wide range of products.", "About Us", "e809f6cf-8fd0-4217-bbd9-60b52dd0620c", "deb0b266-1e12-49d2-97ff-fd19c2ebb8b8", "232d72b1-c24c-41f0-bc0f-c396e0a16347", "eefaa8e9-e2b7-4cb8-85e1-345994ef9420", "9a0ca075-205b-439e-ac0e-6a607b52a09b", "All Rights Reserved.", "18e44284-f31f-497b-81a1-62da2a31fea9", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3022.073292073073!2d-73.9854286845949!3d40.74881797932569!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c2598f3f3b3b3f%3A0x1c3bb99243deb742!2sEmpire%20State%20Building!5e0!3m2!1str!2str!4v1640730000000!5m2!1str!2str", "Welcome to our e-commerce site!", "https://www.facebook.com/", "https://www.instagram.com/", "https://www.twitter.com/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8652bf77-14ca-4220-906b-871d4b91c17d", new DateTime(2025, 2, 16, 21, 51, 51, 317, DateTimeKind.Local).AddTicks(2695), "AQAAAAIAAYagAAAAEGFwKd7ytIor0323k0F3f3GOT3ylX2P6/93yeJLh8qoIySnkuvTnynwFANKZDAAJIA==", "ce455470-6b55-4e22-b31a-b62b95dc1635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10ab6855-7563-409c-bca2-e685071734cd", new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7760), "AQAAAAIAAYagAAAAEGwHs0fGFaegSPAyiHvitSPZooXHjxEuct/odpfGBkdeA6aBmn3/FN42FuGnmUURgQ==", "a2467d7e-2b72-43ec-bd02-cbafc24f7a63" });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 411, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 1 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 5 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 6 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 8 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 9 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 11 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 13 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 14 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 15 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 16 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 17 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 18 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 19 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 20 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 21 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 22 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 23 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 24 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 25 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 26 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 27 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 28 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 29 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 30 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 31 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 32 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 33 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 34 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 35 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 36 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 37 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 38 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 39 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 40 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 41 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 42 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 43 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 44 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 45 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 46 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 47 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 48 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 49 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 50 },
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 16, 21, 51, 51, 236, DateTimeKind.Local).AddTicks(7293));
        }
    }
}
