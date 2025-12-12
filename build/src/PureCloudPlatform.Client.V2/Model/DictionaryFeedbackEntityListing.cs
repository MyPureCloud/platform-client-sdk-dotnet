using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DictionaryFeedbackEntityListing
	/// </summary>
	[DataContract]
	public partial class DictionaryFeedbackEntityListing : IEquatable<DictionaryFeedbackEntityListing>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DictionaryFeedbackEntityListing" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="PageSize">PageSize.</param>
		/// <param name="PageCount">PageCount.</param>
		/// <param name="Total">Total.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="NextUri">NextUri.</param>
		public DictionaryFeedbackEntityListing(List<ListedDictionaryFeedback> Entities = null, int? PageSize = null, int? PageCount = null, int? Total = null, string SelfUri = null, string NextUri = null)
		{
			this.Entities = Entities;
			this.PageSize = PageSize;
			this.PageCount = PageCount;
			this.Total = Total;
			this.SelfUri = SelfUri;
			this.NextUri = NextUri;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<ListedDictionaryFeedback> Entities { get; set; }



		/// <summary>
		/// Gets or Sets PageSize
		/// </summary>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// Gets or Sets PageCount
		/// </summary>
		[DataMember(Name = "pageCount", EmitDefaultValue = false)]
		public int? PageCount { get; set; }



		/// <summary>
		/// Gets or Sets Total
		/// </summary>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public int? Total { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }



		/// <summary>
		/// Gets or Sets NextUri
		/// </summary>
		[DataMember(Name = "nextUri", EmitDefaultValue = false)]
		public string NextUri { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DictionaryFeedbackEntityListing {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  PageCount: ").Append(PageCount).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  NextUri: ").Append(NextUri).Append("\n");
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
			return this.Equals(obj as DictionaryFeedbackEntityListing);
		}

		/// <summary>
		/// Returns true if DictionaryFeedbackEntityListing instances are equal
		/// </summary>
		/// <param name="other">Instance of DictionaryFeedbackEntityListing to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DictionaryFeedbackEntityListing other)
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
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.PageCount == other.PageCount ||
					this.PageCount != null &&
					this.PageCount.Equals(other.PageCount)
				) &&
				(
					this.Total == other.Total ||
					this.Total != null &&
					this.Total.Equals(other.Total)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.NextUri == other.NextUri ||
					this.NextUri != null &&
					this.NextUri.Equals(other.NextUri)
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

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.PageCount != null)
					hash = hash * 59 + this.PageCount.GetHashCode();

				if (this.Total != null)
					hash = hash * 59 + this.Total.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.NextUri != null)
					hash = hash * 59 + this.NextUri.GetHashCode();

				return hash;
			}
		}
	}

}
