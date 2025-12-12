using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserSearchRule
	/// </summary>
	[DataContract]
	public partial class UserSearchRule : IEquatable<UserSearchRule>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserSearchRule" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserSearchRule() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserSearchRule" /> class.
		/// </summary>
		/// <param name="Parts">The parts of this rule; the results of these are ANDed together. (required).</param>
		public UserSearchRule(List<UserSearchRulePart> Parts = null)
		{
			this.Parts = Parts;

		}



		/// <summary>
		/// The parts of this rule; the results of these are ANDed together.
		/// </summary>
		/// <value>The parts of this rule; the results of these are ANDed together.</value>
		[DataMember(Name = "parts", EmitDefaultValue = false)]
		public List<UserSearchRulePart> Parts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserSearchRule {\n");

			sb.Append("  Parts: ").Append(Parts).Append("\n");
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
			return this.Equals(obj as UserSearchRule);
		}

		/// <summary>
		/// Returns true if UserSearchRule instances are equal
		/// </summary>
		/// <param name="other">Instance of UserSearchRule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserSearchRule other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Parts == other.Parts ||
					this.Parts != null &&
					this.Parts.SequenceEqual(other.Parts)
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
				if (this.Parts != null)
					hash = hash * 59 + this.Parts.GetHashCode();

				return hash;
			}
		}
	}

}
