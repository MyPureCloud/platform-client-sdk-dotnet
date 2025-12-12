using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebActionEventsNotificationWebActionMessage
	/// </summary>
	[DataContract]
	public partial class JourneyWebActionEventsNotificationWebActionMessage : IEquatable<JourneyWebActionEventsNotificationWebActionMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationWebActionMessage" /> class.
		/// </summary>
		/// <param name="Action">Action.</param>
		/// <param name="ActionTarget">ActionTarget.</param>
		/// <param name="ActionMap">ActionMap.</param>
		/// <param name="ErrorCode">ErrorCode.</param>
		/// <param name="ErrorMessage">ErrorMessage.</param>
		/// <param name="UserAgentString">UserAgentString.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="IpOrganization">IpOrganization.</param>
		/// <param name="Browser">Browser.</param>
		/// <param name="Device">Device.</param>
		/// <param name="Geolocation">Geolocation.</param>
		/// <param name="MktCampaign">MktCampaign.</param>
		/// <param name="VisitReferrer">VisitReferrer.</param>
		/// <param name="TimeToDisposition">TimeToDisposition.</param>
		public JourneyWebActionEventsNotificationWebActionMessage(JourneyWebActionEventsNotificationEventAction Action = null, JourneyWebActionEventsNotificationActionTarget ActionTarget = null, JourneyWebActionEventsNotificationActionMap ActionMap = null, string ErrorCode = null, string ErrorMessage = null, string UserAgentString = null, string IpAddress = null, string IpOrganization = null, JourneyWebActionEventsNotificationBrowser Browser = null, JourneyWebActionEventsNotificationDevice Device = null, JourneyWebActionEventsNotificationGeoLocation Geolocation = null, JourneyWebActionEventsNotificationMktCampaign MktCampaign = null, JourneyWebActionEventsNotificationReferrer VisitReferrer = null, long? TimeToDisposition = null)
		{
			this.Action = Action;
			this.ActionTarget = ActionTarget;
			this.ActionMap = ActionMap;
			this.ErrorCode = ErrorCode;
			this.ErrorMessage = ErrorMessage;
			this.UserAgentString = UserAgentString;
			this.IpAddress = IpAddress;
			this.IpOrganization = IpOrganization;
			this.Browser = Browser;
			this.Device = Device;
			this.Geolocation = Geolocation;
			this.MktCampaign = MktCampaign;
			this.VisitReferrer = VisitReferrer;
			this.TimeToDisposition = TimeToDisposition;

		}



		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationEventAction Action { get; set; }



		/// <summary>
		/// Gets or Sets ActionTarget
		/// </summary>
		[DataMember(Name = "actionTarget", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationActionTarget ActionTarget { get; set; }



		/// <summary>
		/// Gets or Sets ActionMap
		/// </summary>
		[DataMember(Name = "actionMap", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationActionMap ActionMap { get; set; }



		/// <summary>
		/// Gets or Sets ErrorCode
		/// </summary>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public string ErrorCode { get; set; }



		/// <summary>
		/// Gets or Sets ErrorMessage
		/// </summary>
		[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
		public string ErrorMessage { get; set; }



		/// <summary>
		/// Gets or Sets UserAgentString
		/// </summary>
		[DataMember(Name = "userAgentString", EmitDefaultValue = false)]
		public string UserAgentString { get; set; }



		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string IpAddress { get; set; }



		/// <summary>
		/// Gets or Sets IpOrganization
		/// </summary>
		[DataMember(Name = "ipOrganization", EmitDefaultValue = false)]
		public string IpOrganization { get; set; }



		/// <summary>
		/// Gets or Sets Browser
		/// </summary>
		[DataMember(Name = "browser", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationBrowser Browser { get; set; }



		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationDevice Device { get; set; }



		/// <summary>
		/// Gets or Sets Geolocation
		/// </summary>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationGeoLocation Geolocation { get; set; }



		/// <summary>
		/// Gets or Sets MktCampaign
		/// </summary>
		[DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationMktCampaign MktCampaign { get; set; }



		/// <summary>
		/// Gets or Sets VisitReferrer
		/// </summary>
		[DataMember(Name = "visitReferrer", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationReferrer VisitReferrer { get; set; }



		/// <summary>
		/// Gets or Sets TimeToDisposition
		/// </summary>
		[DataMember(Name = "timeToDisposition", EmitDefaultValue = false)]
		public long? TimeToDisposition { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebActionEventsNotificationWebActionMessage {\n");

			sb.Append("  Action: ").Append(Action).Append("\n");
			sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
			sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
			sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
			sb.Append("  Browser: ").Append(Browser).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
			sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
			sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
			sb.Append("  TimeToDisposition: ").Append(TimeToDisposition).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings
			{
				MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
				Formatting = Formatting.Indented
			});
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as JourneyWebActionEventsNotificationWebActionMessage);
		}

		/// <summary>
		/// Returns true if JourneyWebActionEventsNotificationWebActionMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebActionEventsNotificationWebActionMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebActionEventsNotificationWebActionMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
				) &&
				(
					this.ActionTarget == other.ActionTarget ||
					this.ActionTarget != null &&
					this.ActionTarget.Equals(other.ActionTarget)
				) &&
				(
					this.ActionMap == other.ActionMap ||
					this.ActionMap != null &&
					this.ActionMap.Equals(other.ActionMap)
				) &&
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode)
				) &&
				(
					this.ErrorMessage == other.ErrorMessage ||
					this.ErrorMessage != null &&
					this.ErrorMessage.Equals(other.ErrorMessage)
				) &&
				(
					this.UserAgentString == other.UserAgentString ||
					this.UserAgentString != null &&
					this.UserAgentString.Equals(other.UserAgentString)
				) &&
				(
					this.IpAddress == other.IpAddress ||
					this.IpAddress != null &&
					this.IpAddress.Equals(other.IpAddress)
				) &&
				(
					this.IpOrganization == other.IpOrganization ||
					this.IpOrganization != null &&
					this.IpOrganization.Equals(other.IpOrganization)
				) &&
				(
					this.Browser == other.Browser ||
					this.Browser != null &&
					this.Browser.Equals(other.Browser)
				) &&
				(
					this.Device == other.Device ||
					this.Device != null &&
					this.Device.Equals(other.Device)
				) &&
				(
					this.Geolocation == other.Geolocation ||
					this.Geolocation != null &&
					this.Geolocation.Equals(other.Geolocation)
				) &&
				(
					this.MktCampaign == other.MktCampaign ||
					this.MktCampaign != null &&
					this.MktCampaign.Equals(other.MktCampaign)
				) &&
				(
					this.VisitReferrer == other.VisitReferrer ||
					this.VisitReferrer != null &&
					this.VisitReferrer.Equals(other.VisitReferrer)
				) &&
				(
					this.TimeToDisposition == other.TimeToDisposition ||
					this.TimeToDisposition != null &&
					this.TimeToDisposition.Equals(other.TimeToDisposition)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				if (this.ActionTarget != null)
					hash = hash * 59 + this.ActionTarget.GetHashCode();

				if (this.ActionMap != null)
					hash = hash * 59 + this.ActionMap.GetHashCode();

				if (this.ErrorCode != null)
					hash = hash * 59 + this.ErrorCode.GetHashCode();

				if (this.ErrorMessage != null)
					hash = hash * 59 + this.ErrorMessage.GetHashCode();

				if (this.UserAgentString != null)
					hash = hash * 59 + this.UserAgentString.GetHashCode();

				if (this.IpAddress != null)
					hash = hash * 59 + this.IpAddress.GetHashCode();

				if (this.IpOrganization != null)
					hash = hash * 59 + this.IpOrganization.GetHashCode();

				if (this.Browser != null)
					hash = hash * 59 + this.Browser.GetHashCode();

				if (this.Device != null)
					hash = hash * 59 + this.Device.GetHashCode();

				if (this.Geolocation != null)
					hash = hash * 59 + this.Geolocation.GetHashCode();

				if (this.MktCampaign != null)
					hash = hash * 59 + this.MktCampaign.GetHashCode();

				if (this.VisitReferrer != null)
					hash = hash * 59 + this.VisitReferrer.GetHashCode();

				if (this.TimeToDisposition != null)
					hash = hash * 59 + this.TimeToDisposition.GetHashCode();

				return hash;
			}
		}
	}

}
