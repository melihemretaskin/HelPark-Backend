using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class FloorInformation : BaseModel
    {
       

        public int Number   { get; set; }

        public ICollection<SlotInformation> Slots { get; set; }

    }
}
