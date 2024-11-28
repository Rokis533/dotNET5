
using Microsoft.EntityFrameworkCore;
using PotatoApi.Database;
using PotatoApi.Repositories;

namespace PotatoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("Database")
               )
            );
            builder.Services.AddHttpClient();

            builder.Services.AddScoped<IPotatoRepository, PotatoRepository>();
            builder.Services.AddScoped<ICalculationService, CalculationService>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    policy => policy.WithOrigins("*")
                                    .AllowAnyHeader()
                                    .AllowAnyMethod());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors("AllowLocalhost");

            app.UseMiddleware<GlobalExceptionHandlingMidleware>();

            app.MapControllers();

            app.Run();
        }
    }
}
