

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContext : DbContext
    {

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<OrderedItem> OrderedItem { get; set; }
        public DbSet<PaymentForm> PaymentForm { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// CLASSES DE MAPEAMENTO AQUI...
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new OrderedItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentFormConfiguration());

            modelBuilder.Entity<PaymentForm>().HasData(
                new PaymentForm() { 
                    Id = 1, 
                    Name = "Boleto", 
                Description = "Paymentform BankSlip" 
                },
                new PaymentForm()
                {
                    Id = 2,
                    Name = "Credit Card",
                    Description = "Paymentform Credit Card"
                },
                new PaymentForm()
                {
                    Id = 3,
                    Name = "Deposit",
                    Description = "Paymentform Deposit"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
