using OpenQA.Selenium;

namespace CoreFrameWork.GooglePageObject
{
    public static class GooglePageObjects
    {
        
        public static By searchBox = By.CssSelector("input[title='Search']");

        public static By dropdownResultList = By.CssSelector("ul[class='erkvQe'] > li:nth-child(1) >div >div span");

        
    }
}
