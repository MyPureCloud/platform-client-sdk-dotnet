using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CrossPlatformPolicyCreate
	/// </summary>
	[DataContract]
	public partial class CrossPlatformPolicyCreate : IEquatable<CrossPlatformPolicyCreate>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CrossPlatformPolicyCreate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CrossPlatformPolicyCreate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CrossPlatformPolicyCreate" /> class.
		/// </summary>
		/// <param name="Name">The policy name. (required).</param>
		/// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Order">Order.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Enabled">Enabled.</param>
		/// <param name="MediaPolicies">Conditions and actions per media type.</param>
		/// <param name="Conditions">Conditions.</param>
		/// <param name="Actions">Actions.</param>
		/// <param name="PolicyErrors">PolicyErrors.</param>
		public CrossPlatformPolicyCreate(string Name = null, DateTime? ModifiedDate = null, DateTime? CreatedDate = null, int? Order = null, string Description = null, bool? Enabled = null, CrossPlatformMediaPolicies MediaPolicies = null, PolicyConditions Conditions = null, CrossPlatformPolicyActions Actions = null, PolicyErrors PolicyErrors = null)
		{
			this.Name = Name;
			this.ModifiedDate = ModifiedDate;
			this.CreatedDate = CreatedDate;
			this.Order = Order;
			this.Description = Description;
			this.Enabled = Enabled;
			this.MediaPolicies = MediaPolicies;
			this.Conditions = Conditions;
			this.Actions = Actions;
			this.PolicyErrors = PolicyErrors;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The policy name.
		/// </summary>
		/// <value>The policy name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
		public DateTime? ModifiedDate { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }



		/// <summary>
		/// Gets or Sets Order
		/// </summary>
		[DataMember(Name = "order", EmitDefaultValue = false)]
		public int? Order { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Gets or Sets Enabled
		/// </summary>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// Conditions and actions per media type
		/// </summary>
		/// <value>Conditions and actions per media type</value>
		[DataMember(Name = "mediaPolicies", EmitDefaultValue = false)]
		public CrossPlatformMediaPolicies MediaPolicies { get; set; }



		/// <summary>
		/// Conditions
		/// </summary>
		/// <value>Conditions</value>
		[DataMember(Name = "conditions", EmitDefaultValue = false)]
		public PolicyConditions Conditions { get; set; }



		/// <summary>
		/// Actions
		/// </summary>
		/// <value>Actions</value>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public CrossPlatformPolicyActions Actions { get; set; }



		/// <summary>
		/// Gets or Sets PolicyErrors
		/// </summary>
		[DataMember(Name = "policyErrors", EmitDefaultValue = false)]
		public PolicyErrors PolicyErrors { get; set; }



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
			sb.Append("class CrossPlatformPolicyCreate {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  Order: ").Append(Order).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  MediaPolicies: ").Append(MediaPolicies).Append("\n");
			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
			sb.Append("  Actions: ").Append(Actions).Append("\n");
			sb.Append("  PolicyErrors: ").Append(PolicyErrors).Append("\n");
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
			return this.Equals(obj as CrossPlatformPolicyCreate);
		}

		/// <summary>
		/// Returns true if CrossPlatformPolicyCreate instances are equal
		/// </summary>
		/// <param name="other">Instance of CrossPlatformPolicyCreate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CrossPlatformPolicyCreate other)
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
					this.ModifiedDate == other.ModifiedDate ||
					this.ModifiedDate != null &&
					this.ModifiedDate.Equals(other.ModifiedDate)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
				) &&
				(
					this.Order == other.Order ||
					this.Order != null &&
					this.Order.Equals(other.Order)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.MediaPolicies == other.MediaPolicies ||
					this.MediaPolicies != null &&
					this.MediaPolicies.Equals(other.MediaPolicies)
				) &&
				(
					this.Conditions == other.Conditions ||
					this.Conditions != null &&
					this.Conditions.Equals(other.Conditions)
				) &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.Equals(other.Actions)
				) &&
				(
					this.PolicyErrors == other.PolicyErrors ||
					this.PolicyErrors != null &&
					this.PolicyErrors.Equals(other.PolicyErrors)
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

				if (this.ModifiedDate != null)
					hash = hash * 59 + this.ModifiedDate.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.Order != null)
					hash = hash * 59 + this.Order.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.MediaPolicies != null)
					hash = hash * 59 + this.MediaPolicies.GetHashCode();

				if (this.Conditions != null)
					hash = hash * 59 + this.Conditions.GetHashCode();

				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				if (this.PolicyErrors != null)
					hash = hash * 59 + this.PolicyErrors.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
