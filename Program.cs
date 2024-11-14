using System;
using System.Linq;
using Livraria_Projeto.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DbContextInMemory>(options =>
    options.UseInMemoryDatabase("BookshopDb"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Trabalho Final",
        Version = "v1",
        Description = "API para gerenciamento de produtos, promoções, vendas e logs de estoque",
        Contact = new OpenApiContact
        {
            Name = "Luiz Carlos Orlandi junior",
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();