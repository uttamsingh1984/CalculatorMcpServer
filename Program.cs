using CalculatorMcpServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddMcpServer().WithHttpTransport().WithTools<CalculatorTools>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapMcp("/mcp");

app.MapControllers();

app.Run();
