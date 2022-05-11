using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities.Concrete
{
    public class WorkingDays : BaseModel
    {
         

        public ICollection<Translation> Translations { get; set; }

        public ICollection<WorkingHour> WorkingHour { get; set; }


    }
}
