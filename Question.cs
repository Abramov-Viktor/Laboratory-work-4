using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millioner
{
    public class Question
    {

        private string question;
        private string answer;
        private string[] answerChoice = new string[4];

        public Question(string question, string[] answerChoice)
        {
            this.question = question;
            this.answer = answerChoice[0];
            this.answerChoice = answerChoice;
        }

        public string GetAnswer() => answer;

        public string GetQuestion() => question;

        public string[] GetAnswerChoice()
        {
            Random random = new Random();
            for (int i = answerChoice.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = answerChoice[j];
                answerChoice[j] = answerChoice[i];
                answerChoice[i] = temp;
            }
            return answerChoice;
        }
    }
}
