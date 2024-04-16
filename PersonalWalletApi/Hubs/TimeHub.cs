using Microsoft.AspNetCore.SignalR;

namespace PersonalWalletApi.Hubs;

public class TimeHub : Hub
{
    public async IAsyncEnumerable<string> Streaming(CancellationToken cancellationToken)
    {
        while (true)
        {
            yield return DateTime.UtcNow.ToString();
            await Task.Delay(1000, cancellationToken);
        }
    }
}
