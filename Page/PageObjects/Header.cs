﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page
{
    public class Header : BasePage
    {
        public Header(IWebDriver browser) : base(browser)
        {
        }

        public IWebElement SearchBox => driver.FindElement(By.XPath("//input[contains(@name, 'query')]"));
    }
}
