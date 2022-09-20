using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestWebApi.DTO
{
    public class SummaryDTO
    {
        public ResultDTO result { get; set; }
        public List<QuestionDTO> questions { get; set; }
        
    }
}
