﻿namespace WpfTestApplication.Tests.WiniumCommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    public class MenuCommandsTests : BaseTest<TestWebDriver>
    {
        #region Public Properties

        public IWebElement MenuElement { get; set; }

        #endregion

        #region Public Methods and Operators

        [Test]
        public void IsComboBoxExpanded()
        {
            var menuItem = this.Driver.GetMenuItem(this.MenuElement, "Level1$MultiLevel2$Level3");
            Assert.NotNull(menuItem);
        }

        [SetUp]
        public new void SetUp()
        {
            var mainWindow = this.Driver.FindElementById("WpfTestApplicationMainWindow");
            this.MenuElement = mainWindow.FindElement(By.Id("SimpleMenu"));
        }

        #endregion
    }
}