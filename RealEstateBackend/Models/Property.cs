using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateBackend.Models
{
    public class Property
    {
        public Guid PropertyID { get; set; }
        public int ListingNumber { get; set; }
        public Guid AgentID { get; set; }
        public int PropertyNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int NumberOfGarages { get; set; }
        public int PropertyPrize { get; set; }
        public string PropertyDescription { get; set; }
        public DateTime ListingDate { get; set; } = DateTime.Now;
        public bool PropertySold { get; set; } = false;
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }

        public virtual ListingAgent Agent { get; set; }
        public virtual List<string> PropertyTypes()
        {
            string[] types = Enum.GetNames(typeof(PropertyType));
            return types.ToList();
        }

        public enum PropertyType
        {
            House = 1,
            Apartment = 2
        }
    }
}
