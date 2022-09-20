using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
   public class Option
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
    }
}
