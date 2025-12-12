using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserObservationQueryResponse
	/// </summary>
	[DataContract]
	public partial class UserObservationQueryResponse : IEquatable<UserObservationQueryResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserObservationQueryResponse" /> class.
		/// </summary>
		/// <param name="Results">Results.</param>
		public UserObservationQueryResponse(List<UserObservationDataContainer> Results = null)
		{
			this.Results = Results;

		}



		/// <summary>
		/// Gets or Sets Results
		/// </summary>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public List<UserObservationDataContainer> Results { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserObservationQueryResponse {\n");

			sb.Append("  Results: ").Append(Results).Append("\n");
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
			return this.Equals(obj as UserObservationQueryResponse);
		}

		/// <summary>
		/// Returns true if UserObservationQueryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of UserObservationQueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserObservationQueryResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.SequenceEqual(other.Results)
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

				return hash;
			}
		}
	}

}
