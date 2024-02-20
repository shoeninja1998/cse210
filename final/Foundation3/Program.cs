using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        OutdoorGathering outdoorGathering = new
        ("yes","Outdoor Gathering","title","description","date","time","address");
        outdoorGathering.DisplayShortDescription();
        outdoorGathering.DisplayStandardDetails();
        outdoorGathering.DisplayFullDetails();

        Reception reception = new
        ("email", "Reception", "title", "description", "date", "time", "address");
        reception.DisplayShortDescription();
        reception.DisplayStandardDetails();
        reception.DisplayFullDetails();

        Lecture lecture = new
        ("speaker", 200, "Lecture", "title", "description", "date", "time", "address");
        lecture.DisplayShortDescription();
        lecture.DisplayStandardDetails();
        lecture.DisplayFullDetails();
    }
}