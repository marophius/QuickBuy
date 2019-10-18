using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entity
    {
        private List<string> _validationmessages { get; set; }
        private List<string> ValidationMessage { 
            get {
                return _validationmessages ?? (_validationmessages = new List<string>());
            } 
        }
        protected void ClearValidationMessages()
        {
            ValidationMessage.Clear();
        }
        protected void AddCriticsm(string message)
        {
            ValidationMessage.Add(message);
        }
        public abstract void Validate();
        protected bool IsValid
        {
            get { return !ValidationMessage.Any(); }
        }
    }
}
