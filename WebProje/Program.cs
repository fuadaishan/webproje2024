using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebProje.Data;
using Microsoft.AspNetCore.Identity;
using WebProje.Models;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Reflection;
using Microsoft.Extensions.Options;
using WebProje.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region
builder.Services.AddSingleton<LanguageService>();
// Configure Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Configure MVC with Localization and DataAnnotationsLocalization
builder.Services.AddMvc()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization(options =>
        options.DataAnnotationLocalizerProvider = (type, factory) =>
        {
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            return factory.Create(nameof(SharedResource), assemblyName.Name);
        });

builder.Services.Configure<RequestLocalizationOptions>(options =>
{

    var supportedCultures = new List<CultureInfo>
    {
        new CultureInfo("en-US"),
        new CultureInfo("tr-TR"),

    };
    options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
});


#endregion

builder.Services.AddSession();


builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddDbContext<ApplicationContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(builder.Configuration.GetConnectionString("default"),
            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("default")))
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors()
);

builder.Services.AddIdentity<User, IdentityRole>(options =>
    {
        options.Password.RequiredLength = 1;
        options.Password.RequireDigit = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.User.RequireUniqueEmail = true;
        options.SignIn.RequireConfirmedAccount = false;
    })
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>();
// builder.Services.AddTransient<DBInit>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

void GenerateHashedPassword(string password) {
    var passwordHasher = new PasswordHasher<object>();
    var hashedPassword = passwordHasher.HashPassword(null, password); 
    Console.WriteLine($"Hashed Password: {hashedPassword}"); }

GenerateHashedPassword("123");
app.Run();