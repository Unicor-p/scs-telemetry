using JagfxScsTelemetry.Common.ScsTelemetryExtended.AtomicDto;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public partial class Truck {
        public class Fuel {
            public Unit< decimal > Level              { get; internal set; }
            public int             LevelPercentage    { get; internal set; }
            public Unit< int >     Capacity           { get; internal set; }
            public Unit< decimal > AverageConsumption { get; internal set; }
        }
    }
}