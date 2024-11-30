var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.NetAspire_Arm_ApiService>("apiservice");

builder.AddProject<Projects.NetAspire_Arm_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
