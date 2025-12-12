using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification
	/// </summary>
	[DataContract]
	public partial class WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification : IEquatable<WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification>
	{
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

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
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Entities">Entities.</param>
		/// <param name="Status">Status.</param>
		/// <param name="Error">Error.</param>
		public WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification(string Id = null, List<WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffType> Entities = null, StatusEnum? Status = null, WfmIntegrationsHrisTimeOffTypesJobTopicErrorBody Error = null)
		{
			this.Id = Id;
			this.Entities = Entities;
			this.Status = Status;
			this.Error = Error;

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
		public List<WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffType> Entities { get; set; }





		/// <summary>
		/// Gets or Sets Error
		/// </summary>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public WfmIntegrationsHrisTimeOffTypesJobTopicErrorBody Error { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
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
			return this.Equals(obj as WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification);
		}

		/// <summary>
		/// Returns true if WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmIntegrationsHrisTimeOffTypesJobTopicHrisTimeOffTypesJobNotification other)
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
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
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

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				return hash;
			}
		}
	}

}
