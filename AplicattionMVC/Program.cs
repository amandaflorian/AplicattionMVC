using AplicattionMVC.Data;
using AplicattionMVC.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao contêiner.
builder.Services.AddControllersWithViews();

// Configura o Entity Framework Core com SQL Server
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

// Adiciona o repositório como um serviço Scoped
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

var app = builder.Build();

// Configura o pipeline de requisição HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contato}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
