using JagfxScsTelemetry.Common.ScsTelemetryExtended.AtomicDto;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public partial class Truck {
        public class Transmission {
            public TruckShifterType  ShifterType                     { get; internal set; }
            public string            GearDisplayed                   { get; internal set; }
            public string            GearSelector                    { get; internal set; }
            public TruckGearSelector GearDisplayedWithoutShifterType { get; internal set; }
        }
    }
}