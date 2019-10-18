

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjetoDeValor;

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
    }
}
