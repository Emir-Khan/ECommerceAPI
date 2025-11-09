using System.Linq;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Moq;

namespace ECommerceAPI.API.Tests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        public Mock<IPaymentService> PaymentServiceMock { get; private set; } = new();
        public Mock<IOrderService> OrderServiceMock { get; private set; } = new();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ECommerceAPIDbContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<ECommerceAPIDbContext>(options =>
                {
                    options.UseInMemoryDatabase("ECommerceAPITestDb");
                });

                services.RemoveAll<IPaymentService>();
                PaymentServiceMock = new Mock<IPaymentService>();
                services.AddSingleton(PaymentServiceMock);
                services.AddSingleton<IPaymentService>(sp => PaymentServiceMock.Object);

                services.RemoveAll<IOrderService>();
                OrderServiceMock = new Mock<IOrderService>();
                services.AddSingleton(OrderServiceMock);
                services.AddSingleton<IOrderService>(sp => OrderServiceMock.Object);

                services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = "Admin";
                    options.DefaultChallengeScheme = "Admin";
                }).AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("Admin", options => { });

                var sp = services.BuildServiceProvider();

                using var scope = sp.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<ECommerceAPIDbContext>();
                db.Database.EnsureCreated();
            });
        }
    }
}
