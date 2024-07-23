using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace SumNumberPage
{
    public class SumNumberPageTests
    {
        private ChromeDriver driver;
        private SumNumberPage sumpage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver ();
            driver.Navigate().GoToUrl("https://fe5c1260-8638-4757-b08c-3882eb82e7d6-00-3pfhxp34ym0xb.spock.replit.dev/");
            sumpage = new SumNumberPage(driver);
            sumpage.OpenPage();
        }

        [TearDown]
        public void Close()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }


        [Test]
        public void Test_Valid_Numbers()
        {
            var sumpage = new SumNumberPage(driver);
            sumpage.OpenPage();
            var result = sumpage.AddNumbers("5", "6");
            Assert.That(result, Is.EqualTo("Sum: 11"));
        }

        [Test]
        public void Test_AddTwoNumbers_Invalid()
        {
            var sumpage = new SumNumberPage(driver);
            sumpage.OpenPage();
            string resultText = sumpage.AddNumbers("hello", "world");
            Assert.That(resultText, Is.EqualTo("Sum: invalid input"));
        }

        [Test]
        public void Test_AddTwoNumbers_Reset()
        {
            
            sumpage.AddNumbers("5", "7");
            bool isFormEmpty = sumpage.IsFormEmpty();
            Assert.That(isFormEmpty, Is.False);
            sumpage.ResetForm();
            isFormEmpty = sumpage.IsFormEmpty();
            Assert.That(isFormEmpty, Is.True);
        }


    }
}
