# akka-agent-lab
home hobby experiment on agent and actors

Requires the .NET 10 SDK.

Run the console application:

```sh
dotnet run --project AgentLab
```

The application hosts the `agent-system` ActorSystem using .NET Generic Host and
Akka.Hosting. It stays running until a shutdown signal is received. Press Ctrl+C
to stop it gracefully through Akka.NET CoordinatedShutdown. Akka logs use the
host's logging providers.

Register application actors with `WithActors` in the `AddAkka` configuration in
`AgentLab/Program.cs`.
