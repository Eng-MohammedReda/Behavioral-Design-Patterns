using System;

namespace BehavioralDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CoR.JobApplication jobApplication = new CoR.JobApplication();
            jobApplication.ApplicantName = "Mohammed";
            jobApplication.JobTitle = "Great Job";
            jobApplication.JobCode = "5555";
            jobApplication.Comments = new System.Text.StringBuilder();

            CoR.HREvalHandler hREvalHandler = new CoR.HREvalHandler();
            CoR.TechnicalEvalHandler technicalEvalHandler = new CoR.TechnicalEvalHandler();
            hREvalHandler.SetNext(technicalEvalHandler);

            hREvalHandler.HandleRequest(jobApplication);
          
            Console.WriteLine(jobApplication.Comments);
            Console.ReadLine();
        }
    }
}
