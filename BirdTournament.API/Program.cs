using BirdTournament.Bussiness.Service;
using BirdTournament.Data.Repository;
using CrudApiTemplate.Repository;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.InitServices();


builder.Services.AddDbContext<BirdTournamentDataContext>();

builder.Services.AddScoped<IUnitOfWork, BirdTournamentUnitOfWork>();

var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

var option = new RewriteOptions();
option.AddRedirect("^$", "swagger");
app.UseRewriter(option);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
