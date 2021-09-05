using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime Date_ { get; set; }
        public bool IsOk { get; set; }
        public String AppropveCode { get; set; }
        public decimal PaymentTotal { get; set; }
    }
}
