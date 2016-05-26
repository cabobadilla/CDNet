using WebApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for _DefaultTest and is intended
    ///to contain all _DefaultTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _DefaultTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for num
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\luis.f.ronquillo\\Documents\\GitHub\\NEtJenkinsTest\\NetProjTest\\WebApplication1", "/")]
        [UrlToTest("http://localhost:31991")]
        public void numTest()
        {
            _Default target = new _Default();
               // TODO: Initialize to an appropriate value
            double expected = 7777F; // TODO: Initialize to an appropriate value
            double actual;
            target.num = expected;
            actual = target.num;
            Assert.AreNotEqual(expected, actual);            
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
