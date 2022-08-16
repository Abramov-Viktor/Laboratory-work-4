using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millioner
{
    public class QuestionRepository
    {
        private List<Question> questions;

        public QuestionRepository(List<Question> questions)
        {
            this.questions = questions;
        }
    }
}
