using RealEstateBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateBackend.Data
{
    public class Initializer
    {
        public static void Initialize(ApplicationDBContext dbContext)
        {
            /*if (dbContext.IssueComments.Any())
            {
                return;
            }*/

            var agents = new List<ListingAgent>
            {
                new ListingAgent
                {
                    AgentFirstName = "Nico",
                    AgentLastName = "Fortuin",
                    ContactNumber = "0780629298"
                },
                new ListingAgent
                {
                    AgentFirstName = "Lvis",
                    AgentLastName = "Gene",
                    ContactNumber = "0780629298"
                },
                new ListingAgent
                {
                    AgentFirstName = "Marcel",
                    AgentLastName = "Lappies",
                    ContactNumber = "0780629298"
                },
                new ListingAgent
                {
                    AgentFirstName = "Waylon",
                    AgentLastName = "Spark",
                    ContactNumber = "0780629298"
                }
            };
            agents.ForEach(x => dbContext.ListingAgents.Add(x));

            var properties = new List<Property>
            {
                new Property
                {
                    ListingNumber = 1,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Nico").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -77.0364,
                    Latitude = 38.8951
                },
                new Property
                {
                    ListingNumber = 2,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Nico").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -76.0364,
                    Latitude = 37.8951
                },
                new Property
                {
                    ListingNumber = 3,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Waylon").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -75.0364,
                    Latitude = 36.8951
                },
                new Property
                {
                    ListingNumber = 4,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Lvis").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -74.0364,
                    Latitude = 35.8951
                },
                new Property
                {
                    ListingNumber = 5,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Lvis").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -73.0364,
                    Latitude = 34.8951
                },
                new Property
                {
                    ListingNumber = 6,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Lvis").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -72.0364,
                    Latitude = 33.8951
                },
                new Property
                {
                    ListingNumber = 7,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Marcel").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -71.0364,
                    Latitude = 32.8951
                },
                new Property
                {
                    ListingNumber = 8,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Marcel").AgentID,
                    PropertyNumber = 1,
                    StreetName = "Garnet Street",
                    City = "LTZ",
                    PostalCode = 1234,
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 2,
                    NumberOfGarages = 1,
                    PropertyPrize = 1500000,
                    PropertyDescription = "Sample description",
                    Longitude = -70.0364,
                    Latitude = 31.8951
                }
            };
            properties.ForEach(x => dbContext.Properties.Add(x));

            var images = new List<PropertyImage>
            {
                new PropertyImage
                {
                    PropertyID = dbContext.Properties.FirstOrDefault(x => x.ListingNumber == 1).PropertyID,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Nico").AgentID,
                    ImageFileName = "House1",
                    ImageURL = "https://images.unsplash.com/photo-1580587771525-78b9dba3b914?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8aG91c2V8ZW58MHx8MHx8&ixlib=rb-1.2.1&w=1000&q=80"
                },
                new PropertyImage
                {
                    PropertyID = dbContext.Properties.FirstOrDefault(x => x.ListingNumber == 1).PropertyID,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Nico").AgentID,
                    ImageFileName = "House2",
                    ImageURL = "https://images.unsplash.com/photo-1568605114967-8130f3a36994?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8Mnx8fGVufDB8fHx8&w=1000&q=80"
                },
                new PropertyImage
                {
                    PropertyID = dbContext.Properties.FirstOrDefault(x => x.ListingNumber == 2).PropertyID,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Marcel").AgentID,
                    ImageFileName = "House3",
                    ImageURL = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/brewster-mcleod-architects-1486154143.jpg"
                },
                new PropertyImage
                {
                    PropertyID = dbContext.Properties.FirstOrDefault(x => x.ListingNumber == 3).PropertyID,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Lvis").AgentID,
                    ImageFileName = "House1",
                    ImageURL = "https://www.trepryor.com/blog/wp-content/uploads/2019/06/modern-architecture-home1.jpg"
                },
                new PropertyImage
                {
                    PropertyID = dbContext.Properties.FirstOrDefault(x => x.ListingNumber == 5).PropertyID,
                    AgentID = dbContext.ListingAgents.FirstOrDefault(x => x.AgentFirstName == "Waylon").AgentID,
                    ImageFileName = "House1",
                    ImageURL = "https://thegardengranny.com/wp-content/uploads/2020/05/Sophisticated-Home.jpg"
                }
            };
            images.ForEach(x => dbContext.PropertyImages.Add(x));
        }
    }
}
