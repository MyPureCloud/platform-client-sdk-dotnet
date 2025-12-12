using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContinuousForecastSnapshotResponse
	/// </summary>
	[DataContract]
	public partial class ContinuousForecastSnapshotResponse : IEquatable<ContinuousForecastSnapshotResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContinuousForecastSnapshotResponse" /> class.
		/// </summary>
		/// <param name="SessionId">Session Id of the continuous forecast.</param>
		/// <param name="SnapshotId">Snapshot Id of the continuous forecast session.</param>
		/// <param name="Files">Link to the files containing data for requested snapshot.</param>
		public ContinuousForecastSnapshotResponse(string SessionId = null, string SnapshotId = null, SnapshotFiles Files = null)
		{
			this.SessionId = SessionId;
			this.SnapshotId = SnapshotId;
			this.Files = Files;

		}



		/// <summary>
		/// Session Id of the continuous forecast
		/// </summary>
		/// <value>Session Id of the continuous forecast</value>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; set; }



		/// <summary>
		/// Snapshot Id of the continuous forecast session
		/// </summary>
		/// <value>Snapshot Id of the continuous forecast session</value>
		[DataMember(Name = "snapshotId", EmitDefaultValue = false)]
		public string SnapshotId { get; set; }



		/// <summary>
		/// Link to the files containing data for requested snapshot
		/// </summary>
		/// <value>Link to the files containing data for requested snapshot</value>
		[DataMember(Name = "files", EmitDefaultValue = false)]
		public SnapshotFiles Files { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContinuousForecastSnapshotResponse {\n");

			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  SnapshotId: ").Append(SnapshotId).Append("\n");
			sb.Append("  Files: ").Append(Files).Append("\n");
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
			return this.Equals(obj as ContinuousForecastSnapshotResponse);
		}

		/// <summary>
		/// Returns true if ContinuousForecastSnapshotResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ContinuousForecastSnapshotResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContinuousForecastSnapshotResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.SnapshotId == other.SnapshotId ||
					this.SnapshotId != null &&
					this.SnapshotId.Equals(other.SnapshotId)
				) &&
				(
					this.Files == other.Files ||
					this.Files != null &&
					this.Files.Equals(other.Files)
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
				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.SnapshotId != null)
					hash = hash * 59 + this.SnapshotId.GetHashCode();

				if (this.Files != null)
					hash = hash * 59 + this.Files.GetHashCode();

				return hash;
			}
		}
	}

}
