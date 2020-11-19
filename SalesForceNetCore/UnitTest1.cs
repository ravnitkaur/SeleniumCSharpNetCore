using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SalesForceNetCore
{
    public class Tests : DriverHelper
    {
        private readonly string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      
        [SetUp]
        public void Setup()
        {
           
        Console.WriteLine("Set up");
        
        //ChromeOptions options = new ChromeOptions
        //{   
        //    BinaryLocation = @"C:\Users\RKAUR\source\repos\SalesForceNetCore\SalesForceNetCore\Drivers"
        // };

        driver = new ChromeDriver(driverPath);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            CustomControls.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");

           
            Console.WriteLine("Test 1");
            Assert.Pass();
        }
    }
}