using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.ObjetoDeValor;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Request:Entity
    {
        public int Id { get; set; }
        public DateTime DateRequest { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DeliveryForecast { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int PaymentFormId { get; set; }
        public PaymentForm PaymentForm { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um ou muitos pedidos, relação de 1 para N
        /// </summary>
        public ICollection<OrderedItem> OrderedItems { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();
            if (!OrderedItems.Any())
            {
                AddCriticsm("Order request cannot be empty!");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AddCriticsm("CEP must be completed!");
            }
        }
    }
}
