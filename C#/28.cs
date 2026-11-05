/* var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => " TRAINER ");

int somar()
{
    return 4 + 4;
}

string menssagem()
{
    return "Boa noite!";
}

int subtrair()
{
    return 10 - 4;
}

app.MapGet("/menssagem", () => menssagem());
app.MapGet("/somar", () => somar());
app.MapGet("/subitrair", () => subtrair());

app.Run();
