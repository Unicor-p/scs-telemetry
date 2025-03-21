using TelemetryDataReader = JagfxScsTelemetry.Feature.TelemetryDataReader;

// Setup application
WebApplicationBuilder builder = WebApplication.CreateBuilder( args );
builder.Services.AddCors( options => {
    options.AddDefaultPolicy( config => { config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); } );
} );
builder.Services.AddSignalR();
builder.Services.AddHostedService< TelemetryDataReader.BackgroundService >();

// Start application
WebApplication app = builder.Build();
app.UseCors();
app.MapHub< TelemetryDataReader.Hub >( TelemetryDataReader.Hub.PATTERN ); // Not yet use. But necessary to initialize a connection
app.Run();