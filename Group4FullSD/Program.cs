using Group4FullSD.Components;
using Group4FullSD.Components.Account;
using Group4FullSD.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // Creates instance of the application

// Get the connection string from the configuration
var connectionString = builder.Configuration.GetConnectionString("Group4FullSDContextConnection")
    ?? throw new InvalidOperationException("Connection string 'Group4FullSDContextConnection' not found.");

// Add DbContextFactory
builder.Services.AddDbContextFactory<Group4FullSDContext>(options =>
    options.UseSqlServer(connectionString));

// Add the database developer page exception filter (called once)
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Razor Components and Interactive Server Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add Authentication and Identity services
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

// Configure Identity services
builder.Services.AddIdentityCore<Group4FullSDUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Group4FullSDContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Singleton EmailSender (can be replaced with an actual implementation)
builder.Services.AddSingleton<IEmailSender<Group4FullSDUser>, IdentityNoOpEmailSender>();
builder.Services.AddControllers();

var app = builder.Build(); // Builds the web application instance

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection(); // Adds HTTPS redirection middleware
app.UseStaticFiles(); // Serve static files (CSS, JS, images, etc.)
app.UseAntiforgery(); // Adds Anti-forgery token protection

// Map interactive components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();// Enable interactive server render mode
app.UseRouting();

// Map default controller route and identity endpoints
app.MapAdditionalIdentityEndpoints();
app.MapControllers();
app.Run(); // Run the application
