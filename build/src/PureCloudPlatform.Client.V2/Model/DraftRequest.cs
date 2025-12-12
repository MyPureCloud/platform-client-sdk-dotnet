using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DraftRequest
	/// </summary>
	[DataContract]
	public partial class DraftRequest : IEquatable<DraftRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DraftRequest" /> class.
		/// </summary>
		/// <param name="Intents">Draft intent object..</param>
		/// <param name="Topics">Draft topic object..</param>
		public DraftRequest(List<DraftIntents> Intents = null, List<DraftTopicRequest> Topics = null)
		{
			this.Intents = Intents;
			this.Topics = Topics;

		}



		/// <summary>
		/// Draft intent object.
		/// </summary>
		/// <value>Draft intent object.</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<DraftIntents> Intents { get; set; }



		/// <summary>
		/// Draft topic object.
		/// </summary>
		/// <value>Draft topic object.</value>
		[DataMember(Name = "topics", EmitDefaultValue = false)]
		public List<DraftTopicRequest> Topics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DraftRequest {\n");

			sb.Append("  Intents: ").Append(Intents).Append("\n");
			sb.Append("  Topics: ").Append(Topics).Append("\n");
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
			return this.Equals(obj as DraftRequest);
		}

		/// <summary>
		/// Returns true if DraftRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of DraftRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DraftRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
				) &&
				(
					this.Topics == other.Topics ||
					this.Topics != null &&
					this.Topics.SequenceEqual(other.Topics)
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
				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				if (this.Topics != null)
					hash = hash * 59 + this.Topics.GetHashCode();

				return hash;
			}
		}
	}

}
