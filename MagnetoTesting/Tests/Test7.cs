using System;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;

namespace MagnetoTesting.Tests
{
    public class Test7 : TestBase
    {
        private HomePage _homePage;
        private SearchResultsPage _searchResultsPage;

        public Test7()
        {
            _homePage = new HomePage(Driver);
            _searchResultsPage = new SearchResultsPage(Driver);
        }

        [Test]
        public void Test7_addItemToCart()
        {
            string searchInput = "lord of the rings";

            _homePage.GoToHomepage();
            _homePage.InputSearchText(searchInput);
            _homePage.PressSearch();


        }
    }
}
