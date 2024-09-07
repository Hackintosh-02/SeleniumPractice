using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading.Tasks;


namespace seleniumTask
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            await Task.Delay(2000);
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            await Task.Delay(2000);
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            await Task.Delay(2000);
            driver.FindElement(By.Id("login-button")).Click();
            await Task.Delay(2000);

            driver.FindElement(By.CssSelector(".inventory_item .btn_inventory")).Click();
            await Task.Delay(2000);

            driver.FindElement(By.CssSelector(".shopping_cart_link")).Click();
            await Task.Delay(2000);
            driver.FindElement(By.Id("checkout")).Click();
            await Task.Delay(2000);

            driver.FindElement(By.Id("first-name")).SendKeys("John");
            await Task.Delay(2000);
            driver.FindElement(By.Id("last-name")).SendKeys("Doe");
            await Task.Delay(2000);
            driver.FindElement(By.Id("postal-code")).SendKeys("12345");
            await Task.Delay(2000);
            driver.FindElement(By.Id("continue")).Click();
            await Task.Delay(2000);

            driver.FindElement(By.Id("finish")).Click();
            await Task.Delay(2000);

            //string confirmationMessage = driver.FindElement(By.CssSelector("complete-header")).Text;
            //Assert.That(confirmationMessage, Is.EqualTo("THANK YOU FOR YOUR ORDER"));


            driver.FindElement(By.Id("back-to-products")).Click();

            await Task.Delay(5000);
            //return "nothing";
            driver.Quit();
        }
    }
}
