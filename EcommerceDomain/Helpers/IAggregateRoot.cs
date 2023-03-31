using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public class AggregateRoot :Entity
    {

        public List<IDomainEvent> DomainEvents { get; } = new List<IDomainEvent>();

        public void AddDomainEvent(IDomainEvent eventItem)
        {
            DomainEvents.Add(eventItem);
        }

        protected void RemoveDomainEvent(IDomainEvent eventItem)
        {
            DomainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            DomainEvents?.Clear();
        }
    }
}
