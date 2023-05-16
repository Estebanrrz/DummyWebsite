using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Login Page on POM
    /// </summary>
    public class LoginPage : BasePage
    {
        public LoginPage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region Locators
        private const string ID_USERNAME = "user-name";
        private const string ID_PASSWORD = "password";
        private const string ID_LOGIN_BUTTON = "login-button";
        #endregion
        #region Methods
        
        /// <summary>
        /// Type Username on Username field
        /// </summary>
        /// <param name="username"></param>
        public void TypeUsername(string username)=> Driver.FindElement(By.Id(ID_USERNAME)).SendKeys(username);
        
        /// <summary>
        /// Type Password on Password field
        /// </summary>
        /// <param name="password"></param>
        public void TypePassword(string password)=> Driver.FindElement(By.Id(ID_PASSWORD)).SendKeys(password);

        /// <summary>
        /// Click on Login Button
        /// </summary>
        public void ClickLoginButton()=> Driver.FindElement(By.Id(ID_LOGIN_BUTTON)).Click();

        #endregion
    }
}
