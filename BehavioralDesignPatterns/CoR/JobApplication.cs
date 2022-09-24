using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CoR
{
    public class JobApplication 
    {
        public string ApplicantName { get; set; }
        public string JobTitle { get; set; }
        public string JobCode { get; set; }
        public StringBuilder Comments{ get; set; }
        public string ShowComments()
        {
            return Comments.ToString();
        }
    }
}
