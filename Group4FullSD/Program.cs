using Group4FullSD.Components;
using Group4FullSD.Components.Account;
using Group4FullSD.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); //creates instance of the application
var connectionString = builder.Configuration.GetConnectionString("Group4FullSDContextConnection") ?? throw new InvalidOperationException("Connection string 'Group4FullSDContextConnection' not found.");;

builder.Services.AddDbContext<Group4FullSDContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.
//add razor and interactive server components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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

builder.Services.AddIdentityCore<Group4FullSDUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Group4FullSDContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<Group4FullSDUser>, IdentityNoOpEmailSender>();

var app = builder.Build(); //builds the web application instance

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //adds a middleware 

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); //enable interactive srver mode

app.MapAdditionalIdentityEndpoints();;

app.Run();
