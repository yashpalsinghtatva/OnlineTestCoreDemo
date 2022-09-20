using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAnswerRepository : IGenericRepository<Answer>
    {
        public List<Answer> getAnswersByQuestionId(int[] questionIds);
    }
}
