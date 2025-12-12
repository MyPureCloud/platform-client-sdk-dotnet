using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Settings that control how tracking data is collected and filtered.
	/// </summary>
	[DataContract]
	public partial class TrackingSettings : IEquatable<TrackingSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TrackingSettings" /> class.
		/// </summary>
		/// <param name="ExcludedQueryParameters">List of parameters to be excluded from the query string..</param>
		/// <param name="ShouldKeepUrlFragment">Whether or not to keep the URL fragment..</param>
		/// <param name="SearchQueryParameters">List of query parameters used for search (e.g. &#39;query&#39;)..</param>
		/// <param name="IpFilters">IP address filtering configuration for tracking restrictions..</param>
		public TrackingSettings(List<string> ExcludedQueryParameters = null, bool? ShouldKeepUrlFragment = null, List<string> SearchQueryParameters = null, List<IpFilter> IpFilters = null)
		{
			this.ExcludedQueryParameters = ExcludedQueryParameters;
			this.ShouldKeepUrlFragment = ShouldKeepUrlFragment;
			this.SearchQueryParameters = SearchQueryParameters;
			this.IpFilters = IpFilters;

		}



		/// <summary>
		/// List of parameters to be excluded from the query string.
		/// </summary>
		/// <value>List of parameters to be excluded from the query string.</value>
		[DataMember(Name = "excludedQueryParameters", EmitDefaultValue = false)]
		public List<string> ExcludedQueryParameters { get; set; }



		/// <summary>
		/// Whether or not to keep the URL fragment.
		/// </summary>
		/// <value>Whether or not to keep the URL fragment.</value>
		[DataMember(Name = "shouldKeepUrlFragment", EmitDefaultValue = false)]
		public bool? ShouldKeepUrlFragment { get; set; }



		/// <summary>
		/// List of query parameters used for search (e.g. &#39;query&#39;).
		/// </summary>
		/// <value>List of query parameters used for search (e.g. &#39;query&#39;).</value>
		[DataMember(Name = "searchQueryParameters", EmitDefaultValue = false)]
		public List<string> SearchQueryParameters { get; set; }



		/// <summary>
		/// IP address filtering configuration for tracking restrictions.
		/// </summary>
		/// <value>IP address filtering configuration for tracking restrictions.</value>
		[DataMember(Name = "ipFilters", EmitDefaultValue = false)]
		public List<IpFilter> IpFilters { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TrackingSettings {\n");

			sb.Append("  ExcludedQueryParameters: ").Append(ExcludedQueryParameters).Append("\n");
			sb.Append("  ShouldKeepUrlFragment: ").Append(ShouldKeepUrlFragment).Append("\n");
			sb.Append("  SearchQueryParameters: ").Append(SearchQueryParameters).Append("\n");
			sb.Append("  IpFilters: ").Append(IpFilters).Append("\n");
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
			return this.Equals(obj as TrackingSettings);
		}

		/// <summary>
		/// Returns true if TrackingSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of TrackingSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TrackingSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExcludedQueryParameters == other.ExcludedQueryParameters ||
					this.ExcludedQueryParameters != null &&
					this.ExcludedQueryParameters.SequenceEqual(other.ExcludedQueryParameters)
				) &&
				(
					this.ShouldKeepUrlFragment == other.ShouldKeepUrlFragment ||
					this.ShouldKeepUrlFragment != null &&
					this.ShouldKeepUrlFragment.Equals(other.ShouldKeepUrlFragment)
				) &&
				(
					this.SearchQueryParameters == other.SearchQueryParameters ||
					this.SearchQueryParameters != null &&
					this.SearchQueryParameters.SequenceEqual(other.SearchQueryParameters)
				) &&
				(
					this.IpFilters == other.IpFilters ||
					this.IpFilters != null &&
					this.IpFilters.SequenceEqual(other.IpFilters)
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
				if (this.ExcludedQueryParameters != null)
					hash = hash * 59 + this.ExcludedQueryParameters.GetHashCode();

				if (this.ShouldKeepUrlFragment != null)
					hash = hash * 59 + this.ShouldKeepUrlFragment.GetHashCode();

				if (this.SearchQueryParameters != null)
					hash = hash * 59 + this.SearchQueryParameters.GetHashCode();

				if (this.IpFilters != null)
					hash = hash * 59 + this.IpFilters.GetHashCode();

				return hash;
			}
		}
	}

}
