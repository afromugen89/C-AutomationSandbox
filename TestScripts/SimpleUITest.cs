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
            SelectBrowser((int)Browser.IE);

            browser.FindElement(GooglePageObjects.searchBox).SendKeys("topdanmark");

            ExtensionClass.FindElement(GooglePageObjects.dropdownResultList,browser);

            string topResult = browser.FindElement(GooglePageObjects.dropdownResultList).Text;

            Assert.AreEqual("topdanmark", topResult);
            
        }
    }
}
