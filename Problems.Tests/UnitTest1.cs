using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program P = new Program();
            string result1 = P.Prefix("");
            Assert.AreEqual("0,0:", result1);
        }

        [Test]
        public void Test2()
        {
            Program P = new Program();
            string result2 = P.Prefix("hello");
            Assert.AreEqual("5,1:", result2);
        }

        [Test]
        public void Test3()
        {
            Program P = new Program();
            string result3 = P.Prefix("what    ...  did you say?? ");
            Assert.AreEqual("27,5:", result3);
        }
    }
}