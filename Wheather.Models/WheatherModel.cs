namespace Wheather.Models
{
    public class WheatherModel
    {

        public int Id { get; set; }
        public string CityUniqueCode { get; set; }
        public string CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }

    }
}
