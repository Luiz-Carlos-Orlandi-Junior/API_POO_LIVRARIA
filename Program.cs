using System;
using System.Linq;
using Livraria_Projeto.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext usando um banco de dados em memória
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BookshopDb"));

// Adicionando serviços fundamentais pra desenvoler APIs com controladores
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

// Configuração do Swagger para documentação da API
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Trabalho Final",
        Version = "v1",
        Description = "API para gerenciamento de produtos, promoções, vendas e logs de estoque",
        Contact = new OpenApiContact
        {
            Name = "Luiz Carlos Orlandi",
        }
    });
});

var app = builder.Build();

// Configuração do middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();