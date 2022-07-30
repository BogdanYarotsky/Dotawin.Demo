using Dotawin.Server.Models;
using Dotawin.Server.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connStr = builder.Configuration.GetConnectionString("docker");
builder.Services.AddDbContext<DotaContext>(o => o.UseNpgsql(connStr));
builder.Services.AddGrpc();
var app = builder.Build();
app.MapGrpcService<GreeterService>();
app.Run();
