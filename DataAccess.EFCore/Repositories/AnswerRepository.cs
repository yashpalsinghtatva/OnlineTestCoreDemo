using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>,IAnswerRepository
    {
        public AnswerRepository(OnlineTestContext context) : base(context)
        {

        }

        public List<Answer> getAnswersByQuestionId(int[] questionIds)
        {
            return _context.Answers.Where(answer => questionIds.Contains(answer.Question.QuestionId)).Include(x=>x.Question).ToList();
             
        }
    }
}
