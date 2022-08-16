using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millioner
{
    public class QuestionRepository
    {
        private Question question;

        public QuestionRepository(Question questions)
        {
            question = questions;
        }
    }
}
