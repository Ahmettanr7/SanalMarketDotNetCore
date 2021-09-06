using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CartDto
    {
        public int UserId { get; set; }
        public double TotalCartPrice { get; set; }
    }
}
