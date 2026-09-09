using AWPS.UI.MAUI.Data.Features.Servers;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;

namespace AWPS.UI.MAUI.Data.Features.IoTDevices;

public sealed class IoTDeviceEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces
    public Guid ServerId { get; set; }

    //Navigation properties
    public ServerEntity? Server { get; set; }
}