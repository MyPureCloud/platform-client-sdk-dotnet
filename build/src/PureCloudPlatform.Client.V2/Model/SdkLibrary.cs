using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SdkLibrary
	/// </summary>
	[DataContract]
	public partial class SdkLibrary : IEquatable<SdkLibrary>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SdkLibrary" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SdkLibrary() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SdkLibrary" /> class.
		/// </summary>
		/// <param name="Name">The name of the SDK. (required).</param>
		/// <param name="Version">The version of the SDK. (required).</param>
		public SdkLibrary(string Name = null, string Version = null)
		{
			this.Name = Name;
			this.Version = Version;

		}



		/// <summary>
		/// The name of the SDK.
		/// </summary>
		/// <value>The name of the SDK.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The version of the SDK.
		/// </summary>
		/// <value>The version of the SDK.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SdkLibrary {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as SdkLibrary);
		}

		/// <summary>
		/// Returns true if SdkLibrary instances are equal
		/// </summary>
		/// <param name="other">Instance of SdkLibrary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SdkLibrary other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
