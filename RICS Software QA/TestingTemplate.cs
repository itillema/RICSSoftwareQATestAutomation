using NUnit.Framework;

namespace RICS_Software_QA
{
    public class Tests
    {
        // AAA ("Triple A paradigm"): Integrated and End-to-End Testing:
        // Arrange (Setup)  Everything you'll need to setup the test
        // Act   (Test)  Running the method or making an action
        // Assert (Test)  Checking for a value to validate and pass the test

        //Hooks in NUnit
        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void Test1() //Test case names should exaplain what you're testing and what should happen... e.g.: CreateATitle_ShouldSetTitle(){}
        {
            Assert.Pass(); //See Assert definition to see what can be checked for with the NUnit class
        }
    }
}