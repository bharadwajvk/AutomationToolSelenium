using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Test
    {
        private static string path = System.AppDomain.CurrentDomain.BaseDirectory.Replace(@"\\", @"\");

        public static List<Result> ResultList = new List<Result>();
        // create the reference for our browser

        IWebDriver driver = new ChromeDriver(path);
		

      

        [SetUp]
        public void Initialize(string websiteUrl,string fulfillmentTesting, string paymentTesting, string creditCardTesting)
        {
             ResultList = new List<Result>() ;
            // navigate to the website page
            driver.Navigate().GoToUrl(websiteUrl);

            // IF there is any email pop up close it

            //IWebElement emailpopup = driver.FindElement(By.ClassName("ltkmodal-close"));

            //if (emailpopup!=null)
            //{
            //    emailpopup.Click();
            //}

            //order now button clicked on home page
            //driver.FindElement(By.XPath("//a[@href='cart']")).Click();

            //find shipping the element
            IWebElement element = driver.FindElement(By.Id("sfcShippingInfo_dSForm"));

            if (element!=null)
            {
                ShippingFormTest shippingFormTest = new ShippingFormTest(driver);
                shippingFormTest.TestShippingFormClick();
            }

            // testing the cart flow
            System.Threading.Thread.Sleep(5000);
            CartPageTest cartTest = new CartPageTest(driver);
            cartTest.TestCartClick();


            System.Web.HttpContext.Current.Session["ResultList"] = ResultList;

            // closing the browser
            Cleanup();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
    public class Result
    {
        public string TestName { get; set; }
        public string TestResult { get; set; }
        public string TestResultDetails { get; set; }
        public string TestComments { get; set; }

    }
}
