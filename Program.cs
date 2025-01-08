using Endpoint_FiveToSeven.Services.Mini5;
using Endpoint_FiveToSeven.Services.Mini6;
using Endpoint_FiveToSeven.Services.Mini7A;
using Endpoint_FiveToSeven.Services.Mini7B;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibsService, MadLibsService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphanumericService, ReverseItAlphanumericService>();
builder.Services.AddScoped<IReverseItNumericService, ReverseItNumericService>();

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
