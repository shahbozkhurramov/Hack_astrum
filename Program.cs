using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MedTech.Data;
using Microsoft.EntityFrameworkCore;
using MedTech.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MedTechDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MedTechConnection")));
builder.Services.AddRazorPages();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddServerSideBlazor();

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