using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Town : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public String TownId { get; set; }
    }
}
