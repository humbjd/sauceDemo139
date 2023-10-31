

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [BeforeScenario]
        public void SetUp()
        {
            // Instanciando o ChromeDriver atraves do WeDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); // Instaciou o Selenium como ChromeDriver
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); // encerra o Selenium
        }



        [Given(@"que acesso a pagina inicial do site")]
        public void GivenQueAcessoAPaginaInicialDoSite()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]
        public void WhenASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void WhenAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no icone do carrinho de compras")]
        public void WhenClicoNoIconeDoCarrinhoDeCompras()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void ThenExibeNoTituloDaSecao(string products0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a pagina do carrinho com quantidade ""(.*)""")]
        public void ThenExibeAPaginaDoCarrinhoComQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do produto ""(.*)""")]
        public void ThenNomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)""")]
        public void ThenOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}