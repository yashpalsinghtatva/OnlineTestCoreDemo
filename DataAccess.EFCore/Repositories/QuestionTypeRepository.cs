using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class QuestionTypeRepository :GenericRepository<QuestionType>, IQuestionTypeRepository
    {
        public QuestionTypeRepository(OnlineTestContext context) : base(context)
        {
        }
    }
}
