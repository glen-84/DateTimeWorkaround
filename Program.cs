var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .BindRuntimeType<DateTime, CustomDateTimeType>()
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
