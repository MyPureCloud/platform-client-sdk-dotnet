using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Settings concerning messenger
	/// </summary>
	[DataContract]
	public partial class MessengerSettings : IEquatable<MessengerSettings>
	{
		/// <summary>
		/// The session persistence type for messenger
		/// </summary>
		/// <value>The session persistence type for messenger</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SessionPersistenceTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Acrosssubdomains for "AcrossSubdomains"
			/// </summary>
			[EnumMember(Value = "AcrossSubdomains")]
			Acrosssubdomains,

			/// <summary>
			/// Enum Domainorsubdomainonly for "DomainOrSubdomainOnly"
			/// </summary>
			[EnumMember(Value = "DomainOrSubdomainOnly")]
			Domainorsubdomainonly
		}
		/// <summary>
		/// The session persistence type for messenger
		/// </summary>
		/// <value>The session persistence type for messenger</value>
		[DataMember(Name = "sessionPersistenceType", EmitDefaultValue = false)]
		public SessionPersistenceTypeEnum? SessionPersistenceType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="MessengerSettings" /> class.
		/// </summary>
		/// <param name="Enabled">Whether or not messenger is enabled.</param>
		/// <param name="Styles">The style settings for messenger.</param>
		/// <param name="LauncherButton">The launcher button settings for messenger.</param>
		/// <param name="FileUpload">The file upload settings for messenger.</param>
		/// <param name="Apps">The apps embedded in the messenger.</param>
		/// <param name="HomeScreen">The homescreen settings for messenger.</param>
		/// <param name="SessionPersistenceType">The session persistence type for messenger.</param>
		public MessengerSettings(bool? Enabled = null, MessengerStyles Styles = null, LauncherButtonSettings LauncherButton = null, FileUploadSettings FileUpload = null, MessengerApps Apps = null, MessengerHomeScreen HomeScreen = null, SessionPersistenceTypeEnum? SessionPersistenceType = null)
		{
			this.Enabled = Enabled;
			this.Styles = Styles;
			this.LauncherButton = LauncherButton;
			this.FileUpload = FileUpload;
			this.Apps = Apps;
			this.HomeScreen = HomeScreen;
			this.SessionPersistenceType = SessionPersistenceType;

		}



		/// <summary>
		/// Whether or not messenger is enabled
		/// </summary>
		/// <value>Whether or not messenger is enabled</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// The style settings for messenger
		/// </summary>
		/// <value>The style settings for messenger</value>
		[DataMember(Name = "styles", EmitDefaultValue = false)]
		public MessengerStyles Styles { get; set; }



		/// <summary>
		/// The launcher button settings for messenger
		/// </summary>
		/// <value>The launcher button settings for messenger</value>
		[DataMember(Name = "launcherButton", EmitDefaultValue = false)]
		public LauncherButtonSettings LauncherButton { get; set; }



		/// <summary>
		/// The file upload settings for messenger
		/// </summary>
		/// <value>The file upload settings for messenger</value>
		[DataMember(Name = "fileUpload", EmitDefaultValue = false)]
		public FileUploadSettings FileUpload { get; set; }



		/// <summary>
		/// The apps embedded in the messenger
		/// </summary>
		/// <value>The apps embedded in the messenger</value>
		[DataMember(Name = "apps", EmitDefaultValue = false)]
		public MessengerApps Apps { get; set; }



		/// <summary>
		/// The homescreen settings for messenger
		/// </summary>
		/// <value>The homescreen settings for messenger</value>
		[DataMember(Name = "homeScreen", EmitDefaultValue = false)]
		public MessengerHomeScreen HomeScreen { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessengerSettings {\n");

			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Styles: ").Append(Styles).Append("\n");
			sb.Append("  LauncherButton: ").Append(LauncherButton).Append("\n");
			sb.Append("  FileUpload: ").Append(FileUpload).Append("\n");
			sb.Append("  Apps: ").Append(Apps).Append("\n");
			sb.Append("  HomeScreen: ").Append(HomeScreen).Append("\n");
			sb.Append("  SessionPersistenceType: ").Append(SessionPersistenceType).Append("\n");
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
			return this.Equals(obj as MessengerSettings);
		}

		/// <summary>
		/// Returns true if MessengerSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of MessengerSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessengerSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.Styles == other.Styles ||
					this.Styles != null &&
					this.Styles.Equals(other.Styles)
				) &&
				(
					this.LauncherButton == other.LauncherButton ||
					this.LauncherButton != null &&
					this.LauncherButton.Equals(other.LauncherButton)
				) &&
				(
					this.FileUpload == other.FileUpload ||
					this.FileUpload != null &&
					this.FileUpload.Equals(other.FileUpload)
				) &&
				(
					this.Apps == other.Apps ||
					this.Apps != null &&
					this.Apps.Equals(other.Apps)
				) &&
				(
					this.HomeScreen == other.HomeScreen ||
					this.HomeScreen != null &&
					this.HomeScreen.Equals(other.HomeScreen)
				) &&
				(
					this.SessionPersistenceType == other.SessionPersistenceType ||
					this.SessionPersistenceType != null &&
					this.SessionPersistenceType.Equals(other.SessionPersistenceType)
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
				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.Styles != null)
					hash = hash * 59 + this.Styles.GetHashCode();

				if (this.LauncherButton != null)
					hash = hash * 59 + this.LauncherButton.GetHashCode();

				if (this.FileUpload != null)
					hash = hash * 59 + this.FileUpload.GetHashCode();

				if (this.Apps != null)
					hash = hash * 59 + this.Apps.GetHashCode();

				if (this.HomeScreen != null)
					hash = hash * 59 + this.HomeScreen.GetHashCode();

				if (this.SessionPersistenceType != null)
					hash = hash * 59 + this.SessionPersistenceType.GetHashCode();

				return hash;
			}
		}
	}

}
