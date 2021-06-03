using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateBackend.Models
{
    public class ListingAgent
    {
        public Guid AgentID { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentLastName { get; set; }
        public string ContactNumber { get; set; }
    }
}
