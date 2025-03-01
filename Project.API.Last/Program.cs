using ClassLibrary1.DAL;
using ClassLibrary1.BL;
using Microsoft.Extensions.FileProviders;
using ClassLibrary1.DAL.Data.Context;
using ClassLibrary1.DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using Project.API.Last;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDALService(builder.Configuration);
builder.Services.AddBLServices();
#region Identity

builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;

    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<ProjectContext>();

#endregion

#region Authentication

builder.Services.AddAuthentication(options =>
{
    // Configure used authentication 
    options.DefaultAuthenticateScheme = "MyDefault";
    options.DefaultChallengeScheme = "MyDefault"; // return 401 if not authenticated, 403 if authenticated but not authorized
})
// Define the authentication scheme
    .AddJwtBearer("MyDefault", options =>
    {
        var keyFromConfig = builder.Configuration.GetValue<string>(Constants.AppSettings.SecretKey)!;
        var keyInBytes = Encoding.ASCII.GetBytes(keyFromConfig);
        var key = new SymmetricSecurityKey(keyInBytes);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = key
        };
    });

#endregion

#region Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", b =>
        b
        .RequireClaim("type", "Admin")
        .RequireClaim(ClaimTypes.NameIdentifier));
});
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#region images
app.UseCors("all");
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider($"{Environment.CurrentDirectory}\\Images\\"),
    RequestPath = "/Images"
});
#endregion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
