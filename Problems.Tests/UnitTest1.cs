using NUnit.Framework;
using Problems;
using System.Collections;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        [TestCaseSource(typeof(MyDataClass), "TestCases")]
        public string PrefixTest(string input)
        {
            Program P = new Program();
            string result = P.Prefix(input);
            return result;
        }
    }

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("").Returns("0,0:");
                yield return new TestCaseData("hello").Returns("5,1:hello");
                yield return new TestCaseData("what    ...  did you say?? ").Returns("27,5:what    ...  did you say?? ");
                yield return new TestCaseData("ba").Returns("2,1:ba");
                yield return new TestCaseData("chill mate").Returns("10,2:chill mate");
                yield return new TestCaseData(" ").Returns("1,0: ");
            }
        }
    }
}