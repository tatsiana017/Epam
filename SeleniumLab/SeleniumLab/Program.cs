using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLab
{
    class Program
    {
        private static IWebDriver chromeDriver;
        static void Main(string[] args)
        {
            try
            {
                chromeDriver = new ChromeDriver(@"D:\4 course\epam\geckoandchrome");
                chromeDriver.Navigate().GoToUrl("https://vk.com/");
                chromeDriver.FindElement(By.Id("index_email")).SendKeys("Tatsiana");
                chromeDriver.FindElement(By.Id("index_pass")).SendKeys("ILoveAndrew");
                chromeDriver.FindElement(By.XPath("//button[@id='index_login_button']")).Click();
                System.Threading.Thread.Sleep(10000);
                if (chromeDriver != null)
                    chromeDriver.Quit();
            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
                throw;
            }
            
        }
    }
}
