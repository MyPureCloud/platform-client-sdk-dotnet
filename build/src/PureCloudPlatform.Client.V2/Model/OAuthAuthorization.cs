using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OAuthAuthorization
	/// </summary>
	[DataContract]
	public partial class OAuthAuthorization : IEquatable<OAuthAuthorization>
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
			/// Enum Unauthorized for "Unauthorized"
			/// </summary>
			[EnumMember(Value = "Unauthorized")]
			Unauthorized,

			/// <summary>
			/// Enum Requested for "Requested"
			/// </summary>
			[EnumMember(Value = "Requested")]
			Requested,

			/// <summary>
			/// Enum Authorized for "Authorized"
			/// </summary>
			[EnumMember(Value = "Authorized")]
			Authorized,

			/// <summary>
			/// Enum Revoked for "Revoked"
			/// </summary>
			[EnumMember(Value = "Revoked")]
			Revoked
		}
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OAuthAuthorization" /> class.
		/// </summary>
		/// <param name="Client">Client.</param>
		/// <param name="Scope">Scope.</param>
		/// <param name="Roles">Roles.</param>
		/// <param name="ResourceOwner">ResourceOwner.</param>
		/// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="CreatedBy">CreatedBy.</param>
		/// <param name="ModifiedBy">ModifiedBy.</param>
		/// <param name="Pending">Pending.</param>
		/// <param name="State">State.</param>
		public OAuthAuthorization(OAuthClient Client = null, List<string> Scope = null, List<string> Roles = null, DomainEntityRef ResourceOwner = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, bool? Pending = null, StateEnum? State = null)
		{
			this.Client = Client;
			this.Scope = Scope;
			this.Roles = Roles;
			this.ResourceOwner = ResourceOwner;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.CreatedBy = CreatedBy;
			this.ModifiedBy = ModifiedBy;
			this.Pending = Pending;
			this.State = State;

		}



		/// <summary>
		/// Gets or Sets Client
		/// </summary>
		[DataMember(Name = "client", EmitDefaultValue = false)]
		public OAuthClient Client { get; set; }



		/// <summary>
		/// Gets or Sets Scope
		/// </summary>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public List<string> Scope { get; set; }



		/// <summary>
		/// Gets or Sets Roles
		/// </summary>
		[DataMember(Name = "roles", EmitDefaultValue = false)]
		public List<string> Roles { get; set; }



		/// <summary>
		/// Gets or Sets ResourceOwner
		/// </summary>
		[DataMember(Name = "resourceOwner", EmitDefaultValue = false)]
		public DomainEntityRef ResourceOwner { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Gets or Sets CreatedBy
		/// </summary>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public DomainEntityRef CreatedBy { get; set; }



		/// <summary>
		/// Gets or Sets ModifiedBy
		/// </summary>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public DomainEntityRef ModifiedBy { get; set; }



		/// <summary>
		/// Gets or Sets Pending
		/// </summary>
		[DataMember(Name = "pending", EmitDefaultValue = false)]
		public bool? Pending { get; set; }





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
			sb.Append("class OAuthAuthorization {\n");

			sb.Append("  Client: ").Append(Client).Append("\n");
			sb.Append("  Scope: ").Append(Scope).Append("\n");
			sb.Append("  Roles: ").Append(Roles).Append("\n");
			sb.Append("  ResourceOwner: ").Append(ResourceOwner).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  Pending: ").Append(Pending).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
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
			return this.Equals(obj as OAuthAuthorization);
		}

		/// <summary>
		/// Returns true if OAuthAuthorization instances are equal
		/// </summary>
		/// <param name="other">Instance of OAuthAuthorization to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OAuthAuthorization other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Client == other.Client ||
					this.Client != null &&
					this.Client.Equals(other.Client)
				) &&
				(
					this.Scope == other.Scope ||
					this.Scope != null &&
					this.Scope.SequenceEqual(other.Scope)
				) &&
				(
					this.Roles == other.Roles ||
					this.Roles != null &&
					this.Roles.SequenceEqual(other.Roles)
				) &&
				(
					this.ResourceOwner == other.ResourceOwner ||
					this.ResourceOwner != null &&
					this.ResourceOwner.Equals(other.ResourceOwner)
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
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.Pending == other.Pending ||
					this.Pending != null &&
					this.Pending.Equals(other.Pending)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
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
				if (this.Client != null)
					hash = hash * 59 + this.Client.GetHashCode();

				if (this.Scope != null)
					hash = hash * 59 + this.Scope.GetHashCode();

				if (this.Roles != null)
					hash = hash * 59 + this.Roles.GetHashCode();

				if (this.ResourceOwner != null)
					hash = hash * 59 + this.ResourceOwner.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.Pending != null)
					hash = hash * 59 + this.Pending.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
