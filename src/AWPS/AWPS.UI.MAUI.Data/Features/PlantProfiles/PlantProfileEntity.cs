using AWPS.UI.MAUI.Data.Features.Servers;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.Measurements;
using AWPS.UI.MAUI.Data.Features.EventMessages;
using AWPS.UI.MAUI.Data.Features.DeviceSettings;

namespace AWPS.UI.MAUI.Data.Features.PlantProfiles;

public sealed class PlantProfileEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces
    public string Name { get; set; } = "";
    public Guid ServerId { get; set; }

    //Navigation properties
    public ServerEntity? Server { get; set; }
    public DeviceSettingsEntity? DeviceSettings { get; set; }
    public List<MeasurementEntity> Measurements { get; set; } = [];
    public List<EventMessageEntity> EventMessages { get; set; } = [];
}