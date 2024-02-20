namespace Foundation3
{
    public class Event
    {
        protected string _type;
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected string _address;
        public Event(string type, string title, string description, string date, string time, string address)
        {
            _type = type;
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }
        public void DisplayStandardDetails()
        {
            Console.WriteLine($"{_title}: {_description} - {_date} {_time}, {_address}");
        }
        public void DisplayShortDescription()
        {
            Console.WriteLine($"{_type}: {_title} - {_date}");
        }
    }
}