using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ImagePath : IEntity
    {
        public int Id { get; set; }
        public String ImageId { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int ItemId { get; set; }
    }
}
