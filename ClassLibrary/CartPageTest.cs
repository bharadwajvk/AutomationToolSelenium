using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary
{
    public class CartPageTest
    {
        public IWebDriver driver;
        public CartPageTest(IWebDriver driver1)
        {
            driver = driver1;

            try
            {

                driver.FindElement(By.Id("sbcfShippingBillingCreditForm_ddlPaymentMethod")).FindElement(By.CssSelector("option[value='1']"));
                driver.FindElement(By.Id("sbcfShippingBillingCreditForm_ddlPaymentMethod")).SendKeys("Credit Card");
            }
            catch (Exception)
            {
                try
                {
                    if (driver.FindElement(By.Id("sbcfShippingBillingCreditForm_ddlPaymentMethod")) != null)
                    {
                        driver.FindElement(By.Id("sbcfShippingBillingCreditForm_ddlPaymentMethod")).FindElement(By.CssSelector("option[value='1']"));
                    }
                }
                catch (Exception)
                {
                    
                    //
                }
               
                
            }


            //IWebElement firstName = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtFirstName"));
            //IWebElement lastName = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtLastName"));
            //IWebElement email = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtEmail"));
            //IWebElement address1 = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtAddress1"));
            //IWebElement city = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtCity"));
            //IWebElement country = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$ddlCountry"));
            //IWebElement state = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$ddlState"));
            //try
            //{
            //    IWebElement zipCode = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtZipCode"));
            //}
            //catch (Exception)
            //{

            //    IWebElement zipCode = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtZipCode"));
            //}
            
            //IWebElement phoneNumber = driver.FindElement(By.Id("sbcfShippingBillingCreditForm_txtPhoneNumber"));
            
           // if (firstName != null && lastName != null && email != null && address1 != null && city != null && country != null && state != null && phoneNumber != null )
           // {
                //if (firstName.Text=="" ||lastName.Text=="" || email.Text=="" ||address1.Text=="" ||city.Text=="" ||country.Text=="" ||state.Text=="" ||phoneNumber.Text=="")
                //{
                //    firstName.SendKeys("Test");
                //    lastName.SendKeys("Void");
                //    Random r = new Random();
                //    email.SendKeys("testing" + r.Next(10000).ToString() + "@vendocommerce.com");
                //    address1.SendKeys("11601 Wilshire Blvd");
                //    city.SendKeys("Los Angeles");
                //    country.FindElement(By.CssSelector("option[value='231']"));
                //    state.FindElement(By.CssSelector("option[value='5']"));

                //    state.SendKeys("California");
                //    try
                //    {
                //        driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtZipCode")).SendKeys("90067");
                //        driver.FindElement(By.Id("sbcfShippingBillingCreditForm_txtPhoneNumber")).SendKeys("8787878787");
                //    }
                //    catch (Exception)
                //    {

                //        driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtZipCode")).SendKeys("90067");
                //        driver.FindElement(By.Id("sbcfShippingBillingCreditForm_txtPhoneNumber")).SendKeys("8787878787");
                //    }
                //}
                System.Threading.Thread.Sleep(3000);
                try
                {
                    driver.FindElement(By.Id("bio_ep_close")).Click();

                }
                catch (Exception)
                {

                    //throw;
                }
                IWebElement creditCard = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtCCNumber1"));
                creditCard.SendKeys("4444333322221111");
                System.Threading.Thread.Sleep(2000);
                try
                {
                    driver.FindElement(By.Id("bio_ep_close")).Click();

                }
                catch (Exception)
                {

                    //throw;
                }
                IWebElement cvv = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$txtCvv"));
                cvv.SendKeys("121");
                IWebElement expiryMonth = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$ddlExpMonth"));
                expiryMonth.FindElement(By.CssSelector("option[value='08']"));

                expiryMonth.SendKeys("11");
                IWebElement expiryYear = driver.FindElement(By.Name("sbcfShippingBillingCreditForm$ddlExpYear"));
                expiryYear.FindElement(By.CssSelector("option[value='2022']"));

                expiryYear.SendKeys("2022");

                try
                {
                    driver.FindElement(By.Name("sbcfShippingBillingCreditForm$cbxAgree")).Click();
                }
                catch (Exception)
                {
                    
                   // throw;
                }
            //}
        }

        public void TestCartClick()
        {
            IWebElement orderNow = driver.FindElement(By.Id("sbcfShippingBillingCreditForm_imgBtn"));
            if (orderNow!=null)
            {

                System.Threading.Thread.Sleep(2000);
                try
                {
                    driver.FindElement(By.Id("bio_ep_close")).Click();

                }
                catch (Exception)
                {

                    //throw;
                }
                orderNow.Click();
                System.Threading.Thread.Sleep(3000);
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        driver.FindElement(By.ClassName("btn_no")).Click();
                    }
                    catch (Exception)
                    {
                        
                        //throw;
                    }
                }
                if (driver.Url.Contains("receipt"))
                {
                    Result r = new Result();
                    r.TestName = "Test order in Cart Page";
                    r.TestResult = "Pass";
                    r.TestResultDetails = "Order is placed";
                    r.TestComments = "none";
                    Test.ResultList.Add(r);
                }
            }
           
        }
    }
}
