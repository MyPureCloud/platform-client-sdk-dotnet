using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UtilizationResponse
	/// </summary>
	[DataContract]
	public partial class UtilizationResponse : IEquatable<UtilizationResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UtilizationResponse" /> class.
		/// </summary>
		/// <param name="Utilization">Map of media type to utilization settings..</param>
		/// <param name="LabelUtilizations">Map of label ids to utilization settings..</param>
		public UtilizationResponse(Dictionary<string, MediaUtilization> Utilization = null, Dictionary<string, LabelUtilizationResponse> LabelUtilizations = null)
		{
			this.Utilization = Utilization;
			this.LabelUtilizations = LabelUtilizations;

		}



		/// <summary>
		/// Map of media type to utilization settings.
		/// </summary>
		/// <value>Map of media type to utilization settings.</value>
		[DataMember(Name = "utilization", EmitDefaultValue = false)]
		public Dictionary<string, MediaUtilization> Utilization { get; set; }



		/// <summary>
		/// Map of label ids to utilization settings.
		/// </summary>
		/// <value>Map of label ids to utilization settings.</value>
		[DataMember(Name = "labelUtilizations", EmitDefaultValue = false)]
		public Dictionary<string, LabelUtilizationResponse> LabelUtilizations { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UtilizationResponse {\n");

			sb.Append("  Utilization: ").Append(Utilization).Append("\n");
			sb.Append("  LabelUtilizations: ").Append(LabelUtilizations).Append("\n");
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
			return this.Equals(obj as UtilizationResponse);
		}

		/// <summary>
		/// Returns true if UtilizationResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of UtilizationResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UtilizationResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Utilization == other.Utilization ||
					this.Utilization != null &&
					this.Utilization.SequenceEqual(other.Utilization)
				) &&
				(
					this.LabelUtilizations == other.LabelUtilizations ||
					this.LabelUtilizations != null &&
					this.LabelUtilizations.SequenceEqual(other.LabelUtilizations)
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
				if (this.Utilization != null)
					hash = hash * 59 + this.Utilization.GetHashCode();

				if (this.LabelUtilizations != null)
					hash = hash * 59 + this.LabelUtilizations.GetHashCode();

				return hash;
			}
		}
	}

}
