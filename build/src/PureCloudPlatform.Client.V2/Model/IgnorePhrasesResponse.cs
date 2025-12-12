using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IgnorePhrasesResponse
	/// </summary>
	[DataContract]
	public partial class IgnorePhrasesResponse : IEquatable<IgnorePhrasesResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="IgnorePhrasesResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IgnorePhrasesResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IgnorePhrasesResponse" /> class.
		/// </summary>
		/// <param name="TotalPhrases">Total number of phrases in current org (required).</param>
		/// <param name="AddedPhrases">Number of phrases added in current request (required).</param>
		/// <param name="UpdatedPhrases">Number of phrases updated in current request (required).</param>
		public IgnorePhrasesResponse(int? TotalPhrases = null, int? AddedPhrases = null, int? UpdatedPhrases = null)
		{
			this.TotalPhrases = TotalPhrases;
			this.AddedPhrases = AddedPhrases;
			this.UpdatedPhrases = UpdatedPhrases;

		}



		/// <summary>
		/// Total number of phrases in current org
		/// </summary>
		/// <value>Total number of phrases in current org</value>
		[DataMember(Name = "totalPhrases", EmitDefaultValue = false)]
		public int? TotalPhrases { get; set; }



		/// <summary>
		/// Number of phrases added in current request
		/// </summary>
		/// <value>Number of phrases added in current request</value>
		[DataMember(Name = "addedPhrases", EmitDefaultValue = false)]
		public int? AddedPhrases { get; set; }



		/// <summary>
		/// Number of phrases updated in current request
		/// </summary>
		/// <value>Number of phrases updated in current request</value>
		[DataMember(Name = "updatedPhrases", EmitDefaultValue = false)]
		public int? UpdatedPhrases { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IgnorePhrasesResponse {\n");

			sb.Append("  TotalPhrases: ").Append(TotalPhrases).Append("\n");
			sb.Append("  AddedPhrases: ").Append(AddedPhrases).Append("\n");
			sb.Append("  UpdatedPhrases: ").Append(UpdatedPhrases).Append("\n");
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
			return this.Equals(obj as IgnorePhrasesResponse);
		}

		/// <summary>
		/// Returns true if IgnorePhrasesResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of IgnorePhrasesResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IgnorePhrasesResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TotalPhrases == other.TotalPhrases ||
					this.TotalPhrases != null &&
					this.TotalPhrases.Equals(other.TotalPhrases)
				) &&
				(
					this.AddedPhrases == other.AddedPhrases ||
					this.AddedPhrases != null &&
					this.AddedPhrases.Equals(other.AddedPhrases)
				) &&
				(
					this.UpdatedPhrases == other.UpdatedPhrases ||
					this.UpdatedPhrases != null &&
					this.UpdatedPhrases.Equals(other.UpdatedPhrases)
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
				if (this.TotalPhrases != null)
					hash = hash * 59 + this.TotalPhrases.GetHashCode();

				if (this.AddedPhrases != null)
					hash = hash * 59 + this.AddedPhrases.GetHashCode();

				if (this.UpdatedPhrases != null)
					hash = hash * 59 + this.UpdatedPhrases.GetHashCode();

				return hash;
			}
		}
	}

}
