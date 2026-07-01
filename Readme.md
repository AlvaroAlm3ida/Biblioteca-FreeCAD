# Biblioteca-FreeCAD
📌 Descrição curta (campo "About")  API REST em ASP.NET Core para catalogar peças modeladas no FreeCAD, com metadados, imagens e arquivos

# BibliotecaFreeCAD

API REST desenvolvida em **ASP.NET Core** para catalogar e organizar peças modeladas no **FreeCAD**, funcionando como um portfólio técnico pessoal.

Projeto criado como forma de aprendizado prático de C#, ASP.NET Core e Entity Framework, evoluindo em fases incrementais.

## ✨ Funcionalidades

- 📦 Cadastro de peças com metadados (nome, material, dimensões, categoria)
- 🖼️ Upload de imagens/renders das peças *(em desenvolvimento)*
- 📁 Armazenamento do arquivo `.FCStd` original *(em desenvolvimento)*
- 🔐 Autenticação via JWT *(planejado)*
- 🔍 Filtros e busca por categoria/material *(planejado)*

## 🛠️ Tecnologias

- **.NET 9** / ASP.NET Core
- **Entity Framework Core**
- **SQLite**
- **Swagger / OpenAPI**

## 📂 Estrutura do projeto
BibliotecaFreeCAD/

├── Controllers/

├── Models/

├── Data/

├── Program.cs

└── appsettings.json


## 🚀 Como rodar

```bash
git clone https://github.com/seu-usuario/BibliotecaFreeCAD.git
cd BibliotecaFreeCAD
dotnet restore
dotnet run
```

A documentação da API estará disponível via Swagger em `https://localhost:{porta}/swagger`.

## 🗺️ Roadmap

- [x] CRUD básico de peças
- [ ] Relacionamento com Projetos
- [ ] Upload de arquivos (.FCStd e imagens)
- [ ] Autenticação JWT
- [ ] Filtros e paginação

## 📖 Sobre o projeto

Este repositório documenta minha jornada aprendendo C# e ASP.NET Core, aplicando os conceitos na construção de um catálogo para minhas peças modeladas no FreeCAD.
