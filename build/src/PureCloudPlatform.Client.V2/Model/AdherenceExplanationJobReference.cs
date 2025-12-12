using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AdherenceExplanationJobReference
	/// </summary>
	[DataContract]
	public partial class AdherenceExplanationJobReference : IEquatable<AdherenceExplanationJobReference>
	{
		/// <summary>
		/// The type of the adherence explanation job
		/// </summary>
		/// <value>The type of the adherence explanation job</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Addexplanation for "AddExplanation"
			/// </summary>
			[EnumMember(Value = "AddExplanation")]
			Addexplanation,

			/// <summary>
			/// Enum Updateexplanation for "UpdateExplanation"
			/// </summary>
			[EnumMember(Value = "UpdateExplanation")]
			Updateexplanation,

			/// <summary>
			/// Enum Queryagentexplanations for "QueryAgentExplanations"
			/// </summary>
			[EnumMember(Value = "QueryAgentExplanations")]
			Queryagentexplanations,

			/// <summary>
			/// Enum Querybuexplanations for "QueryBuExplanations"
			/// </summary>
			[EnumMember(Value = "QueryBuExplanations")]
			Querybuexplanations
		}
		/// <summary>
		/// The status of the adherence explanation job
		/// </summary>
		/// <value>The status of the adherence explanation job</value>
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
		/// The type of the adherence explanation job
		/// </summary>
		/// <value>The type of the adherence explanation job</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The status of the adherence explanation job
		/// </summary>
		/// <value>The status of the adherence explanation job</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="AdherenceExplanationJobReference" /> class.
		/// </summary>
		/// <param name="Type">The type of the adherence explanation job.</param>
		/// <param name="Status">The status of the adherence explanation job.</param>
		public AdherenceExplanationJobReference(TypeEnum? Type = null, StatusEnum? Status = null)
		{
			this.Type = Type;
			this.Status = Status;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }







		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AdherenceExplanationJobReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as AdherenceExplanationJobReference);
		}

		/// <summary>
		/// Returns true if AdherenceExplanationJobReference instances are equal
		/// </summary>
		/// <param name="other">Instance of AdherenceExplanationJobReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AdherenceExplanationJobReference other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
