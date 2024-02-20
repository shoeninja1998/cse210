namespace Foundation4
{
    public class Activity
    {
        protected string _type;
        protected int _minutes;
        protected string _date;
        public Activity(string type, int minutes, string date)
        {
            _type = type;
            _minutes = minutes;
            _date = date;
        }
        public void GetSummary()
        {
            Console.WriteLine($"{_date} {_type} ({_minutes}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
        }
        public virtual double GetDistance()
        {
            return 0;
        }
        public virtual double GetSpeed()
        {
            return 0;
        }
        public virtual double GetPace()
        {
            return 0;
        }
    }
}