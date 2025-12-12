using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Model for a Nuance bot application
	/// </summary>
	[DataContract]
	public partial class NuanceApplication : IEquatable<NuanceApplication>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceApplication" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NuanceApplication() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceApplication" /> class.
		/// </summary>
		/// <param name="Id">The application ID (required).</param>
		/// <param name="Tag">The application Tag (required).</param>
		/// <param name="Name">The application name (required).</param>
		public NuanceApplication(string Id = null, string Tag = null, string Name = null)
		{
			this.Id = Id;
			this.Tag = Tag;
			this.Name = Name;

		}



		/// <summary>
		/// The application ID
		/// </summary>
		/// <value>The application ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The application Tag
		/// </summary>
		/// <value>The application Tag</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string Tag { get; set; }



		/// <summary>
		/// The application name
		/// </summary>
		/// <value>The application name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NuanceApplication {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Tag: ").Append(Tag).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
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
			return this.Equals(obj as NuanceApplication);
		}

		/// <summary>
		/// Returns true if NuanceApplication instances are equal
		/// </summary>
		/// <param name="other">Instance of NuanceApplication to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NuanceApplication other)
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
					this.Tag == other.Tag ||
					this.Tag != null &&
					this.Tag.Equals(other.Tag)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
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

				if (this.Tag != null)
					hash = hash * 59 + this.Tag.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				return hash;
			}
		}
	}

}
