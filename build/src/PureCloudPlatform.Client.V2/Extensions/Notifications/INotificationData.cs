namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    public interface INotificationData
    {
        string TopicName { get; set; }
        string Version { get; set; }
        Metadata Metadata { get; set; }
    }
}