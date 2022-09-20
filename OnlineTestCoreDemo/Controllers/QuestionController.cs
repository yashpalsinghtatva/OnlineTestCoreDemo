using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OnlineTestWebApi.DTO;
using OnlineTestWebApi.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<QuestionController>
        [Route("[action]/{preferedLanguageId}")]
        [HttpGet]
        public IActionResult GetRandomQuestion(int preferedLanguageId)
        {
            try
            {
                List<QuestionDTO> questions = _unitOfWork.Questions.GetRandomQuestion(preferedLanguageId).ConvertToQuestionDTOList().ToList();
                return Ok(questions);
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = "Error Occurred"
                };
                return NotFound(resp);
            }
        }

        [HttpPost]
        [Route("[action]")]

        public IActionResult CalculateResult(AnsweredQuestionDTO answeredQuestion)
        {
            try
            {
                int CorrectAnswers = 0;
                List<Answer> allQuestionsAnswers= _unitOfWork.Answers.getAnswersByQuestionId(answeredQuestion.allAnsweredQuestions.Select(x=>x.QuestionId).ToArray());
                foreach(var question in answeredQuestion.allAnsweredQuestions)
                {
                    question.Answers = allQuestionsAnswers.Where(x => x.Question.QuestionId == question.QuestionId).ConvertToAnswerDTOList();
                    var IsCurrentAnswer = question.UserAnswers != null && question.UserAnswers.Length > 0 ? question.Answers.Select(x => x.AnswerText).SequenceEqual(question.UserAnswers): false;
                    if (IsCurrentAnswer)
                    {
                        CorrectAnswers++;
                    }
                }
                Result result = new Result();
                result.TotalMarks = answeredQuestion.allAnsweredQuestions.Count();
                result.ObtainedMarks = CorrectAnswers;
                result.CandidateId = answeredQuestion.CandidateId;
                _unitOfWork.Result.Add(result);
                _unitOfWork.Complete();

                SummaryDTO summary = new SummaryDTO();
                summary.questions = answeredQuestion.allAnsweredQuestions;
                summary.result = result.ConvertToResultDTO();
                return Ok(summary);

            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = "Error Occurred"
                };
                return NotFound(resp);
            }
        }
    }
}
