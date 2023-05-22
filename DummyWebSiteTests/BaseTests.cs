using DummyWebSiteTests.Utilities;
using Framework.Core;

namespace DummyWebSiteTests
{
    /// <summary>
    /// Base Test Class
    /// </summary>
    public abstract class BaseTests
    {
        protected SeleniumWebDriver Driver;
        protected string User;
        protected string Password;
        protected string Url;


        [TestInitialize]
        public void SetupInit()
        {
            InitVariables();
            Navigate();
        }

        [TestCleanup]
        public void Teardown()
        {
            Driver?.Quit();

        }

        #region methods
        /// <summary>
        /// Initialize variables before start the test
        /// </summary>
        private void InitVariables()
        {
            Configuration.SetupConfigFile();
            Url = Configuration.Url;
            User = Configuration.User;
            Password = Configuration.Password;
            Driver = new SeleniumWebDriver(Configuration.Browser);
        }

        /// <summary>
        /// Navigate to URL and Maximixe the  Browser
        /// </summary>
        protected void Navigate()
        {
            Driver.Url = Url;
            Driver.Manage().Window.Maximize();
        }
        #endregion

    }
}