using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{

    public class Candidate
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidiatePhoneNo { get; set; }
        public char CandidateGender { get; set; }
        public int PreferedLanguageId { get; set; }

        [ForeignKey("PreferedLanguageId")]
        public virtual Language candidatePreferedLanguageId { get; set; }

    }
}
