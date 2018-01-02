using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
   public static class Pages
    {
        // below static method can return us any generic page
        //it is private and static. it returns a genric type
        //it always takes a parameter 
        //comstraint on the parameter is always an object type , not int, string etc.,
        //it has to have a parameterless constructor--? why
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        public static GooglePage Google
        {
        get {
                return GetPage<GooglePage>();
            }
        }
        public static SearchResultsPage SearchResults
        {
            get
            {
                return GetPage<SearchResultsPage>();
            }
        }
    }
}