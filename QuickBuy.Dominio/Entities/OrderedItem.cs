using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class OrderedItem:Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
            {
                AddCriticsm("The product's reference can not be defined!");
            }
            if(Amount == 0)
            {
                AddCriticsm("Amount not reported");
            }
        }
    }
}
