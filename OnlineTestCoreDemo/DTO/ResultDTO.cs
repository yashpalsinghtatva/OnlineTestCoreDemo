using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.DTO
{
    public class ResultDTO
    {
        public int ResultId { get; set; }
        public CandidateDTO Candidate { get; set; }
        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }

    }
}
