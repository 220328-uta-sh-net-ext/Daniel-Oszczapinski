global using Serilog;
using RestaurantBL;
using RestaurantDL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RestuarantAPI.Repository;


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/dotnet-training-220328/Daniel-Oszczapinski/Project 0/RestaurantApp/RestaurantUI/Logging.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager Config = builder.Configuration;

// Add services to the container.

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    var key = Encoding.UTF8.GetBytes(Config["JWT:Key"]);
    o.SaveToken = true;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidIssuer = Config["JWT:Issuer"],
        ValidAudience = Config["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IJWTManagerRepository, JWTManagerRepository>();
builder.Services.AddScoped<IBL, OperationsBL>();
builder.Services.AddScoped<IRepository>(repo => new SqlRepository(Config.GetConnectionString("RestaurantDb")));//THis might not work, see pokemonapp for reference.

var app = builder.Build();
app.Logger.LogInformation("App Started");
// Configure the HTTP request pipeline.
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
