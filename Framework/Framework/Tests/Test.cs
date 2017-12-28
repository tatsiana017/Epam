using Framework.CromeDriver;
using Framework.Pages;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.Tests
{
    /// <summary>
    /// Сводное описание для Test
    /// </summary>
    [TestClass]
    public class Test
    {
        public Test()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test1("Цюрих", "Вена", new DateTime(2017, 12, 29), new DateTime(2018, 01, 8), 2);

            Assert.IsTrue(page.IsTicketsListExist());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB1("Вена", "Москва", new DateTime(2017, 12, 29), new DateTime(2018, 01, 10), 2, 1, "Бизнес");

            Assert.IsTrue(page.IsTicketsListExist());

        }

        [TestMethod]
        public void TestMethod3()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB2("Варшава", "Москва", new DateTime(2017, 12, 29), new DateTime(2018, 01, 10), 3,4, 1, "Эконом");

            Assert.IsTrue(page.IsTicketsListExist());

        }

        [TestMethod]
        public void TestMethod4()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB3("Париж", "Москва", new DateTime(2017, 12, 29), 1, "Бизнес");

            Assert.IsTrue(page.IsTicketsListExist());

        }

        [TestMethod]
        public void TestMethod5()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB4("Милан", "Берлин", new DateTime(2017, 12, 29), new DateTime(2017, 12, 23), 3, 1, "Эконом");

            Assert.IsTrue(page.IsErrorExist());
        }

        [TestMethod]
        public void TestMethod6()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB5("Варшава", new DateTime(2017, 12, 29), new DateTime(2017, 12, 23), 1, "Эконом");

            Assert.IsTrue(page.IsErrorExist());
        }

        [TestMethod]
        public void TestMethod7()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB6("Варшава", "Москва", "Москва", "Милан", new DateTime(2017, 12, 29), new DateTime(2017, 12, 31), 1, "Бизнес");
            Assert.IsTrue(page.IsTicketsListExist());

        }

        [TestMethod]
        public void TestMethod8()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB7("Минск", "Лос-Анджелес", new DateTime(2017, 12, 29), new DateTime(2017, 12, 31), 2, 2, 1, "Эконом");

            Assert.IsTrue(page.IsErrorExist()); Assert.IsTrue(page.IsErrorExist());
        }

        [TestMethod]
        public void TestMethod9()
        {
            var driver = DriverInstance.GetInstance();
            BookingPage page = new BookingPage(driver);
            page.OpenPage();
            page.TestB8("Москва", "Париж", new DateTime(2017, 12, 28), new DateTime(2017, 12, 31), 2, 10, "Первый");

            Assert.IsTrue(page.IsErrorExist());
        }

        [TestMethod]
        public void TestMethod10()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test10("Париж", "Москва", new DateTime(2017, 12, 29), new DateTime(2018, 01, 04), 2, 1, 1);

            Assert.IsTrue(page.IsTicketsListExist());
        }
    }
}
