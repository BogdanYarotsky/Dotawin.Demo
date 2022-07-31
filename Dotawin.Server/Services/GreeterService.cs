namespace Dotawin.Server.Services;
using Dotawin.Server;
using Dotawin.Server.Models;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    private readonly DotaContext _db;

    public GreeterService(ILogger<GreeterService> logger, DotaContext db)
    {
        _logger = logger;
        _db = db;
    }

    public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        var hero = await _db.Heroes.FirstOrDefaultAsync();
        return new HelloReply
        {
            Message = $"{hero?.Name} is a fucking piece of junk. Have a nice day!"
        };
    }
}
