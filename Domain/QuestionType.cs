using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class QuestionType
    {
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }
        public List<Question> Questions { get; set; }

    }
}
