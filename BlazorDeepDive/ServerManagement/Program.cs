using Microsoft.FluentUI.AspNetCore.Components;
using ServerManagement.Components;
using ServerManagement.Handlers;         

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

// Add services to the container.
//builder.Services.AddRazorComponents();
builder.Services.AddFluentUIComponents();

builder.Services.AddScoped<IActionHandler, LisOrderActionHandler>();
builder.Services.AddScoped<IActionHandler, InstrumentResultActionHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();