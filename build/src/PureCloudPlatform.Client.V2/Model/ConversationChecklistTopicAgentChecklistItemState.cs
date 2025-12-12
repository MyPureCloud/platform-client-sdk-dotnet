using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationChecklistTopicAgentChecklistItemState
	/// </summary>
	[DataContract]
	public partial class ConversationChecklistTopicAgentChecklistItemState : IEquatable<ConversationChecklistTopicAgentChecklistItemState>
	{
		/// <summary>
		/// Gets or Sets StateFromModel
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateFromModelEnum
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
			/// Enum Ticked for "Ticked"
			/// </summary>
			[EnumMember(Value = "Ticked")]
			Ticked,

			/// <summary>
			/// Enum Unticked for "Unticked"
			/// </summary>
			[EnumMember(Value = "Unticked")]
			Unticked
		}
		/// <summary>
		/// Gets or Sets StateFromAgent
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateFromAgentEnum
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
			/// Enum Ticked for "Ticked"
			/// </summary>
			[EnumMember(Value = "Ticked")]
			Ticked,

			/// <summary>
			/// Enum Unticked for "Unticked"
			/// </summary>
			[EnumMember(Value = "Unticked")]
			Unticked
		}
		/// <summary>
		/// Gets or Sets StateFromModel
		/// </summary>
		[DataMember(Name = "stateFromModel", EmitDefaultValue = false)]
		public StateFromModelEnum? StateFromModel { get; set; }
		/// <summary>
		/// Gets or Sets StateFromAgent
		/// </summary>
		[DataMember(Name = "stateFromAgent", EmitDefaultValue = false)]
		public StateFromAgentEnum? StateFromAgent { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationChecklistTopicAgentChecklistItemState" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="StateFromModel">StateFromModel.</param>
		/// <param name="StateFromAgent">StateFromAgent.</param>
		/// <param name="DateLastModifiedByModel">DateLastModifiedByModel.</param>
		/// <param name="DateLastModifiedByAgent">DateLastModifiedByAgent.</param>
		/// <param name="AutomatedCheckEnabled">AutomatedCheckEnabled.</param>
		/// <param name="Important">Important.</param>
		/// <param name="LastModifiedInAcw">LastModifiedInAcw.</param>
		public ConversationChecklistTopicAgentChecklistItemState(Guid? Id = null, string Name = null, string Description = null, StateFromModelEnum? StateFromModel = null, StateFromAgentEnum? StateFromAgent = null, DateTime? DateLastModifiedByModel = null, DateTime? DateLastModifiedByAgent = null, bool? AutomatedCheckEnabled = null, bool? Important = null, bool? LastModifiedInAcw = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.StateFromModel = StateFromModel;
			this.StateFromAgent = StateFromAgent;
			this.DateLastModifiedByModel = DateLastModifiedByModel;
			this.DateLastModifiedByAgent = DateLastModifiedByAgent;
			this.AutomatedCheckEnabled = AutomatedCheckEnabled;
			this.Important = Important;
			this.LastModifiedInAcw = LastModifiedInAcw;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }







		/// <summary>
		/// Gets or Sets DateLastModifiedByModel
		/// </summary>
		[DataMember(Name = "dateLastModifiedByModel", EmitDefaultValue = false)]
		public DateTime? DateLastModifiedByModel { get; set; }



		/// <summary>
		/// Gets or Sets DateLastModifiedByAgent
		/// </summary>
		[DataMember(Name = "dateLastModifiedByAgent", EmitDefaultValue = false)]
		public DateTime? DateLastModifiedByAgent { get; set; }



		/// <summary>
		/// Gets or Sets AutomatedCheckEnabled
		/// </summary>
		[DataMember(Name = "automatedCheckEnabled", EmitDefaultValue = false)]
		public bool? AutomatedCheckEnabled { get; set; }



		/// <summary>
		/// Gets or Sets Important
		/// </summary>
		[DataMember(Name = "important", EmitDefaultValue = false)]
		public bool? Important { get; set; }



		/// <summary>
		/// Gets or Sets LastModifiedInAcw
		/// </summary>
		[DataMember(Name = "lastModifiedInAcw", EmitDefaultValue = false)]
		public bool? LastModifiedInAcw { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationChecklistTopicAgentChecklistItemState {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  StateFromModel: ").Append(StateFromModel).Append("\n");
			sb.Append("  StateFromAgent: ").Append(StateFromAgent).Append("\n");
			sb.Append("  DateLastModifiedByModel: ").Append(DateLastModifiedByModel).Append("\n");
			sb.Append("  DateLastModifiedByAgent: ").Append(DateLastModifiedByAgent).Append("\n");
			sb.Append("  AutomatedCheckEnabled: ").Append(AutomatedCheckEnabled).Append("\n");
			sb.Append("  Important: ").Append(Important).Append("\n");
			sb.Append("  LastModifiedInAcw: ").Append(LastModifiedInAcw).Append("\n");
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
			return this.Equals(obj as ConversationChecklistTopicAgentChecklistItemState);
		}

		/// <summary>
		/// Returns true if ConversationChecklistTopicAgentChecklistItemState instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationChecklistTopicAgentChecklistItemState to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationChecklistTopicAgentChecklistItemState other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.StateFromModel == other.StateFromModel ||
					this.StateFromModel != null &&
					this.StateFromModel.Equals(other.StateFromModel)
				) &&
				(
					this.StateFromAgent == other.StateFromAgent ||
					this.StateFromAgent != null &&
					this.StateFromAgent.Equals(other.StateFromAgent)
				) &&
				(
					this.DateLastModifiedByModel == other.DateLastModifiedByModel ||
					this.DateLastModifiedByModel != null &&
					this.DateLastModifiedByModel.Equals(other.DateLastModifiedByModel)
				) &&
				(
					this.DateLastModifiedByAgent == other.DateLastModifiedByAgent ||
					this.DateLastModifiedByAgent != null &&
					this.DateLastModifiedByAgent.Equals(other.DateLastModifiedByAgent)
				) &&
				(
					this.AutomatedCheckEnabled == other.AutomatedCheckEnabled ||
					this.AutomatedCheckEnabled != null &&
					this.AutomatedCheckEnabled.Equals(other.AutomatedCheckEnabled)
				) &&
				(
					this.Important == other.Important ||
					this.Important != null &&
					this.Important.Equals(other.Important)
				) &&
				(
					this.LastModifiedInAcw == other.LastModifiedInAcw ||
					this.LastModifiedInAcw != null &&
					this.LastModifiedInAcw.Equals(other.LastModifiedInAcw)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.StateFromModel != null)
					hash = hash * 59 + this.StateFromModel.GetHashCode();

				if (this.StateFromAgent != null)
					hash = hash * 59 + this.StateFromAgent.GetHashCode();

				if (this.DateLastModifiedByModel != null)
					hash = hash * 59 + this.DateLastModifiedByModel.GetHashCode();

				if (this.DateLastModifiedByAgent != null)
					hash = hash * 59 + this.DateLastModifiedByAgent.GetHashCode();

				if (this.AutomatedCheckEnabled != null)
					hash = hash * 59 + this.AutomatedCheckEnabled.GetHashCode();

				if (this.Important != null)
					hash = hash * 59 + this.Important.GetHashCode();

				if (this.LastModifiedInAcw != null)
					hash = hash * 59 + this.LastModifiedInAcw.GetHashCode();

				return hash;
			}
		}
	}

}
