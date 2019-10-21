using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentForm",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Paymentform BankSlip", "Boleto" });

            migrationBuilder.InsertData(
                table: "PaymentForm",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Paymentform Credit Card", "Credit Card" });

            migrationBuilder.InsertData(
                table: "PaymentForm",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Paymentform Deposit", "Deposit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentForm",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentForm",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentForm",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
