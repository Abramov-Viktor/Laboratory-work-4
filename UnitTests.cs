using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Millioner;

namespace MillionerTests
{
    [TestClass]
    public class UnitTests
    {
        
        [TestMethod]
        public void QuestionInitializeTest()
        {
            Question question = new Question();
            Assert.IsNotNull(question);
        }
    }
}
