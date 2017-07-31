﻿using OpenQA.Selenium;

namespace Page
{
    public class Header : BasePage    {
        
        public Header(IWebDriver browser) : base(browser)
        {
        }
        
        public IWebElement SearchBox => driver.FindElement(By.XPath("//input[contains(@name, 'query')]"));
    }
}
