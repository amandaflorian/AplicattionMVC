# AplicattionMVC

Este projeto é um CRUD simples de cadastro de contatos desenvolvido em ASP.NET MVC (C#). Ele permite cadastrar, visualizar, editar e excluir contatos.

## Tecnologias Utilizadas

- ASP.NET MVC (C#)
- Entity Framework
- SQL Server
- Bootstrap (para estilização básica)

## Funcionalidades

- Criar novos contatos
- Listar contatos cadastrados
- Editar informações de um contato
- Excluir contatos

## Estrutura do Projeto

- **Models**: Contém a classe `Contato`, que representa a entidade do banco de dados.
- **Controllers**: Contém o `ContatoController`, responsável pelo CRUD.
- **Views**: Páginas Razor para exibição dos contatos e formulários de edição/criação.
- **Data**: Contém o contexto do banco de dados (DbContext).

## Configuração do Banco de Dados

1. Configure a string de conexão no arquivo `appsettings.json`.
2. Execute as migrações para criar o banco de dados:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Como Executar

1. Clone o repositório:
   ```sh
   git clone https://github.com/amandaflorian/AplicattionMVC.git
   ```
2. Abra o projeto no Visual Studio.
3. Configure o SQL Server e aplique as migrações.
4. Execute a aplicação pressionando `F5` ou rodando o comando:
   ```sh
   dotnet run
   ```

## Contribuição

Sinta-se à vontade para abrir issues ou enviar pull requests para melhorias.

## Licença

Este projeto está sob a licença MIT. Para mais informações, consulte o arquivo LICENSE.

---

Desenvolvido por Amanda Florian.



