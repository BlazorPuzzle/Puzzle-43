using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Puzzle_43.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IEpisodeService, EpisodeService>();

await builder.Build().RunAsync();
