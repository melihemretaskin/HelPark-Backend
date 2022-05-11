using HelPark.Core.Settings;
using HelPark.Models.IsParkDTO;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelPark.DataAccess.Repository
{
    public class IsParkRepository : MongoRepositoryBase<IsPark>
    {
        public IsParkRepository(IOptions<MongoSettings> settings) : base(settings)
        {
        }
    }
}
