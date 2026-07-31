var builder = WebApplication.CreateBuilder(args);

//Acessando o appsettings.json para pegar a string de conexão com o banco de dados
var defaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var defaultLogLevel = builder.Configuration.GetValue<LogLevel>("Logging:LogLevel:Default");

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
