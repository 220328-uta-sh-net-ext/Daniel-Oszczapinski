using RestaurantBL;
using RestaurantDL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;

string connectionStringFilePath = "C:/Revature/dotnet-training-220328/Daniel-Oszczapinski/Project 0/RestaurantApp/RestaurantDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

var builder = WebApplication.CreateBuilder(args);

var Config = builder.Configuration;

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
        ValidateIssuer = true,
        ValidateAudience = true
    };
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBL, OperationsBL>();
//builder.Services.AddScoped<IRepository>(repo => new SqlRepository(connectionString));//THis might not work, see pokemonapp for reference.
var app = builder.Build();

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
