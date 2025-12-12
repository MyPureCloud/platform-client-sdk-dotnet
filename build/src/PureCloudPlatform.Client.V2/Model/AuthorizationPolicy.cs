using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AuthorizationPolicy
	/// </summary>
	[DataContract]
	public partial class AuthorizationPolicy : IEquatable<AuthorizationPolicy>
	{
		/// <summary>
		/// The effect this policy should have when its conditions are met
		/// </summary>
		/// <value>The effect this policy should have when its conditions are met</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EffectEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Allow for "ALLOW"
			/// </summary>
			[EnumMember(Value = "ALLOW")]
			Allow,

			/// <summary>
			/// Enum Deny for "DENY"
			/// </summary>
			[EnumMember(Value = "DENY")]
			Deny
		}
		/// <summary>
		/// The effect this policy should have when its conditions are met
		/// </summary>
		/// <value>The effect this policy should have when its conditions are met</value>
		[DataMember(Name = "effect", EmitDefaultValue = false)]
		public EffectEnum? Effect { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthorizationPolicy" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AuthorizationPolicy() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthorizationPolicy" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Subject">The subject to whom the policy will apply, including type and id (required).</param>
		/// <param name="Effect">The effect this policy should have when its conditions are met (required).</param>
		/// <param name="Condition">The condition tree the policy will evaluate.</param>
		/// <param name="Description">Description.</param>
		/// <param name="PresetAttributes">Map of names and values of preset attributes to use in policy evaluation.</param>
		/// <param name="Active">Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users..</param>
		public AuthorizationPolicy(string Name = null, Subject Subject = null, EffectEnum? Effect = null, Object Condition = null, string Description = null, Dictionary<string, TypedAttribute> PresetAttributes = null, bool? Active = null)
		{
			this.Name = Name;
			this.Subject = Subject;
			this.Effect = Effect;
			this.Condition = Condition;
			this.Description = Description;
			this.PresetAttributes = PresetAttributes;
			this.Active = Active;

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
		/// The targeted resource to which the policy should apply, in the form of domain:entity:action
		/// </summary>
		/// <value>The targeted resource to which the policy should apply, in the form of domain:entity:action</value>
		[DataMember(Name = "targetResource", EmitDefaultValue = false)]
		public string TargetResource { get; private set; }



		/// <summary>
		/// The subject to whom the policy will apply, including type and id
		/// </summary>
		/// <value>The subject to whom the policy will apply, including type and id</value>
		[DataMember(Name = "subject", EmitDefaultValue = false)]
		public Subject Subject { get; set; }





		/// <summary>
		/// The condition tree the policy will evaluate
		/// </summary>
		/// <value>The condition tree the policy will evaluate</value>
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public Object Condition { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// Map of names and values of preset attributes to use in policy evaluation
		/// </summary>
		/// <value>Map of names and values of preset attributes to use in policy evaluation</value>
		[DataMember(Name = "presetAttributes", EmitDefaultValue = false)]
		public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }



		/// <summary>
		/// Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.
		/// </summary>
		/// <value>Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.</value>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool? Active { get; set; }



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
			sb.Append("class AuthorizationPolicy {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  TargetResource: ").Append(TargetResource).Append("\n");
			sb.Append("  Subject: ").Append(Subject).Append("\n");
			sb.Append("  Effect: ").Append(Effect).Append("\n");
			sb.Append("  Condition: ").Append(Condition).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  PresetAttributes: ").Append(PresetAttributes).Append("\n");
			sb.Append("  Active: ").Append(Active).Append("\n");
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
			return this.Equals(obj as AuthorizationPolicy);
		}

		/// <summary>
		/// Returns true if AuthorizationPolicy instances are equal
		/// </summary>
		/// <param name="other">Instance of AuthorizationPolicy to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuthorizationPolicy other)
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
					this.TargetResource == other.TargetResource ||
					this.TargetResource != null &&
					this.TargetResource.Equals(other.TargetResource)
				) &&
				(
					this.Subject == other.Subject ||
					this.Subject != null &&
					this.Subject.Equals(other.Subject)
				) &&
				(
					this.Effect == other.Effect ||
					this.Effect != null &&
					this.Effect.Equals(other.Effect)
				) &&
				(
					this.Condition == other.Condition ||
					this.Condition != null &&
					this.Condition.Equals(other.Condition)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.PresetAttributes == other.PresetAttributes ||
					this.PresetAttributes != null &&
					this.PresetAttributes.SequenceEqual(other.PresetAttributes)
				) &&
				(
					this.Active == other.Active ||
					this.Active != null &&
					this.Active.Equals(other.Active)
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

				if (this.TargetResource != null)
					hash = hash * 59 + this.TargetResource.GetHashCode();

				if (this.Subject != null)
					hash = hash * 59 + this.Subject.GetHashCode();

				if (this.Effect != null)
					hash = hash * 59 + this.Effect.GetHashCode();

				if (this.Condition != null)
					hash = hash * 59 + this.Condition.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.PresetAttributes != null)
					hash = hash * 59 + this.PresetAttributes.GetHashCode();

				if (this.Active != null)
					hash = hash * 59 + this.Active.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
