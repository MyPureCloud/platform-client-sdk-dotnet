using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AuthzGrantPolicy
	/// </summary>
	[DataContract]
	public partial class AuthzGrantPolicy : IEquatable<AuthzGrantPolicy>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthzGrantPolicy" /> class.
		/// </summary>
		/// <param name="Actions">Actions.</param>
		/// <param name="Condition">Condition.</param>
		/// <param name="Domain">Domain.</param>
		/// <param name="EntityName">EntityName.</param>
		public AuthzGrantPolicy(List<string> Actions = null, string Condition = null, string Domain = null, string EntityName = null)
		{
			this.Actions = Actions;
			this.Condition = Condition;
			this.Domain = Domain;
			this.EntityName = EntityName;

		}



		/// <summary>
		/// Gets or Sets Actions
		/// </summary>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public List<string> Actions { get; set; }



		/// <summary>
		/// Gets or Sets Condition
		/// </summary>
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public string Condition { get; set; }



		/// <summary>
		/// Gets or Sets Domain
		/// </summary>
		[DataMember(Name = "domain", EmitDefaultValue = false)]
		public string Domain { get; set; }



		/// <summary>
		/// Gets or Sets EntityName
		/// </summary>
		[DataMember(Name = "entityName", EmitDefaultValue = false)]
		public string EntityName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuthzGrantPolicy {\n");

			sb.Append("  Actions: ").Append(Actions).Append("\n");
			sb.Append("  Condition: ").Append(Condition).Append("\n");
			sb.Append("  Domain: ").Append(Domain).Append("\n");
			sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
			return this.Equals(obj as AuthzGrantPolicy);
		}

		/// <summary>
		/// Returns true if AuthzGrantPolicy instances are equal
		/// </summary>
		/// <param name="other">Instance of AuthzGrantPolicy to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuthzGrantPolicy other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.SequenceEqual(other.Actions)
				) &&
				(
					this.Condition == other.Condition ||
					this.Condition != null &&
					this.Condition.Equals(other.Condition)
				) &&
				(
					this.Domain == other.Domain ||
					this.Domain != null &&
					this.Domain.Equals(other.Domain)
				) &&
				(
					this.EntityName == other.EntityName ||
					this.EntityName != null &&
					this.EntityName.Equals(other.EntityName)
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
				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				if (this.Condition != null)
					hash = hash * 59 + this.Condition.GetHashCode();

				if (this.Domain != null)
					hash = hash * 59 + this.Domain.GetHashCode();

				if (this.EntityName != null)
					hash = hash * 59 + this.EntityName.GetHashCode();

				return hash;
			}
		}
	}

}
