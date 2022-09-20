using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }


    }
}
