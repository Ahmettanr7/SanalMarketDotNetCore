using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Favorite : IEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
    }
}
