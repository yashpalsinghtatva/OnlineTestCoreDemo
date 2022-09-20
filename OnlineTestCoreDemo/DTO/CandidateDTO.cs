using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.DTO
{
    public class CandidateDTO
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidiatePhoneNo { get; set; }
        public char CandidateGender { get; set; }
        public int CandidatePreferedLanguageId { get; set; }

    }

}
