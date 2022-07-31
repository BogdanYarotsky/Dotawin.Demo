using Dotawin.Client;
using Dotawin.Client.Data;
using static System.Environment;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddGrpcClient<Greeter.GreeterClient>(o =>
{
    var baseAddress = GetEnvironmentVariable("backendUrl");
    if (baseAddress == null) throw new ArgumentNullException(nameof(baseAddress));
    o.Address = new Uri(baseAddress);

}).ConfigurePrimaryHttpMessageHandler(() => // https://docs.microsoft.com/en-us/aspnet/core/grpc/performance?view=aspnetcore-6.0
    new SocketsHttpHandler
    {
        PooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan,
        KeepAlivePingDelay = TimeSpan.FromSeconds(60),
        KeepAlivePingTimeout = TimeSpan.FromSeconds(30),
        EnableMultipleHttp2Connections = true
    });

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
