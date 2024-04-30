var builder = DistributedApplication.CreateBuilder(args);

var inventoryDatabase = builder.AddPostgres("pgsql")
                               .PublishAsAzurePostgresFlexibleServer()
                               .AddDatabase("inventory");

var apiService = builder.AddProject<Projects.AspireWithPostgres_ApiService>("apiservice")
                        .WithReference(inventoryDatabase);

builder.AddProject<Projects.AspireWithPostgres_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
