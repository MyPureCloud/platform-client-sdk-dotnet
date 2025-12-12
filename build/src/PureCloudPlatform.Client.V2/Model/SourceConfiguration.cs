using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SourceConfiguration
	/// </summary>
	[DataContract]
	public partial class SourceConfiguration : IEquatable<SourceConfiguration>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SourceConfiguration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SourceConfiguration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SourceConfiguration" /> class.
		/// </summary>
		/// <param name="SourceId">Identifies the external platform that is the source of the conversation. (required).</param>
		/// <param name="InteractionId">The customer&#39;s unique external identifier associated with the conversation that comes from the external platform. (required).</param>
		/// <param name="TagId">The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation..</param>
		public SourceConfiguration(string SourceId = null, string InteractionId = null, string TagId = null)
		{
			this.SourceId = SourceId;
			this.InteractionId = InteractionId;
			this.TagId = TagId;

		}



		/// <summary>
		/// Identifies the external platform that is the source of the conversation.
		/// </summary>
		/// <value>Identifies the external platform that is the source of the conversation.</value>
		[DataMember(Name = "sourceId", EmitDefaultValue = false)]
		public string SourceId { get; set; }



		/// <summary>
		/// The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.
		/// </summary>
		/// <value>The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.</value>
		[DataMember(Name = "interactionId", EmitDefaultValue = false)]
		public string InteractionId { get; set; }



		/// <summary>
		/// The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.
		/// </summary>
		/// <value>The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.</value>
		[DataMember(Name = "tagId", EmitDefaultValue = false)]
		public string TagId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SourceConfiguration {\n");

			sb.Append("  SourceId: ").Append(SourceId).Append("\n");
			sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
			sb.Append("  TagId: ").Append(TagId).Append("\n");
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
			return this.Equals(obj as SourceConfiguration);
		}

		/// <summary>
		/// Returns true if SourceConfiguration instances are equal
		/// </summary>
		/// <param name="other">Instance of SourceConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SourceConfiguration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SourceId == other.SourceId ||
					this.SourceId != null &&
					this.SourceId.Equals(other.SourceId)
				) &&
				(
					this.InteractionId == other.InteractionId ||
					this.InteractionId != null &&
					this.InteractionId.Equals(other.InteractionId)
				) &&
				(
					this.TagId == other.TagId ||
					this.TagId != null &&
					this.TagId.Equals(other.TagId)
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
				if (this.SourceId != null)
					hash = hash * 59 + this.SourceId.GetHashCode();

				if (this.InteractionId != null)
					hash = hash * 59 + this.InteractionId.GetHashCode();

				if (this.TagId != null)
					hash = hash * 59 + this.TagId.GetHashCode();

				return hash;
			}
		}
	}

}
