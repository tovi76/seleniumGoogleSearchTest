using System;

public class GoogleHomePage
{
    private IWebDriver driver;

    public GoogleHomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public NavigateTo(string url)
    {
        driver.Navigate().GoToUrl("https://www.google.com");

    }

    public void Search(string query)
    {
        IWebElement searchBox = driver.FindElement(By.Name("q"));

        searchBox.Submit();

    }

    private IWebDriver driver;

    private IList<IWebElement> Results;

    ReadOnlyCollection<IWebElement> searchResults;

    private WebDriverWait wait;

    public GoogleResultsPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Initialize explicit wait

    }

}
