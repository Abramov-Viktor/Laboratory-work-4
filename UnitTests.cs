using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Millioner;
using System.Collections.Generic;

namespace MillionerTests
{
    [TestClass]
    public class QuestionTests
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

        [TestInitialize]
        public void RepositoryInitializeTest()
        {
            string filePath = "TestFile.xml";
            repository = new QuestionRepository(filePath);
            repository.SetCurrentQuestion();
            Assert.IsNotNull(repository);
        }
        [TestMethod]
        public void GetCurrentAnswerTest()
        {
            string expected = "На гуслях";
            string actual = repository.GetCurrentAnswer();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsUsedQuestionTest()
        {
            bool actual = repository.GetCurrentQuestion().isUsed;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ResetUsedQuestionTest()
        {
            repository.ResetUsedStatus();
            bool actual = repository.GetCurrentQuestion().isUsed;
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void GetQuestionTextTest()
        {
            string expected = "На каком инструменте, как считается, играл древнерусский певец и сказитель Боян?";
            Assert.AreEqual(expected, repository.GetQuestionText());
        }
        [TestMethod]
        public void GetQuestionAnswerChoiceTest()
        {
            bool actual = true;
            string[] newAnswers = repository.GetQuestionAnswerChoice();
            for (int i = 0; i < 4; i++)
                if (Array.IndexOf(newAnswers, repository.GetCurrentQuestion().GetAnswerChoice()[i]) == -1)
                    actual = false;
            Assert.IsTrue(actual);
        }

    }

    [TestClass]
    public class PlayerTests
    {
        Player player;

        [TestInitialize]
        public void PlayerInitializeTest()
        {
            player = new Player();
            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void IncreasePositivePointsTest()
        {
            player.IncresePoints(10);
            Assert.AreEqual(10, player.Points);
        }

        [TestMethod]
        public void IncreaseNegativePointsTest()
        {
            player.IncresePoints(-10);
            Assert.AreEqual(0, player.Points);
        }

        [TestMethod]
        public void ResetPointsTest()
        {
            player.IncresePoints(10);
            player.IncresePoints(5);
            player.ResetPoints();
            Assert.AreEqual(0, player.Points);
        }

    }

}
