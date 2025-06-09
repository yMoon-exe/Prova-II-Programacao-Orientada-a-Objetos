# Prova-II-Programacao-Orientada-a-Objetos

Conceitos Aplicados
Programação Orientada a Objetos

Classes e Objetos

Abstração, Encapsulamento, Herança e Polimorfismo

Interfaces

----------------------------------------------------------

Design Patterns Utilizados

Strategy: Para aplicar diferentes estratégias de desconto

Factory Method: Para criação de pedidos

----------------------------------------------------------

Clean Code

Separação de responsabilidades

Nomenclatura clara e significativa

Código legível e modularizado

----------------------------------------------------------

Princípios SOLID

SRP: Cada classe tem uma única responsabilidade

OCP: Estratégias de desconto usam polimorfismo para extensão

LSP: Subclasses substituem com segurança

ISP: Interfaces específicas para comportamentos diferentes

DIP: Pedido depende de abstrações, não implementações concretas

Aplicação dos Princípios SOLID

SRP — Single Responsibility Principle (Princípio da Responsabilidade Única)
Cada classe tem uma responsabilidade única:

Produto.cs: representa apenas os dados do produto.

Cliente.cs: representa apenas os dados do cliente.

Pedido.cs: contém lógica apenas do pedido (como calcular valor total e armazenar os itens).

ItemPedido.cs: representa a associação entre um produto e sua quantidade.

PedidoFactory.cs: responsável apenas por criar instâncias de Pedido.

DescontoPorCategoriaStrategy.cs e DescontoPorQuantidadeStrategy.cs: responsáveis exclusivamente por aplicar tipos específicos de desconto.

OCP — Open/Closed Principle (Aberto para Extensão, Fechado para Modificação)
A estratégia de desconto segue esse princípio:

A interface IDescontoStrategy permite criar novos tipos de descontos sem modificar os existentes.

As estratégias existentes (por categoria, por quantidade) são implementadas separadamente e podem ser estendidas com novas sem alterar código antigo.

LSP — Liskov Substitution Principle (Princípio da Substituição de Liskov) 
As classes que implementam IDescontoStrategy (como DescontoPorCategoriaStrategy e DescontoPorQuantidadeStrategy) podem ser substituídas umas pelas outras, pois respeitam a interface comum sem alterar o comportamento esperado do sistema.

ISP — Interface Segregation Principle (Princípio da Segregação de Interfaces) 
As interfaces IDescontoStrategy e IPedidoFactory são pequenas e específicas para os comportamentos que representam. Não obrigam as classes a implementarem métodos que não utilizam.

DIP — Dependency Inversion Principle (Princípio da Inversão de Dependência) 

A classe Pedido depende da abstração IPedidoFactory para criar pedidos.

Estratégias de desconto são passadas para o código principal via interface IDescontoStrategy, desacoplando o Program.cs das implementações concretas.

Além disso, a proposta original já mencionava que serviços de logging poderiam ser acoplados por injeção de dependência (poderia ser feito facilmente com ILogger ou similar).

