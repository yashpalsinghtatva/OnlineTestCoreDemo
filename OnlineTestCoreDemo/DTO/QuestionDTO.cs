using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public QuestionTypeDTO QuestionType { get; set; }
        public LanguageDTO Language { get; set; }
        public List<OptionDTO> Options { get; set; }
        public List<AnswerDTO> Answers { get; set; }
        public string[] UserAnswers { get; set; }
        public int CandidateId { get; set; }

    }
    public class OptionDTO
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; }
    }
    public class AnswerDTO
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }
    public class QuestionTypeDTO
    {
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }
    }
    public class LanguageDTO
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
