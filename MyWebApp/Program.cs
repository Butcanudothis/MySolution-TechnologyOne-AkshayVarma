using System.ComponentModel;
using NumericWordsConversion;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// redirect 404 to Pages/error/404.cshtml
app.UseStatusCodePagesWithRedirects("/errors/{0}");
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
