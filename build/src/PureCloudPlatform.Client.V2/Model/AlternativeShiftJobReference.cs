using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlternativeShiftJobReference
	/// </summary>
	[DataContract]
	public partial class AlternativeShiftJobReference : IEquatable<AlternativeShiftJobReference>
	{
		/// <summary>
		/// The status of the alternative shift job
		/// </summary>
		/// <value>The status of the alternative shift job</value>
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
		/// The type of alternative shift asynchronous job
		/// </summary>
		/// <value>The type of alternative shift asynchronous job</value>
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
			/// Enum Listoffers for "ListOffers"
			/// </summary>
			[EnumMember(Value = "ListOffers")]
			Listoffers,

			/// <summary>
			/// Enum Searchoffers for "SearchOffers"
			/// </summary>
			[EnumMember(Value = "SearchOffers")]
			Searchoffers,

			/// <summary>
			/// Enum Listusertrades for "ListUserTrades"
			/// </summary>
			[EnumMember(Value = "ListUserTrades")]
			Listusertrades,

			/// <summary>
			/// Enum Searchtrades for "SearchTrades"
			/// </summary>
			[EnumMember(Value = "SearchTrades")]
			Searchtrades,

			/// <summary>
			/// Enum Bulkupdatetrades for "BulkUpdateTrades"
			/// </summary>
			[EnumMember(Value = "BulkUpdateTrades")]
			Bulkupdatetrades
		}
		/// <summary>
		/// The status of the alternative shift job
		/// </summary>
		/// <value>The status of the alternative shift job</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// The type of alternative shift asynchronous job
		/// </summary>
		/// <value>The type of alternative shift asynchronous job</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftJobReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlternativeShiftJobReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftJobReference" /> class.
		/// </summary>
		/// <param name="Status">The status of the alternative shift job (required).</param>
		/// <param name="Type">The type of alternative shift asynchronous job (required).</param>
		public AlternativeShiftJobReference(StatusEnum? Status = null, TypeEnum? Type = null)
		{
			this.Status = Status;
			this.Type = Type;

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
			sb.Append("class AlternativeShiftJobReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as AlternativeShiftJobReference);
		}

		/// <summary>
		/// Returns true if AlternativeShiftJobReference instances are equal
		/// </summary>
		/// <param name="other">Instance of AlternativeShiftJobReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlternativeShiftJobReference other)
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
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
