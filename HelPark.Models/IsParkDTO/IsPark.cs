using HelPark.Core.Models;

namespace HelPark.Models.IsParkDTO
{
    public class IsPark : BaseModel
    {
        public IsPark()
        {
            Id = ParkID;
        }
        public int ParkID { get; set; }
        public string ParkName { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int Capacity { get; set; }
        public int EmptyCapacity { get; set; }
        public string WorkHours { get; set; }
        public string ParkType { get; set; }
        public int FreeTime { get; set; }
        public string District { get; set; }
        public int IsOpen { get; set; }

    }
}
