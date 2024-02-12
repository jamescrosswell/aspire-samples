var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireWithSentry_ApiService>("apiservice");

builder.AddProject<Projects.AspireWithSentry_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
