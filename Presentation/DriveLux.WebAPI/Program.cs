using DriveLux.Application.Features.RepositoryPattern;
using DriveLux.Application.Interfaces.BlogInterfaces;
using DriveLux.Application.Interfaces.CarInterfaces;
using DriveLux.Application.Interfaces.CarPricingInterfaces;
using DriveLux.Application.Interfaces.TagCloudInterfaces;
using DriveLux.Application.Interfaces;
using DriveLux.Persistence.Context;
using DriveLux.Persistence.Repositories.BlogRepositories;
using DriveLux.Persistence.Repositories.CarPricingRepositories;
using DriveLux.Persistence.Repositories.CarRepositories;
using DriveLux.Persistence.Repositories.CommentRepositories;
using DriveLux.Persistence.Repositories.TagCloudRepositories;
using DriveLux.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using DriveLux.Application.Features.CQRS.Handlers.AboutHandlers;
using DriveLux.Application.Features.CQRS.Handlers.BannerHandlers;
using DriveLux.Application.Features.CQRS.Handlers.BrandHandlers;
using DriveLux.Application.Features.CQRS.Handlers.CarHandlers;
using DriveLux.Application.Features.CQRS.Handlers.ContactHandlers;
using DriveLux.Application.Services;
using DriveLux.Application.Interfaces.StatisticsInterfaces;
using DriveLux.Persistence.Repositories.StatisticsRepositories;
using DriveLux.Application.Interfaces.RentCarInterfaces;
using DriveLux.Persistence.Repositories.RentCarRepositories;
using DriveLux.Application.Interfaces.CarFeatureInterfaces;
using DriveLux.Persistence.Repositories.CarFeatureRepositories;
using DriveLux.Application.Interfaces.CarDescriptionInterfaces;
using DriveLux.Persistence.Repositories.CarDescriptionRepositories;
using DriveLux.Application.Interfaces.ReviewInterfaces;
using DriveLux.Persistence.Repositories.ReviewRepository;
using FluentValidation.AspNetCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


// Context ve Repository Sýnýflarý
builder.Services.AddScoped<DriveLuxContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IRentCarRepository), typeof(RentCarRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));



// About Sýnýfý Konfigürasyonu
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

// Banner Sýnýfý Konfigürasyonu
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();


// Brand Sýnýfý Konfigürasyonu
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();

// Car Sýnýfý Konfigürasyonu
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

// Contact Sýnýfý Konfigürasyonu
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();

// Mediator registration

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddDbContext<DriveLuxContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




builder.Services.AddControllers().AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
