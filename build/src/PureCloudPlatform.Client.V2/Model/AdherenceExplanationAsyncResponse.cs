using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AdherenceExplanationAsyncResponse
	/// </summary>
	[DataContract]
	public partial class AdherenceExplanationAsyncResponse : IEquatable<AdherenceExplanationAsyncResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AdherenceExplanationAsyncResponse" /> class.
		/// </summary>
		/// <param name="Job">A reference to the job that was started by the request.</param>
		public AdherenceExplanationAsyncResponse(AdherenceExplanationJobReference Job = null)
		{
			this.Job = Job;

		}



		/// <summary>
		/// A reference to the job that was started by the request
		/// </summary>
		/// <value>A reference to the job that was started by the request</value>
		[DataMember(Name = "job", EmitDefaultValue = false)]
		public AdherenceExplanationJobReference Job { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AdherenceExplanationAsyncResponse {\n");

			sb.Append("  Job: ").Append(Job).Append("\n");
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
			return this.Equals(obj as AdherenceExplanationAsyncResponse);
		}

		/// <summary>
		/// Returns true if AdherenceExplanationAsyncResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AdherenceExplanationAsyncResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AdherenceExplanationAsyncResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Job == other.Job ||
					this.Job != null &&
					this.Job.Equals(other.Job)
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

				return hash;
			}
		}
	}

}
