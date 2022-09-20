using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(OnlineTestContext context) : base(context)
        {
        }

        public IEnumerable<Question> GetRandomQuestion(int preferedLanguageId)
        {
            var allQuestions = _context.Questions.Include(x=>x.Options).Include(x => x.Language).Include(x=>x.QuestionType).Where(x => x.Language.LanguageId == preferedLanguageId).ToList();
            if(allQuestions !=null && allQuestions.Count > 0)
            {
                //allQuestions =allQuestions.GroupBy(x=>x.LanguageId). Select(x=>x. .Take(5).ToList();
                allQuestions = allQuestions.GroupBy(x => x.QuestionTypeId, (key, g) => g.OrderBy(e => e.QuestionTypeId).First()).Take(5).ToList();
            }
        
            return allQuestions;
        }
    }
}
