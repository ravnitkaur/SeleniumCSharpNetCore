﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesForceNetCore
{
    public class CustomControls : DriverHelper
    {

        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
        }
    }
}
