var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FluentWithAspire>("fluentwithaspire");

builder.Build().Run();
