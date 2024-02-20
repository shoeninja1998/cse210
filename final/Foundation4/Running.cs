namespace Foundation4
{
    public class Running : Activity
    {
        private double _distance;
        public Running(double distance, string type, int minutes, string date):base(type, minutes, date)
        {
            _distance = distance;
        }
        
        public override double GetDistance()
        {
            return _distance;
        }
        public override double GetSpeed()
        {
            return GetDistance()/_minutes * 60;
        }
        public override double GetPace()
        {
            return Math.Round(_minutes/GetDistance(),2);
        }
    }
}