using aimy_testing_automation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aimy_testing_automation.AssertHelper
{

    public class LoadPageHelper : CommonDriver
    {
        WebDriverWait wait;

        public LoadPageHelper()
        {
            // Initialize WebDriverWait with a timeout of 15 seconds
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        // Method to assert the current URL for the Dashboard page
        public void dashboardAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/dashboard"));
        }
        // Method to assert the current URL for the Accounts page
        public void accountAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/customer/account/profile/25314/profile"));
        }
        // Method to assert the current URL for the Attendees page
        public void attendeesAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/customer/attendee/profile/34647/profile"));
        }
        // Method to assert the current URL for the Attendees page
        public void bookingManagerAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/booking/manager/pending"));
        }
        // Method to assert the current URL for the Booking page
        public void bookingAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/booking/class"));
        }
        // Method to assert the current URL for the Booking Reconciliation
        public void bookingReconciliationAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/booking/reconciliation"));
        }
        // Method to assert the current URL for the Booking Reconciliation
        public void bookingWaitingListAssert()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => d.Url.StartsWith("https://uat-app.aimyone.com/booking/waiting-list"));
        }
    }
}
