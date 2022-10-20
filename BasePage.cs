namespace NUnit_lipa;

public class BasePage
{
    public static IWebDriver driver;
    
    public void Initialize()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Navigate().GoToUrl("https://www.aviva.com/");
        //Thread.Sleep(3000);
    }

    public void TearDown()
    {
        //driver.Close();
        driver.Quit();
    }

}