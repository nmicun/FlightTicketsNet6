using FlightTicketsNet6;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI5ODczQDMxMzkyZTMzMmUzMFVCTFRsOG56aTJQSG83dFBCVTFvUkpzMnUrSG9WY1BxR0QzdHV1MUwzRFU9");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
