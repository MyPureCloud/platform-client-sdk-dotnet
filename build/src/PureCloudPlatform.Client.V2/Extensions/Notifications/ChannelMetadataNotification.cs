using System.Runtime.Serialization;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
	///<Summary>
	/// ChannelMetadataNotification class
	///</Summary>
	public class ChannelMetadataNotification
	{
		///<Summary>
		/// Message
		///</Summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }
	}
}
