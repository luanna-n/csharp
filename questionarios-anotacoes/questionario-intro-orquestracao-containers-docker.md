# Introdução a Orquestração de Containers com Docker :woman_technologist:

## **EXERCÍCIOS TEÓRICOS**



- **QUESTIONÁRIO 01 - Introdução ao tema**

##### O que é Dockerfile?

É um arquivo de texto que contém instruções para criar(build) uma imagem.

##### O que é Escalonamento horizontal?

É a ação de adicionar mais nós (VM/Container) de um sistema.

##### O que é uma TAG?

É a forma de versionar nossas imagens.

##### O que é Docker Image?

É um pacote com todas as dependências para criar o container.

##### Qual desses comandos listam os containers que estão rodando:

docker ps

##### Quais destes comandos criam um container:

docker run --name meu-primeiro-container -p 80:80 -d nginx

##### Qual destes ambientes é o mais ideal para rodar nossos microsserviços?

Container.

##### O que é Escalonamento vertical?

É a ação de aumentar os recursos utilizados como CPU e Memória.

##### O que é Docker?

É uma tecnologia de conteinerização que permite a criação e o uso de contêineres.

##### Quando criamos um container qual a primeira ação que vemos no console:

O pull (download) da imagem do repositório para nosso Docker.

<br>

- **QUESTIONÁRIO 02 - Primeiros passos com o Docker**

##### Onde o Docker é executado no Windows?

Em uma máquina virtual.

##### Preciso saber qual volume está montado em um container, qual parâmetro me possibilita isso?

inspect

##### Quais destes não é um requisito para instalação do Docker no Linux:

Suporte a virtualização.

##### Qual parâmetro realiza um merge de todas as camadas da nossa imagem?

export

##### Qual pré-requisito precisamos contemplar para instalar o Docker em um Windows?

Suporte a virtualização.

##### Sobre camadas, arquivos que serão constantemente modificados ao criar uma imagem, em qual posição do nosso Dockerfile o acionamos?

Na última linha possível.

##### Qual parâmetro do Docker run expõe a porta do container para a internet?

--publish ou -p

##### Qual comando é utilizado para instalar o Docker no Ubuntu?

apt-get install docker.io

##### Quais destes parâmetros possibilita o acesso a um container:

exec

##### Para adicionar novas camadas a minha imagem, o que preciso modificar:

Dockerfile.

<br>

- **QUESTIONÁRIO 03 - Rede do Docker**

##### O que é preciso ter para que containers em hosts diferentes se comuniquem?

Cluster(swarm, k8s,...)

##### Qual destas rede é a default na criação de um Container:

Bridge

##### Quais destas afirmações não é verdadeira?

Todos containers já se comunicam nativamente.

##### Qual destes comando cria uma rede no modo bridge?

docker network create -d brigde redeBridge

##### Ao utilizar a rede host ao container, o que não conseguiremos fazer?

Ter N containers expondo a mesma porta.

##### Qual comando aumenta o numero de replicas de um serviço swarm?

docker service scale <service_name>=<int>

##### Qual comando usamos para criar nossos containers em um ambiente Swarm?

docker service create...

##### Para que dois container consigam se comunicar, o que precisamos fazer?

Criar uma rede e adicioná-los a ela.

##### Como containers que utilizam a rede no modo host se comunicam entre si?

Localhost, modificando apenas a porta que estão expondo.

##### Qual comando ingressa um node a um cluster Swarm?

docker swarm join...

<br>

- **QUESTIONÁRIO 04 - Armazenamento no Docker**

##### Em um disco temporário, tmpfs. Como limitamos seu tamanho?

--tmpfs-size=...

##### Ao utilizar bind, se não criarmos um diretório antes de mapeá-lo o que irá ocorrer?

A pasta será criada automaticamente.

##### Qual tipo de armazenamento cria arquivos no host caso eles já existam na imagem:

volume

##### Para mapear pastas/arquivos do host para container, qual tipo de armazenamento devemos escolher:

bind

##### Em um container sem armazenamento mapeado, quando o container for removido o que acontecerá com os dados criados quando estava em execução?

Deixarão de existir.

##### Qual destes comando cria um volume?

docker volume create meuVolume

##### Para armazenar arquivos temporários qual tipo de armazenamento devemos escolher:

tmpfs

<br>

- **QUESTIONÁRIO 05 - Nosso projeto no ar!**

##### Quantos nodes (servidores) são necessários para iniciar um cluster de swarm?

1

##### Qual recurso é importante ser limitado:

Memória.

##### Qual destes é um repositório de imagens?

DockerHub

##### Qual parâmetro do Dockefile permite a conexão na porta da aplicação criada?

EXPOSE

##### O que é Docker-compose.yaml?

É a receita de bolo da nossa aplicação, terá as definições de quais container precisamos e suas características.

##### Qual parâmetro nos permite instalar aplicação no momento do build da nossa imagem?

RUN

##### Qual parâmetro do Docker run utilizamos para limitar CPU e Memória?

--cpus e --memory

