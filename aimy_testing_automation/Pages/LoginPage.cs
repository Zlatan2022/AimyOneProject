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
    public class LoginPage:CommonDriver
    {
        WebDriverWait wait;

        // Define elements on the login page using locators
        private IWebElement usernameTextbox => driver.FindElement(By.Id("Username"));
        private IWebElement passwordTextbox => driver.FindElement(By.Id("Password"));
        private IWebElement clickRememberMe => driver.FindElement(By.Id("RememberLogin"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//*[@id=\"login-form\"]/button[1]"));
        private IWebElement accountName => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/section/section/header/div/div/div[2]/div/span[1]"));
        private IWebElement logoutButton => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/section/section/header/div/div/div[1]/div/div/div[2]/div/div/div/div/ul/li[1]/span/div"));

        public LoginPage()
        {
            
            // Initialize WebDriverWait with a timeout of 15 seconds
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }
        // Method to perform login with given username and password
        public void doSignIn(string username, string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Username")));
            usernameTextbox.SendKeys(username);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Password")));
            passwordTextbox.SendKeys(password);
            clickRememberMe.Click();
            loginButton.Click();
        }
        // Method to assert error message for missing password
        public void passwordErrorMessage()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var errorMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".validation-summary-errors li")));
            errorMessageElement.Text.Should().Contain("The Password field is required.");

        }

        // Method to assert error message for missing username
        public void usernameErrorMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var errorMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".validation-summary-errors li")));
            errorMessageElement.Text.Should().Contain("The Username field is required.");

        }

        // Method to assert that the title after login is as expected
        public void ValidCredentials()
        {
            var title = driver.Title;
            Assert.AreEqual("AimyOne", title);
        }

        // Method to assert error message for invalid username or password
        public void invalidUsernameOrPassword()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var errorMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".validation-summary-errors li")));
            errorMessageElement.Text.Should().Contain("Invalid username or password");

        }

        // Method to perform logout
        public void logout()
        {
            // Click on the account name to open the dropdown menu
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/div/div/section/section/header/div/div/div[2]/div/span[1]", 10);
            accountName.Click();

            // Click on the logout button in the dropdown menu
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"root\"]/div/div/div/section/section/header/div/div/div[1]/div/div/div[2]/div/div/div/div/ul/li[1]/span/div", 10);
            logoutButton.Click();
        }

        // Method to assert redirection to the login page after logout
        public void logoutAssert()
        {
            // Get the current URL after clicking on the logout button
            string currentUrl = driver.Url;

            // Assertion
            Assert.IsTrue(currentUrl.Contains("login"), "Expected to be redirected to the login page, but redirection did not occur.");
        }
       
    }
}
