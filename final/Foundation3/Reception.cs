namespace Foundation3
{
    public class Reception : Event
    {
        private string _email;
        public Reception(string email, string type, string title, string description, string date, string time, string address):base(type, title, description, date, time, address)
        {
            _email = email;
        }
        public void DisplayFullDetails()
        {
            Console.WriteLine($@"{_type}: {_title} - RSVP: {_email}
{_description}
{_date} {_time}
{_address}");
        }
    }
}