using System;
using System.Collections;
using NUnit.Framework;

namespace LShift{
    [TestFixture]
    class Tests{
        public static IEnumerable TestCases()
        {
            yield return (0,0);
            yield return (5,2);
            yield return (8,1);
            yield return (15,4);
            yield return (19,3);
            yield return (1000000,7);
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public static void Population_count_returns_correct_results(ValueTuple<int, int> testCase)
        {
            var res =Interview.Population_count(testCase.Item1);
            Assert.AreEqual(testCase.Item2,res);
        }
    }
}