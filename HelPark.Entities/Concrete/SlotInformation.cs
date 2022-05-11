using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class SlotInformation : BaseModel
    {
        
        public ICollection<Translation>     Translation { get; set; }
    }
}
