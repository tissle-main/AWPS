using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.PlantProfiles;

namespace AWPS.UI.MAUI.Data.Features.DeviceSettings;

public sealed class DeviceSettingsEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces
    public bool KeepActive { get; set; }
    public TimeSpan MeasurementPeriod { get; set; }
    public TimeSpan WateringDuration { get; set; }
    public TimeSpan WateringCyclePeriod { get; set; }
    public int WateringCycleCount { get; set; }
    public Guid PlantProfileId { get; set; }

    //Navigation properties
    public PlantProfileEntity? PlantProfile { get; set; }
}