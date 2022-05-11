using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelPark.Core.Models
{
     public class Result
    {
        public Result()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
     public class GetOneResult<TEntity> : Result where TEntity : BaseModel
    {
        public TEntity Entity { get; set; }

        
     }

     public class GetManyResult<TEntity> : Result where TEntity : BaseModel
    {
         public IEnumerable<TEntity> Result { get; set; }
     }


}
