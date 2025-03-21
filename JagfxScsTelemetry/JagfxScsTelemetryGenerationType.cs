using TypeGen.Core.SpecGeneration;
using TelemetryDataReader = JagfxScsTelemetry.Feature.TelemetryDataReader;

namespace JagfxScsTelemetry;

public class JagfxScsTelemetryGenerationType : GenerationSpec {
    public override void OnBeforeGeneration( OnBeforeGenerationArgs args ) {
        AddClass< TelemetryDataReader.ClientMethods >();
        AddInterface< TelemetryDataReader.Hub >();
    }
}