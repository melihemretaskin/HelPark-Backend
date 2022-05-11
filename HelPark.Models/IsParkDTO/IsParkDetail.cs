using HelPark.Core.Models;

namespace HelPark.Models.IsParkDTO
{
    public class IsParkDetail: BaseModel
    {
        public IsParkDetail()
        {
            Id = ParkID;
        }
        public string LocationName { get; set; }
        public int ParkID { get; set; }
        public string ParkName { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int Capacity { get; set; }
        public int EmptyCapacity { get; set; }
        public string UpdateDate { get; set; }
        public string WorkHours { get; set; }
        public string ParkType { get; set; }
        public int FreeTime { get; set; }
        public double MonthlyFee { get; set; }
        public string Tariff { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string AreaPolygon { get; set; }
    }
}
