

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; // objeto do Selenium
        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario] // Porque fizemos Hooks
        public void SetUp()
        {
            // Instanciando o ChromeDriver atraves do WeDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); // Instaciou o Selenium como ChromeDriver
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();

        }

        [AfterScenario] // Porque fizemos Hooks
        public void TearDown()
        {
            driver.Quit(); // encerra o Selenium
        }



        [Given(@"que acesso a pagina inicial do site")]
        public void GivenQueAcessoAPaginaInicialDoSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"preencho o usuario como ""(.*)""")]
        [When(@"preencho o ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string username)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]
        public void WhenASenhaEClicoNoBotaoLogin(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void WhenAdicionoOProdutoAoCarrinho(string product)
        {
            String productSelector = "add-to-cart-" + product.ToLower().Replace(" ", "-");
            Console.WriteLine($"Seletor de Produto = {productSelector}");
            driver.FindElement(By.Id(productSelector)).Click();

            // id da mochila: add-to-cart-sauce-labs-backpack
            // id da lanterna: add-to-cart-sauce-labs-bike-light
            // O nome do produto vem do arquivo. feature = Sauce LAbs ***
            // O texto vem com maiusculas e o id em minusculas e com hifens
            // Sauce Labs Backpack --> ToLower() --> sauce labs backpack

        }

        [When(@"clico no icone do carrinho de compras")]
        public void WhenClicoNoIconeDoCarrinhoDeCompras()
        {
            driver.FindElement(By.Id("shopping_cart_container")).Click();
        }

        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void ThenExibeNoTituloDaSecao(string title)
        {
            // Espera explicita pelo elemento span.title ser carregado na pagina
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));
            wait.Until(d => driver.FindElement(By.CssSelector("span.title")).Displayed);            
            
            Assert.That(driver.FindElement(By.CssSelector("span.title")).Text, Is.EqualTo(title));
        }

        [Then(@"exibe a pagina do carrinho com quantidade ""(.*)""")]
        public void ThenExibeAPaginaDoCarrinhoComQuantidade(string quantity)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.cart_quantity")).Text, Is.EqualTo(quantity));
        }

        [Then(@"nome do produto ""(.*)""")]
        public void ThenNomeDoProduto(string product)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_name ")).Text, Is.EqualTo(product));
                                           
        }

        [Then(@"o preco como ""(.*)""")]
        public void ThenOPrecoComo(string price)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_price")).Text, Is.EqualTo(price));
        }
    }
}