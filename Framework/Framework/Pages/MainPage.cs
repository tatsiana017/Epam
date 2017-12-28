using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.swiss.com/";

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightOrigin']")]
        private IWebElement inputFlightOrigin;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightDestination']")]
        private IWebElement inputFlightDestination;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightOutboundDate']")]
        private IWebElement inputFlightOutboundDate;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightInboundDate']")]
        private IWebElement inputFlightInboundDate;
       
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightAdults']")]
        private IWebElement inputFlightAdults;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightChildren']")]
        private IWebElement inputFlightChildren;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightInfant']")]
        private IWebElement inputFlightInfant;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"bookingbar - flight\"]/form/div[2]/div/div[4]/button")]
        private IWebElement SearchButton;

        [FindsBy(How = How.Id, Using = "tabs_1_1")]
        private IWebElement buttonHotel;

        [FindsBy(How = How.Id, Using = "HotelDestination")]
        private IWebElement inputDestinationHotel;

        [FindsBy(How = How.Id, Using = "HotelCheckInDate")]
        private IWebElement HotelCheckInDate;

        [FindsBy(How = How.Id, Using = "HotelCheckOutDate")]
        private IWebElement HotelCheckOutDate;

        [FindsBy(How = How.Id, Using = "q-rooms-adults-1")]
        private IWebElement HotelCheckRoom1;

        [FindsBy(How = How.Id, Using = "q-rooms-adults-2")]
        private IWebElement HotelCheckRoom2;

        [FindsBy(How = How.XPath, Using = "//button[@class='evo-time_select--popup--button js-evo-time_select--close']")]
        private IWebElement buttonClose;



        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickButton()
        {
            SearchButton.Click();
        }
        

        public void SelectRoom(string room)
        {
            SelectElement selectRoom = new SelectElement(driver.FindElement(By.Id("bookingbar-hotel")));
            selectRoom.SelectByText(room);
            
        }

        public void Test1(string origin, string destination, DateTime departDate, DateTime returnDate, int count)
        {
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.SendKeys(destination);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            inputFlightOutboundDate.Clear();
            inputFlightOutboundDate.SendKeys(Convert.ToString(departDate));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            inputFlightInboundDate.Clear();
            inputFlightInboundDate.SendKeys(Convert.ToString(returnDate));
            inputFlightInboundDate.SendKeys(Keys.Tab);
            inputFlightAdults.SendKeys(Convert.ToString(count));
            inputFlightAdults.SendKeys(Keys.Enter);
        }

        public void Test10(string origin, string destination, DateTime departDate, DateTime returnDate, int countA, int countC, int countI)
        {
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.SendKeys(destination);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            inputFlightOutboundDate.Clear();
            inputFlightOutboundDate.SendKeys(Convert.ToString(departDate));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            inputFlightInboundDate.Clear();
            inputFlightInboundDate.SendKeys(Convert.ToString(returnDate));
            inputFlightInboundDate.SendKeys(Keys.Tab);
            inputFlightAdults.SendKeys(Convert.ToString(countA));
            inputFlightAdults.SendKeys(Keys.Tab);
            inputFlightChildren.SendKeys(Convert.ToString(countC));
            inputFlightChildren.SendKeys(Keys.Tab);
            inputFlightInfant.SendKeys(Convert.ToString(countI));
            inputFlightInfant.SendKeys(Keys.Enter);
        }

        public bool IsTicketsListExist()
        {
            var ticketsList = driver.FindElements(By.XPath("//div[@class=\"book_bundle_row has-urgencysense has-2classes  js-book-bundling--row\"]"));
            return ticketsList.Count > 0 ? true : false;
        }
    }



}

