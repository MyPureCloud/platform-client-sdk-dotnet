using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AvailableMediaType
	/// </summary>
	[DataContract]
	public partial class AvailableMediaType : IEquatable<AvailableMediaType>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AvailableMediaType" /> class.
		/// </summary>
		/// <param name="MediaType">Name of the available media type.</param>
		/// <param name="AvailableSubTypes">List of available subtypes for this media type.</param>
		public AvailableMediaType(string MediaType = null, List<string> AvailableSubTypes = null)
		{
			this.MediaType = MediaType;
			this.AvailableSubTypes = AvailableSubTypes;

		}



		/// <summary>
		/// Name of the available media type
		/// </summary>
		/// <value>Name of the available media type</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public string MediaType { get; set; }



		/// <summary>
		/// List of available subtypes for this media type
		/// </summary>
		/// <value>List of available subtypes for this media type</value>
		[DataMember(Name = "availableSubTypes", EmitDefaultValue = false)]
		public List<string> AvailableSubTypes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AvailableMediaType {\n");

			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  AvailableSubTypes: ").Append(AvailableSubTypes).Append("\n");
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
			return this.Equals(obj as AvailableMediaType);
		}

		/// <summary>
		/// Returns true if AvailableMediaType instances are equal
		/// </summary>
		/// <param name="other">Instance of AvailableMediaType to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AvailableMediaType other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.AvailableSubTypes == other.AvailableSubTypes ||
					this.AvailableSubTypes != null &&
					this.AvailableSubTypes.SequenceEqual(other.AvailableSubTypes)
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
				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.AvailableSubTypes != null)
					hash = hash * 59 + this.AvailableSubTypes.GetHashCode();

				return hash;
			}
		}
	}

}
