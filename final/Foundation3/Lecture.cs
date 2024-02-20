namespace Foundation3
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;
        public Lecture(string speaker, int capacity, string type, string title, string description, string date, string time, string address):base(type, title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }
        public void DisplayFullDetails()
        {
            Console.WriteLine($@"{_type}: {_title} - Speaker: {_speaker} Capacity: {_capacity}
{_description} 
{_date} {_time}
{_address}");
        }
    }
}