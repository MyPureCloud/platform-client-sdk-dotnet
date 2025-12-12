using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TagValue
	/// </summary>
	[DataContract]
	public partial class TagValue : IEquatable<TagValue>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TagValue" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TagValue() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TagValue" /> class.
		/// </summary>
		/// <param name="Name">The workspace tag name. (required).</param>
		/// <param name="InUse">InUse.</param>
		/// <param name="Acl">Acl.</param>
		public TagValue(string Name = null, bool? InUse = null, List<string> Acl = null)
		{
			this.Name = Name;
			this.InUse = InUse;
			this.Acl = Acl;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The workspace tag name.
		/// </summary>
		/// <value>The workspace tag name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets InUse
		/// </summary>
		[DataMember(Name = "inUse", EmitDefaultValue = false)]
		public bool? InUse { get; set; }



		/// <summary>
		/// Gets or Sets Acl
		/// </summary>
		[DataMember(Name = "acl", EmitDefaultValue = false)]
		public List<string> Acl { get; set; }



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
			sb.Append("class TagValue {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  InUse: ").Append(InUse).Append("\n");
			sb.Append("  Acl: ").Append(Acl).Append("\n");
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
			return this.Equals(obj as TagValue);
		}

		/// <summary>
		/// Returns true if TagValue instances are equal
		/// </summary>
		/// <param name="other">Instance of TagValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TagValue other)
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
					this.InUse == other.InUse ||
					this.InUse != null &&
					this.InUse.Equals(other.InUse)
				) &&
				(
					this.Acl == other.Acl ||
					this.Acl != null &&
					this.Acl.SequenceEqual(other.Acl)
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

				if (this.InUse != null)
					hash = hash * 59 + this.InUse.GetHashCode();

				if (this.Acl != null)
					hash = hash * 59 + this.Acl.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
