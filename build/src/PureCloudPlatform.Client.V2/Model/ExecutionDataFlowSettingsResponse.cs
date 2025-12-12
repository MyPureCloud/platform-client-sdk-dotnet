using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExecutionDataFlowSettingsResponse
	/// </summary>
	[DataContract]
	public partial class ExecutionDataFlowSettingsResponse : IEquatable<ExecutionDataFlowSettingsResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExecutionDataFlowSettingsResponse" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Enabled">whether or not the setting is enabled..</param>
		/// <param name="ModifiedBy">User that last changed the setting..</param>
		/// <param name="ModifiedByClient">OAuth client that last changed the setting..</param>
		/// <param name="DateModified">The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public ExecutionDataFlowSettingsResponse(string Name = null, bool? Enabled = null, UserReference ModifiedBy = null, DomainEntityRef ModifiedByClient = null, DateTime? DateModified = null)
		{
			this.Name = Name;
			this.Enabled = Enabled;
			this.ModifiedBy = ModifiedBy;
			this.ModifiedByClient = ModifiedByClient;
			this.DateModified = DateModified;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// whether or not the setting is enabled.
		/// </summary>
		/// <value>whether or not the setting is enabled.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// User that last changed the setting.
		/// </summary>
		/// <value>User that last changed the setting.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; set; }



		/// <summary>
		/// OAuth client that last changed the setting.
		/// </summary>
		/// <value>OAuth client that last changed the setting.</value>
		[DataMember(Name = "modifiedByClient", EmitDefaultValue = false)]
		public DomainEntityRef ModifiedByClient { get; set; }



		/// <summary>
		/// The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



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
			sb.Append("class ExecutionDataFlowSettingsResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  ModifiedByClient: ").Append(ModifiedByClient).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
			return this.Equals(obj as ExecutionDataFlowSettingsResponse);
		}

		/// <summary>
		/// Returns true if ExecutionDataFlowSettingsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ExecutionDataFlowSettingsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExecutionDataFlowSettingsResponse other)
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
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.ModifiedByClient == other.ModifiedByClient ||
					this.ModifiedByClient != null &&
					this.ModifiedByClient.Equals(other.ModifiedByClient)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
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

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.ModifiedByClient != null)
					hash = hash * 59 + this.ModifiedByClient.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
