using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebEventDevice
	/// </summary>
	[DataContract]
	public partial class WebEventDevice : IEquatable<WebEventDevice>
	{
		/// <summary>
		/// Device category.
		/// </summary>
		/// <value>Device category.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CategoryEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Desktop for "desktop"
			/// </summary>
			[EnumMember(Value = "desktop")]
			Desktop,

			/// <summary>
			/// Enum Mobile for "mobile"
			/// </summary>
			[EnumMember(Value = "mobile")]
			Mobile,

			/// <summary>
			/// Enum Tablet for "tablet"
			/// </summary>
			[EnumMember(Value = "tablet")]
			Tablet,

			/// <summary>
			/// Enum Other for "other"
			/// </summary>
			[EnumMember(Value = "other")]
			Other
		}
		/// <summary>
		/// Device category.
		/// </summary>
		/// <value>Device category.</value>
		[DataMember(Name = "category", EmitDefaultValue = false)]
		public CategoryEnum? Category { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WebEventDevice" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebEventDevice() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebEventDevice" /> class.
		/// </summary>
		/// <param name="Category">Device category. (required).</param>
		/// <param name="Type">Device type (e.g. iPad, iPhone, Other). (required).</param>
		/// <param name="IsMobile">Flag that is true for mobile devices..</param>
		/// <param name="ScreenHeight">Device&#39;s screen height..</param>
		/// <param name="ScreenWidth">Device&#39;s screen width..</param>
		/// <param name="ScreenDensity">Device&#39;s screen density, measured as a scale factor where a value of 1 represents a baseline 1:1 ratio of pixels to logical (device-independent) pixels..</param>
		/// <param name="OsFamily">Operating system family. (required).</param>
		/// <param name="OsVersion">Operating system version. (required).</param>
		/// <param name="Manufacturer">Manufacturer of the device..</param>
		public WebEventDevice(CategoryEnum? Category = null, string Type = null, bool? IsMobile = null, int? ScreenHeight = null, int? ScreenWidth = null, int? ScreenDensity = null, string OsFamily = null, string OsVersion = null, string Manufacturer = null)
		{
			this.Category = Category;
			this.Type = Type;
			this.IsMobile = IsMobile;
			this.ScreenHeight = ScreenHeight;
			this.ScreenWidth = ScreenWidth;
			this.ScreenDensity = ScreenDensity;
			this.OsFamily = OsFamily;
			this.OsVersion = OsVersion;
			this.Manufacturer = Manufacturer;

		}





		/// <summary>
		/// Device type (e.g. iPad, iPhone, Other).
		/// </summary>
		/// <value>Device type (e.g. iPad, iPhone, Other).</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// Flag that is true for mobile devices.
		/// </summary>
		/// <value>Flag that is true for mobile devices.</value>
		[DataMember(Name = "isMobile", EmitDefaultValue = false)]
		public bool? IsMobile { get; set; }



		/// <summary>
		/// Device&#39;s screen height.
		/// </summary>
		/// <value>Device&#39;s screen height.</value>
		[DataMember(Name = "screenHeight", EmitDefaultValue = false)]
		public int? ScreenHeight { get; set; }



		/// <summary>
		/// Device&#39;s screen width.
		/// </summary>
		/// <value>Device&#39;s screen width.</value>
		[DataMember(Name = "screenWidth", EmitDefaultValue = false)]
		public int? ScreenWidth { get; set; }



		/// <summary>
		/// Device&#39;s screen density, measured as a scale factor where a value of 1 represents a baseline 1:1 ratio of pixels to logical (device-independent) pixels.
		/// </summary>
		/// <value>Device&#39;s screen density, measured as a scale factor where a value of 1 represents a baseline 1:1 ratio of pixels to logical (device-independent) pixels.</value>
		[DataMember(Name = "screenDensity", EmitDefaultValue = false)]
		public int? ScreenDensity { get; set; }



		/// <summary>
		/// Operating system family.
		/// </summary>
		/// <value>Operating system family.</value>
		[DataMember(Name = "osFamily", EmitDefaultValue = false)]
		public string OsFamily { get; set; }



		/// <summary>
		/// Operating system version.
		/// </summary>
		/// <value>Operating system version.</value>
		[DataMember(Name = "osVersion", EmitDefaultValue = false)]
		public string OsVersion { get; set; }



		/// <summary>
		/// Manufacturer of the device.
		/// </summary>
		/// <value>Manufacturer of the device.</value>
		[DataMember(Name = "manufacturer", EmitDefaultValue = false)]
		public string Manufacturer { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebEventDevice {\n");

			sb.Append("  Category: ").Append(Category).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  IsMobile: ").Append(IsMobile).Append("\n");
			sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
			sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
			sb.Append("  ScreenDensity: ").Append(ScreenDensity).Append("\n");
			sb.Append("  OsFamily: ").Append(OsFamily).Append("\n");
			sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
			sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
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
			return this.Equals(obj as WebEventDevice);
		}

		/// <summary>
		/// Returns true if WebEventDevice instances are equal
		/// </summary>
		/// <param name="other">Instance of WebEventDevice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebEventDevice other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Category == other.Category ||
					this.Category != null &&
					this.Category.Equals(other.Category)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.IsMobile == other.IsMobile ||
					this.IsMobile != null &&
					this.IsMobile.Equals(other.IsMobile)
				) &&
				(
					this.ScreenHeight == other.ScreenHeight ||
					this.ScreenHeight != null &&
					this.ScreenHeight.Equals(other.ScreenHeight)
				) &&
				(
					this.ScreenWidth == other.ScreenWidth ||
					this.ScreenWidth != null &&
					this.ScreenWidth.Equals(other.ScreenWidth)
				) &&
				(
					this.ScreenDensity == other.ScreenDensity ||
					this.ScreenDensity != null &&
					this.ScreenDensity.Equals(other.ScreenDensity)
				) &&
				(
					this.OsFamily == other.OsFamily ||
					this.OsFamily != null &&
					this.OsFamily.Equals(other.OsFamily)
				) &&
				(
					this.OsVersion == other.OsVersion ||
					this.OsVersion != null &&
					this.OsVersion.Equals(other.OsVersion)
				) &&
				(
					this.Manufacturer == other.Manufacturer ||
					this.Manufacturer != null &&
					this.Manufacturer.Equals(other.Manufacturer)
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
				if (this.Category != null)
					hash = hash * 59 + this.Category.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.IsMobile != null)
					hash = hash * 59 + this.IsMobile.GetHashCode();

				if (this.ScreenHeight != null)
					hash = hash * 59 + this.ScreenHeight.GetHashCode();

				if (this.ScreenWidth != null)
					hash = hash * 59 + this.ScreenWidth.GetHashCode();

				if (this.ScreenDensity != null)
					hash = hash * 59 + this.ScreenDensity.GetHashCode();

				if (this.OsFamily != null)
					hash = hash * 59 + this.OsFamily.GetHashCode();

				if (this.OsVersion != null)
					hash = hash * 59 + this.OsVersion.GetHashCode();

				if (this.Manufacturer != null)
					hash = hash * 59 + this.Manufacturer.GetHashCode();

				return hash;
			}
		}
	}

}
