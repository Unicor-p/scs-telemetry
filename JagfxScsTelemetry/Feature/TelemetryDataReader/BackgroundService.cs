using Microsoft.AspNetCore.SignalR;
using SCSSdkClient;
using SCSSdkClient.Object;

namespace JagfxScsTelemetry.Feature.TelemetryDataReader;

public class BackgroundService( IHubContext< Hub > hubContext ) : Microsoft.Extensions.Hosting.BackgroundService {
    private const string SHARED_MEMORY_MAP = "Local\\SCSTelemetry";
    private const int    TIME_MS           = 100;

    private SharedMemory _sharedMemory;

    protected override async Task ExecuteAsync( CancellationToken stoppingToken ) {
        _sharedMemory = new SharedMemory();
        _sharedMemory.Connect( SHARED_MEMORY_MAP );

        DoWork();

        using PeriodicTimer timer = new(TimeSpan.FromMilliseconds( TIME_MS ));

        try {
            while ( await timer.WaitForNextTickAsync( stoppingToken ) ) DoWork();
        } catch ( OperationCanceledException ) {
            // _logger.LogInformation("Timed Hosted Service is stopping.");
        }
    }

    private void DoWork() {
        SCSTelemetry scsTelemetry = _sharedMemory.Update< SCSTelemetry >();

        hubContext.Clients.All.SendAsync( ClientMethods.TELEMETRY_RAW, scsTelemetry );

        // _logger.LogInformation("Timed Hosted Service is working. Count: {Count}", count);
    }
}