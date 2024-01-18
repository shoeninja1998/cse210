using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new(){
            _jobTitle = "CEO",
            _company = "Microsoft",
            _startYear = 1998,
            _endYear = 2011
        };
        Job job2 = new(){
            _jobTitle = "Owner",
            _company = "Apple",
            _startYear = 2011,
            _endYear = 2024
        };
        Resume resume1 = new()
        {
            _name = "Eric Johnson"
        };

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}