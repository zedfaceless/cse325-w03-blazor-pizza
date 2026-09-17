using System.Globalization;
using BlazingPizza;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-PH");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-PH");
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<OrderState>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();