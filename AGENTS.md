# Repository instructions

Follow the shared command-line instructions in:
@C:\Users\StanislavLastovka\.codex\RTK.md

## C# code style

Use Microsoft's common C# coding conventions as the baseline:
- https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
- https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

- Indent with four spaces; do not use tabs.
- Place opening and closing braces on separate lines (Allman style).
- Write one statement and one declaration per line.
- Use `PascalCase` for types, namespaces, methods, properties, events, and constants.
- Prefix interface names with `I`, for example `IActorService`.
- Use `camelCase` for parameters and local variables, and `_camelCase` for private instance fields.
- Choose descriptive names and avoid unnecessary abbreviations.
- Use C# type keywords such as `string`, `int`, and `bool`.
- Use `var` when the type is clear from the expression; otherwise specify the type.
- Keep `using` directives at the top of the file, outside the namespace; place `System` directives first and remove unused directives.
- Keep nullable reference types enabled and handle nullability explicitly.
- Use `async`/`await` for asynchronous I/O and suffix asynchronous methods with `Async`, except where a framework defines the name.
- Avoid blocking asynchronous operations with `.Wait()` or `.Result`.
- Use `using` or `await using` to dispose owned resources.
- Keep code simple and readable; write comments to explain intent rather than restate the code.
- Follow existing surrounding style for choices not covered here. Honor applicable `.editorconfig` settings if added.

## Project structure

- Keep actors in `Actors/` within their project. Each actor must have its own subfolder, for example `Actors/WorkerActor/WorkerActor.cs`.
- Keep application models in `Models/`.
- Keep clients in `Clients/`, with a separate subfolder for each client.
- Keep DTOs specific to a client in that client's `DTO/` subfolder, for example `Clients/ExampleClient/DTO/ExampleResponse.cs`.

```text
AgentLab/
  Actors/
    WorkerActor/
      WorkerActor.cs
  Models/
    WorkItem.cs
  Clients/
    ExampleClient/
      ExampleClient.cs
      DTO/
        ExampleResponse.cs
  Program.cs
```

## Validation

- Build with `dotnet build AgentLab.slnx` after code changes (prefix shell commands with `rtk` as required above).
- Run relevant existing tests when behavior changes.
- Keep changes focused on the requested task; avoid unrelated formatting.
