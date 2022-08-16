using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Millioner;

namespace MillionerTests
{
    [TestClass]
    public class UnitTests
    {
        Question question;

        [TestInitialize]
        public void QuestionInitializeTest()
        {
            question = new Question();
            Assert.IsNotNull(question);
        }

        [TestMethod]
        public void GetAnswerTest()
        {
            string expected = "Answer";
            Assert.AreEqual(expected, question.GetAnswer());
        }
        [TestMethod]
        public void GetQuestion()
        {
            string expected = "Question";
            Assert.AreEqual(expected, question.GetQuestion());
        }
    }
}
