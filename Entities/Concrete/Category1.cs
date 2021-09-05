using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category1 : IEntity
    {
        public int Id { get; set; }
        public String  CategoryName { get; set; }
        public String ImageUrl { get; set; }
    }
}
