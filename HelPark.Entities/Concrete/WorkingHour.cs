using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class WorkingHour
    {
        ICollection<Translation> Translation { get; set; }
    }
}
