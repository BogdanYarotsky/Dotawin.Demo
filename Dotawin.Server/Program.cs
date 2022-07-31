using Dotawin.Server.Models;
using Dotawin.Server.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var isContainer = Environment.GetEnvironmentVariable("isContainer");
var configConnString = isContainer == null ? "local" : "docker";
var connStr = builder.Configuration.GetConnectionString(configConnString);
builder.Services.AddDbContext<DotaContext>(o => o.UseNpgsql(connStr));
builder.Services.AddGrpc();
var app = builder.Build();
app.MapGrpcService<GreeterService>();
app.MapGrpcService<UpdaterService>();
app.Run();
