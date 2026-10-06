# Consumer Advice API

Aplicação de console em C# que consome a API pública **Advice Slip** e exibe um conselho aleatório no terminal.

## Funcionamento

A aplicação realiza uma requisição HTTP assíncrona para:

```text
https://api.adviceslip.com/advice
```

A resposta JSON é desserializada com `System.Text.Json` e o campo de conselho é exibido no console.

## Tecnologias

- C#
- .NET
- `HttpClient`
- `System.Text.Json`
- API REST

## Como executar

Com o .NET SDK instalado:

```bash
dotnet restore
dotnet run
```

## Objetivo

Projeto acadêmico voltado à prática de consumo de APIs REST, requisições HTTP assíncronas e desserialização de JSON em C#.
