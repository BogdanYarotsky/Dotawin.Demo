namespace Dotawin.Server.Services;

using Dotawin.Server.Models;

public class UpdaterService : Updater.UpdaterBase
{
    private readonly DotaContext _db;

    public UpdaterService(DotaContext db)
    {
        _db = db;
    }
}
