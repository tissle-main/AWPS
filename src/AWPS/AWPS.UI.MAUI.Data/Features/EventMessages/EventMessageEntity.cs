using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.PlantProfiles;

namespace AWPS.UI.MAUI.Data.Features.EventMessages;

public sealed class EventMessageEntity : IKeyedEntity
{
    //Value properties
    public Guid Id { get; set; } //Interfaces
    public DateTimeOffset Timestamp { get; set; }
    public EventMessageType MessageType { get; set; }
    public string Message { get; set; } = "";
    public Guid PlantProfileId { get; set; }

    //Navigation properties
    public PlantProfileEntity? PlantProfile { get; set; }
}