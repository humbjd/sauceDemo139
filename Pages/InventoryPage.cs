using OpenQA.Selenium;

namespace Pages
{
    public class InventoryPage : CommonPage // equivale ao extends no java
    {
        // Mapeamento dos Elementos
        // Como queremos mapear o botão "dd to Cart" e o id muda por produto
        // Iremos mapear de forma dinâmica  pelo bloco de ações

        // Construtor
        public InventoryPage(IWebDriver driver) : base(driver)
        {

        }
        // Ações
        public void AdicionaAoCarrinho(String produto)
        {
            String seletorProduto = "add-to-cart-" + produto.ToLower().Replace(" ", "-");
            driver.FindElement(By.Id(seletorProduto)).Click();
        }
    }
}