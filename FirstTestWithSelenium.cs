using NUnit.Framework;
using FluentAssertions;
using OpenQA.Selenium.Chrome;

namespace nt_tests
{
    public class FirstTestWithSelenium
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Url.Should().Be("https://www.google.com/");
        }
    }
}