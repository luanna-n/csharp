# Primeiros passos com .NET + C#:woman_technologist:

## **EXERCÍCIOS TEÓRICOS**



- **QUESTIONÁRIO 01** - O que é .NET?

  

##### O que acontece a partir de 2020 com relação ao .NET?

O .NET Framework deixará de ser evoluido, mantendo-se a evolução apenas do .NET Core, que passará se chamar apenas .NET.

##### Em 1999, Jason Zander ajudou na criação de um CLR. Qual o significado de CLR?

Common Language Runtime

##### Qual é a ordem correta de atuação de cada componente dentro do .NET?

Código Fonte > Compilador da linguagem > Linguagem Intermediária > CLR > Linguagem de Máquina

##### Qual dos fatos a seguir não é verdadeiro?

Em 2014 o empresário Satya Nadella compra a Microsoft e se torna sócio majoritário da empresa. (FALSO)

O Roslyn é um novo compilador C# criado a partir de 2013.

Em 2010 a Microsoft lança comercialmente o Windows Azure.

O C# 1.0 foi lançado em 2002.

O .NET 1.0 foi lançado em 2000.

##### Qual o foco da Microsoft a partir de 2014?

Cloud.

##### O .NET Core é uma implementação open source e multiplataforma do .NET Standard. Qual dos itens abaixo é uma das outras implementações?

.NET Framework

##### O que era o projeto Mono criado por Miguel de Icaza em 2001?

Uma reimplementação black box do .NET, criado de forma independente por ele com foco em ser open source e multiplataforma.

##### Qual linguagem de programação começou a ser criada pela Microsoft em 1999 com ajuda de Anders Hejlsberg?

C#

##### Em qual ano surgiu a primeira versão do Visual Studio?

1997





- **QUESTIONÁRIO 02** - Iniciando com .NET

  

##### Qual dos itens abaixo é uma opção multiplataforma para edição/criação do meu código fonte em .NET?

Visual Studio Code.

##### Qual o comando para criar uma aplicação console via CLI do .NET com o nome 'Teste'?

dotnet new console -n Teste

##### O que faz o comando 'dotnet restore' na CLI do .NET?

Restaura os pacotes e dependências do projeto.

##### Qual o comando parâmetro para visualizar a documentação de ajuda da CLI do .NET?

--help

##### Qual é o comando da CLI do .NET para compilar o código fonte e gerar as DLL's?

dotnet build

##### Qual dos itens abaixo não compõe o pacote de instalação do .NET SDK?

Visual Studio Code

##### Qual dos itens abaixo é necessário ter instalado na máquina para desenvolver aplicações .NET?

.NET SDK

##### O que é uma aplicação console?

Uma aplicação que é executada em um terminal.

##### O que significa CLI?

Command Line Interface

##### Qual o comando para rodar uma aplicação .NET via CLI?

dotnet run





- **QUESTIONÁRIO 03** - Conhecendo o C#

  

##### Qual dos itens a seguir é parte da estrutura de um programa C#?

Membros, Tipos, Namespaces, Assemblies e Programas

##### Quem converte os assemblies em Linguagem de Máquina?

CLR

##### Qual dos itens a seguir é exemplo de tipo?

Classe (Outro exemplo é a interface)

##### Os assemblies gerados na compilação do C# geralmente possuem qual extensão?

.exe ou .dll

##### Quando os programas C# são compilados, eles são fisicamente empacotados em:

Assemblies.

##### O código e os recursos de Linguagem Intermediária são armazenados no disco em um arquivo executável chamado:

Assembly

##### Qual o nome da compilação para converter o código de Linguagem Intermediária em instruções de máquina nativas?

JIT (Just in Time)

##### Qual é a função do Garbage Collector?

Limpar objetos não utilizados da memória.

##### Qual dos itens a seguir é exemplo de membro?

Campos. (Outros: métodos, eventos e propriedades)

##### O que um código C# gera ao ser compilado no comando "dotnet build"?

Código compilado em Linguagem Intermediária.





- **QUESTIONÁRIO 04** - Conhecendo variáveis e instruções

  

##### O que é correto afirmar sobre variáveis de tipo Referência?

Variáveis de tipos de referência armazenam referências a seus ponteiros direto na memória.

##### Qual destes não é exemplo de um tipo Referência?

enum

##### Qual destes não é exemplo de um tipo Valor?

class

##### Quais destes são instruções de repetição?

for e while

##### Quais destes são instruções condicionais?

if e switch

##### Qual das afirmações não é verdadeira sobre Arrays?

Arrays são tipos de valor.

##### O que é correto afirmar sobre variáveis de tipo Valor?

Variáveis de tipos de valor contêm diretamente seus dados.

##### Quais destes são instruções para tratativa de exceções?

try e catch

##### Qual das inicializações de array a seguir é inválida?

string[] a = new int[] {1, 2, 3};

##### Os índices dos elementos de um array começam a ser contados em:

0





- **QUESTIONÁRIO 05** - Classes e Objetos Essenciais em C#

  

##### Sobre objetos é correto afirmar

Possui membros.

São instâncias de uma classe.

São criados usando o operador new.

A memória ocupada por um objeto é recuperada automaticamente quando o objeto não está mais acessível.

##### Qual dos itens abaixo não representa um tipo de acessibilidade de um membro?

static

##### O que são objetos?

São instâncias de uma classe.

##### Um método internal pode ser acessado por qualquer parte do código. Sobre esta afirmação:

Ela está correta em partes, pois o internal só pode ser acessado por classes do seu próprio assembly.

##### Quando a classe A herda da classe B, a classe A herda todos os membros da classe B. Sobre esta afirmação é correto afirmar que:

Nem todos os membros são herdados.

##### Sobre métodos estáticos é correto afirmar:

São acessados diretamente pela classe.

Não são visualizados através de uma instância da classe.

São declarados com o modificador "static".

Pertencem a classe e não ao objeto.

##### Uma classe é uma estrutura de dados que combina:

Estado e ações.

##### O que indica o modificar "ref" antes de um parâmetro em um método?

Indica que aquele parâmetro será passado como referência.

##### Sobre membros é correto afirmar:

Constantes, variáveis, métodos, propriedades e construtores são exemplos de membros.

Membros estáticos pertencem a classe e membros de instância pertencem ao objeto.

Cada membro de uma classe tem uma acessibilidade associada, que controla as regiões do texto do programa que podem acessar o membro.

Os membros de uma classe podem ser estáticos ou membros da instância.

##### Sobre métodos é errado afirmar:

Os métodos não podem ter um tipo de retorno.





- **QUESTIONÁRIO 06** - Trabalhando com structs, interfaces e enums

  

##### Qual área da memória que as Classes requerem alocação e as Structs não requerem?

Heap

##### Sobre Enums é correto afirmar:

Eles fornecem significado semântico a valores discretos.

##### Qual das alternativas abaixo não é verdadeira sobre Structs?

As structs são tipos de valor e requerem alocação de heap.

##### O que é uma Interface em C#?

Uma interface define um contrato que pode ser implementado por classes e structs.

##### O que é um Enum no C#?

É um tipo de valor distinto com um conjunto de constantes nomeadas.

##### O que são Structs?

São estruturas de dados que podem conter membros de dados e membros de ação.

##### Qual o tipo que as Strucuts se enquadram?

Tipo valor.

##### Qual área da memória que normalmente as Structs são alocadas?

Stack

##### Sobre Interface é correto afirmar:

Uma interface pode conter métodos, propriedades, eventos e indexadores.

Uma interface define um contrato que pode ser implementado por classes e structs.

Uma interface não fornece implementações dos membros que define - apenas suas “assinaturas”;

As interfaces podem empregar herança múltipla.

##### Um Enum que não declara explicitamente um tipo subjacente tem um tipo subjacente:

int
