using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SearchDecisionTableRowsRequest
	/// </summary>
	[DataContract]
	public partial class SearchDecisionTableRowsRequest : IEquatable<SearchDecisionTableRowsRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SearchDecisionTableRowsRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SearchDecisionTableRowsRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SearchDecisionTableRowsRequest" /> class.
		/// </summary>
		/// <param name="Filter">The filter criteria for searching decision table rows (required).</param>
		public SearchDecisionTableRowsRequest(RowSearchFilter Filter = null)
		{
			this.Filter = Filter;

		}



		/// <summary>
		/// The filter criteria for searching decision table rows
		/// </summary>
		/// <value>The filter criteria for searching decision table rows</value>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public RowSearchFilter Filter { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SearchDecisionTableRowsRequest {\n");

			sb.Append("  Filter: ").Append(Filter).Append("\n");
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
			return this.Equals(obj as SearchDecisionTableRowsRequest);
		}

		/// <summary>
		/// Returns true if SearchDecisionTableRowsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of SearchDecisionTableRowsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SearchDecisionTableRowsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Filter == other.Filter ||
					this.Filter != null &&
					this.Filter.Equals(other.Filter)
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
				if (this.Filter != null)
					hash = hash * 59 + this.Filter.GetHashCode();

				return hash;
			}
		}
	}

}
