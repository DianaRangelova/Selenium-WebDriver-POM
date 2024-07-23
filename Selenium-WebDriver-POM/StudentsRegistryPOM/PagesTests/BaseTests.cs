using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using StudentsRegistryPOM.Pages;

namespace StudentsRegistryPOM.Tests
{
    public class BaseTests
    { 
   protected IWebDriver driver;

    [OneTimeSetUp]
    public void Setup()
    {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:82/ ");
        }

    [OneTimeTearDown]
    public void ShutDown()
    {
        driver.Quit();
        driver.Dispose();
        }
}
}
