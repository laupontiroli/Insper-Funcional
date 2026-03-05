# Trabalhando com .NET

## Fazer um novo solution

- Vá para o seu diretório favorito
- `dotnet new solution`

## Criando uma biblioteca

```bash
dotnet new classlib --language F# -o Greet
```

## Adicionando o projeto na solution

```bash
dotnet solution add Greet
```

## Criando um projeto de testes e adicionando na solution

```bash
dotnet new xunit --language F# -o Greet.Tests
dotnet solution add Greet.Tests
```