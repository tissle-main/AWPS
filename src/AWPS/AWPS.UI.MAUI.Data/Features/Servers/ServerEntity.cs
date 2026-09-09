using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.IoTDevices;
using AWPS.UI.MAUI.Data.Features.PlantProfiles;

namespace AWPS.UI.MAUI.Data.Features.Servers;

public sealed class ServerEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces

    //Navigation properties
    public List<PlantProfileEntity> PlantProfiles { get; set; } = [];
    public List<IoTDeviceEntity> IoTDevices { get; set; } = [];
}