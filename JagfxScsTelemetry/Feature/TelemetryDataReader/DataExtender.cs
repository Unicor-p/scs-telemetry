using JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;
using SCSSdkClient.Object;
using ScsTelemetryExtended = JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto.ScsTelemetryExtended;

namespace JagfxScsTelemetry.Feature.TelemetryDataReader;

public interface IDataExtender {
    IScsTelemetryExtended Extend( SCSTelemetry scsTelemetry );
}

public class DataExtender : IDataExtender {
    public IScsTelemetryExtended Extend( SCSTelemetry scsTelemetry ) {
        // Forward simple values
        var scsTelemetryExtended = new ScsTelemetryExtended {
            GameValues = {
                Id          = scsTelemetry.Game,
                SdkIsActive = scsTelemetry.SdkActive,
                Time        = scsTelemetry.CommonValues.GameTime
            },
        };

        // Compute values

        return scsTelemetryExtended;
    }
}