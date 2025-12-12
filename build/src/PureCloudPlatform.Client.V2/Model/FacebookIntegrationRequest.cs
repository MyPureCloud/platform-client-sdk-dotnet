using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FacebookIntegrationRequest
	/// </summary>
	[DataContract]
	public partial class FacebookIntegrationRequest : IEquatable<FacebookIntegrationRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="FacebookIntegrationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FacebookIntegrationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FacebookIntegrationRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the Facebook Integration (required).</param>
		/// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
		/// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
		/// <param name="PageAccessToken">The long-lived Page Access Token of Facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required..</param>
		/// <param name="UserAccessToken">The short-lived User Access Token of the Facebook user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required..</param>
		/// <param name="PageId">The page Id of Facebook page. The pageId is required when userAccessToken is provided..</param>
		/// <param name="AppId">The app Id of Facebook app. The appId is required when a customer wants to use their own approved Facebook app..</param>
		/// <param name="AppSecret">The app Secret of Facebook app. The appSecret is required when appId is provided..</param>
		public FacebookIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string PageAccessToken = null, string UserAccessToken = null, string PageId = null, string AppId = null, string AppSecret = null)
		{
			this.Name = Name;
			this.SupportedContent = SupportedContent;
			this.MessagingSetting = MessagingSetting;
			this.PageAccessToken = PageAccessToken;
			this.UserAccessToken = UserAccessToken;
			this.PageId = PageId;
			this.AppId = AppId;
			this.AppSecret = AppSecret;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the Facebook Integration
		/// </summary>
		/// <value>The name of the Facebook Integration</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Defines the SupportedContent profile configured for an integration
		/// </summary>
		/// <value>Defines the SupportedContent profile configured for an integration</value>
		[DataMember(Name = "supportedContent", EmitDefaultValue = false)]
		public SupportedContentReference SupportedContent { get; set; }



		/// <summary>
		/// Defines the message settings to be applied for this integration
		/// </summary>
		/// <value>Defines the message settings to be applied for this integration</value>
		[DataMember(Name = "messagingSetting", EmitDefaultValue = false)]
		public MessagingSettingRequestReference MessagingSetting { get; set; }



		/// <summary>
		/// The long-lived Page Access Token of Facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required.
		/// </summary>
		/// <value>The long-lived Page Access Token of Facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required.</value>
		[DataMember(Name = "pageAccessToken", EmitDefaultValue = false)]
		public string PageAccessToken { get; set; }



		/// <summary>
		/// The short-lived User Access Token of the Facebook user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required.
		/// </summary>
		/// <value>The short-lived User Access Token of the Facebook user logged into the Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required.</value>
		[DataMember(Name = "userAccessToken", EmitDefaultValue = false)]
		public string UserAccessToken { get; set; }



		/// <summary>
		/// The page Id of Facebook page. The pageId is required when userAccessToken is provided.
		/// </summary>
		/// <value>The page Id of Facebook page. The pageId is required when userAccessToken is provided.</value>
		[DataMember(Name = "pageId", EmitDefaultValue = false)]
		public string PageId { get; set; }



		/// <summary>
		/// The app Id of Facebook app. The appId is required when a customer wants to use their own approved Facebook app.
		/// </summary>
		/// <value>The app Id of Facebook app. The appId is required when a customer wants to use their own approved Facebook app.</value>
		[DataMember(Name = "appId", EmitDefaultValue = false)]
		public string AppId { get; set; }



		/// <summary>
		/// The app Secret of Facebook app. The appSecret is required when appId is provided.
		/// </summary>
		/// <value>The app Secret of Facebook app. The appSecret is required when appId is provided.</value>
		[DataMember(Name = "appSecret", EmitDefaultValue = false)]
		public string AppSecret { get; set; }



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
			sb.Append("class FacebookIntegrationRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
			sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
			sb.Append("  PageAccessToken: ").Append(PageAccessToken).Append("\n");
			sb.Append("  UserAccessToken: ").Append(UserAccessToken).Append("\n");
			sb.Append("  PageId: ").Append(PageId).Append("\n");
			sb.Append("  AppId: ").Append(AppId).Append("\n");
			sb.Append("  AppSecret: ").Append(AppSecret).Append("\n");
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
			return this.Equals(obj as FacebookIntegrationRequest);
		}

		/// <summary>
		/// Returns true if FacebookIntegrationRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of FacebookIntegrationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FacebookIntegrationRequest other)
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
					this.PageAccessToken == other.PageAccessToken ||
					this.PageAccessToken != null &&
					this.PageAccessToken.Equals(other.PageAccessToken)
				) &&
				(
					this.UserAccessToken == other.UserAccessToken ||
					this.UserAccessToken != null &&
					this.UserAccessToken.Equals(other.UserAccessToken)
				) &&
				(
					this.PageId == other.PageId ||
					this.PageId != null &&
					this.PageId.Equals(other.PageId)
				) &&
				(
					this.AppId == other.AppId ||
					this.AppId != null &&
					this.AppId.Equals(other.AppId)
				) &&
				(
					this.AppSecret == other.AppSecret ||
					this.AppSecret != null &&
					this.AppSecret.Equals(other.AppSecret)
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

				if (this.PageAccessToken != null)
					hash = hash * 59 + this.PageAccessToken.GetHashCode();

				if (this.UserAccessToken != null)
					hash = hash * 59 + this.UserAccessToken.GetHashCode();

				if (this.PageId != null)
					hash = hash * 59 + this.PageId.GetHashCode();

				if (this.AppId != null)
					hash = hash * 59 + this.AppId.GetHashCode();

				if (this.AppSecret != null)
					hash = hash * 59 + this.AppSecret.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
