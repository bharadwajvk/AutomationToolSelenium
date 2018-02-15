using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary
{
    public class ShippingFormTest
    {
        public IWebDriver driver;
        public ShippingFormTest(IWebDriver driver1)
        {
            driver = driver1;
            IWebElement firstName = driver.FindElement(By.Id("sfcShippingInfo_txtShippingFirstName"));
            IWebElement lastName = driver.FindElement(By.Id("sfcShippingInfo_txtShippingLastName"));
            IWebElement email = driver.FindElement(By.Id("sfcShippingInfo_txtEmail"));
            IWebElement address1 = driver.FindElement(By.Id("sfcShippingInfo_txtShippingAddress1"));
            IWebElement city = driver.FindElement(By.Id("sfcShippingInfo_txtShippingCity"));
            IWebElement country = driver.FindElement(By.Id("sfcShippingInfo_ddlShippingCountry"));
            IWebElement state = driver.FindElement(By.Id("sfcShippingInfo_ddlShippingState"));
            IWebElement zipCode = driver.FindElement(By.Name("sfcShippingInfo$txtShippingZipCode"));
            IWebElement phoneNumber = driver.FindElement(By.Id("sfcShippingInfo_txtPhoneNumber"));
            
            if (firstName != null && lastName != null && email != null && address1 != null && city != null && country != null && state != null && zipCode != null && phoneNumber != null )
            {
                firstName.SendKeys("Test");
                lastName.SendKeys("Void");
                Random r = new Random();
                email.SendKeys("testing" + r.Next(10000).ToString() + "@vendocommerce.com");
                address1.SendKeys("11601 Wilshire Blvd");
                city.SendKeys("Los Angeles");
                country.FindElement(By.CssSelector("option[value='231']"));
                state.FindElement(By.CssSelector("option[value='5']"));

                state.SendKeys("California");
                try
                {
                    driver.FindElement(By.Id("sfcShippingInfo_txtShippingZipCode")).SendKeys("90067");
                    driver.FindElement(By.Id("sfcShippingInfo_txtPhoneNumber")).SendKeys("8787878787");
                }
                catch (Exception)
                {

                    driver.FindElement(By.Id("sfcShippingInfo_txtShippingZipCode")).SendKeys("90067");
                    driver.FindElement(By.Id("sfcShippingInfo_txtPhoneNumber")).SendKeys("8787878787");
                }
                
            }
        }

        public void TestShippingFormClick()
        {
            IWebElement orderNow = driver.FindElement(By.Id("sfcShippingInfo_imgBtn"));
            if (orderNow!=null)
            {
                orderNow.Click();
                System.Threading.Thread.Sleep(5000);
                if (driver.Url.Contains("cart"))
                {
                    Result r = new Result();
                    r.TestName = "Shipping Form Test on Home page";
                    r.TestResult = "Pass";
                    r.TestResultDetails = "All details tranfered to cart page successfully";
                    r.TestComments = "none";
                    Test.ResultList.Add(r);
                }
            }
           
        }
    }
}
