using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebEventsNotificationBrowser
	/// </summary>
	[DataContract]
	public partial class JourneyWebEventsNotificationBrowser : IEquatable<JourneyWebEventsNotificationBrowser>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebEventsNotificationBrowser" /> class.
		/// </summary>
		/// <param name="Family">Family.</param>
		/// <param name="Version">Version.</param>
		/// <param name="Lang">Lang.</param>
		/// <param name="Fingerprint">Fingerprint.</param>
		/// <param name="ViewHeight">ViewHeight.</param>
		/// <param name="ViewWidth">ViewWidth.</param>
		/// <param name="FeaturesFlash">FeaturesFlash.</param>
		/// <param name="FeaturesJava">FeaturesJava.</param>
		/// <param name="FeaturesPdf">FeaturesPdf.</param>
		/// <param name="FeaturesWebrtc">FeaturesWebrtc.</param>
		public JourneyWebEventsNotificationBrowser(string Family = null, string Version = null, string Lang = null, string Fingerprint = null, long? ViewHeight = null, long? ViewWidth = null, bool? FeaturesFlash = null, bool? FeaturesJava = null, bool? FeaturesPdf = null, bool? FeaturesWebrtc = null)
		{
			this.Family = Family;
			this.Version = Version;
			this.Lang = Lang;
			this.Fingerprint = Fingerprint;
			this.ViewHeight = ViewHeight;
			this.ViewWidth = ViewWidth;
			this.FeaturesFlash = FeaturesFlash;
			this.FeaturesJava = FeaturesJava;
			this.FeaturesPdf = FeaturesPdf;
			this.FeaturesWebrtc = FeaturesWebrtc;

		}



		/// <summary>
		/// Gets or Sets Family
		/// </summary>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public string Family { get; set; }



		/// <summary>
		/// Gets or Sets Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; set; }



		/// <summary>
		/// Gets or Sets Lang
		/// </summary>
		[DataMember(Name = "lang", EmitDefaultValue = false)]
		public string Lang { get; set; }



		/// <summary>
		/// Gets or Sets Fingerprint
		/// </summary>
		[DataMember(Name = "fingerprint", EmitDefaultValue = false)]
		public string Fingerprint { get; set; }



		/// <summary>
		/// Gets or Sets ViewHeight
		/// </summary>
		[DataMember(Name = "viewHeight", EmitDefaultValue = false)]
		public long? ViewHeight { get; set; }



		/// <summary>
		/// Gets or Sets ViewWidth
		/// </summary>
		[DataMember(Name = "viewWidth", EmitDefaultValue = false)]
		public long? ViewWidth { get; set; }



		/// <summary>
		/// Gets or Sets FeaturesFlash
		/// </summary>
		[DataMember(Name = "featuresFlash", EmitDefaultValue = false)]
		public bool? FeaturesFlash { get; set; }



		/// <summary>
		/// Gets or Sets FeaturesJava
		/// </summary>
		[DataMember(Name = "featuresJava", EmitDefaultValue = false)]
		public bool? FeaturesJava { get; set; }



		/// <summary>
		/// Gets or Sets FeaturesPdf
		/// </summary>
		[DataMember(Name = "featuresPdf", EmitDefaultValue = false)]
		public bool? FeaturesPdf { get; set; }



		/// <summary>
		/// Gets or Sets FeaturesWebrtc
		/// </summary>
		[DataMember(Name = "featuresWebrtc", EmitDefaultValue = false)]
		public bool? FeaturesWebrtc { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebEventsNotificationBrowser {\n");

			sb.Append("  Family: ").Append(Family).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Lang: ").Append(Lang).Append("\n");
			sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
			sb.Append("  ViewHeight: ").Append(ViewHeight).Append("\n");
			sb.Append("  ViewWidth: ").Append(ViewWidth).Append("\n");
			sb.Append("  FeaturesFlash: ").Append(FeaturesFlash).Append("\n");
			sb.Append("  FeaturesJava: ").Append(FeaturesJava).Append("\n");
			sb.Append("  FeaturesPdf: ").Append(FeaturesPdf).Append("\n");
			sb.Append("  FeaturesWebrtc: ").Append(FeaturesWebrtc).Append("\n");
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
			return this.Equals(obj as JourneyWebEventsNotificationBrowser);
		}

		/// <summary>
		/// Returns true if JourneyWebEventsNotificationBrowser instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebEventsNotificationBrowser to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebEventsNotificationBrowser other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Family == other.Family ||
					this.Family != null &&
					this.Family.Equals(other.Family)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.Lang == other.Lang ||
					this.Lang != null &&
					this.Lang.Equals(other.Lang)
				) &&
				(
					this.Fingerprint == other.Fingerprint ||
					this.Fingerprint != null &&
					this.Fingerprint.Equals(other.Fingerprint)
				) &&
				(
					this.ViewHeight == other.ViewHeight ||
					this.ViewHeight != null &&
					this.ViewHeight.Equals(other.ViewHeight)
				) &&
				(
					this.ViewWidth == other.ViewWidth ||
					this.ViewWidth != null &&
					this.ViewWidth.Equals(other.ViewWidth)
				) &&
				(
					this.FeaturesFlash == other.FeaturesFlash ||
					this.FeaturesFlash != null &&
					this.FeaturesFlash.Equals(other.FeaturesFlash)
				) &&
				(
					this.FeaturesJava == other.FeaturesJava ||
					this.FeaturesJava != null &&
					this.FeaturesJava.Equals(other.FeaturesJava)
				) &&
				(
					this.FeaturesPdf == other.FeaturesPdf ||
					this.FeaturesPdf != null &&
					this.FeaturesPdf.Equals(other.FeaturesPdf)
				) &&
				(
					this.FeaturesWebrtc == other.FeaturesWebrtc ||
					this.FeaturesWebrtc != null &&
					this.FeaturesWebrtc.Equals(other.FeaturesWebrtc)
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
				if (this.Family != null)
					hash = hash * 59 + this.Family.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Lang != null)
					hash = hash * 59 + this.Lang.GetHashCode();

				if (this.Fingerprint != null)
					hash = hash * 59 + this.Fingerprint.GetHashCode();

				if (this.ViewHeight != null)
					hash = hash * 59 + this.ViewHeight.GetHashCode();

				if (this.ViewWidth != null)
					hash = hash * 59 + this.ViewWidth.GetHashCode();

				if (this.FeaturesFlash != null)
					hash = hash * 59 + this.FeaturesFlash.GetHashCode();

				if (this.FeaturesJava != null)
					hash = hash * 59 + this.FeaturesJava.GetHashCode();

				if (this.FeaturesPdf != null)
					hash = hash * 59 + this.FeaturesPdf.GetHashCode();

				if (this.FeaturesWebrtc != null)
					hash = hash * 59 + this.FeaturesWebrtc.GetHashCode();

				return hash;
			}
		}
	}

}
