using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SourceBaseResponse
	/// </summary>
	[DataContract]
	public partial class SourceBaseResponse : IEquatable<SourceBaseResponse>
	{
		/// <summary>
		/// The source type.
		/// </summary>
		/// <value>The source type.</value>
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
			/// Enum Salesforce for "Salesforce"
			/// </summary>
			[EnumMember(Value = "Salesforce")]
			Salesforce,

			/// <summary>
			/// Enum Servicenow for "ServiceNow"
			/// </summary>
			[EnumMember(Value = "ServiceNow")]
			Servicenow
		}
		/// <summary>
		/// The source type.
		/// </summary>
		/// <value>The source type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SourceBaseResponse" /> class.
		/// </summary>
		/// <param name="Name">Name of the source..</param>
		/// <param name="DateCreated">Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Type">The source type..</param>
		/// <param name="Integration">The reference to the integration associated with the source..</param>
		/// <param name="SchedulePeriod">The schedule period of the source in hours..</param>
		/// <param name="LastSync">Additional information about the last synchronization of the source..</param>
		public SourceBaseResponse(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, TypeEnum? Type = null, KnowledgeIntegrationReference Integration = null, int? SchedulePeriod = null, SourceLastSync LastSync = null)
		{
			this.Name = Name;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.Type = Type;
			this.Integration = Integration;
			this.SchedulePeriod = SchedulePeriod;
			this.LastSync = LastSync;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Name of the source.
		/// </summary>
		/// <value>Name of the source.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }





		/// <summary>
		/// The reference to the integration associated with the source.
		/// </summary>
		/// <value>The reference to the integration associated with the source.</value>
		[DataMember(Name = "integration", EmitDefaultValue = false)]
		public KnowledgeIntegrationReference Integration { get; set; }



		/// <summary>
		/// The schedule period of the source in hours.
		/// </summary>
		/// <value>The schedule period of the source in hours.</value>
		[DataMember(Name = "schedulePeriod", EmitDefaultValue = false)]
		public int? SchedulePeriod { get; set; }



		/// <summary>
		/// Additional information about the last synchronization of the source.
		/// </summary>
		/// <value>Additional information about the last synchronization of the source.</value>
		[DataMember(Name = "lastSync", EmitDefaultValue = false)]
		public SourceLastSync LastSync { get; set; }



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
			sb.Append("class SourceBaseResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Integration: ").Append(Integration).Append("\n");
			sb.Append("  SchedulePeriod: ").Append(SchedulePeriod).Append("\n");
			sb.Append("  LastSync: ").Append(LastSync).Append("\n");
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
			return this.Equals(obj as SourceBaseResponse);
		}

		/// <summary>
		/// Returns true if SourceBaseResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of SourceBaseResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SourceBaseResponse other)
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
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Integration == other.Integration ||
					this.Integration != null &&
					this.Integration.Equals(other.Integration)
				) &&
				(
					this.SchedulePeriod == other.SchedulePeriod ||
					this.SchedulePeriod != null &&
					this.SchedulePeriod.Equals(other.SchedulePeriod)
				) &&
				(
					this.LastSync == other.LastSync ||
					this.LastSync != null &&
					this.LastSync.Equals(other.LastSync)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Integration != null)
					hash = hash * 59 + this.Integration.GetHashCode();

				if (this.SchedulePeriod != null)
					hash = hash * 59 + this.SchedulePeriod.GetHashCode();

				if (this.LastSync != null)
					hash = hash * 59 + this.LastSync.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
