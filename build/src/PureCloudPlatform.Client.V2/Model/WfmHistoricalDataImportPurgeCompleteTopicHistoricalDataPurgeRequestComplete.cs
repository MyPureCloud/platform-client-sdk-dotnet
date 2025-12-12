using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete
	/// </summary>
	[DataContract]
	public partial class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete : IEquatable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete>
	{
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
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
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="State">State.</param>
		/// <param name="Entities">Entities.</param>
		/// <param name="DisallowedEntities">DisallowedEntities.</param>
		public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete(string Id = null, StateEnum? State = null, List<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity> Entities = null, List<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity> DisallowedEntities = null)
		{
			this.Id = Id;
			this.State = State;
			this.Entities = Entities;
			this.DisallowedEntities = DisallowedEntities;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }





		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDeleteEntity> Entities { get; set; }



		/// <summary>
		/// Gets or Sets DisallowedEntities
		/// </summary>
		[DataMember(Name = "disallowedEntities", EmitDefaultValue = false)]
		public List<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity> DisallowedEntities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  DisallowedEntities: ").Append(DisallowedEntities).Append("\n");
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
			return this.Equals(obj as WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete);
		}

		/// <summary>
		/// Returns true if WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataPurgeRequestComplete other)
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
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.DisallowedEntities == other.DisallowedEntities ||
					this.DisallowedEntities != null &&
					this.DisallowedEntities.SequenceEqual(other.DisallowedEntities)
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

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.DisallowedEntities != null)
					hash = hash * 59 + this.DisallowedEntities.GetHashCode();

				return hash;
			}
		}
	}

}
