
using WEBAPI.Controllers;

namespace WEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            //IScopedService scopedService = new ScopedService();
            //ISingletonService singletonService = new SingletonService();

            //TestController testController = new TestController(scopedService, singletonService);

















            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IScopedService, ScopedService>(); //susikuria ties kiekvienu request
            builder.Services.AddSingleton<ISingletonService, SingletonService>();//susikuria viena kartà kai programa pasileidþia
            builder.Services.AddTransient<ITransientService, TransientService>();//susikuria kiekviena kartà

            builder.Services.AddScoped<IApplesService, ApplesService>();


            builder.Services.AddScoped<IAppleRepository, AppleRepository>();

            builder.Services.AddSingleton<IAppleStorage, AppleStorage>();

            builder.Services.AddHttpClient();


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
