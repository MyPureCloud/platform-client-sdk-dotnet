using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserPrimarySource
	/// </summary>
	[DataContract]
	public partial class UserPrimarySource : IEquatable<UserPrimarySource>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserPrimarySource" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="SourceId">The id of the source.</param>
		/// <param name="Registered">Whether or not the source is registered.</param>
		public UserPrimarySource(string Name = null, string SourceId = null, bool? Registered = null)
		{
			this.Name = Name;
			this.SourceId = SourceId;
			this.Registered = Registered;

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
		/// The id of the source
		/// </summary>
		/// <value>The id of the source</value>
		[DataMember(Name = "sourceId", EmitDefaultValue = false)]
		public string SourceId { get; set; }



		/// <summary>
		/// Whether or not the source is registered
		/// </summary>
		/// <value>Whether or not the source is registered</value>
		[DataMember(Name = "registered", EmitDefaultValue = false)]
		public bool? Registered { get; set; }



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
			sb.Append("class UserPrimarySource {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SourceId: ").Append(SourceId).Append("\n");
			sb.Append("  Registered: ").Append(Registered).Append("\n");
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
			return this.Equals(obj as UserPrimarySource);
		}

		/// <summary>
		/// Returns true if UserPrimarySource instances are equal
		/// </summary>
		/// <param name="other">Instance of UserPrimarySource to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserPrimarySource other)
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
					this.SourceId == other.SourceId ||
					this.SourceId != null &&
					this.SourceId.Equals(other.SourceId)
				) &&
				(
					this.Registered == other.Registered ||
					this.Registered != null &&
					this.Registered.Equals(other.Registered)
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

				if (this.SourceId != null)
					hash = hash * 59 + this.SourceId.GetHashCode();

				if (this.Registered != null)
					hash = hash * 59 + this.Registered.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
