using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestUI.ViewModels
{
    public class QuestionViewModel
    {
        public int questionId { get; set; }
        public string questionText { get; set; }
        public QuestionType questionType { get; set; }
        public int languageId { get; set; }
        public List<Option> options { get; set; }
        public List<Answer> answers { get; set; }
        public string[] userAnswer { get; set; }

        public int questionIndexNo { get; set; }
    }
    public class Option
    {
        public int optionId { get; set; }
        public string optionText { get; set; }
        public int questionId { get; set; }
    }
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public int questionId { get; set; }

    }
    public class QuestionType
    {
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }

    }
}
