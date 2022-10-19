namespace NUnit_lipa;

public class BasePage
{
    public static IWebDriver driver;
    
    public void Initialize()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.aviva.com/");
        //Thread.Sleep(3000);
    }

    public void TearDown()
    {
        driver.Close();
        driver.Quit();
    }

}