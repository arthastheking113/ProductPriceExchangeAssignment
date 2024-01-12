using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProductPriceExchange.Client;
using ProductPriceExchange.Client.DI;
using ProductPriceExchange.Shared;
using System.Net;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();


builder.Services.AddHttpClient(StaticData.ApiName, client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.Timeout = new TimeSpan(0, 5, 0);
    client.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrLower;
    client.DefaultRequestVersion = HttpVersion.Version30;
});

builder.Services.RegisterService();

await builder.Build().RunAsync();
