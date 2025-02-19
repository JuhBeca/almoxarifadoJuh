using AlmoxarifadoBackAPI.Repositorio;
using AlmoxarifadoBackAPI.Repositorio_pro;
using AlmoxarifadoBackAPI.Repositorio_For;
using AlmoxarifadoBackAPI.Repositorio_Ent;
using AlmoxarifadoBackAPI.Repositorio_sai;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
//builder.Services.AddScoped<CategoriaRepositorio>();
builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
<<<<<<< HEAD
builder.Services.AddScoped< IProdutosRepositorio, ProdutosRepositorio >();
builder.Services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
builder.Services.AddScoped<ISecretariaRepositorio, SecretariaRepositorio>();
builder.Services.AddScoped<IEntradaRepositorio, EntradaRepoitorio>();
builder.Services.AddScoped<ISaidaRepositorio, SaidaRepositorio>();
builder.Services.AddScoped<IItensEntradaRepositorio, ItensEntradaRepositorio>();
builder.Services.AddScoped<IItensSaidaRepositorio, ItensSaidaRepositorio>();


=======
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
>>>>>>> LayoutPadrão

builder.Services.AddDbContext<Context1>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddDbContext<Context2>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
builder.Services.AddDbContext<Context3>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IEntradaRepositorio, EntradaRepositorio>();
builder.Services.AddDbContext<Context4>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<ISaidaRepositorio, SaidaRepositorio>();

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
