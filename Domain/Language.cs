using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public List<Candidate> Candidates { get; set; }
        public List<Question> Questions { get; set; }
    }
}
