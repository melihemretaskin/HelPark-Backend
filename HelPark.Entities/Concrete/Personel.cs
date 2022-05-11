using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using HelPark.Entities.Concrete;
using MongoDB.Bson.Serialization.Attributes;

namespace HelPark.Entities
{
    public class Personel : BaseModel
    {
       
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string[] Roles { get; set; }

        public PersonelContact PersonelContact { get; set; }

        public ICollection<Address> Adresses { get; set; }

        public short Status { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        // ? boş geçilebilir anlamında

    }
}
