using System; // Importando o namespace System
using TechTalk.SpecFlow; // Importação da Biblioteca do Given, When, Then

namespace MyNamespace
{
    public class SelectProductPO
    {
        //Given que acesso a pagina inicial do site PO

        [Given(@"que acesso a pagina inicial do site PO")]
        public void GivenQueAcessoAPaginaInicialDoSitePO()
        {
            
        }

        //When preencho o "visual_user" PO

        [When(@"preencho o ""(.*)"" PO")]
        public void WhenPreenchoOPO(string p0)
        {
            
        }

        //And a senha "secret_sauce" e clico no botao Login PO

        [When(@"a senha ""(.*)"" e clico no botao Login PO")]
        public void WhenASenhaEClicoNoBotaoLoginPO(string p0)
        {
            
        }

        //Then exibe "Products" no titulo da secao PO

        [Then(@"exibe ""(.*)"" no titulo da secao PO")]
        public void ThenExibeNoTituloDaSecaoPO(string products0)
        {
            
        }

        //When adiciono o produto "Sauce Labs Bike Light" ao carrinho PO

        [When(@"adiciono o produto ""(.*)"" ao carrinho PO")]
        public void WhenAdicionoOProdutoAoCarrinhoPO(string p0)
        {
            
        }

        //And clico no icone do carrinho de compras PO

        [When(@"clico no icone do carrinho de compras PO")]
        public void WhenClicoNoIconeDoCarrinhoDeComprasPO()
        {
            
        }

        //Then exibe a pagina do carrinho com quantidade "1" PO

        [Then(@"exibe a pagina do carrinho com quantidade ""(.*)"" PO")]
        public void ThenExibeAPaginaDoCarrinhoComQuantidadePO(string p0)
        {
            
        }

        //And nome do produto "Sauce Labs Backpack" PO

        [Then(@"nome do produto ""(.*)"" PO")]
        public void ThenNomeDoProdutoPO(string p0)
        {
            
        }

        //And o preco como "$9.99" PO

        [Then(@"o preco como ""(.*)"" PO")]
        public void ThenOPrecoComoPO(string p0)
        {
            
        }
    }
}






