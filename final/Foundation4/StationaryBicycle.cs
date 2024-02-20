namespace Foundation4
{
    public class StationaryBicycle : Activity
    {
        private double _speed;
        public StationaryBicycle(double speed, string type, int minutes, string date):base(type, minutes, date)
        {
            _speed = speed;
        }
        public override double GetDistance()
        {
            return GetSpeed() * _minutes/60;
        }
        public override double GetSpeed()
        {
            return _speed;
        }
        public override double GetPace()
        {
            return Math.Round(60/GetSpeed(),2);
        }
    }
}