using Foundation4;
class Program
{
    static void Main(string[] args)
    {
        Running running = new(5.5, "Running", 30, "20 February 2024");
        running.GetSummary();

        StationaryBicycle stationaryBicycle = new(2.3, "Stationary Bicycle", 30, "20 February 2024");
        stationaryBicycle.GetSummary();

        Swimming swimming = new(20, "Swimming", 30, "20 February 2024");
        swimming.GetSummary();

    }
}