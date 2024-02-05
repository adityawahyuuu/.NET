using graphQL.Application;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();

var app = builder.Build();
app.MapGraphQL();
app.Run();