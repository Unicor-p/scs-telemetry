using JagfxScsTelemetry.Common.ScsTelemetryExtended.AtomicDto;

namespace JagfxScsTelemetry.Common.ScsTelemetryExtended.Dto;

public partial class ScsTelemetryExtended : IScsTelemetryExtended {
    public interface ITruck {
        Unit< decimal >   Speed              { get; }
        Unit< int >       Odometer           { get; }
        bool              HasTruck           { get; }
        string?           LicensePlate       { get; }
        int               AverageDamage      { get; }
        int               ChassisDamage      { get; }
        int               Damage             { get; }
        bool              EngineIsStarted    { get; }
        bool              IgnitionIsTurnedOn { get; }
        bool              IgnitionStart      { get; }
        bool              HasWarnings        { get; }
        bool              HasErrors          { get; }
        bool              HasEngineWarning   { get; }
        Unit< decimal >   CruiseControlSpeed { get; }
        Truck.Fuel        FuelValues         { get; }
        Truck.AdBlue      AdBlueValues       { get; }
        Truck.Pressure    PressureValues     { get; }
        Truck.Temperature TemperatureValues  { get; }
    }

    public partial class Truck : ITruck {
        public Truck() {
            FuelValues        = new Fuel();
            AdBlueValues      = new AdBlue();
            PressureValues    = new Pressure();
            TemperatureValues = new Temperature();
        }

        // Common
        public Unit< decimal > Speed              { get; internal set; }
        public Unit< int >     Odometer           { get; internal set; }
        public bool            HasTruck           { get; internal set; }
        public string?         LicensePlate       { get; internal set; }
        public int             AverageDamage      { get; internal set; }
        public int             ChassisDamage      { get; internal set; }
        public int             Damage             { get; internal set; }
        public bool            EngineIsStarted    { get; internal set; }
        public bool            IgnitionIsTurnedOn { get; internal set; }
        public bool            IgnitionStart      { get; internal set; }
        public bool            HasWarnings        { get; internal set; }
        public bool            HasErrors          { get; internal set; }
        public bool            HasEngineWarning   { get; internal set; }
        public Unit< decimal > CruiseControlSpeed { get; internal set; }

        public Fuel        FuelValues        { get; internal set; }
        public AdBlue      AdBlueValues      { get; internal set; }
        public Pressure    PressureValues    { get; internal set; }
        public Temperature TemperatureValues { get; internal set; }
    }
}