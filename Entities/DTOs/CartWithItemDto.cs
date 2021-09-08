using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CartWithItemDto : IDto
    {
        public int Id { get; set; }
        public double Count { get; set; }
        public int UserId { get; set; }
        public bool CartStatus { get; set; }
        public double LineTotal { get; set; }
        public int ItemId { get; set; }
        public String ItemCode { get; set; }
        public String ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int Category1 { get; set; }
        public String Category2 { get; set; }
        public String Category3 { get; set; }
        public String Category4 { get; set; }
        public String Brand { get; set; }
        public String ImageUrl { get; set; }
    }
}
