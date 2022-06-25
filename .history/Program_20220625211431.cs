using GraphiQl;
using GraphQL.Execution;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<IProduct, ProductService>();
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ISchema, ProductSchema>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Switch of Metrics From GraphQL Server


builder.Services.AddGraphQL(o =>
{
    o.EnableMetrics = false;
}).AddSystemTextJson();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();