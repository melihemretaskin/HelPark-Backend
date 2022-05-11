using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelPark.Core.Settings;
using HelPark.Models.IsParkDTO;
using Microsoft.Extensions.Options;

namespace HelPark.DataAccess.Repository
{
    public class IsParkDetailRepository : MongoRepositoryBase<IsParkDetail>
    {
        public IsParkDetailRepository(IOptions<MongoSettings> settings) : base(settings)
        {
        }
    }
}
