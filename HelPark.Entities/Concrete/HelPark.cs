using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class HelPark : BaseModel
    {
     
        public string Name { get; set; }

        public string[] PhoneNumber { get; set; }

        public Address Address { get; set; }

        public string[] Personels { get; set; } 
        
        public string WebSite   { get; set; }

        public string[] EmailAddressees   { get; set; }

        public ICollection<WorkingDays> WorkingDays { get; set; }



    }
}
