using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Http.Timeouts;
using RinhaBackend.Data;
using RinhaBackend.Endpoints;

var builder = WebApplication.CreateSlimBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RinhaDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"))
);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var clienteGroup = app.MapGroup("/clientes");

clienteGroup.MapGet("/", Cliente.GetClientes);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
