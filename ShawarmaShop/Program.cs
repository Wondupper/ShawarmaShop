using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShawarmaShop;
using ShawarmaShop.ViewModels;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<CustomerViewModel>();
builder.Services.AddSingleton<SellerViewModel>();
builder.Services.AddSingleton<ShawarmaViewModel>();
builder.Services.AddSingleton<OrderViewModel>();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
