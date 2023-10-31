Feature: Selecionar Produto na Loja
    Scenario: Selecao de Produto com sucesso
        Given que acesso a pagina inicial do site
        When preencho o usuario como "standard_user"
        And a senha "sauce_secret" e clico no botao Login
        Then exibe "Products" no titulo da secao
        When adiciono o produto "Sauce Labs Backpack" ao carrinho
        And clico no icone do carrinho de compras
        Then exibe a pagina do carrinho com quantidade "1"
        And nome do produto "Sauce Labs Backpack"
        And o preco como "$29.99"