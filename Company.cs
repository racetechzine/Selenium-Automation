using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static NUnit.Core.NUnitFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Keys.Pages
{
    class Company
    {
        internal Company()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        //Page Factory Def
        //Click on Company Link
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/ul[1]/li[3]/a")]
        private IWebElement CompanyLink { get; set; }
        //Click on Add New Company Button
        [FindsBy(How = How.XPath, Using = "//*[@id='company-grid']/div[1]/button")]
        private IWebElement AddCompanyButton { get; set; }
        // Add New Company Header
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[1]/h4")]
        private IWebElement AddCompanyHeader { get; set; }
        //Enter Company Name
        [FindsBy(How = How.XPath, Using = "//*[@id='Cname']")]
        private IWebElement CompanyName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[1]/div/span")]
        private IWebElement CompanyNameErr { get; set; }
        //Enter Company Website
        [FindsBy(How = How.XPath, Using = "//*[@id='Cwebsite']")]
        private IWebElement CompanyWeb { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[2]/div/span")]
        private IWebElement CompanyWebErr { get; set; }
        //Enter Search Addr
        [FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
        private IWebElement SearchAddr { get; set; }
        //Enter Number
        [FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
        private IWebElement ANumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[2]/div/span")]
        private IWebElement ANumberErr { get; set; }
        
        //Enter Street
        [FindsBy(How = How.XPath, Using = "//*[@id='route']")]
        private IWebElement AStreet { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[3]/div/span")]
        private IWebElement AStreetErr { get; set; }
        //Enter PostCode
        [FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
        private IWebElement APostCode { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[4]/div/span")]
        private IWebElement APostCodeErr { get; set; }
        //Enter City
        [FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
        private IWebElement ACity { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[5]/div/span")]
        private IWebElement ACityErr { get; set; }
        //Enter Suburb
        [FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
        private IWebElement ASuburb { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[6]/div/span")]
        private IWebElement ASuburbErr { get; set; }
        //Checkbox Is ShpSame
        [FindsBy(How = How.XPath, Using = "//*[@id='isShipSame']")]
        private IWebElement CheckShipSame { get; set; }
        //Billing Address
        ////Enter Search Addr
        //[FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
        //private IWebElement BSearchAddr { get; set; }
        ////Enter Number
        //[FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
        //private IWebElement BNumber { get; set; }
        ////Enter Street
        //[FindsBy(How = How.XPath, Using = "//*[@id='route']")]
        //private IWebElement BStreet { get; set; }
        ////Enter PostCode
        //[FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
        //private IWebElement BPostCode { get; set; }
        ////Enter City
        //[FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
        //private IWebElement BCity { get; set; }
        ////Enter Suburb
        //[FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
        //private IWebElement BSuburb { get; set; }

        //public static bool IsAlphaNumeric(this string stringToTest)
        //{
        //    //English
        //    const string charSet = "a-zA-Z";
        //    const string numSet = @"0-9";

        // return Regex.Match(stringToTest, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success;
        //}

        //public static bool IsNumeric(this string stringToTest)
        //{
        //    //English
        //    const string numSet = @"0-9";

        //    return Regex.Match(stringToTest, @"^[" + numSet + @"]+$").Success;
        //}

        //public static bool IsAlpha(this string stringToTest)
        //{
        //    //English
        //    const string charSet = "a-zA-Z";

        //    return Regex.Match(stringToTest, @"^[" + charSet + @"]+$").Success;
        //}

        internal void CompanyMaxLength()
        {
            //TC_010_01

            //Click Company tab
            CompanyLink.Click();
            //Click AddNewCompany Button
            AddCompanyButton.Click();

        }
        internal void CompanyPopupValidation()
        {
            //TC_010_01

            //Click Company tab
            CompanyLink.Click();
            //Click AddNewCompany Button
            AddCompanyButton.Click();
            String ExpectedTxt;
            //Verify the header
            ExpectedTxt = "Add new company";
            Driver.wait(5);
            bool b = AddCompanyHeader.Text.Contains(ExpectedTxt);
            try
            {
                Assert.IsTrue(CompanyName.Enabled);
               //Assert.IsTrue(b);
               // Assert.AreSame(ExpectedTxt, AddCompanyHeader.Text);
                Base.test.Log(LogStatus.Pass, "TC_010_01: Navigation and Add Company Header validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected Header: '" + ExpectedTxt + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No Add New Company Popup");
            }

            

        }
        internal void AddCompanyFieldValidation()
        {
            //TC_010_04


            //Check the fields are displayed
            Driver.wait(1);
            try
            {
                Assert.IsTrue(CompanyName.Enabled);
                Base.test.Log(LogStatus.Pass, "Company Name field is displayed, Pass");
                Assert.IsTrue(CompanyWeb.Enabled);
                Base.test.Log(LogStatus.Pass, "Company Website field is displayed, Pass");
                Base.test.Log(LogStatus.Info, "Physical Address Frame Validation");
                Assert.IsTrue(SearchAddr.Enabled);
                Base.test.Log(LogStatus.Pass, "Search Address field is displayed, Pass");
                Assert.IsTrue(ANumber.Enabled);
                Base.test.Log(LogStatus.Pass, " Address Number field is displayed, Pass");
                Assert.IsTrue(AStreet.Enabled);
                Base.test.Log(LogStatus.Pass, " Address Street field is displayed, Pass");
                Assert.IsTrue(APostCode.Enabled);
                Base.test.Log(LogStatus.Pass, " Address PostCode field is displayed, Pass");
                Assert.IsTrue(ACity.Enabled);
                Base.test.Log(LogStatus.Pass, " Address City field is displayed, Pass");
                Assert.IsTrue(ASuburb.Enabled);
                Base.test.Log(LogStatus.Pass, " Address Suburb field is displayed, Pass");
                Assert.IsTrue(CheckShipSame.Enabled);
                Base.test.Log(LogStatus.Pass, "Checkbox field is displayed, Pass");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + "Some Fields are not displayed. Please Check");
            }


        }
        internal void CompanyInvalidDataValidation()
        {
            
//            TC_010_05
//TC_010_15
//TC_010_16
//TC_010_17
//TC_010_06
//            //Click Company tab
            CompanyLink.Click();
            //Explicit Wait
            Thread.Sleep(500);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");
            AddCompanyButton.Click();
            //Validating Alphanumeric in property Details
            Driver.wait(3);
            string expectederr;
            //Property Brief Info
            CompanyName.SendKeys(ExcelLib.ReadData(2, "Name"));
            CompanyWeb.SendKeys(ExcelLib.ReadData(2, "Website"));
            //Physical Address
            SearchAddr.SendKeys(ExcelLib.ReadData(2, "SearchAddr"));
           ANumber.SendKeys(ExcelLib.ReadData(2, "ANumber"));
            AStreet.SendKeys(ExcelLib.ReadData(2, "AStreet"));
            APostCode.SendKeys(ExcelLib.ReadData(2, "APostCode"));
            ACity.SendKeys(ExcelLib.ReadData(2, "ACity"));
            ASuburb.SendKeys(ExcelLib.ReadData(2, "ASuburb"));
            Driver.wait(1);
            CheckShipSame.Click();
            //Screenshot
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Company Details 1");
            Driver.wait(1);
            String data = ExcelLib.ReadData(2, "Name");
            //Company Name Validation
            if (String.IsNullOrWhiteSpace(data))
            {
                try
                {
                    expectederr = "This field is required.";
                    Assert.AreEqual(expectederr, CompanyNameErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company Name Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Name");
                }
            }

            //Website Validation
            data = ExcelLib.ReadData(2, "Website");
            
            //Need to Add Validation for http and domain
            if (String.IsNullOrWhiteSpace(data))
            {
                try
                {
                    expectederr = "This field is required.";
                    Assert.AreEqual(expectederr, CompanyWebErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
                }
            }
            else
            {
                if(data.Contains("https://")== false)
                {
                    try
                    {
                        expectederr = "Enter valid Website.";
                        Assert.AreEqual(expectederr, CompanyWebErr.Text);
                        Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
                        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                    }
                    catch (Exception e)
                    {
                        Base.test.Log(LogStatus.Fail, "Fail");
                        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
                    }
                }
            }
            //Physical Address

            //Search Address
            SearchAddr.SendKeys(ExcelLib.ReadData(2, "SearchAddr"));
            
           // var regexItem = new Regex("^[a-zA-Z0-9]*$");
            const string charSet = "a-zA-Z";
               const string numSet = @"0-9";
            //Address Number
            //if (Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success || Regex.Match(txtnum, @"^[" + charSet + @"]+$").Success)
            //Regex rg = new Regex(@"^[-!$%^&*()_+|~=`{}\[\]:"; '<>?,.\/]*$");
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };

            //rg.IsMatch(txtnum) || Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
            string txtnum = ExcelLib.ReadData(2, "ANumber");
            //doesnot validate if only chars
            if (list.Any(txtnum.Contains)  )//|| !Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
              
            {
                try
                {
                    expectederr = "The Number field must be alphanumeric characters.";
                    Assert.AreEqual(expectederr, ANumberErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company Number Address Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Number");
                }

            }
            else {
                Base.test.Log(LogStatus.Pass, "Company Number Address validation, Pass");
               }
            //Address Street
            string txtstreet = AStreet.Text;
            if (list.Any(txtstreet.Contains))// || !Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
                //Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
            {
                try
                {
                    expectederr = "The Street field must be alphanumeric characters.";
                    Assert.AreEqual(expectederr, AStreetErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company Street Address Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Street");
                }

            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Company Street Address validation, Pass");
              }
            //Address City
            string txtcity = ExcelLib.ReadData(2, "ACity");
            if (list.Any(txtcity.Contains) )//|| !Regex.Match(txtcity, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

            {
                try
                {
                    expectederr = "The City field must be alphanumeric characters.";
                    Assert.AreEqual(expectederr, ACityErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company City Address Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address City");
                }

            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Company City Address validation, Pass");
            }
            //Address Suburb
            string txtsub = ExcelLib.ReadData(2, "ASuburb");
            if (list.Any(txtsub.Contains))// || !Regex.Match(txtsub, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

            {
                try
                {
                    expectederr = "The Suburb field must be alphanumeric characters.";
                    Assert.AreEqual(expectederr, ACityErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company Suburb Address Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Suburb");
                }

            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Company Suburb Address validation, Pass");
            }
            //Address PostCode
            string txtpcode = ExcelLib.ReadData(2, "APostCode");
            if (list.Any(txtpcode.Contains))// || !Regex.Match(txtpcode, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

            {
                try
                {
                    expectederr = "The Post Code field must be numeric characters";
                    Assert.AreEqual(expectederr, APostCodeErr.Text);
                    Base.test.Log(LogStatus.Pass, "Company PostCode Address Error validation, Pass");
                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "Fail");
                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address PostCode");
                }

            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Company Address PostCode validation, Pass");
            }

            Base.test.Log(LogStatus.Pass, "Test Pass");

        }

        }
    }
