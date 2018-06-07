using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IOrdderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }

}
