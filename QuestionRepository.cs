using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Millioner
{
    public class QuestionRepository
    {
        private List<Question> questions = new List<Question>();
        private Question currentQuestion;

        public QuestionRepository(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlElement xRoot = xml.DocumentElement;
            if (xRoot != null)
            {                
                for (int i = 0; i < xRoot.ChildNodes.Count; i += 2)
                {
                    string questionText = null;
                    string[] answers = new string[4];
                    questionText = xRoot.ChildNodes[i].InnerText;
                    for (int j = 0; j < xRoot.ChildNodes[i + 1].ChildNodes.Count; j++)
                    {
                        answers[j] = xRoot.ChildNodes[i + 1].ChildNodes[j].InnerText;
                    }
                    questions.Add(new Question(questionText, answers));
                }
            }
        }
        public void SetCurrentQuestion()
        {
            Random random = new Random();
            do
            {
                this.currentQuestion = this.questions[random.Next(questions.Count)];
            } while (currentQuestion.isUsed);
            currentQuestion.isUsed = true;
        }

        public void ResetUsedStatus()
        {
            foreach (var question in this.questions)
            {
                question.isUsed = false;
            }
        }

        public Question GetCurrentQuestion() => currentQuestion;

        public string GetQuestionText() => currentQuestion.GetQuestion();

        public string[] GetQuestionAnswerChoice() => currentQuestion.GetAnswerChoice();

        public string GetCurrentAnswer() => currentQuestion.GetAnswer();
    }
}
