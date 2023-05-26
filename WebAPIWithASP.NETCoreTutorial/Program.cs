using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ASP.NETCoreWebAPIwithUnitOfWork.Data;
using ASP.NETCoreWebAPIwithUnitOfWork.Service;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Services;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Repositories;
using ASP.NETCoreWebAPIwithUnitOfWork.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.

// setup EF service
builder.Services.AddDbContext<CatalogoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CatalogoDB")));

// Register of services 
builder.Services.AddScoped<IAvaliacaoService, AvaliacaoService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IComentarioService, ComentarioService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>(); 

// Register of repositories
builder.Services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IComentarioRepository, ComentarioRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
