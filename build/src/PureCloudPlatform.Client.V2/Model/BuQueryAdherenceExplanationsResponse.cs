using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuQueryAdherenceExplanationsResponse
	/// </summary>
	[DataContract]
	public partial class BuQueryAdherenceExplanationsResponse : IEquatable<BuQueryAdherenceExplanationsResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuQueryAdherenceExplanationsResponse" /> class.
		/// </summary>
		/// <param name="Job">The asynchronous job handling the query.</param>
		/// <param name="Result">The result of the query. May come via notification.</param>
		/// <param name="DownloadUrl">The URL from which to download the result. May come via notification.</param>
		public BuQueryAdherenceExplanationsResponse(AdherenceExplanationJobReference Job = null, AdherenceExplanationListingBuQueryResponse Result = null, string DownloadUrl = null)
		{
			this.Job = Job;
			this.Result = Result;
			this.DownloadUrl = DownloadUrl;

		}



		/// <summary>
		/// The asynchronous job handling the query
		/// </summary>
		/// <value>The asynchronous job handling the query</value>
		[DataMember(Name = "job", EmitDefaultValue = false)]
		public AdherenceExplanationJobReference Job { get; set; }



		/// <summary>
		/// The result of the query. May come via notification
		/// </summary>
		/// <value>The result of the query. May come via notification</value>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		public AdherenceExplanationListingBuQueryResponse Result { get; set; }



		/// <summary>
		/// The URL from which to download the result. May come via notification
		/// </summary>
		/// <value>The URL from which to download the result. May come via notification</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuQueryAdherenceExplanationsResponse {\n");

			sb.Append("  Job: ").Append(Job).Append("\n");
			sb.Append("  Result: ").Append(Result).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
			return this.Equals(obj as BuQueryAdherenceExplanationsResponse);
		}

		/// <summary>
		/// Returns true if BuQueryAdherenceExplanationsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of BuQueryAdherenceExplanationsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuQueryAdherenceExplanationsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Job == other.Job ||
					this.Job != null &&
					this.Job.Equals(other.Job)
				) &&
				(
					this.Result == other.Result ||
					this.Result != null &&
					this.Result.Equals(other.Result)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
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
				if (this.Job != null)
					hash = hash * 59 + this.Job.GetHashCode();

				if (this.Result != null)
					hash = hash * 59 + this.Result.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				return hash;
			}
		}
	}

}
