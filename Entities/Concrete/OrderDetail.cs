using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public double Count { get; set; }
        public int ItemId { get; set; }
        public int OrderId { get; set; }
    }
}
