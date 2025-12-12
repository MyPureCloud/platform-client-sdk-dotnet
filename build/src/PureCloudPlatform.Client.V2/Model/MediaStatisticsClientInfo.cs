using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MediaStatisticsClientInfo
	/// </summary>
	[DataContract]
	public partial class MediaStatisticsClientInfo : IEquatable<MediaStatisticsClientInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MediaStatisticsClientInfo" /> class.
		/// </summary>
		/// <param name="OriginAppName">The name of the application that created the media session..</param>
		/// <param name="OriginAppId">The ID of the application that created the media session..</param>
		/// <param name="OriginAppVersion">The version of the application that created the media session..</param>
		public MediaStatisticsClientInfo(string OriginAppName = null, string OriginAppId = null, string OriginAppVersion = null)
		{
			this.OriginAppName = OriginAppName;
			this.OriginAppId = OriginAppId;
			this.OriginAppVersion = OriginAppVersion;

		}



		/// <summary>
		/// The name of the application that created the media session.
		/// </summary>
		/// <value>The name of the application that created the media session.</value>
		[DataMember(Name = "originAppName", EmitDefaultValue = false)]
		public string OriginAppName { get; set; }



		/// <summary>
		/// The ID of the application that created the media session.
		/// </summary>
		/// <value>The ID of the application that created the media session.</value>
		[DataMember(Name = "originAppId", EmitDefaultValue = false)]
		public string OriginAppId { get; set; }



		/// <summary>
		/// The version of the application that created the media session.
		/// </summary>
		/// <value>The version of the application that created the media session.</value>
		[DataMember(Name = "originAppVersion", EmitDefaultValue = false)]
		public string OriginAppVersion { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MediaStatisticsClientInfo {\n");

			sb.Append("  OriginAppName: ").Append(OriginAppName).Append("\n");
			sb.Append("  OriginAppId: ").Append(OriginAppId).Append("\n");
			sb.Append("  OriginAppVersion: ").Append(OriginAppVersion).Append("\n");
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
			return this.Equals(obj as MediaStatisticsClientInfo);
		}

		/// <summary>
		/// Returns true if MediaStatisticsClientInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of MediaStatisticsClientInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MediaStatisticsClientInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OriginAppName == other.OriginAppName ||
					this.OriginAppName != null &&
					this.OriginAppName.Equals(other.OriginAppName)
				) &&
				(
					this.OriginAppId == other.OriginAppId ||
					this.OriginAppId != null &&
					this.OriginAppId.Equals(other.OriginAppId)
				) &&
				(
					this.OriginAppVersion == other.OriginAppVersion ||
					this.OriginAppVersion != null &&
					this.OriginAppVersion.Equals(other.OriginAppVersion)
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
				if (this.OriginAppName != null)
					hash = hash * 59 + this.OriginAppName.GetHashCode();

				if (this.OriginAppId != null)
					hash = hash * 59 + this.OriginAppId.GetHashCode();

				if (this.OriginAppVersion != null)
					hash = hash * 59 + this.OriginAppVersion.GetHashCode();

				return hash;
			}
		}
	}

}
