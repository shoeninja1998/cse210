namespace Foundation4
{
    public class Swimming : Activity
    {
        private int _laps;
        public Swimming(int laps, string type, int minutes, string date):base(type, minutes, date)
        {
            _laps = laps;
        }
        public override double GetDistance()
        {
            return _laps * 50 / 1000 * 0.62;
        }
        public override double GetSpeed()
        {
            return GetDistance()/_minutes * 60;
        }
        public override double GetPace()
        {
            return Math.Round(_minutes/GetDistance(), 2);
        }
    }
}