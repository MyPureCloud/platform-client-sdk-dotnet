using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AssistantListing
	/// </summary>
	[DataContract]
	public partial class AssistantListing : IEquatable<AssistantListing>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssistantListing" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="NextUri">NextUri.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="PreviousUri">PreviousUri.</param>
		public AssistantListing(List<Assistant> Entities = null, string NextUri = null, string SelfUri = null, string PreviousUri = null)
		{
			this.Entities = Entities;
			this.NextUri = NextUri;
			this.SelfUri = SelfUri;
			this.PreviousUri = PreviousUri;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<Assistant> Entities { get; set; }



		/// <summary>
		/// Gets or Sets NextUri
		/// </summary>
		[DataMember(Name = "nextUri", EmitDefaultValue = false)]
		public string NextUri { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }



		/// <summary>
		/// Gets or Sets PreviousUri
		/// </summary>
		[DataMember(Name = "previousUri", EmitDefaultValue = false)]
		public string PreviousUri { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssistantListing {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  NextUri: ").Append(NextUri).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
			return this.Equals(obj as AssistantListing);
		}

		/// <summary>
		/// Returns true if AssistantListing instances are equal
		/// </summary>
		/// <param name="other">Instance of AssistantListing to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AssistantListing other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.NextUri == other.NextUri ||
					this.NextUri != null &&
					this.NextUri.Equals(other.NextUri)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.PreviousUri == other.PreviousUri ||
					this.PreviousUri != null &&
					this.PreviousUri.Equals(other.PreviousUri)
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
				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.NextUri != null)
					hash = hash * 59 + this.NextUri.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.PreviousUri != null)
					hash = hash * 59 + this.PreviousUri.GetHashCode();

				return hash;
			}
		}
	}

}
