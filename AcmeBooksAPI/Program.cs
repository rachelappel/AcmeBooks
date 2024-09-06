using AcmeBooks.Models;
using AcmeBooksAPI.Models;
using AcmeBooksAPI.Services;
using AcmeBooksAPI.Services.BookInventoryManager;
using Microsoft.EntityFrameworkCore;


namespace AcmeBooksAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddDbContext<AcmeBooksDbContext>(options =>
                options.UseSqlite(@"Data Source=AcmeBooks.sqlite"));
          
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                });
            
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddTransient<Order>();
            builder.Services.AddTransient<OrderItem>();
            builder.Services.AddTransient<Customer>();
            
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
            
        }
    }
}