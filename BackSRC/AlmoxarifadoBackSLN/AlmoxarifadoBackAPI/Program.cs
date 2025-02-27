using AlmoxarifadoBackAPI.Repositorio;
using AlmoxarifadoBackAPI.Repositorio_pro;
using AlmoxarifadoBackAPI.Repositorio_For;
using AlmoxarifadoBackAPI.Repositorio_Ent;
using AlmoxarifadoBackAPI.Repositorio_sai;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var builder2 = WebApplication.CreateBuilder(args);

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

var jwtSettings = builder2.Configuration.GetSection("JwtSettings");
var key = Encoding.UTF8.GetBytes(jwtSettings["Secret"]);

builder2.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidateAudience = true,
        ValidAudience = jwtSettings["Audience"],
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

builder2.Services.AddAuthorization();
builder2.Services.AddControllers();

var app2 = builder2.Build();

app2.UseAuthentication(); // Middleware de autenticação
app2.UseAuthorization(); // Middleware de autorização

app2.MapControllers();

app2.Run();
