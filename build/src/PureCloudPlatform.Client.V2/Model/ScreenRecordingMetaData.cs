using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ScreenRecordingMetaData
	/// </summary>
	[DataContract]
	public partial class ScreenRecordingMetaData : IEquatable<ScreenRecordingMetaData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ScreenRecordingMetaData" /> class.
		/// </summary>
		/// <param name="TrackId">TrackId.</param>
		/// <param name="MediaId">MediaId.</param>
		/// <param name="ScreenId">ScreenId.</param>
		/// <param name="OriginX">OriginX.</param>
		/// <param name="OriginY">OriginY.</param>
		/// <param name="Primary">Primary.</param>
		/// <param name="Main">Main.</param>
		public ScreenRecordingMetaData(string TrackId = null, string MediaId = null, string ScreenId = null, int? OriginX = null, int? OriginY = null, bool? Primary = null, bool? Main = null)
		{
			this.TrackId = TrackId;
			this.MediaId = MediaId;
			this.ScreenId = ScreenId;
			this.OriginX = OriginX;
			this.OriginY = OriginY;
			this.Primary = Primary;
			this.Main = Main;

		}



		/// <summary>
		/// Gets or Sets TrackId
		/// </summary>
		[DataMember(Name = "trackId", EmitDefaultValue = false)]
		public string TrackId { get; set; }



		/// <summary>
		/// Gets or Sets MediaId
		/// </summary>
		[DataMember(Name = "mediaId", EmitDefaultValue = false)]
		public string MediaId { get; set; }



		/// <summary>
		/// Gets or Sets ScreenId
		/// </summary>
		[DataMember(Name = "screenId", EmitDefaultValue = false)]
		public string ScreenId { get; set; }



		/// <summary>
		/// Gets or Sets OriginX
		/// </summary>
		[DataMember(Name = "originX", EmitDefaultValue = false)]
		public int? OriginX { get; set; }



		/// <summary>
		/// Gets or Sets OriginY
		/// </summary>
		[DataMember(Name = "originY", EmitDefaultValue = false)]
		public int? OriginY { get; set; }



		/// <summary>
		/// Gets or Sets Primary
		/// </summary>
		[DataMember(Name = "primary", EmitDefaultValue = false)]
		public bool? Primary { get; set; }



		/// <summary>
		/// Gets or Sets Main
		/// </summary>
		[DataMember(Name = "main", EmitDefaultValue = false)]
		public bool? Main { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ScreenRecordingMetaData {\n");

			sb.Append("  TrackId: ").Append(TrackId).Append("\n");
			sb.Append("  MediaId: ").Append(MediaId).Append("\n");
			sb.Append("  ScreenId: ").Append(ScreenId).Append("\n");
			sb.Append("  OriginX: ").Append(OriginX).Append("\n");
			sb.Append("  OriginY: ").Append(OriginY).Append("\n");
			sb.Append("  Primary: ").Append(Primary).Append("\n");
			sb.Append("  Main: ").Append(Main).Append("\n");
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
			return this.Equals(obj as ScreenRecordingMetaData);
		}

		/// <summary>
		/// Returns true if ScreenRecordingMetaData instances are equal
		/// </summary>
		/// <param name="other">Instance of ScreenRecordingMetaData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ScreenRecordingMetaData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TrackId == other.TrackId ||
					this.TrackId != null &&
					this.TrackId.Equals(other.TrackId)
				) &&
				(
					this.MediaId == other.MediaId ||
					this.MediaId != null &&
					this.MediaId.Equals(other.MediaId)
				) &&
				(
					this.ScreenId == other.ScreenId ||
					this.ScreenId != null &&
					this.ScreenId.Equals(other.ScreenId)
				) &&
				(
					this.OriginX == other.OriginX ||
					this.OriginX != null &&
					this.OriginX.Equals(other.OriginX)
				) &&
				(
					this.OriginY == other.OriginY ||
					this.OriginY != null &&
					this.OriginY.Equals(other.OriginY)
				) &&
				(
					this.Primary == other.Primary ||
					this.Primary != null &&
					this.Primary.Equals(other.Primary)
				) &&
				(
					this.Main == other.Main ||
					this.Main != null &&
					this.Main.Equals(other.Main)
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
				if (this.TrackId != null)
					hash = hash * 59 + this.TrackId.GetHashCode();

				if (this.MediaId != null)
					hash = hash * 59 + this.MediaId.GetHashCode();

				if (this.ScreenId != null)
					hash = hash * 59 + this.ScreenId.GetHashCode();

				if (this.OriginX != null)
					hash = hash * 59 + this.OriginX.GetHashCode();

				if (this.OriginY != null)
					hash = hash * 59 + this.OriginY.GetHashCode();

				if (this.Primary != null)
					hash = hash * 59 + this.Primary.GetHashCode();

				if (this.Main != null)
					hash = hash * 59 + this.Main.GetHashCode();

				return hash;
			}
		}
	}

}
