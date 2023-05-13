using EjemploCleanCode.Application.Repository;
using EjemploCleanCode.Application.Service;
using EjemploCleanCode.Application.ServiceImpl;
using EjemploCleanCode.Infrastructure.Data;
using EjemploCleanCode.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EjemploCleanCode.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddDbContext<UniversidadContext>(options => options.UseSqlServer(configuration.GetConnectionString("universidad")));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IAlumnoRepository, AlumnoRepository>();
            builder.Services.AddScoped<IAlumnoService, AlumnoServiceImpl>();

            builder.Services.AddScoped<IDocenteRepository, DocenteRepository>();
            builder.Services.AddScoped<IDocenteService, DocenteServiceImpl>();

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
        }
    }
}