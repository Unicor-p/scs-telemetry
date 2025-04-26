namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public interface IScsTelemetryExtended {
    ScsTelemetryExtended.Game   GameValues  { get; }
    ScsTelemetryExtended.ITruck TruckValues { get; }
}

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    // TODO Remove this; It's for the initial test only
    public Game   GameValues  { get; internal set; }
    public ITruck TruckValues { get; internal set; }
}