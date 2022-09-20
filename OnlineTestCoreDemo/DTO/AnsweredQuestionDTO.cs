using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.DTO
{
    public class AnsweredQuestionDTO
    {
       public List<QuestionDTO> allAnsweredQuestions { get; set; }
       public int CandidateId { get; set; }
    }
}
