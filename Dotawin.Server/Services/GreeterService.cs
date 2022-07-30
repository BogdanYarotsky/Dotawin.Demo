namespace Dotawin.Server.Services;
using Dotawin.Server;
using Grpc.Core;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Your are fucking blazor piece of junk. Have a nice day!"
        });
    }
}
