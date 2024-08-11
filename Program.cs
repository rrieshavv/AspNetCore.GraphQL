using Api.Database;
using Api.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddSingleton<Repository>()
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
