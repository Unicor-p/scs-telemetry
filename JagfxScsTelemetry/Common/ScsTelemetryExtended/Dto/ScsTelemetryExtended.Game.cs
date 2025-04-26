using SCSSdkClient;
using SCSSdkClient.Object;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public interface IGame {
    SCSTelemetry.Time Time        { get; }
    SCSGame           Id          { get; }
    bool              SdkIsActive { get; }
}

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public class Game : IGame {
        public SCSTelemetry.Time Time        { get; internal set; }
        public SCSGame           Id          { get; internal set; }
        public bool              SdkIsActive { get; internal set; }
    }
}