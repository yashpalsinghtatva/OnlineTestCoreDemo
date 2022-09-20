using Domain;
using OnlineTestWebApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.HelperClasses
{
    public static class MapperClass
    {
        public static QuestionDTO ConvertToQuestionDTO(this Question question)
        {
            return question == null ? null : new QuestionDTO
            {
                QuestionId = question.QuestionId,
                QuestionText = question.QuestionText,
                QuestionType = ConvertToQuestionTypeDTO(question.QuestionType),
                Language = ConvertToLanguageDTO(question.Language),
                Answers = ConvertToAnswerDTOList(question.Answers),
                Options = ConvertToOptionDTOList(question.Options)

            };
        }
        public static IEnumerable<QuestionDTO> ConvertToQuestionDTOList(this IEnumerable<Question> questions)
        {
            return questions == null ? null : questions.Select(question => ConvertToQuestionDTO(question));
        }

        public static QuestionTypeDTO ConvertToQuestionTypeDTO(this QuestionType questionType)
        {
            return questionType == null ? null : new QuestionTypeDTO
            {
                QuestionTypeId = questionType.QuestionTypeId,
                QuestionTypeName = questionType.QuestionTypeName,

            };
        }
        public static LanguageDTO ConvertToLanguageDTO(this Language language)
        {
            return language == null ? null : new LanguageDTO
            {
                LanguageId = language.LanguageId,
                LanguageName = language.LanguageName
            };
        }
        public static OptionDTO ConvertToOptionDTO(this Option option)
        {
            return option == null ? null : new OptionDTO
            {
                OptionId = option.OptionId,
                OptionText = option.OptionText
            };
        }
        public static AnswerDTO ConvertToAnswerDTO(this Answer answer)
        {
            return answer == null ? null : new AnswerDTO
            {
                AnswerId = answer.AnswerId,
                AnswerText = answer.AnswerText
            };
        }
        public static List<AnswerDTO> ConvertToAnswerDTOList(this IEnumerable<Answer> answers)
        {
            return answers == null ? null :  answers.Select(answer => ConvertToAnswerDTO(answer)).ToList();
        }
        public static List<OptionDTO> ConvertToOptionDTOList(this IEnumerable<Option> options)
        {
            return options == null ? null : options.Select(option => ConvertToOptionDTO(option)).ToList();
        }
        public static Candidate  ConvertToCandidate(this CandidateDTO candidateDTO)
        {
            return candidateDTO == null ? null : new Candidate
            {
                CandidateId = candidateDTO.CandidateId,
                CandidateEmail = candidateDTO.CandidateEmail,
                CandidateGender = candidateDTO.CandidateGender,
                CandidateName = candidateDTO.CandidateName,
                PreferedLanguageId = candidateDTO.CandidatePreferedLanguageId,
                CandidiatePhoneNo = candidateDTO.CandidiatePhoneNo

            };
        }
        public static CandidateDTO ConvertToCandidateDTO(this Candidate candidate)
        {
            return candidate == null ? null : new CandidateDTO
            {
                CandidateId = candidate.CandidateId,
                CandidateEmail = candidate.CandidateEmail,
                CandidateGender = candidate.CandidateGender,
                CandidateName = candidate.CandidateName,
                CandidatePreferedLanguageId = candidate.PreferedLanguageId,
                CandidiatePhoneNo = candidate.CandidiatePhoneNo

            };
        }
        public static ResultDTO ConvertToResultDTO(this Result result)
        {
            return result == null ? null : new ResultDTO
            {
                ResultId = result.ResultId,
                ObtainedMarks = result.ObtainedMarks,
                TotalMarks = result.TotalMarks,
                Candidate = result.candidate.ConvertToCandidateDTO()

            };
        }
    }

}
