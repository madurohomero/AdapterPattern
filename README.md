# AdapterPattern
Prós
----------------------------------------------------------------------------------------------------------------
Princípio de responsabilidade única.
Você pode separar a interface ou código de conversão de dados da lógica de negócios principal do programa.

Princípio aberto/fechado.
Você pode introduzir novos tipos de adaptadores no programa sem quebrar o código do cliente existente, desde que
funcionem com os adaptadores por meio da interface do cliente.

Contras
----------------------------------------------------------------------------------------------------------------
A complexidade geral do código aumenta porque você precisa apresentar um conjunto de novas interfaces e classes.
Às vezes, é mais simples apenas alterar a classe de serviço para que corresponda ao restante do seu código.
