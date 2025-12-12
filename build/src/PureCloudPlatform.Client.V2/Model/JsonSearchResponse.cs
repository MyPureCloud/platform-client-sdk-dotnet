using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JsonSearchResponse
	/// </summary>
	[DataContract]
	public partial class JsonSearchResponse : IEquatable<JsonSearchResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="JsonSearchResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected JsonSearchResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="JsonSearchResponse" /> class.
		/// </summary>
		/// <param name="Total">The total number of results found (required).</param>
		/// <param name="PageCount">The total number of pages (required).</param>
		/// <param name="PageSize">The current page size (required).</param>
		/// <param name="PageNumber">The current page number (required).</param>
		/// <param name="Types">Resource types the search was performed against (required).</param>
		/// <param name="Results">Search results (required).</param>
		/// <param name="Aggregations">Aggregations.</param>
		public JsonSearchResponse(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, List<string> Types = null, Object Results = null, Object Aggregations = null)
		{
			this.Total = Total;
			this.PageCount = PageCount;
			this.PageSize = PageSize;
			this.PageNumber = PageNumber;
			this.Types = Types;
			this.Results = Results;
			this.Aggregations = Aggregations;

		}



		/// <summary>
		/// The total number of results found
		/// </summary>
		/// <value>The total number of results found</value>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public long? Total { get; set; }



		/// <summary>
		/// The total number of pages
		/// </summary>
		/// <value>The total number of pages</value>
		[DataMember(Name = "pageCount", EmitDefaultValue = false)]
		public int? PageCount { get; set; }



		/// <summary>
		/// The current page size
		/// </summary>
		/// <value>The current page size</value>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// The current page number
		/// </summary>
		/// <value>The current page number</value>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// Resource types the search was performed against
		/// </summary>
		/// <value>Resource types the search was performed against</value>
		[DataMember(Name = "types", EmitDefaultValue = false)]
		public List<string> Types { get; set; }



		/// <summary>
		/// Search results
		/// </summary>
		/// <value>Search results</value>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public Object Results { get; set; }



		/// <summary>
		/// Gets or Sets Aggregations
		/// </summary>
		[DataMember(Name = "aggregations", EmitDefaultValue = false)]
		public Object Aggregations { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JsonSearchResponse {\n");

			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  PageCount: ").Append(PageCount).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  Types: ").Append(Types).Append("\n");
			sb.Append("  Results: ").Append(Results).Append("\n");
			sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
			return this.Equals(obj as JsonSearchResponse);
		}

		/// <summary>
		/// Returns true if JsonSearchResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of JsonSearchResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JsonSearchResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Total == other.Total ||
					this.Total != null &&
					this.Total.Equals(other.Total)
				) &&
				(
					this.PageCount == other.PageCount ||
					this.PageCount != null &&
					this.PageCount.Equals(other.PageCount)
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
					this.Types == other.Types ||
					this.Types != null &&
					this.Types.SequenceEqual(other.Types)
				) &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.Equals(other.Results)
				) &&
				(
					this.Aggregations == other.Aggregations ||
					this.Aggregations != null &&
					this.Aggregations.Equals(other.Aggregations)
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
				if (this.Total != null)
					hash = hash * 59 + this.Total.GetHashCode();

				if (this.PageCount != null)
					hash = hash * 59 + this.PageCount.GetHashCode();

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.Types != null)
					hash = hash * 59 + this.Types.GetHashCode();

				if (this.Results != null)
					hash = hash * 59 + this.Results.GetHashCode();

				if (this.Aggregations != null)
					hash = hash * 59 + this.Aggregations.GetHashCode();

				return hash;
			}
		}
	}

}
