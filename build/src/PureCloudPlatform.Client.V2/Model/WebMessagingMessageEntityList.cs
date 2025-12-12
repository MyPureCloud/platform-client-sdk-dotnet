using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebMessagingMessageEntityList
	/// </summary>
	[DataContract]
	public partial class WebMessagingMessageEntityList : IEquatable<WebMessagingMessageEntityList>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingMessageEntityList" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="PageSize">PageSize.</param>
		/// <param name="PageNumber">PageNumber.</param>
		/// <param name="Total">Total.</param>
		/// <param name="PageCount">PageCount.</param>
		public WebMessagingMessageEntityList(List<WebMessagingMessage> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, int? PageCount = null)
		{
			this.Entities = Entities;
			this.PageSize = PageSize;
			this.PageNumber = PageNumber;
			this.Total = Total;
			this.PageCount = PageCount;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<WebMessagingMessage> Entities { get; set; }



		/// <summary>
		/// Gets or Sets PageSize
		/// </summary>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// Gets or Sets PageNumber
		/// </summary>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// Gets or Sets Total
		/// </summary>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public long? Total { get; set; }



		/// <summary>
		/// Gets or Sets PageCount
		/// </summary>
		[DataMember(Name = "pageCount", EmitDefaultValue = false)]
		public int? PageCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebMessagingMessageEntityList {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
			return this.Equals(obj as WebMessagingMessageEntityList);
		}

		/// <summary>
		/// Returns true if WebMessagingMessageEntityList instances are equal
		/// </summary>
		/// <param name="other">Instance of WebMessagingMessageEntityList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebMessagingMessageEntityList other)
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
					this.PageNumber == other.PageNumber ||
					this.PageNumber != null &&
					this.PageNumber.Equals(other.PageNumber)
				) &&
				(
					this.Total == other.Total ||
					this.Total != null &&
					this.Total.Equals(other.Total)
				) &&
				(
					this.PageCount == other.PageCount ||
					this.PageCount != null &&
					this.PageCount.Equals(other.PageCount)
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

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.Total != null)
					hash = hash * 59 + this.Total.GetHashCode();

				if (this.PageCount != null)
					hash = hash * 59 + this.PageCount.GetHashCode();

				return hash;
			}
		}
	}

}
