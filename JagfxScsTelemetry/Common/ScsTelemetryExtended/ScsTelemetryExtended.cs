namespace JagfxScsTelemetry.Common.ScsTelemetryExtended;

public interface IScsTelemetryExtended { }

public class ScsTelemetryExtended : IScsTelemetryExtended {
    public float Scale { get; internal set; }
}