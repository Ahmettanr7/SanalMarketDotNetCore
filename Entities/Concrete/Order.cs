using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date_ { get; set; }
        public double TotalPrice { get; set; }
        public int AddressId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
