using CleanArchitectureGraphQl.Infrastructure;
using CleanArchitectureGraphQl.Appplication;
using GraphQL.Server;
using CleanArchitectureGraphQl.Appplication.Common.GraphQl.AppSchema;
using CleanArchitectureGraphQl.Appplication.Common.GraphQl.Queries;
using GraphiQl;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQL().AddSystemTextJson();

builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
builder.Services.AddProblemDetails();
builder.Services.AddInfrastructureServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseGraphQL<BookSchema>();   

app.UseGraphQLGraphiQL("/ui/graphql");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
