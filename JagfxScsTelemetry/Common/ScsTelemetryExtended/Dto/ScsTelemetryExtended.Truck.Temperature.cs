using JagfxScsTelemetry.Common.ScsTelemetryExtended.AtomicDto;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public partial class Truck {
        public class Temperature {
            public Unit< decimal > EngineWater { get; internal set; }
            public Unit< decimal > EngineOil   { get; internal set; }
            public Unit< decimal > Brake       { get; internal set; }
        }
    }
}