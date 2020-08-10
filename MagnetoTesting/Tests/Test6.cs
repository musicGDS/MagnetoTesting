using System;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;

namespace MagnetoTesting.Tests
{
    public class Test6 : TestBase
    {
        private HomePage _homePage;
        private SearchResultsPage _searchResultsPage;
        

        public Test6()
        {
            _homePage = new HomePage(Driver);
            _searchResultsPage = new SearchResultsPage(Driver);
        }

        [Test]
        public void Test6_searchItem()
        {
            string searchInput = "lord of the rings";
            string expectedTitle = "The Lord of the Rings. Part 1: The Fellowship of the Ring";

            _homePage.GoToHomepage();
            _homePage.InputSearchText(searchInput);
            _homePage.PressSearch();

            Assert.That(_searchResultsPage.IsPresent(expectedTitle));
        }
    }
}
