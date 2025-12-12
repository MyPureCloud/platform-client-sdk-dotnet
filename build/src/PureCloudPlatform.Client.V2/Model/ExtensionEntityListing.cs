using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExtensionEntityListing
	/// </summary>
	[DataContract]
	public partial class ExtensionEntityListing : IEquatable<ExtensionEntityListing>, IPagedResource<Extension>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExtensionEntityListing" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="PageSize">PageSize.</param>
		/// <param name="PageNumber">PageNumber.</param>
		/// <param name="Total">Total.</param>
		/// <param name="TotalNumberOfEntities">The total organization-wide number of entities..</param>
		/// <param name="LastUri">LastUri.</param>
		/// <param name="FirstUri">FirstUri.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="NextUri">NextUri.</param>
		/// <param name="PreviousUri">PreviousUri.</param>
		/// <param name="PageCount">PageCount.</param>
		public ExtensionEntityListing(List<Extension> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, long? TotalNumberOfEntities = null, string LastUri = null, string FirstUri = null, string SelfUri = null, string NextUri = null, string PreviousUri = null, int? PageCount = null)
		{
			this.Entities = Entities;
			this.PageSize = PageSize;
			this.PageNumber = PageNumber;
			this.Total = Total;
			this.TotalNumberOfEntities = TotalNumberOfEntities;
			this.LastUri = LastUri;
			this.FirstUri = FirstUri;
			this.SelfUri = SelfUri;
			this.NextUri = NextUri;
			this.PreviousUri = PreviousUri;
			this.PageCount = PageCount;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<Extension> Entities { get; set; }



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
		/// The total organization-wide number of entities.
		/// </summary>
		/// <value>The total organization-wide number of entities.</value>
		[DataMember(Name = "totalNumberOfEntities", EmitDefaultValue = false)]
		public long? TotalNumberOfEntities { get; set; }



		/// <summary>
		/// Gets or Sets LastUri
		/// </summary>
		[DataMember(Name = "lastUri", EmitDefaultValue = false)]
		public string LastUri { get; set; }



		/// <summary>
		/// Gets or Sets FirstUri
		/// </summary>
		[DataMember(Name = "firstUri", EmitDefaultValue = false)]
		public string FirstUri { get; set; }



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
		/// Gets or Sets PreviousUri
		/// </summary>
		[DataMember(Name = "previousUri", EmitDefaultValue = false)]
		public string PreviousUri { get; set; }



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
			sb.Append("class ExtensionEntityListing {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  TotalNumberOfEntities: ").Append(TotalNumberOfEntities).Append("\n");
			sb.Append("  LastUri: ").Append(LastUri).Append("\n");
			sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  NextUri: ").Append(NextUri).Append("\n");
			sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
			return this.Equals(obj as ExtensionEntityListing);
		}

		/// <summary>
		/// Returns true if ExtensionEntityListing instances are equal
		/// </summary>
		/// <param name="other">Instance of ExtensionEntityListing to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExtensionEntityListing other)
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
					this.TotalNumberOfEntities == other.TotalNumberOfEntities ||
					this.TotalNumberOfEntities != null &&
					this.TotalNumberOfEntities.Equals(other.TotalNumberOfEntities)
				) &&
				(
					this.LastUri == other.LastUri ||
					this.LastUri != null &&
					this.LastUri.Equals(other.LastUri)
				) &&
				(
					this.FirstUri == other.FirstUri ||
					this.FirstUri != null &&
					this.FirstUri.Equals(other.FirstUri)
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
				) &&
				(
					this.PreviousUri == other.PreviousUri ||
					this.PreviousUri != null &&
					this.PreviousUri.Equals(other.PreviousUri)
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

				if (this.TotalNumberOfEntities != null)
					hash = hash * 59 + this.TotalNumberOfEntities.GetHashCode();

				if (this.LastUri != null)
					hash = hash * 59 + this.LastUri.GetHashCode();

				if (this.FirstUri != null)
					hash = hash * 59 + this.FirstUri.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.NextUri != null)
					hash = hash * 59 + this.NextUri.GetHashCode();

				if (this.PreviousUri != null)
					hash = hash * 59 + this.PreviousUri.GetHashCode();

				if (this.PageCount != null)
					hash = hash * 59 + this.PageCount.GetHashCode();

				return hash;
			}
		}
	}

}
