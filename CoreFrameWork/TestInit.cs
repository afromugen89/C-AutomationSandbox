using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoreFrameWork
{
    public class TestInit
    {
        
        private readonly string initUrl = "https://www.google.com";

        public IWebDriver browser;

        public enum Browser {Chrome,Firefox,IE }

        public IWebDriver SelectBrowser(int browsertype)
        {
            int selectedBrowser = browsertype;

            switch (selectedBrowser)
            {
                case 0:
                    browser = new ChromeDriver();
                    break;
                case 1:
                    browser = new FirefoxDriver();
                    break;
                case 2:
                    browser = new InternetExplorerDriver();
                    break;
            }

            browser.Manage().Window.Maximize();

            browser.Navigate().GoToUrl(initUrl);

            return browser;
        }

        [TestCleanup]
        public void TestTearDown()
        {
            browser.Close();
        }

    }
}
