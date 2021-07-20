# Arquitetura de Sistemas Avançado :woman_technologist:

## **EXERCÍCIOS TEÓRICOS**

<br>

- **QUESTIONÁRIO 01** - Conceitos de integração de sistemas e mensageria <br>

##### Quais são as principais vantagens da arquitetura em mensageria assíncrona?

Desacoplamento e buffer de comunicação entre serviços.

##### Como rastrear um fluxo em uma arquitetura de mensagens assíncronas?

Usando um metadata nos logs e indexá-los em um único lugar.

##### Qual a vantagem da comunicação assíncrona?

Um serviço “quebrado” não interferir no outro.

##### Dado que o Serviço A escreve mensagens que são consumidas pelo Serviço B, o que precisa ser feito para “aposentar” o Serviço A e colocar o Serviço C em seu lugar e continuar produzindo as mensagens para o Serviço B?

Desativar o Serviço A e habilitar o Serviço C para produzir mensagens na mesma fila que o Serviço A produzia.

##### O que define uma arquitetura em mensageria?

Serviços que produzem e consomem mensagens de um message broker.

##### Dado que o Serviço A escreve mensagens que são consumidas pelo Serviço B, o que precisa ser feito para “aposentar” o Serviço B e colocar o Serviço C em seu lugar e continuar processando as mensagens do Serviço A?

Desabilitar o Serviço B e fazer o Serviço C consumir mensagens da fila do Serviço A.

##### Qual possível problema pode se ter com arquitetura em mensageria assíncrona?

Inconsistência de dados por não recebimento de mensagens.

##### Qual a maior desvantagem de centralizar todas as mensagens em um único Message Broker?

Ter dependência de um message broker em todos os serviços (Single point of failure).

##### Como lidar com erros ao processar uma mensagem de forma assíncrona?

O consumidor que sofrer o erro deve lidar com erro (ex. Dead Letter Queue).

##### Qual pattern pode ser usado com essa arquitetura?

Event source



<br>

- **QUESTIONÁRIO 02** - Arquitetura de dados não estruturados e business intelligence <br>

##### Dados semi-estruturados: I - Possuem uma estrutura de organização, mas é flexível. II - Não possuem estrutura alguma, admitindo qualquer tipo de informação. III - Podem também ser utilizados substituindo banco de dados estruturados.

I e III estão corretas.

##### Quais são consideradas “dimensões” em DW?

Tempo, Geografia e Membros.

##### Leia as sentenças sobre Big Data e assinale a alternativa correta. I - É um conjunto muito grande dados, estruturados ou não. II - Não há um banco de dados específico, mas sim uma composição de várias origens. III - Pode ser armazenado somente em banco de dados semi-estruturados..

I e II estão corretas.

##### O que significa OLTP?

On Line Transaction Processing.

##### Qual característica não é marcante em OLAP?

Dados voláteis, passíveis de modificação.

##### Qual informação esta incorreta sobre BI?

Considera apenas dados gerados pelos profissionais de BI.

##### Qual ou quais são ferramentas de Big Data?

Storm. Spark. DataTorrent. Hadoop.

Todas as alternativas são ferramentas de Big Data.

##### Qual das alternativas é uma características de OLTP:

Dados voláteis, passíveis de modificação e exclusão.

##### Qual das alternativas não é exemplo de um banco de dados NoSQL?

ApacheDB.

##### Quais das ferramentas abaixo são opções para Analytics em BI?

Microsoft Power BI. Tableu. IBM Cognos Analytics. SAP Business Objects.

Todas as alternativas estão corretas.



<br>

- **QUESTIONÁRIO 03** - Fundamentos de arquitetura de aplicações em nuvem <br>

##### O que é Cloud Computing?

Solução de servidores servida por um provedor.

##### O que é IaaS?

Infraestrutura como serviço

##### Qual das opções abaixo é um provedor de BaaS?

Firebase.

##### O que é BaaS?

Backend como Serviço.

##### O que é Serverless?

É um modelo de execução de computação em nuvem no qual o provedor de nuvem executa o servidor e gerencia dinamicamente a alocação de recursos da máquina.



##### Em relação a disponibilidade de serviço, como o PaaS nos ajuda?

Proporcionando um meio de escalar a infraestrutura de forma automatizada.

##### Qual das opções abaixo é um provedor de cloud computing?

Amazon Web Services.

##### Qual das opções abaixo é uma ferramenta de receita provisionamento?

Terraform AWS

##### O que é PaaS?

Plataforma como Serviço.

##### Em caso de uma arquitetura não serverless, qual o melhor meio de obter alta disponibilidade em cloud?

Utilizando um orquestrador de containers como Kubernetes.



<br>

- **QUESTIONÁRIO 04** - Desenvolvimento e operação de software integrado <br>

##### Os cincos pilares do acrônimo CALMS são:

Cultura, automatização, enxuto, mensurável e compartilhamento.

##### Assinale a alternativa que melhor define inspeção contínua:

Coleta e análise de métricas de qualidade do software.

##### Marque a opção correta:

CircleCI e AppVeyor são ferramentas de CI/CD.

##### Marque a única afirmativa incorreta:

O caminho “Aprendizado” permite que o desenvolvedor não tenha culpa de erros.

##### As principais etapas para a produção de software em conjunto entre desenvolvimento e operações são:

Planejamento, codificação, teste, release, deploy, operação e monitoramento.

##### Complete: “Além de gerar conhecimento, _________ criam previsibilidade sobre possíveis incidentes que possam vir a surgir”

Métricas.

##### Marque a alternativa que melhor define se as afirmações abaixo são verdadeiras ou falsas: I – Entrega Contínua não necessita de um aprovador para realizar o deploy. II – A construção e o teste unitário são componentes da Integração Contínua. III – Implantação Contínua prevê o deploy automático para um determinado ambiente.

F - V - V.

##### A Integração Contínua é uma responsabilidade principalmente da(s) área(s) de:

Desenvolvimento e Operações.

##### Complete: “ __________________ é uma métrica definida baseada no número de caminhos independentes possíveis em um código”.

Complexidade Ciclomática.

##### Qual afirmativa define melhor o conceito de DevOps?

É a colaboração entre as equipes, compartilhamento de conhecimento e práticas que integram e automatizam processos.