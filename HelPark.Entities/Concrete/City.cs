using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class City : BaseModel
    {
      

        public string Name { get; set; }
        public string Plate { get; set; }
        public string Latitude { get; set; }
        public string Logitude { get; set; }
        public ICollection<County> Counties { get; set; }
    }
}


