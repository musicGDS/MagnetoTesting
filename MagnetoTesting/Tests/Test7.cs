using System;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;

namespace MagnetoTesting.Tests
{
    public class Test7 : TestBase
    {
        private HomePage _homePage;
        private SearchResultsPage _searchResultsPage;
        private ShoppingCartPage _shoppingCartPage;

        public Test7()
        {
            _homePage = new HomePage(Driver);
            _searchResultsPage = new SearchResultsPage(Driver);
            _shoppingCartPage = new ShoppingCartPage(Driver);
        }

        [Test]
        public void Test7_addItemToCart()
        {
            string searchInput = "software testing";
            string expectedTitle = "Shopping Cart";

            _homePage.GoToHomepage();
            _homePage.InputSearchText(searchInput);
            _homePage.PressSearch();

            _searchResultsPage.AddToCartFirstProduct();

            string actualResult = _shoppingCartPage.GetPageTitle();

            Assert.That(expectedTitle == actualResult);
        }
    }
}
