namespace DotawinGRPC.Updater.Services;

using Grpc.Net.ClientFactory;
using System.Threading.Tasks;

public class UpdaterService : IUpdaterClientService
{
    private readonly Updater.UpdaterClient _client;

    public UpdaterService(GrpcClientFactory grpcClientFactory)
    {
        _client = grpcClientFactory.CreateClient<Updater.UpdaterClient>("Updater");
    }

    public async Task<PatchInfo> GetPatchInfo()
    {
        return await _client.GetLatestPatchAsync(new PatchRequest());
    }

    public Task<UpdateResult> SendDotaUpdate(DotaUpdate update) => throw new NotImplementedException();
    public async Task<string> SendMessage(string message) =>
        (await _client.SayHelloAsync(new HelloRequest(message))).Message;
}
