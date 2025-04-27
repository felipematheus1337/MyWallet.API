# 📚 MyWalletApi
Sistema de gerenciamento de carteiras de usuários, com suporte a transações financeiras.

## 🚀 Tecnologias Utilizadas
.NET 8

ASP.NET Core Web API

Entity Framework Core (SQL Server)

AutoMapper

Swagger/OpenAPI

Repository Pattern + Unit of Work

Filtro Global de Exceptions (ApiExceptionFilter)

<hr>

## 🏗️ Estrutura do Projeto

Context/ - Configurações de banco de dados (DbContext)

Repositories/ - Repositórios para acesso aos dados

Services/ - Regras de negócio (camada de serviço)

Filter/ - Filtros de exceções globais

Mapper/ - Configuração de mapeamento entre entidades e DTOs

Controllers/ - Endpoints da API

<hr>

## 🧠 Principais Entidades
<img src="https://github.com/felipematheus1337/MyWallet.API/blob/dev/assets/er_diagrama.png?raw=true" />
Usuário

Possui 1 carteira

Contém informações como nome, email e senha (armazenada como hash)

Carteira

Pertence a um único usuário

Possui saldo e uma lista de transações

Transação

Pertence a uma carteira

Representa movimentações financeiras (entrada ou saída)

<hr>
 
## ⚙️ Como rodar o projeto localmente

Clone o repositório:
git clone https://github.com/seu-usuario/MyWalletApi.git

Navegue até a pasta do projeto:
cd MyWalletApi
Configure a connection string no arquivo appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=MyWalletDb;Trusted_Connection=True;"
  }
}
Execute as migrações para criar o banco de dados:

dotnet ef database update
Rode a aplicação:
dotnet run
<hr>

## 🛡️ Boas práticas implementadas
Uso de DTOs para proteger o modelo de domínio

Validação e tratamento de erros globais

Projeto modularizado seguindo Separation of Concerns (SoC)

Configuração do ReferenceHandler.IgnoreCycles para evitar problemas de navegação cíclica nos objetos

Uso de async/await para operações assíncronas

Commit explícito no UnitOfWork para garantir transações consistentes

## ✨ Melhorias Futuras
Implementar autenticação e autorização (JWT)

Registro de logs com serilog

Paginação em listagens de transações

Melhor detalhamento nas mensagens de erro

🧑‍💻
Feito com dedicação por Felipe Matheus 🚀

🔥 Observação
Esse projeto foi desenvolvido para praticar e demonstrar habilidades em arquitetura limpa com .NET 8 para aplicações Web API.
