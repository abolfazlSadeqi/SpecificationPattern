using App;
using Domain.interfaces;
using Infra.EF;
using Infra.EF.Repositorys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<NewContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
AddIOC(builder);
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.MapControllers();


    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

// Ensure UseRouting is called before UseAuthorization and UseAuthentication
app.UseRouting();

app.Run();

#region IOc
static void AddIOC(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IPersonRepository, PersonRepository>();
    builder.Services.AddScoped<IPersonApp, PersonApp>();
}

#endregion