using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateBackend.Models
{
    public class PropertyImage
    {
        public Guid PropertyImageID { get; set; }
        public Guid PropertyID { get; set; }
        public Guid AgentID { get; set; }
        public string ImageFileName { get; set; }
        public string ImageURL { get; set; }

        public virtual Property Property { get; set; }
        public virtual ListingAgent Agent { get; set; }
    }
}
