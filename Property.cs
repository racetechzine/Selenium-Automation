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
using static NUnit.Core.NUnitFramework;

namespace Keys.Pages
{
    class Property
    {
        internal Property()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        //POM DEf
        //Click on Property Link
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/ul[1]/li[2]/a")]
        private IWebElement PropertyLink { get; set; }
    
        //Property Name in  row
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-grid']/div[2]/div/div/ul/li[3]/a")]
        
        private IWebElement Page { get; set; }

        //Finding the add new property
       [FindsBy(How = How.XPath, Using = "//*[@id='add-new-property']")]
       private IWebElement AddNewProperty { get; set; }

        //Finding the Property Info
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[1]/div/div/input")]
        private IWebElement PropertyName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[1]/div/div/span")]
        private IWebElement PropertyNameErr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[2]/div/div/textarea")]
        private IWebElement Description { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[2]/div/div/span")]
        private IWebElement DescErr { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[3]/div/div/select")]
        private IWebElement PropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[4]/div[1]/div/select")]
        private IWebElement ResidentalType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[5]/div/div/input")]
        private IWebElement TargetRent { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[5]/div/div/span")]
        private IWebElement TargetRentErr { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[6]/div/div/select")]
        private IWebElement RentType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
        private IWebElement SearchAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
        private IWebElement Number { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[2]/div/span")]
        private IWebElement NumberErr { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='route']")]
        private IWebElement Street { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[3]/div/span")]
        private IWebElement StreetErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
        private IWebElement PostCode { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[4]/div/span")]
        private IWebElement PostCodeErr { get; set; }
       

        [FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
        private IWebElement City { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[5]/div/span")]
        private IWebElement CityErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
        private IWebElement Suburb { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[6]/div/span")]
        private IWebElement SuburbErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[1]/div/input")]
        private IWebElement BedRoom { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[1]/div/span")]
        private IWebElement BedRoomErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[2]/div/input")]
        private IWebElement BathRoom { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[2]/div/span")]
        private IWebElement BathRoomErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[3]/div/input")]
        private IWebElement FloorArea { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[3]/div/span")]
        private IWebElement FloorAreaErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[4]/div/input")]
        private IWebElement LandArea { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[4]/div/span")]
        private IWebElement LandAreaErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[5]/div/input")]
        private IWebElement ParkingSpace { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[5]/div/span")]
        private IWebElement ParkingSpaceErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[6]/div/input")]
        private IWebElement YearBuilt { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[6]/div/span")]
        private IWebElement YearBuiltErr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[4]/button[1]")]
        private IWebElement Save { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[4]/button[2]")]
        private IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[1]/h4/a")]
        private IWebElement PhotosTab { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[2]/input")]
        private IWebElement Browse { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[3]/button[1]")]
        private IWebElement SavePhotos { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[3]/button[2]")]
        private IWebElement CancelPhotos { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div/div/div[1]/ul[1]/li[2]/a/h4")]
        private IWebElement PropertyPage { get; set; }

        internal void PropertyDetailValidation()
        {
            //Click Property tab
            PropertyLink.Click();
            //Explicit Wait
            Thread.Sleep(500);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
            AddNewProperty.Click();
            //Validating Alphanumeric in property Details
            Driver.wait(3);
            string expectederr;
            //Property Brief Info
            PropertyName.SendKeys(ExcelLib.ReadData(2, "Name"));
            Description.SendKeys(ExcelLib.ReadData(2, "Desc"));
            TargetRent.SendKeys(ExcelLib.ReadData(2, "TargetRent"));
            SearchAddress.SendKeys(ExcelLib.ReadData(2, "Location"));
            Number.SendKeys(ExcelLib.ReadData(2, "ANumber"));
            Street.SendKeys(ExcelLib.ReadData(2, "AStreet"));
            Driver.wait(1);
            //Screenshot
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 1");
            Driver.wait(1);
            PostCode.SendKeys(ExcelLib.ReadData(2, "APostCode"));
            BedRoom.SendKeys(ExcelLib.ReadData(2, "Bedroom"));
            City.SendKeys(ExcelLib.ReadData(2, "ACity"));
            Suburb.SendKeys(ExcelLib.ReadData(2, "ASuburb"));
            BathRoom.SendKeys(ExcelLib.ReadData(2, "Bathroom"));
            FloorArea.SendKeys(ExcelLib.ReadData(2, "FloorArea"));
            LandArea.SendKeys(ExcelLib.ReadData(2, "LandArea"));
            ParkingSpace.SendKeys(ExcelLib.ReadData(2, "PSpace"));
            YearBuilt.SendKeys(ExcelLib.ReadData(2, "Year"));
            ParkingSpace.Click();
            try
            {
                expectederr = "The Name field must be alphanumeric characters.";
                Assert.AreEqual(expectederr, PropertyNameErr.Text);
                Base.test.Log(LogStatus.Pass, "Property Name Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '"+ expectederr+ " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Property Name");
            }
            
            Driver.wait(1);
            
           
            try {
                expectederr = "The Target Rent field must be a number.";
                Assert.AreEqual(expectederr, TargetRentErr.Text);
               Base.test.Log(LogStatus.Pass, "Target Rent Error validation, Pass");
               Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid TargetRent");
            }
            Driver.wait(1);
            //Address
            
            Driver.wait(1);
           
            try
            {
                expectederr = "The Number field must be alphanumeric characters.";
                Assert.AreEqual(expectederr, NumberErr.Text);
                Base.test.Log(LogStatus.Pass, "Address Number Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Number in address detail");
            }
            Driver.wait(1);
            
            try
            {
                expectederr = "The Street field must be alphanumeric characters.";
                Assert.AreEqual(expectederr, StreetErr.Text);
                Base.test.Log(LogStatus.Pass, "Address Street Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Street");

            }
            Driver.wait(1);
            
            try
            {
                expectederr = "The PostCode field must be numeric.";
                Assert.AreEqual(expectederr, PostCodeErr.Text);
                Base.test.Log(LogStatus.Pass, "Pass");
                Base.test.Log(LogStatus.Info, "Expected err: " + expectederr + "is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid PostCode");
            }
            Driver.wait(1);
            
            try
            {
                expectederr = "The City field must be alphanumeric characters.";
                Assert.AreEqual(expectederr, CityErr.Text);
                Base.test.Log(LogStatus.Pass, "Address City Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid City Details");
            }
            
            try
            {
                expectederr = "The Suburb field must be alphanumeric characters.";
                Assert.AreEqual(expectederr, SuburbErr.Text);
                Base.test.Log(LogStatus.Pass, "Address Suburb Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Suburb Details");
            }
            Driver.wait(1);
            //Property Detail
           
            try
            {
                expectederr = "The Bedroom field must be a number.";
                Assert.AreEqual(expectederr, BedRoomErr.Text);
                Base.test.Log(LogStatus.Pass, "Bedroom Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bedroom Details");
            }
            Driver.wait(1);
           
            try
            {
                expectederr = "The Bathroom field must be a number.";
                Assert.AreEqual(expectederr, BathRoomErr.Text);
                Base.test.Log(LogStatus.Pass, "Bathroom Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bathroom Details");
            }
            Driver.wait(1);
            
            try
            {
                expectederr = "The Floor Area field must be a number.";
                Assert.AreEqual(expectederr, FloorAreaErr.Text);
                Base.test.Log(LogStatus.Pass, "Floor Area Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid FloorArea Details");
            }
            
          
            Driver.wait(1);
            try
            {
                expectederr = "The Land Area field must be a number.";
                Assert.AreEqual(expectederr, LandAreaErr.Text);
                Base.test.Log(LogStatus.Pass, "LandArea Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid LandArea Details");
            }
           
            Driver.wait(1);
            try
            {
                expectederr = "The Parking Space field must be a number.";
                Assert.AreEqual(expectederr, ParkingSpaceErr.Text);
                Base.test.Log(LogStatus.Pass, "Parking Space Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Parking Space Details");
            }
           
            Driver.wait(1);
            try
            {
                expectederr = "The Year Built field must be a number.";
                Assert.AreEqual(expectederr, YearBuiltErr.Text);
                Base.test.Log(LogStatus.Pass, "Year Built Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Year Details");
            }
            //Screenshot
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 2");
        }

        internal void DeleteCancel()
        {
            //Click Property tab
            PropertyLink.Click();
            //Explicit Wait
            Thread.Sleep(500);
            Thread.Sleep(500);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
            //Bool delete check
            bool Delete = true;
            //Remove once Defect672 fix
            //Retrieve tot PGnumber
            String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[2]/div/div/ul/li[2]/a")).Text;
            int POSof = PageNumber.IndexOf("of") + 3;
            int endpos = PageNumber.IndexOf(".");
            int Totnum = Convert.ToInt32(PageNumber.Substring(POSof, endpos - POSof));
            int Count = 1;
            //remove //Remove once Defect672 fix

            //Search the excel data in the grid
            try
            {
                do
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
                        {
                            if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
                            {
                                //Click on Details Page
                                Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
                                //Verify the Address 
                                if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
                                {
                                    //Click on Back button
                                    Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                    //Screenshot
                                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Delete Property");
                                    //Click Delete button
                                    Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
                                    //Implicit Wait
                                    //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
                                    Thread.Sleep(500);

                                    //Click Cancel on confirmation page                              
                                    
                                    Driver.driver.FindElement(By.XPath("//*[@id='removeModal']/div/div/div[3]/form/button")).Click();
                                    Delete = false;
                                    //Log Info
                                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Cancelled");
                                    break;
                                    
                                }
                                else
                                {
                                    if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
                                    {
                                        //Click on Back button
                                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                    }
                                }

                            }


                        }
                    }
                    Thread.Sleep(500);
                    if (Page.Enabled && Delete == true)
                    {
                        Page.Click();
                        Thread.Sleep(500);
                    }
                    Count++;
                    //Check Next Pg button
                } while (Page.Enabled && Delete == true && Count <= Totnum);
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
            }
            //Verify the record is not deleted
            //Refresh Property Page
            PropertyLink.Click();
            Thread.Sleep(500);
            bool found = false;
            Count = 1;
            //Check the Boolean
            if (Delete==false)
            {
                //Verify the record not deleted from the grid
                //Log Info
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After Cancellation, Verifying whether Property is available in the grid");
                try
                {
                    do
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
                            {
                                if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
                                {
                                    //Click on Details Page
                                    Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
                                    //Verify the Address 
                                    if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
                                    {
                                        //Click on Back button
                                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                        //Record Available
                                        found = true;
                                        //Logg the status report
                                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record not Deleted, Test Pass");

                                    }
                                    else
                                    {
                                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
                                            //Click on Back button
                                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                        //Record Not Found
                                        found = false;
                                    }

                                }


                            }
                        }
                        if (Page.Enabled)
                        {
                            Page.Click();
                            Thread.Sleep(500);
                        }
                        Count++;
                        //Check Next Pg button
                    } while (Page.Enabled && Count <= Totnum);


                }
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
                }
            }
            else
            {
                //Logging Status in Test Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not present for deletion, Test Failed");
                Delete = false;
            }
            if (found == false && Delete == true)
                //Logging Status in Test Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Deleted, Test Failed");
        }

        internal void DeleteProperty()
        {
            //Click Property tab
            PropertyLink.Click();
            //Explicit Wait
            Thread.Sleep(500);
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
            //Bool delete check
            bool Delete = false;
            //Remove once Defect672 fix
            //Retrieve tot PGnumber
            String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[2]/div/div/ul/li[2]/a")).Text;
           int POSof= PageNumber.IndexOf("of") + 3;
            int endpos = PageNumber.IndexOf(".");
           int Totnum= Convert.ToInt32(PageNumber.Substring(POSof,endpos-POSof));
            int Count = 1;
            //remove //Remove once Defect672 fix
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Totnum.ToString());
            
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
                    {
                        if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
                        {
                            //Click on Details Page
                            Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
                            //Verify the Address 
                            if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
                            {
                                //Click on Back button
                                Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                //Screenshot
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteProperty");
                                //Click Delete button
                                Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
                                //Implicit Wait
                                //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
                                Thread.Sleep(500);

                                //Click Delete on confirmation page                              
                                //Driver.driver.SwitchTo().Frame("removeModal");
                                Driver.driver.FindElement(By.XPath("//*[@id='removeModal']/div/div/div[3]/form/input")).Click();
                                Delete = true;
                                //Log Info
                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Deleted");
                                break;
                                /************************/
                                //  Driver.driver.SwitchTo().Alert().Accept();
                            }
                            else
                            {
                                if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
                                {
                                    //Click on Back button
                                    Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                }
                            }

                        }


                    }
                }
                Thread.Sleep(500);
                if (Page.Enabled && Delete==false)
                {
                    Page.Click();
                    Thread.Sleep(500);
                }
                Count++;
//Check Next Pg button
            } while (Page.Enabled && Delete==false && Count<=Totnum);
            //Refresh Property Page
            PropertyLink.Click();
            Thread.Sleep(500);
            bool found = false;
            Count = 1;
            //Check the Boolean
            if (Delete)
            {
                //Verify the record deleted from the grid
                //Log Info
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After Deletion, Verifying whether Deleted Property available in the grid");
                try
                {
                    do
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
                            {
                                if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
                                {
                                    //Click on Details Page
                                    Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
                                    //Verify the Address 
                                    if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
                                    {
                                        //Click on Back button
                                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                        //Record Available
                                        found = true;
                                        //Logg the status report
                                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not Deleted, Test Failed");

                                    }
                                    else
                                    {
                                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
                                            //Click on Back button
                                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
                                        //Record Not Found
                                        found = false;
                                    }

                                }


                            }
                        }
                        if (Page.Enabled)
                        {
                            Page.Click();
                            Thread.Sleep(500);
                        }
                        Count++;
                        //Check Next Pg button
                    } while (Page.Enabled && Count<=Totnum);


                }
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
                }
            }
            else
            {
                //Logging Status in Test Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not present for deletion, Test Failed");
            }
            if(found==false && Delete==true)
                //Logging Status in Test Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record Deleted Successfully, Test Pass");
        }
    }
}
