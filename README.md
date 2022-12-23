<h1 align="center">
   <p>CondominioDev - API</p>
  Projeto desenvolvido para o curso DEVinHouse
</h1> 


## 💻 Sobre o projeto

O projeto trata-se de uma API desenvolvida em .NET Core 6 com Entity Framework, para um sistema de cadastro e relatório mensal de um Condominio.

## 🌱Aprendizados
- Atuar em projeto .Net com Entity Framework em C#, conectando em base SQL Server
- SQL: Comandos DDL e DML
- Banco de Dados: Modelagem de dados relacional, modelagem física, modelagem conceitual, modelagem lógica e SQL Server
- Versionamento: Git e GitHub

## ⚙️ Requisitos

Organização Git:
- Utilização do padrão baseado em GitFlow com branches master/main, features e releases
- Utilização de commits curtos e concisos

Requisito geral da aplicação: 
- Novo Habitante
- Listagem de habitantes por ID, nome, mês e idade
- Atualização de cadastro
- Deletar um habitante
- Deletar um habitante
Relatório financeiro do Condominio:
- Morador com maior custo
- Orçamento total do condominio
- O somatório da renda de todos os habitantes

Criar modelagem de dados do condomínio:
- Modelagem conceitual:Exportar esboço do modelo seguido das entidades
- Modelagem Lógica: Exportar PDF ou PNG do BrModelo (Apenas o Diagrama)
- Modelagem Física: Exportar PDF ou PNG do BrModelo (Apenas o Diagrama)

## 🚀 Como executar o projeto

Este projeto é uma aplicação web em Backend.

### Pré-requisitos

Para rodar o projeto em sua máquina, você vai precisar ter instalado as seguintes ferramentas:
[Git](https://git-scm.com) e [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
Além disto é importante ter um editor para trabalhar com o código, como [VisualStudio](https://visualstudio.microsoft.com/) e um sistema gerenciador de Banco de dados relacional, como o [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

#### 🎲 Rodando a Aplicação

<ol start="1">
<li>Clone o projeto </li>

```bash
# Clone este repositório
$ git clone https://github.com/hibrunasimoes/condominiodev-api.git
```

<li> Para Windowns, vá para o arquivo <b style="color:#7b9eeb">appsettings.json</b> e adicione a ConnectionString, seguindo o modelo abaixo: <br>

```bash
"ConnectionStrings": {
  "ServerConnection": "Server=YOURSERVER\\SQLEXPRESS;Database=BD_CONDOMINIODEVAPI;Trusted_Connection=True;"
  }
```
</li>
  <li> Para Mac, vá para o arquivo <b style="color:#7b9eeb">appsettings.json</b> e adicione a ConnectionString, seguindo o modelo abaixo: <br>

```bash
"ConnectionStrings": {
  "ServerConnection": "Server=localhost;Database=BD_CONDOMINIODEVAPI;User=SA;Password=yourpassword;"
  }
```
</li>
  
<li>Se necessário, instale as seguintes dependências, via NuGet:</li>
<ul>
<li>Microsoft.EntityFrameworkCore</li>
<li>Microsoft.EntityFrameworkCore.Tools</li>
<li>Microsoft.EntityFrameworkCore.Design</li>
<li>Microsoft.EntityFrameworkCore.SqlServer</li>
<li>Swashbuckle.AspNetCore</li>
</ul><br>

<li>Após o comando executado, atualize o Banco de Dados</li>

```bash
dotnet ef database update
```
<li>Pronto, sua aplicação está pronta para rodar</li>

```bash
dotnet watch run
```
## Autor
Bruna Simões
