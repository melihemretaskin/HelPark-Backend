using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class County : BaseModel
    {
       
        public string Name { get; set; }
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string PostCode { get; set; }
    }
}
