using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    class BookingPage
    {
        private const string BASE_URL = "https://www.swiss.com/pl/ru/Book/Flight/";

        [FindsBy(How = How.XPath, Using = "//input[@id='SearchODCalenderModel_SearchCriteria_Origin']")]
        private IWebElement inputFlightOrigin;

        [FindsBy(How = How.XPath, Using = "//input[@id='SearchODCalenderModel_SearchCriteria_Destination']")]
        private IWebElement inputFlightDestination;

        [FindsBy(How = How.Id, Using = "tabs_1_0")]
        private IWebElement returnButton;

        [FindsBy(How = How.Id, Using = "tabs_1_1")]
        private IWebElement singleButton;

        [FindsBy(How = How.Id, Using = "tabs_1_2")]
        private IWebElement multipleDestinationsButton;

        [FindsBy(How = How.Id, Using = "open_jaw_from_0")]
        private IWebElement inputFrom0;

        [FindsBy(How = How.Id, Using = "open_jaw_from_1")]
        private IWebElement inputFrom1;

        [FindsBy(How = How.Id, Using = "open_jaw_to_0")]
        private IWebElement inputTo0;

        [FindsBy(How = How.Id, Using = "open_jaw_to_1")]
        private IWebElement inputTo1;

        [FindsBy(How = How.Id, Using = "open_jaw_date_0")]
        private IWebElement dateFrom0;

        [FindsBy(How = How.Id, Using = "open_jaw_date_1")]
        private IWebElement dateFrom1;

        [FindsBy(How = How.XPath, Using = "//input[@id='datefrom']")]
        private IWebElement dateFrom;

        [FindsBy(How = How.XPath, Using = "//input[@id='dateto']")]
        private IWebElement dateTo;

        [FindsBy(How = How.XPath, Using = "//input[@id='SearchPaxClassAirlineModel_FlightServiceSearchCriteria_ServiceClassString']")]
        private IWebElement inputClass;

        [FindsBy(How = How.XPath, Using = "//input[@id='SearchPaxClassAirlineModel_FlightServiceSearchCriteria_IncludeLufthansa']")]
        private IWebElement inputTab;


        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-large btn-red btn-link r-float']")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.XPath, Using = "//button[@class='book-bundle-button btn  is-type-economy js-book-bundling--button']")]
        private IWebElement buttonClass;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-large btn-submit']")]
        private IWebElement buttonR;


        private IWebDriver driver;

        public BookingPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(this.driver, this);

        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void SelectAdult(int count)
        {
            SelectElement selectAdult = new SelectElement(driver.FindElement(By.Id("SearchPaxClassAirlineModel_PaxSelectionModel_SearchCriteria_Adults")));
            selectAdult.SelectByText(Convert.ToString(count));
        }

        public void SelectChildren(int count)
        {
            SelectElement selectChildren = new SelectElement(driver.FindElement(By.Id("SearchPaxClassAirlineModel_PaxSelectionModel_SearchCriteria_Children")));
            selectChildren.SelectByText(Convert.ToString(count));
        }

        public void SelectInfants(int count)
        {
            SelectElement selectInfant = new SelectElement(driver.FindElement(By.Id("SearchPaxClassAirlineModel_PaxSelectionModel_SearchCriteria_Infants")));
            selectInfant.SelectByText(Convert.ToString(count));
        }

        public void SelectTypeClass(string typClass)
        {
            SelectElement selectClass = new SelectElement(driver.FindElement(By.Id("SearchPaxClassAirlineModel_FlightServiceSearchCriteria_ServiceClassString")));
            selectClass.SelectByText(typClass);
        }

        public void TestB1(string origin, string destination, DateTime departDate, DateTime returnDate, int countAdult, int countChildren, string typeClass)
        {
            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectChildren(countChildren);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB2(string origin, string destination, DateTime departDate, DateTime returnDate, int countAdult, int countChildren, int countInfant, string typeClass)
        {
            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectChildren(countChildren);
            SelectInfants(countInfant);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB3(string origin, string destination, DateTime departDate, int countAdult, string typeClass)
        {

            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            singleButton.Click();
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));

            SelectAdult(countAdult);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB4(string origin, string destination, DateTime departDate, DateTime returnDate, int countAdult, int countChild, string typeClass)
        {

            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectChildren(countChild);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB5(string origin, DateTime departDate, DateTime returnDate, int countAdult, string typeClass)
        {

            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }


        public void TestB6(string origin, string depart, string origin1, string depart1, DateTime departDate, DateTime returnDate, int countAdult, string typeClass)
        {
            multipleDestinationsButton.Click();
            inputFrom0.Clear();
            inputFrom0.SendKeys(origin);
            inputTo0.Clear();
            inputTo0.SendKeys(depart);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom0.Clear();
            dateFrom0.SendKeys(Convert.ToString(departDate));

            inputFrom1.Clear();
            inputFrom1.SendKeys(origin1);
            inputTo1.Clear();
            inputTo1.SendKeys(depart1);
            dateFrom1.Clear();
            dateFrom1.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB7(string origin, string destination, DateTime departDate, DateTime returnDate, int countAdult, int countChildren, int countInfant, string typeClass)
        {
            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectChildren(countChildren);
            SelectInfants(countInfant);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public void TestB8(string origin, string destination, DateTime departDate, DateTime returnDate, int countAdult, int countInfant, string typeClass)
        {
            inputFlightOrigin.Clear();
            inputFlightOrigin.SendKeys(origin);
            inputFlightDestination.Clear();
            inputFlightDestination.SendKeys(destination);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateFrom.Clear();
            dateFrom.SendKeys(Convert.ToString(departDate));
            dateTo.Clear();
            dateTo.SendKeys(Convert.ToString(returnDate));

            SelectAdult(countAdult);
            SelectInfants(countInfant);
            SelectTypeClass(typeClass);

            buttonSearch.Click();
        }

        public bool IsErrorExist()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return null!= driver.FindElement(By.XPath("//*[@id=\"GlobalNotificationBar\"]/div"))? true: false;
        }

        public bool IsTicketsListExist()
        {
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            var ticketsList = driver.FindElements(By.XPath("//div[@class=\"book_bundle_row has-urgencysense has-2classes  js-book-bundling--row\"]"));
            return ticketsList.Count > 0 ? true : false;
        }

    }
}
