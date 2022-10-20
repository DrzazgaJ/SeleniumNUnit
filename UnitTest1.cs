namespace NUnit_lipa;

[TestFixture]
public class Tests : BasePage
{

    [OneTimeSetUp]
    public void Setup()
    {
        Initialize();
    }

//    [Test, Order(1)]
//    public void Test1()
//    {
//        String WinTitle = driver.Title;
//        Console.WriteLine("Tytuł okna to: {0}",WinTitle);
//        Assert.AreEqual("Aviva corporate website - Aviva plc", WinTitle);
        //Assert.Pass();
//    }

    [Test, Order(2)]
    public void Test2()
    {
        Thread.Sleep(2000);
        IWebElement cookiesAcceptAllButton = driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']"));
        bool isElementDisplayed = driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']")).Displayed;
        if(isElementDisplayed == true)
        {
            driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']")).Click();
        }
        
        //IWebElement przyciskMA = driver.FindElement(By.XPath("//html/body/div[1]/div[1]/header/div[2]/div[1]/ul/li[2]/ul/li/a"));
        //IWebElement przyciskMA = driver.FindElement(By.PartialLinkText("MyAviva"));
        IWebElement przyciskMA = driver.FindElement(By.XPath("//li[@class='o-masthead__login-link']//*[text()='MyAviva']"));
        przyciskMA.Click();
        Console.WriteLine(driver.Title);
        Assert.AreEqual("MyAviva - Aviva plc",driver.Title);
    }

    [OneTimeTearDown]
    public void CloseDriver()
    {
        TearDown();
    }
}