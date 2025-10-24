using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmployeeApp;
using EmployeeApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// <-- Read API base URL from appsettings.json -->
var apiBaseUrl = builder.Configuration["ApiBaseUrl"];

// Register HttpClient with API base URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl!) });

// Register EmployeeService
builder.Services.AddScoped<EmployeeService>();

await builder.Build().RunAsync();
