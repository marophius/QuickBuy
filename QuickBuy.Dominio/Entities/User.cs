using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class User:Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Request> Requests { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AddCriticsm("Invalid e-mail");
            }
            if (string.IsNullOrEmpty(Password))
            {
                AddCriticsm("Password not reported");
            }
        }
    }
}
