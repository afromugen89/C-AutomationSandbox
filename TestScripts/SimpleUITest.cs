using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreFrameWork;
using CoreFrameWork.GooglePageObject;
using CoreFrameWork.Extension;

namespace TestScripts
{
    [TestClass]
    public class SimpleSearch : TestInit
    {
        
        [TestMethod]
        public void SearchAndValidate()
        {
            SelectBrowser((int)Browser.Chrome);

            browser.FindElement(GooglePageObjects.searchBox).SendKeys("topdanmark");

            ExtensionClass.FindElement(GooglePageObjects.dropdownResultList,browser);

            string topResult = browser.FindElement(GooglePageObjects.dropdownResultList).Text;

            Assert.AreEqual("topdanmark", topResult);
            
        }

        [TestMethod]
        public void OpenWebPageOnChrome()
        {
            SelectBrowser((int)Browser.Chrome);

            browser.Navigate().GoToUrl(TopdanmarkPageObject.topdanmarkurl);

            try
            {
                ExtensionClass.FindElement(TopdanmarkPageObject.topdanmarkLogo,browser);
            }
            catch
            {
                Assert.Fail("Not able to load the webpage on Chrome");
            }
        }

        [TestMethod]
        public void OpenWebPageOnFireFox()
        {
            SelectBrowser((int)Browser.Firefox);

            browser.Navigate().GoToUrl(TopdanmarkPageObject.topdanmarkurl);

            try
            {
                ExtensionClass.FindElement(TopdanmarkPageObject.topdanmarkLogo, browser);
            }
            catch
            {
                Assert.Fail("Not able to load the webpage on Firefox");
            }
        }
    }
}
