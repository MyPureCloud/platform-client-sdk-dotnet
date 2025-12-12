using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ParticipantInfo
	/// </summary>
	[DataContract]
	public partial class ParticipantInfo : IEquatable<ParticipantInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ParticipantInfo" /> class.
		/// </summary>
		/// <param name="ActiveParticipantCount">The number of active participants in the video conference..</param>
		/// <param name="Version">The version of the participant count..</param>
		public ParticipantInfo(int? ActiveParticipantCount = null, int? Version = null)
		{
			this.ActiveParticipantCount = ActiveParticipantCount;
			this.Version = Version;

		}



		/// <summary>
		/// The number of active participants in the video conference.
		/// </summary>
		/// <value>The number of active participants in the video conference.</value>
		[DataMember(Name = "activeParticipantCount", EmitDefaultValue = false)]
		public int? ActiveParticipantCount { get; set; }



		/// <summary>
		/// The version of the participant count.
		/// </summary>
		/// <value>The version of the participant count.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ParticipantInfo {\n");

			sb.Append("  ActiveParticipantCount: ").Append(ActiveParticipantCount).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as ParticipantInfo);
		}

		/// <summary>
		/// Returns true if ParticipantInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of ParticipantInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ParticipantInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActiveParticipantCount == other.ActiveParticipantCount ||
					this.ActiveParticipantCount != null &&
					this.ActiveParticipantCount.Equals(other.ActiveParticipantCount)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.ActiveParticipantCount != null)
					hash = hash * 59 + this.ActiveParticipantCount.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
