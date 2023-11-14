Feature: Selecionar Produto na Loja PO
    @PO
    Scenario Outline: Selecao de Produto com sucesso PO
        Given que acesso a pagina inicial do site PO
        When preencho o <usuario> PO
        And a senha <senha> e clico no botao Login PO
        Then exibe <tituloSecao> no titulo da secao PO
        When adiciono o produto <produto> ao carrinho PO
        And clico no icone do carrinho de compras PO
        Then exibe a pagina do carrinho com quantidade <quantidade> PO
        And nome do produto <produto> PO
        And o preco como <preco> PO

    Examples:
    | usuario         | senha          | tituloSecao | produto                 | quantidade | preco    |
    | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"   | "1"        | "$29.99" |
    | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light" | "1"        |  "$9.99" |