namespace Foundation3
{
    public class OutdoorGathering : Event
    {
        private string _weather;
        public OutdoorGathering(string weather, string type, string title, string description, string date, string time, string address):base(type, title, description, date, time, address)
        {
            _weather = weather;
        }
        public void DisplayFullDetails()
        {
            Console.WriteLine($@"{_type}: {_title} - Weather: {_weather}
{_description}
{_date} {_time}
{_address}");
        }
    }
} 