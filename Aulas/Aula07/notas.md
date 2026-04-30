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

## Adicionando o projeto Greet como dependencia do projeto Greet.Tests

```bash
cd Greet.Tests
dotnet add reference ../Greet
cd ..
```

## Criando um projeto de programa executável com dependência de Greet

```bash
dotnet new console --language F# -o Main
cd Main
dotnet add reference ../Greet
cd ..
dotnet solution add Main
```

## Resumo: criando a solution completa

```bash
dotnet new solution
dotnet new classlib --language F# -o Greet
dotnet new console --language F# -o Main
dotnet new xunit --language F# -o Greet.Tests
dotnet solution add Main
dotnet solution add Greet
dotnet solution add Greet.Tests
cd Main
dotnet add reference ../Greet
cd ..
cd Greet.Tests
dotnet add reference ../Greet
cd ..
```

```bash
dotnet build
dotnet test
```
