using aimy_testing_automation.Pages;
using aimy_testing_automation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace aimy_testing_automation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions: CommonDriver
    {

        private readonly LoginPage loginPageObj = new LoginPage();
                                

        [When(@"\[When I enter ""([^""]*)"" as the password and ""([^""]*)"" as the username and click login]")]
        public void WhenWhenIEnterAsThePasswordAndAsTheUsernameAndClickLogin(string password, string username)
        {
           loginPageObj.doSignIn(username, password);
        }

        [Then(@"\[I should see an error message indicating that the password is required]")]
        public void ThenIShouldSeeAnErrorMessageIndicatingThatThePasswordIsRequired()
        {
           loginPageObj.passwordErrorMessage();
        }
        [Then(@"\[I should see an error message indicating that the username is required]")]
        public void ThenIShouldSeeAnErrorMessageIndicatingThatTheUsernameIsRequired()
        {
           loginPageObj.usernameErrorMessage();
        }
        [Then(@"\[I should see the dashboard page]")]
        public void ThenIShouldSeeTheDashboardPage()
        {
           loginPageObj.ValidCredentials();
        }
        [Then(@"\[I should see an error message indicating Invalid username or password]")]
        public void ThenIShouldSeeAnErrorMessageIndicatingInvalidUsernameOrPassword()
        {
            loginPageObj.invalidUsernameOrPassword();
        }
        [When(@"\[I click on the logout button]")]
        public void WhenIClickOnTheLogoutButton()
        {
            loginPageObj.logout();
        }

        [Then(@"\[I should be redirected to the login page]")]
        public void ThenIShouldBeRedirectedToTheLoginPage()
        {
            loginPageObj.logoutAssert();
        }





    }
}
