using graphQL.Application.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<QueryGetBooks>();

var app = builder.Build();

app.MapGraphQL();

app.Run();