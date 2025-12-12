using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TwitterDataHistoricalTweetRequest
	/// </summary>
	[DataContract]
	public partial class TwitterDataHistoricalTweetRequest : IEquatable<TwitterDataHistoricalTweetRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterDataHistoricalTweetRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TwitterDataHistoricalTweetRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterDataHistoricalTweetRequest" /> class.
		/// </summary>
		/// <param name="SearchTerms">Search terms to use in the query (required).</param>
		/// <param name="Countries">ISO 3166-1 alpha-2 country codes to use for the search. Defaults to worldwide..</param>
		public TwitterDataHistoricalTweetRequest(string SearchTerms = null, List<string> Countries = null)
		{
			this.SearchTerms = SearchTerms;
			this.Countries = Countries;

		}



		/// <summary>
		/// Search terms to use in the query
		/// </summary>
		/// <value>Search terms to use in the query</value>
		[DataMember(Name = "searchTerms", EmitDefaultValue = false)]
		public string SearchTerms { get; set; }



		/// <summary>
		/// ISO 3166-1 alpha-2 country codes to use for the search. Defaults to worldwide.
		/// </summary>
		/// <value>ISO 3166-1 alpha-2 country codes to use for the search. Defaults to worldwide.</value>
		[DataMember(Name = "countries", EmitDefaultValue = false)]
		public List<string> Countries { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TwitterDataHistoricalTweetRequest {\n");

			sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
			sb.Append("  Countries: ").Append(Countries).Append("\n");
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
			return this.Equals(obj as TwitterDataHistoricalTweetRequest);
		}

		/// <summary>
		/// Returns true if TwitterDataHistoricalTweetRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TwitterDataHistoricalTweetRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TwitterDataHistoricalTweetRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SearchTerms == other.SearchTerms ||
					this.SearchTerms != null &&
					this.SearchTerms.Equals(other.SearchTerms)
				) &&
				(
					this.Countries == other.Countries ||
					this.Countries != null &&
					this.Countries.SequenceEqual(other.Countries)
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
				if (this.SearchTerms != null)
					hash = hash * 59 + this.SearchTerms.GetHashCode();

				if (this.Countries != null)
					hash = hash * 59 + this.Countries.GetHashCode();

				return hash;
			}
		}
	}

}
