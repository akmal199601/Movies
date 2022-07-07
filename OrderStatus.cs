using System.Collections.Generic;
using Entities.Enums;

namespace Entities.Models;

public class OrderStatus
{
    public OrderStatuses Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<Order> Orders { get; set; }
}