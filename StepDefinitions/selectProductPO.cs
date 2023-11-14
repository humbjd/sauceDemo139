using System; // Importando o namespace System
using OpenQA.Selenium;
using Pages;
using TechTalk.SpecFlow; // Importação da Biblioteca do Given, When, Then

namespace MyNamespace
{
    [Binding]
    public class SelectProductPO
    {
        // Atributos / Objetos
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;

        // Classe das páginas de mapeamento
        private LoginPage loginPage;
        private CommonPage commonPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;


        // Construtor
        public SelectProductPO(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = (IWebDriver) _scenarioContext["driver"];
        }

        //Given que acesso a pagina inicial do site PO

        [Given(@"que acesso a pagina inicial do site PO")]
        public void GivenQueAcessoAPaginaInicialDoSitePO()
        {
            driver.Navigate().GoToUrl("https://saucedemo.com/");
        }

        //When preencho o "visual_user" PO

        [When(@"preencho o ""(.*)"" PO")]
        public void WhenPreenchoOPO(string usuario)
        {
            loginPage = new LoginPage(driver); // instancioamos a classe
            loginPage.PreencherUsuario(usuario);
        }

        //And a senha "secret_sauce" e clico no botao Login PO

        [When(@"a senha ""(.*)"" e clico no botao Login PO")]
        public void WhenASenhaEClicoNoBotaoLoginPO(string senha)
        {
            loginPage.PreencherSenha(senha);
            loginPage.ClicarNoBotaoLogin();
        }

        //Then exibe "Products" no titulo da secao PO

        [Then(@"exibe ""(.*)"" no titulo da secao PO")]
        public void ThenExibeNoTituloDaSecaoPO(string tituloSecao)
        {
            inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.LerTituloDaSecao, Is.EqualTo(tituloSecao));
        }

        //When adiciono o produto "Sauce Labs Bike Light" ao carrinho PO

        [When(@"adiciono o produto ""(.*)"" ao carrinho PO")]
        public void WhenAdicionoOProdutoAoCarrinhoPO(string produto)
        {
            inventoryPage.AdicionaAoCarrinho(produto);
        }

        //And clico no icone do carrinho de compras PO

        [When(@"clico no icone do carrinho de compras PO")]
        public void WhenClicoNoIconeDoCarrinhoDeComprasPO()
        {
            inventoryPage.IrParaOCarrinho();
        }

        //Then exibe a pagina do carrinho com quantidade "1" PO

        [Then(@"exibe a pagina do carrinho com quantidade ""(.*)"" PO")]
        public void ThenExibeAPaginaDoCarrinhoComQuantidadePO(string quantidade)
        {
            cartPage = new CartPage(driver);
            Assert.That(cartPage.LerQuantidade(), Is.EqualTo(quantidade));
            
        }

        //And nome do produto "Sauce Labs Backpack" PO

        [Then(@"nome do produto ""(.*)"" PO")]
        public void ThenNomeDoProdutoPO(string produto)
        {
            Assert.That(cartPage.LerTituloProduto(), Is.EqualTo(produto));
        }

        //And o preco como "$9.99" PO

        [Then(@"o preco como ""(.*)"" PO")]
        public void ThenOPrecoComoPO(string preco)
        {
            Assert.That(cartPage.LerPreco(), Is.EqualTo(preco));
        }
    }
}

