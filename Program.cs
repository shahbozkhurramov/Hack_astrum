using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CSA.Data;
using Microsoft.EntityFrameworkCore;
using CSA.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CSADbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CSAConnection")));
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryItemRepository, CategoryItemRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddServerSideBlazor();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
