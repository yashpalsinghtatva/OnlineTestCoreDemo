using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Result
    {
        public int ResultId { get; set; }
        public Candidate candidate { get; set; }

        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
        public int CandidateId { get; set; }

        //public List<Option> Options { get; set; }
        //public List<Answer> Answers { get; set; }
    }
}
