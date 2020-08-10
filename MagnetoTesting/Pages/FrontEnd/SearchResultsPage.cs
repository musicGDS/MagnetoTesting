﻿using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class SearchResultsPage : PageBase
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        private By elem_count = By.XPath("//body/div/div/div/div/div/div/div/div/div[1]/p[1]/strong[1]");

        private By elem_showPerPage = By.XPath("//body/div/div/div/div/div/div/div/div/div[1]/div[1]/select[1]");

        private By elem_addToCart1 = By.XPath("//html//body//div//div//div//div//div//div//div//ul//li//div//button");


        //Methods

        public bool IsPresent(string linkText)
        {
            return Driver.FindElements(By.LinkText(linkText)).Count != 0;
        }

        public void AddToCartFirstProduct()
        {
            Click(elem_addToCart1);
        }
    }
}
