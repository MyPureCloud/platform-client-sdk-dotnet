using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SocialMediaAsyncDetailQueryResponse
	/// </summary>
	[DataContract]
	public partial class SocialMediaAsyncDetailQueryResponse : IEquatable<SocialMediaAsyncDetailQueryResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SocialMediaAsyncDetailQueryResponse" /> class.
		/// </summary>
		/// <param name="Results">Results.</param>
		/// <param name="Cursor">Cursor token to retrieve next or previous page.</param>
		public SocialMediaAsyncDetailQueryResponse(List<SocialMediaDetailDataContainer> Results = null, string Cursor = null)
		{
			this.Results = Results;
			this.Cursor = Cursor;

		}



		/// <summary>
		/// Gets or Sets Results
		/// </summary>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public List<SocialMediaDetailDataContainer> Results { get; set; }



		/// <summary>
		/// Cursor token to retrieve next or previous page
		/// </summary>
		/// <value>Cursor token to retrieve next or previous page</value>
		[DataMember(Name = "cursor", EmitDefaultValue = false)]
		public string Cursor { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SocialMediaAsyncDetailQueryResponse {\n");

			sb.Append("  Results: ").Append(Results).Append("\n");
			sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
			return this.Equals(obj as SocialMediaAsyncDetailQueryResponse);
		}

		/// <summary>
		/// Returns true if SocialMediaAsyncDetailQueryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of SocialMediaAsyncDetailQueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SocialMediaAsyncDetailQueryResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.SequenceEqual(other.Results)
				) &&
				(
					this.Cursor == other.Cursor ||
					this.Cursor != null &&
					this.Cursor.Equals(other.Cursor)
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
				if (this.Results != null)
					hash = hash * 59 + this.Results.GetHashCode();

				if (this.Cursor != null)
					hash = hash * 59 + this.Cursor.GetHashCode();

				return hash;
			}
		}
	}

}
