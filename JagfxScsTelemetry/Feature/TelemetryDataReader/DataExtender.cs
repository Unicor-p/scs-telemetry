using JagfxScsTelemetry.Common.ScsTelemetryExtended;
using SCSSdkClient.Object;

namespace JagfxScsTelemetry.Feature.TelemetryDataReader;

public interface IDataExtender {
    IScsTelemetryExtended Extend( SCSTelemetry scsTelemetry );
}

public class DataExtender : IDataExtender {
    public IScsTelemetryExtended Extend( SCSTelemetry scsTelemetry ) {
        var scsTelemetryExtended = new ScsTelemetryExtended {
            Scale = scsTelemetry.CommonValues.Scale + 10
        };

        return scsTelemetryExtended;
    }
}