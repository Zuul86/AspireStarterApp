var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStaterDemo_ApiService>("apiservice");

builder.AddProject<Projects.AspireStaterDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
