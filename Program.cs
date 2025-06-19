using ProductAvailabilityService.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

builder.WebHost.ConfigureKestrel(options =>
{
    // Setup a HTTP/2 endpoint without TLS.
    //options.ListenLocalhost(5000, o => o.Protocols = HttpProtocols.Http2);
    options.ListenAnyIP(80, o => o.Protocols = HttpProtocols.Http2);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<ProductAvailabilityCheckService>();
app.MapGrpcReflectionService();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
