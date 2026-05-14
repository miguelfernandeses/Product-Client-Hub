# 📦 Product Client Hub (.NET)

API REST desenvolvida em .NET para o controle e gerenciamento de clientes e seus respectivos produtos. O projeto foca em uma arquitetura organizada, separando responsabilidades em bibliotecas de classes para comunicações e tratamento de exceções.

Este projeto foi desenvolvido com o auxílio do curso da **Rocketseat** para aprofundamento na criação de APIs com C#.

---

## 🚀 Tecnologias

* **Linguagem:** C#
* **Framework:** .NET 10
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQLite
* **Documentação:** Swagger (OpenAPI)

---

## 📌 Funcionalidades

### Gestão de Clientes
* Criar cliente
* Listar clientes
* Buscar por ID do cliente
* Atualizar dados do cliente
* Excluir cliente

### Gestão de Produtos
* Criar produtos para o cliente
* Excluir produtos

---

## 📂 Estrutura do Projeto

A solução foi estruturada adicionando projetos como bibliotecas de classes para separar as responsabilidades:
* **Web API:** Ponto de entrada da aplicação.
* **Infrastructure:** Gerenciamento do banco de dados e conexão (`ProductClientHubDbContext`).
* **Communication:** Biblioteca de classes para comunicações.
* **Exceptions:** Biblioteca de classes para padronização de exceções.

---

## ⚙️ Configuração e Instalação

### Pré-requisitos
* SDK do **.NET 10**

### ⚠️ Configuração Importante (Banco de Dados)
Como o projeto utiliza SQLite local, é **necessário** configurar o caminho do banco de dados na sua máquina para que a API funcione corretamente:
1. No seu projeto, navegue até o arquivo: `ProductClientHub/Infrastructure/ProductClientHubDbContext.cs`.
2. Na **linha 13**, altere o caminho do banco de dados para o local exato onde ele está salvo no seu computador.

### Execução no Visual Studio
1. Clone o repositório para a sua máquina.
2. Abra a solução no Visual Studio.
3. Faça a configuração do banco de dados explicada acima.
4. Pressione `F5` ou clique no botão **Start** para rodar a aplicação.

---

## 📘 Swagger

Com a aplicação rodando, a interface do Swagger abrirá automaticamente no seu navegador, permitindo testar todos os endpoints de clientes e produtos diretamente pela interface (geralmente em `https://localhost:<porta>/swagger`).
