namespace JagfxScsTelemetry.Feature.TelemetryDataReader;

public struct ClientMethods {
    public const string TELEMETRY_RAW      = "ReceivedTelemetryRaw";
    public const string TELEMETRY_EXTENDED = "ReceivedTelemetryExtended";
}

public class Hub : Microsoft.AspNetCore.SignalR.Hub {
    public const string PATTERN = "/telemetry";

    // public async Task SendMessage(string user, string message)
    // {
    //     await Clients.All.SendAsync(ClientMethods.TELEMETRY_RAW, user, message);
    // }
}