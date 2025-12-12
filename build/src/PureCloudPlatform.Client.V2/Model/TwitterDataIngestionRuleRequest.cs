using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TwitterDataIngestionRuleRequest
	/// </summary>
	[DataContract]
	public partial class TwitterDataIngestionRuleRequest : IEquatable<TwitterDataIngestionRuleRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterDataIngestionRuleRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TwitterDataIngestionRuleRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterDataIngestionRuleRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the data ingestion rule. (required).</param>
		/// <param name="Description">A description of the data ingestion rule..</param>
		/// <param name="SearchTerms">Search terms for X (formally Twitter). (required).</param>
		/// <param name="Countries">ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide..</param>
		public TwitterDataIngestionRuleRequest(string Name = null, string Description = null, string SearchTerms = null, List<string> Countries = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.SearchTerms = SearchTerms;
			this.Countries = Countries;

		}



		/// <summary>
		/// The name of the data ingestion rule.
		/// </summary>
		/// <value>The name of the data ingestion rule.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// A description of the data ingestion rule.
		/// </summary>
		/// <value>A description of the data ingestion rule.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Search terms for X (formally Twitter).
		/// </summary>
		/// <value>Search terms for X (formally Twitter).</value>
		[DataMember(Name = "searchTerms", EmitDefaultValue = false)]
		public string SearchTerms { get; set; }



		/// <summary>
		/// ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide.
		/// </summary>
		/// <value>ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide.</value>
		[DataMember(Name = "countries", EmitDefaultValue = false)]
		public List<string> Countries { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TwitterDataIngestionRuleRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
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
			return this.Equals(obj as TwitterDataIngestionRuleRequest);
		}

		/// <summary>
		/// Returns true if TwitterDataIngestionRuleRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TwitterDataIngestionRuleRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TwitterDataIngestionRuleRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.SearchTerms != null)
					hash = hash * 59 + this.SearchTerms.GetHashCode();

				if (this.Countries != null)
					hash = hash * 59 + this.Countries.GetHashCode();

				return hash;
			}
		}
	}

}
