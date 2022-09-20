using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        public QuestionType QuestionType { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }

        public List<Option> Options { get; set; }
        public List<Answer> Answers { get; set; }

        public int QuestionTypeId { get; set; }
        public int LanguageId { get; set; }

    }
}
