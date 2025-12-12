using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InstagramIntegration
	/// </summary>
	[DataContract]
	public partial class InstagramIntegration : IEquatable<InstagramIntegration>
	{
		/// <summary>
		/// Status of asynchronous create operation
		/// </summary>
		/// <value>Status of asynchronous create operation</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CreateStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Initiated for "Initiated"
			/// </summary>
			[EnumMember(Value = "Initiated")]
			Initiated,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Status of asynchronous create operation
		/// </summary>
		/// <value>Status of asynchronous create operation</value>
		[DataMember(Name = "createStatus", EmitDefaultValue = false)]
		public CreateStatusEnum? CreateStatus { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="InstagramIntegration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected InstagramIntegration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="InstagramIntegration" /> class.
		/// </summary>
		/// <param name="Name">The name of the Instagram Integration (required).</param>
		/// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
		/// <param name="MessagingSetting">MessagingSetting.</param>
		/// <param name="AppId">The App ID from Facebook (required).</param>
		/// <param name="PageId">The Page ID from Instagram messenger.</param>
		/// <param name="InstagramId">The ID from Instagram messenger.</param>
		/// <param name="InstagramUsername">The Username from Instagram messenger.</param>
		/// <param name="InstagramName">The name from Instagram messenger.</param>
		/// <param name="InstagramProfileImageUrl">The url of the profile image from Instagram messenger.</param>
		/// <param name="Status">The status of the Instagram Integration.</param>
		/// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="CreatedBy">User reference that created this Integration.</param>
		/// <param name="ModifiedBy">User reference that last modified this Integration.</param>
		/// <param name="Version">Version number required for updates. (required).</param>
		public InstagramIntegration(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null, string AppId = null, string PageId = null, string InstagramId = null, string InstagramUsername = null, string InstagramName = null, string InstagramProfileImageUrl = null, string Status = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, int? Version = null)
		{
			this.Name = Name;
			this.SupportedContent = SupportedContent;
			this.MessagingSetting = MessagingSetting;
			this.AppId = AppId;
			this.PageId = PageId;
			this.InstagramId = InstagramId;
			this.InstagramUsername = InstagramUsername;
			this.InstagramName = InstagramName;
			this.InstagramProfileImageUrl = InstagramProfileImageUrl;
			this.Status = Status;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.CreatedBy = CreatedBy;
			this.ModifiedBy = ModifiedBy;
			this.Version = Version;

		}



		/// <summary>
		/// A unique Integration ID.
		/// </summary>
		/// <value>A unique Integration ID.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the Instagram Integration
		/// </summary>
		/// <value>The name of the Instagram Integration</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Defines the SupportedContent profile configured for an integration
		/// </summary>
		/// <value>Defines the SupportedContent profile configured for an integration</value>
		[DataMember(Name = "supportedContent", EmitDefaultValue = false)]
		public SupportedContentReference SupportedContent { get; set; }



		/// <summary>
		/// Gets or Sets MessagingSetting
		/// </summary>
		[DataMember(Name = "messagingSetting", EmitDefaultValue = false)]
		public MessagingSettingReference MessagingSetting { get; set; }



		/// <summary>
		/// The App ID from Facebook
		/// </summary>
		/// <value>The App ID from Facebook</value>
		[DataMember(Name = "appId", EmitDefaultValue = false)]
		public string AppId { get; set; }



		/// <summary>
		/// The Page ID from Instagram messenger
		/// </summary>
		/// <value>The Page ID from Instagram messenger</value>
		[DataMember(Name = "pageId", EmitDefaultValue = false)]
		public string PageId { get; set; }



		/// <summary>
		/// The ID from Instagram messenger
		/// </summary>
		/// <value>The ID from Instagram messenger</value>
		[DataMember(Name = "instagramId", EmitDefaultValue = false)]
		public string InstagramId { get; set; }



		/// <summary>
		/// The Username from Instagram messenger
		/// </summary>
		/// <value>The Username from Instagram messenger</value>
		[DataMember(Name = "instagramUsername", EmitDefaultValue = false)]
		public string InstagramUsername { get; set; }



		/// <summary>
		/// The name from Instagram messenger
		/// </summary>
		/// <value>The name from Instagram messenger</value>
		[DataMember(Name = "instagramName", EmitDefaultValue = false)]
		public string InstagramName { get; set; }



		/// <summary>
		/// The url of the profile image from Instagram messenger
		/// </summary>
		/// <value>The url of the profile image from Instagram messenger</value>
		[DataMember(Name = "instagramProfileImageUrl", EmitDefaultValue = false)]
		public string InstagramProfileImageUrl { get; set; }



		/// <summary>
		/// The status of the Instagram Integration
		/// </summary>
		/// <value>The status of the Instagram Integration</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string Status { get; set; }



		/// <summary>
		/// The recipient reference associated to the Instagram Integration. This recipient is used to associate a flow to an integration
		/// </summary>
		/// <value>The recipient reference associated to the Instagram Integration. This recipient is used to associate a flow to an integration</value>
		[DataMember(Name = "recipient", EmitDefaultValue = false)]
		public DomainEntityRef Recipient { get; private set; }



		/// <summary>
		/// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// User reference that created this Integration
		/// </summary>
		/// <value>User reference that created this Integration</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public DomainEntityRef CreatedBy { get; set; }



		/// <summary>
		/// User reference that last modified this Integration
		/// </summary>
		/// <value>User reference that last modified this Integration</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public DomainEntityRef ModifiedBy { get; set; }



		/// <summary>
		/// Version number required for updates.
		/// </summary>
		/// <value>Version number required for updates.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }





		/// <summary>
		/// Error information returned, if createStatus is set to Error
		/// </summary>
		/// <value>Error information returned, if createStatus is set to Error</value>
		[DataMember(Name = "createError", EmitDefaultValue = false)]
		public ErrorBody CreateError { get; private set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InstagramIntegration {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
			sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
			sb.Append("  AppId: ").Append(AppId).Append("\n");
			sb.Append("  PageId: ").Append(PageId).Append("\n");
			sb.Append("  InstagramId: ").Append(InstagramId).Append("\n");
			sb.Append("  InstagramUsername: ").Append(InstagramUsername).Append("\n");
			sb.Append("  InstagramName: ").Append(InstagramName).Append("\n");
			sb.Append("  InstagramProfileImageUrl: ").Append(InstagramProfileImageUrl).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Recipient: ").Append(Recipient).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
			sb.Append("  CreateError: ").Append(CreateError).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as InstagramIntegration);
		}

		/// <summary>
		/// Returns true if InstagramIntegration instances are equal
		/// </summary>
		/// <param name="other">Instance of InstagramIntegration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InstagramIntegration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.SupportedContent == other.SupportedContent ||
					this.SupportedContent != null &&
					this.SupportedContent.Equals(other.SupportedContent)
				) &&
				(
					this.MessagingSetting == other.MessagingSetting ||
					this.MessagingSetting != null &&
					this.MessagingSetting.Equals(other.MessagingSetting)
				) &&
				(
					this.AppId == other.AppId ||
					this.AppId != null &&
					this.AppId.Equals(other.AppId)
				) &&
				(
					this.PageId == other.PageId ||
					this.PageId != null &&
					this.PageId.Equals(other.PageId)
				) &&
				(
					this.InstagramId == other.InstagramId ||
					this.InstagramId != null &&
					this.InstagramId.Equals(other.InstagramId)
				) &&
				(
					this.InstagramUsername == other.InstagramUsername ||
					this.InstagramUsername != null &&
					this.InstagramUsername.Equals(other.InstagramUsername)
				) &&
				(
					this.InstagramName == other.InstagramName ||
					this.InstagramName != null &&
					this.InstagramName.Equals(other.InstagramName)
				) &&
				(
					this.InstagramProfileImageUrl == other.InstagramProfileImageUrl ||
					this.InstagramProfileImageUrl != null &&
					this.InstagramProfileImageUrl.Equals(other.InstagramProfileImageUrl)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Recipient == other.Recipient ||
					this.Recipient != null &&
					this.Recipient.Equals(other.Recipient)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.CreateStatus == other.CreateStatus ||
					this.CreateStatus != null &&
					this.CreateStatus.Equals(other.CreateStatus)
				) &&
				(
					this.CreateError == other.CreateError ||
					this.CreateError != null &&
					this.CreateError.Equals(other.CreateError)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.SupportedContent != null)
					hash = hash * 59 + this.SupportedContent.GetHashCode();

				if (this.MessagingSetting != null)
					hash = hash * 59 + this.MessagingSetting.GetHashCode();

				if (this.AppId != null)
					hash = hash * 59 + this.AppId.GetHashCode();

				if (this.PageId != null)
					hash = hash * 59 + this.PageId.GetHashCode();

				if (this.InstagramId != null)
					hash = hash * 59 + this.InstagramId.GetHashCode();

				if (this.InstagramUsername != null)
					hash = hash * 59 + this.InstagramUsername.GetHashCode();

				if (this.InstagramName != null)
					hash = hash * 59 + this.InstagramName.GetHashCode();

				if (this.InstagramProfileImageUrl != null)
					hash = hash * 59 + this.InstagramProfileImageUrl.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Recipient != null)
					hash = hash * 59 + this.Recipient.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.CreateStatus != null)
					hash = hash * 59 + this.CreateStatus.GetHashCode();

				if (this.CreateError != null)
					hash = hash * 59 + this.CreateError.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
