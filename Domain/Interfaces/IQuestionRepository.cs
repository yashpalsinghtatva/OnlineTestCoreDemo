﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        IEnumerable<Question> GetRandomQuestion(int preferedLanguageId);
    }
}
