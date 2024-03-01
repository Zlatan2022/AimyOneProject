using aimy_testing_automation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aimy_testing_automation.Pages
{
    public class PageNavigators : CommonDriver
    {
        WebDriverWait wait;
        private IWebElement customersSubMenuClick => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/section/aside/div/ul/li[2]/div"));
        private IWebElement bookingSubMenuClick => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/section/aside/div/ul/li[3]/div"));

        public PageNavigators()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
     
        // Method to navigate to Customers submenu
        public void CustomersSubMenu()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/div/div/section/aside/div/ul/li[2]/div", 15);
            customersSubMenuClick.Click();
        }
        // Method to navigate to the Accounts link
        public void accountsLink()
        {
            // Wait for the Accounts link to be clickable
            var accountsLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='/customer/account']")));
            // Click on the Accounts link
            accountsLink.Click();
        }
        // Method to navigate to the Attendees link
        public void attendeesLink()
        {
            // Wait for the Attendees link to be clickable
            var attendeesLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='/customer/attendee']")));
            // Click on the Attendees link
            attendeesLink.Click();
        }
        // Method to navigate to Booking submenu
        public void bookingSubMenu()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/div/div/section/aside/div/ul/li[3]/div", 15);
            bookingSubMenuClick.Click();
        }
        // Method to navigate to the Booking Manager link
        public void bookingManagerLink()
        {
            // Wait for the Accounts link to be clickable
            var bookingManagerLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='/booking/manager']")));
            // Click on the Accounts link
            bookingManagerLink.Click();
        }
        // Method to navigate to the Booking link
        public void bookingLink()
        {
            // Wait for the Accounts link to be clickable
            var bookingLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='/booking/class']")));
            // Click on the Accounts link
            bookingLink.Click();
        }
        public void bookingReconciliationLink()
        {
            // Wait for the Accounts link to be clickable
            var bookingReconciliationLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='/booking/reconciliation']")));
            // Click on the Accounts link
            bookingReconciliationLink.Click();
        }
        public void waitingListLink()
        {
            // Wait for the Accounts link to be clickable
            var waitingListLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='/booking/waiting-list']")));
            // Click on the Accounts link
            waitingListLink.Click();
        }

    }
}
