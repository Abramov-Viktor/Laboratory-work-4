using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Millioner;

namespace MillionerTests
{
    [TestClass]
    public class UnitTests
    {
        Question question;
        string[] answers = new string[]{
                "Answer",
                "Answer1",
                "Answer2",
                "Answer3"
            };

        [TestInitialize]
        public void QuestionInitializeTest()
        {
            question = new Question("Question", answers);
            Assert.IsNotNull(question);
        }

        [TestMethod]
        public void GetAnswerTest()
        {
            string expected = "Answer";
            Assert.AreEqual(expected, question.GetAnswer());
        }
        [TestMethod]
        public void GetQuestionTest()
        {
            string expected = "Question";
            Assert.AreEqual(expected, question.GetQuestion());
        }
        [TestMethod]
        public void GetAnswerChoiceTest()
        {
            bool actual = true;
            string[] newAnswers = question.GetAnswerChoice();
            for (int i = 0; i < 4; i++)
                if (Array.IndexOf(newAnswers, answers[i]) == -1)
                    actual = false;
            Assert.IsTrue(actual);
        }
    }

    [TestClass]
    public class QuestionRepositoryTests
    {
        QuestionRepository repository;
        Question question = new Question("Question", new string[]
        {
            "Answer",
                "Answer1",
                "Answer2",
                "Answer3"
        });

        [TestInitialize]
        public void RepositoryInitializeTest()
        {
            repository = new QuestionRepository(question);
            Assert.IsNotNull(repository);
        }
    }

}
