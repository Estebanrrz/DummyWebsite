using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    /// <summary>
    /// IDriver interface
    /// </summary>
    public interface IDriver
    {
        string Url { get; set; }
        void Close();
        void Quit();
        public IWebElement FindElement(By by);
        public INavigation Navigate();
    }
}
