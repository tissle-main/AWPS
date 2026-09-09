using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.PlantProfiles;

namespace AWPS.UI.MAUI.Data.Features.Measurements;

public sealed class MeasurementEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces
    public DateTimeOffset Timestamp { get; set; }
    public byte LightPercent { get; set; }
    public byte MoisturePercent { get; set; }
    public byte HumidityPercent { get; set; }
    public sbyte TemperatureCelsium { get; set; }
    public Guid PlantProfileId { get; set; }

    //Navigation properties
    public PlantProfileEntity? PlantProfile { get; set; }
}