using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContestCompleteDataScore
	/// </summary>
	[DataContract]
	public partial class ContestCompleteDataScore : IEquatable<ContestCompleteDataScore>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContestCompleteDataScore" /> class.
		/// </summary>
		/// <param name="Score">The Contest score.</param>
		public ContestCompleteDataScore(double? Score = null)
		{
			this.Score = Score;

		}



		/// <summary>
		/// The Contest score
		/// </summary>
		/// <value>The Contest score</value>
		[DataMember(Name = "score", EmitDefaultValue = false)]
		public double? Score { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContestCompleteDataScore {\n");

			sb.Append("  Score: ").Append(Score).Append("\n");
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
			return this.Equals(obj as ContestCompleteDataScore);
		}

		/// <summary>
		/// Returns true if ContestCompleteDataScore instances are equal
		/// </summary>
		/// <param name="other">Instance of ContestCompleteDataScore to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContestCompleteDataScore other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Score == other.Score ||
					this.Score != null &&
					this.Score.Equals(other.Score)
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
				if (this.Score != null)
					hash = hash * 59 + this.Score.GetHashCode();

				return hash;
			}
		}
	}

}
