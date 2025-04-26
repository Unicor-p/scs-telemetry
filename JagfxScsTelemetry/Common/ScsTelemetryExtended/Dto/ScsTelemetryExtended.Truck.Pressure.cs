using JagfxScsTelemetry.Common.ScsTelemetryExtended.AtomicDto;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public partial class Truck {
        public class Pressure {
            public Unit< int > Oil      { get; internal set; }
            public Unit< int > BrakeAir { get; internal set; }
        }
    }
}