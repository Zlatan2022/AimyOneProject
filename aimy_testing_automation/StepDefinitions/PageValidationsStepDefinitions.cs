using aimy_testing_automation.AssertHelper;
using aimy_testing_automation.Pages;
using aimy_testing_automation.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace aimy_testing_automation.StepDefinitions
{
    [Binding]
    public class PageValidationsStepDefinitions : CommonDriver
    {
        WebDriverWait wait;
        private readonly PageNavigators navigatorsObj = new PageNavigators();
        private readonly LoadPageHelper pageHelper = new LoadPageHelper();

        public PageValidationsStepDefinitions()
        {
            // Initialize WebDriverWait with a timeout of 15 seconds
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }

        [When(@"\[I click on the Customers submenu]")]
        public void WhenIClickOnTheCustomersSubmenu()
        {
            navigatorsObj.CustomersSubMenu();
        }

        [When(@"\[I select Accounts from the dropdown menu]")]
        public void WhenISelectAccountsFromTheDropdownMenu()
        {
            navigatorsObj.accountsLink();
        }

        [Then(@"\[I should be redirected to the /customer/account page]")]
        public void ThenIShouldBeRedirectedToTheCustomerAccountPage()
        {
            pageHelper.accountAssert();
        }

        [When(@"\[I select Attendees from the dropdown menu]")]
        public void WhenISelectAttendeesFromTheDropdownMenu()
        {
            navigatorsObj.attendeesLink();
        }

        [Then(@"\[I should be redirected to the /customer/attendees page]")]
        public void ThenIShouldBeRedirectedToTheCustomerAttendeesPage()
        {
            pageHelper.attendeesAssert();
        }
        [When(@"\[I click on the Booking submenu]")]
        public void WhenIClickOnTheBookingSubmenu()
        {
            navigatorsObj.bookingSubMenu();
        }
        [When(@"\[I select Booking Manager from the dropdown menu]")]
        public void WhenISelectBookingManagerFromTheDropdownMenu()
        {
            navigatorsObj.bookingManagerLink();
        }
        [Then(@"\[I should be redirected to the /booking/manager]")]
        public void ThenIShouldBeRedirectedToTheBookingManager()
        {
            pageHelper.bookingManagerAssert();
        }
        [When(@"\[I select Booking from the dropdown menu]")]
        public void WhenISelectBookingFromTheDropdownMenu()
        {
            navigatorsObj.bookingLink();
        }
        [Then(@"\[I should be redirected to the /booking/class]")]
        public void ThenIShouldBeRedirectedToTheBookingClass()
        {
            pageHelper.bookingAssert();
        }
        [When(@"\[I select Booking Reconciliation from the dropdown menu]")]
        public void WhenISelectBookingReconciliationFromTheDropdownMenu()
        {
            navigatorsObj.bookingReconciliationLink();
        }
        [Then(@"\[I should be redirected to the /booking/reconciliation]")]
        public void ThenIShouldBeRedirectedToTheBookingReconciliation()
        {
            pageHelper.bookingReconciliationAssert();
        }
        [When(@"\[I select Waiting List from the dropdown menu]")]
        public void WhenISelectWaitingListFromTheDropdownMenu()
        {
            navigatorsObj.waitingListLink();
        }
        [Then(@"\[I should be redirected to the /booking/waiting-list]")]
        public void ThenIShouldBeRedirectedToTheBookingWaiting_List()
        {
            pageHelper.bookingWaitingListAssert();
        }


    }
}
