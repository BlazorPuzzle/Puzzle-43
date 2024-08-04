using Microsoft.AspNetCore.Components;
using Puzzle_43;
using Puzzle_43.Client;
using Puzzle_43.Client.Pages;
using Puzzle_43.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
		.AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<IEpisodeService, ServerEpisodeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapEpisodeApi();

app.MapRazorComponents<App>()
		.AddInteractiveWebAssemblyRenderMode()
		.AddAdditionalAssemblies(typeof(Puzzle_43.Client._Imports).Assembly);

app.Run();
