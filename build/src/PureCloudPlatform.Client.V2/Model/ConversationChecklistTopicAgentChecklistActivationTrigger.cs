using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationChecklistTopicAgentChecklistActivationTrigger
	/// </summary>
	[DataContract]
	public partial class ConversationChecklistTopicAgentChecklistActivationTrigger : IEquatable<ConversationChecklistTopicAgentChecklistActivationTrigger>
	{
		/// <summary>
		/// Gets or Sets TriggerType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TriggerTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Conversationstart for "ConversationStart"
			/// </summary>
			[EnumMember(Value = "ConversationStart")]
			Conversationstart,

			/// <summary>
			/// Enum Intent for "Intent"
			/// </summary>
			[EnumMember(Value = "Intent")]
			Intent
		}
		/// <summary>
		/// Gets or Sets TriggerType
		/// </summary>
		[DataMember(Name = "triggerType", EmitDefaultValue = false)]
		public TriggerTypeEnum? TriggerType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationChecklistTopicAgentChecklistActivationTrigger" /> class.
		/// </summary>
		/// <param name="TriggerType">TriggerType.</param>
		/// <param name="TriggerDate">TriggerDate.</param>
		/// <param name="IntentName">IntentName.</param>
		/// <param name="IntentId">IntentId.</param>
		public ConversationChecklistTopicAgentChecklistActivationTrigger(TriggerTypeEnum? TriggerType = null, DateTime? TriggerDate = null, string IntentName = null, string IntentId = null)
		{
			this.TriggerType = TriggerType;
			this.TriggerDate = TriggerDate;
			this.IntentName = IntentName;
			this.IntentId = IntentId;

		}





		/// <summary>
		/// Gets or Sets TriggerDate
		/// </summary>
		[DataMember(Name = "triggerDate", EmitDefaultValue = false)]
		public DateTime? TriggerDate { get; set; }



		/// <summary>
		/// Gets or Sets IntentName
		/// </summary>
		[DataMember(Name = "intentName", EmitDefaultValue = false)]
		public string IntentName { get; set; }



		/// <summary>
		/// Gets or Sets IntentId
		/// </summary>
		[DataMember(Name = "intentId", EmitDefaultValue = false)]
		public string IntentId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationChecklistTopicAgentChecklistActivationTrigger {\n");

			sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
			sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
			sb.Append("  IntentName: ").Append(IntentName).Append("\n");
			sb.Append("  IntentId: ").Append(IntentId).Append("\n");
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
			return this.Equals(obj as ConversationChecklistTopicAgentChecklistActivationTrigger);
		}

		/// <summary>
		/// Returns true if ConversationChecklistTopicAgentChecklistActivationTrigger instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationChecklistTopicAgentChecklistActivationTrigger to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationChecklistTopicAgentChecklistActivationTrigger other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TriggerType == other.TriggerType ||
					this.TriggerType != null &&
					this.TriggerType.Equals(other.TriggerType)
				) &&
				(
					this.TriggerDate == other.TriggerDate ||
					this.TriggerDate != null &&
					this.TriggerDate.Equals(other.TriggerDate)
				) &&
				(
					this.IntentName == other.IntentName ||
					this.IntentName != null &&
					this.IntentName.Equals(other.IntentName)
				) &&
				(
					this.IntentId == other.IntentId ||
					this.IntentId != null &&
					this.IntentId.Equals(other.IntentId)
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
				if (this.TriggerType != null)
					hash = hash * 59 + this.TriggerType.GetHashCode();

				if (this.TriggerDate != null)
					hash = hash * 59 + this.TriggerDate.GetHashCode();

				if (this.IntentName != null)
					hash = hash * 59 + this.IntentName.GetHashCode();

				if (this.IntentId != null)
					hash = hash * 59 + this.IntentId.GetHashCode();

				return hash;
			}
		}
	}

}
