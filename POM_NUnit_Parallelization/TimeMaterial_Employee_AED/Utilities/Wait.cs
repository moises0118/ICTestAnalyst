﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMaterialAED.Utilities
{
    class Wait
    {

        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locator == "XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));

            }

            if (locator == "id")

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));

            if (locator == "cssSelector")

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

        }




  



    }
}
