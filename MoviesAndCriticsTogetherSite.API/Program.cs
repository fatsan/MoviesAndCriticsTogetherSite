using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Concretes;
using MoviesAndCriticsTogetherSite.DataAccess.Contexts;
using MoviesAndCriticsTogetherSite.Service.Abstracts;
using MoviesAndCriticsTogetherSite.Service.Concretes;
using MoviesAndCriticsTogetherSite.Service.Profiles;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IMovieRepository, EfMovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IArtistRepository, EfArtistRepository>();
builder.Services.AddScoped<IArtistService, ArtistService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
