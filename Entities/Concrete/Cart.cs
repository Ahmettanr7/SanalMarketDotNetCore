using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Cart : IEntity
    {
        public int Id { get; set; }
        public double Count { get; set; }
        public int ItemId { get; set; }

        public double UnitPrice { get; set; }
        public int UserId { get; set; }
        public bool CartStatus { get; set; }
        public double LineTotal { get; set; }
    }
}
