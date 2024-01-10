using MiniChallengeFiveToSeven_Endpoints.Services.MadLib;
using MiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;
using MiniChallengeFiveToSeven_Endpoints.Services.ReverseItAlphanumeric;
using MiniChallengeFiveToSeven_Endpoints.Services.ReverseItNumbers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphanumericService, ReverseItAlphanumericService>();
builder.Services.AddScoped<IReverseItNumbersService, ReverseItNumbersService>();

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

app.Run();
