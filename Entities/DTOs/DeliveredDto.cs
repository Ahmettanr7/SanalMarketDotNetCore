using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DeliveredDto : IDto
    {
        public int OrderId { get; set; }
        public DateTime Date_ { get; set; }
        public double TotalPrice { get; set; }
        public bool IsDelivered { get; set; }
        public int AddressId { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public int TownId { get; set; }

        public int DistrictId { get; set; }

        public String PostalCode { get; set; }

        public String AddressText { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    
}
}
