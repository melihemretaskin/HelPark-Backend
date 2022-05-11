using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelPark.Models.IsParkDTO;

namespace HelPark.Business.Interfaces
{
    public interface IIsParkService
    {
        IsParkDetail GetIsParkDetailById(int id);
        List<Models.IsParkDTO.IsPark> GetIsPark();
    }
}
