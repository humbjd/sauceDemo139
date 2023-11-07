Feature: Selecionar Produto na Loja
    Scenario: Selecao de Produto com sucesso
        Given que acesso a pagina inicial do site
        When preencho o usuario como "standard_user"
        And a senha "secret_sauce" e clico no botao Login
        Then exibe "Products" no titulo da secao
        When adiciono o produto "Sauce Labs Backpack" ao carrinho
        And clico no icone do carrinho de compras
        Then exibe a pagina do carrinho com quantidade "1"
        And nome do produto "Sauce Labs Backpack"
        And o preco como "$29.99"


    Scenario Outline: Selecao de Produto com sucesso DDT
        Given que acesso a pagina inicial do site
        When preencho o <usuario>
        And a senha <senha> e clico no botao Login
        Then exibe <tituloSecao> no titulo da secao
        When adiciono o produto <produto> ao carrinho
        And clico no icone do carrinho de compras
        Then exibe a pagina do carrinho com quantidade <quantidade>
        And nome do produto <produto>
        And o preco como <preco>

    Examples:
    | usuario         | senha          | tituloSecao | produto                             | quantidade | preco    |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"               | "1"        | "$29.99" |
    | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light"             | "1"        | "$9.99"  |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Bolt T-Shirt"           | "1"        | "$15.99" |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Fleece Jacket"          | "1"        | "$49.99" |
    | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Onesie"                 | "1"        | "$7.99"  |
    | "standard_user" | "secret_sauce" | "Products"  | "Test.allTheThings() T-Shirt (Red)" | "1"        | "$15.99" |
