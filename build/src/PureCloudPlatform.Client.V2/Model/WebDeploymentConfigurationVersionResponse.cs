using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Details about the configuration version of a Web Deployment
    /// </summary>
    [DataContract]
    public partial class WebDeploymentConfigurationVersionResponse :  IEquatable<WebDeploymentConfigurationVersionResponse>
    {
        /// <summary>
        /// The current status of the configuration version
        /// </summary>
        /// <value>The current status of the configuration version</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Deleting for "Deleting"
            /// </summary>
            [EnumMember(Value = "Deleting")]
            Deleting
        }
        /// <summary>
        /// The current status of the configuration version
        /// </summary>
        /// <value>The current status of the configuration version</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebDeploymentConfigurationVersionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionResponse" /> class.
        /// </summary>
        /// <param name="Id">The configuration version ID.</param>
        /// <param name="Name">The configuration version name (required).</param>
        /// <param name="Version">The version of the configuration.</param>
        /// <param name="HeadlessMode">Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI..</param>
        /// <param name="Description">The description of the configuration.</param>
        /// <param name="Languages">A list of languages supported on the configuration required if the messenger is enabled.</param>
        /// <param name="DefaultLanguage">The default language to use for the configuration required if the messenger is enabled.</param>
        /// <param name="CustomI18nLabels">The localization settings for homescreen app.</param>
        /// <param name="Messenger">The settings for messenger.</param>
        /// <param name="Position">The settings for position.</param>
        /// <param name="SupportCenter">The settings for knowledge portal (previously support center).</param>
        /// <param name="Cobrowse">The settings for cobrowse.</param>
        /// <param name="JourneyEvents">The settings for journey events.</param>
        /// <param name="AuthenticationSettings">The settings for authenticated deployments.</param>
        /// <param name="Status">The current status of the configuration version.</param>
        public WebDeploymentConfigurationVersionResponse(string Id = null, string Name = null, string Version = null, WebDeploymentHeadlessMode HeadlessMode = null, string Description = null, List<string> Languages = null, string DefaultLanguage = null, List<CustomI18nLabels> CustomI18nLabels = null, MessengerSettings Messenger = null, PositionSettings Position = null, SupportCenterSettings SupportCenter = null, CobrowseSettings Cobrowse = null, JourneyEventsSettings JourneyEvents = null, AuthenticationSettings AuthenticationSettings = null, StatusEnum? Status = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Version = Version;
            this.HeadlessMode = HeadlessMode;
            this.Description = Description;
            this.Languages = Languages;
            this.DefaultLanguage = DefaultLanguage;
            this.CustomI18nLabels = CustomI18nLabels;
            this.Messenger = Messenger;
            this.Position = Position;
            this.SupportCenter = SupportCenter;
            this.Cobrowse = Cobrowse;
            this.JourneyEvents = JourneyEvents;
            this.AuthenticationSettings = AuthenticationSettings;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// The configuration version ID
        /// </summary>
        /// <value>The configuration version ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The configuration version name
        /// </summary>
        /// <value>The configuration version name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The version of the configuration
        /// </summary>
        /// <value>The version of the configuration</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



        /// <summary>
        /// Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.
        /// </summary>
        /// <value>Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.</value>
        [DataMember(Name="headlessMode", EmitDefaultValue=false)]
        public WebDeploymentHeadlessMode HeadlessMode { get; set; }



        /// <summary>
        /// The description of the configuration
        /// </summary>
        /// <value>The description of the configuration</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// A list of languages supported on the configuration required if the messenger is enabled
        /// </summary>
        /// <value>A list of languages supported on the configuration required if the messenger is enabled</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }



        /// <summary>
        /// The default language to use for the configuration required if the messenger is enabled
        /// </summary>
        /// <value>The default language to use for the configuration required if the messenger is enabled</value>
        [DataMember(Name="defaultLanguage", EmitDefaultValue=false)]
        public string DefaultLanguage { get; set; }



        /// <summary>
        /// The localization settings for homescreen app
        /// </summary>
        /// <value>The localization settings for homescreen app</value>
        [DataMember(Name="customI18nLabels", EmitDefaultValue=false)]
        public List<CustomI18nLabels> CustomI18nLabels { get; set; }



        /// <summary>
        /// The settings for messenger
        /// </summary>
        /// <value>The settings for messenger</value>
        [DataMember(Name="messenger", EmitDefaultValue=false)]
        public MessengerSettings Messenger { get; set; }



        /// <summary>
        /// The settings for position
        /// </summary>
        /// <value>The settings for position</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionSettings Position { get; set; }



        /// <summary>
        /// The settings for knowledge portal (previously support center)
        /// </summary>
        /// <value>The settings for knowledge portal (previously support center)</value>
        [DataMember(Name="supportCenter", EmitDefaultValue=false)]
        public SupportCenterSettings SupportCenter { get; set; }



        /// <summary>
        /// The settings for cobrowse
        /// </summary>
        /// <value>The settings for cobrowse</value>
        [DataMember(Name="cobrowse", EmitDefaultValue=false)]
        public CobrowseSettings Cobrowse { get; set; }



        /// <summary>
        /// The settings for journey events
        /// </summary>
        /// <value>The settings for journey events</value>
        [DataMember(Name="journeyEvents", EmitDefaultValue=false)]
        public JourneyEventsSettings JourneyEvents { get; set; }



        /// <summary>
        /// The settings for authenticated deployments
        /// </summary>
        /// <value>The settings for authenticated deployments</value>
        [DataMember(Name="authenticationSettings", EmitDefaultValue=false)]
        public AuthenticationSettings AuthenticationSettings { get; set; }



        /// <summary>
        /// The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; private set; }



        /// <summary>
        /// A reference to the user who most recently modified the configuration version
        /// </summary>
        /// <value>A reference to the user who most recently modified the configuration version</value>
        [DataMember(Name="lastModifiedUser", EmitDefaultValue=false)]
        public AddressableEntityRef LastModifiedUser { get; private set; }



        /// <summary>
        /// A reference to the user who created the configuration version
        /// </summary>
        /// <value>A reference to the user who created the configuration version</value>
        [DataMember(Name="createdUser", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedUser { get; private set; }



        /// <summary>
        /// A reference to the user who published the configuration version
        /// </summary>
        /// <value>A reference to the user who published the configuration version</value>
        [DataMember(Name="publishedUser", EmitDefaultValue=false)]
        public AddressableEntityRef PublishedUser { get; private set; }





        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentConfigurationVersionResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  HeadlessMode: ").Append(HeadlessMode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  CustomI18nLabels: ").Append(CustomI18nLabels).Append("\n");
            sb.Append("  Messenger: ").Append(Messenger).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SupportCenter: ").Append(SupportCenter).Append("\n");
            sb.Append("  Cobrowse: ").Append(Cobrowse).Append("\n");
            sb.Append("  JourneyEvents: ").Append(JourneyEvents).Append("\n");
            sb.Append("  AuthenticationSettings: ").Append(AuthenticationSettings).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  LastModifiedUser: ").Append(LastModifiedUser).Append("\n");
            sb.Append("  CreatedUser: ").Append(CreatedUser).Append("\n");
            sb.Append("  PublishedUser: ").Append(PublishedUser).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as WebDeploymentConfigurationVersionResponse);
        }

        /// <summary>
        /// Returns true if WebDeploymentConfigurationVersionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentConfigurationVersionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentConfigurationVersionResponse other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.HeadlessMode == other.HeadlessMode ||
                    this.HeadlessMode != null &&
                    this.HeadlessMode.Equals(other.HeadlessMode)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
                ) &&
                (
                    this.DefaultLanguage == other.DefaultLanguage ||
                    this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(other.DefaultLanguage)
                ) &&
                (
                    this.CustomI18nLabels == other.CustomI18nLabels ||
                    this.CustomI18nLabels != null &&
                    this.CustomI18nLabels.SequenceEqual(other.CustomI18nLabels)
                ) &&
                (
                    this.Messenger == other.Messenger ||
                    this.Messenger != null &&
                    this.Messenger.Equals(other.Messenger)
                ) &&
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) &&
                (
                    this.SupportCenter == other.SupportCenter ||
                    this.SupportCenter != null &&
                    this.SupportCenter.Equals(other.SupportCenter)
                ) &&
                (
                    this.Cobrowse == other.Cobrowse ||
                    this.Cobrowse != null &&
                    this.Cobrowse.Equals(other.Cobrowse)
                ) &&
                (
                    this.JourneyEvents == other.JourneyEvents ||
                    this.JourneyEvents != null &&
                    this.JourneyEvents.Equals(other.JourneyEvents)
                ) &&
                (
                    this.AuthenticationSettings == other.AuthenticationSettings ||
                    this.AuthenticationSettings != null &&
                    this.AuthenticationSettings.Equals(other.AuthenticationSettings)
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
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.LastModifiedUser == other.LastModifiedUser ||
                    this.LastModifiedUser != null &&
                    this.LastModifiedUser.Equals(other.LastModifiedUser)
                ) &&
                (
                    this.CreatedUser == other.CreatedUser ||
                    this.CreatedUser != null &&
                    this.CreatedUser.Equals(other.CreatedUser)
                ) &&
                (
                    this.PublishedUser == other.PublishedUser ||
                    this.PublishedUser != null &&
                    this.PublishedUser.Equals(other.PublishedUser)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.HeadlessMode != null)
                    hash = hash * 59 + this.HeadlessMode.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();

                if (this.DefaultLanguage != null)
                    hash = hash * 59 + this.DefaultLanguage.GetHashCode();

                if (this.CustomI18nLabels != null)
                    hash = hash * 59 + this.CustomI18nLabels.GetHashCode();

                if (this.Messenger != null)
                    hash = hash * 59 + this.Messenger.GetHashCode();

                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();

                if (this.SupportCenter != null)
                    hash = hash * 59 + this.SupportCenter.GetHashCode();

                if (this.Cobrowse != null)
                    hash = hash * 59 + this.Cobrowse.GetHashCode();

                if (this.JourneyEvents != null)
                    hash = hash * 59 + this.JourneyEvents.GetHashCode();

                if (this.AuthenticationSettings != null)
                    hash = hash * 59 + this.AuthenticationSettings.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.LastModifiedUser != null)
                    hash = hash * 59 + this.LastModifiedUser.GetHashCode();

                if (this.CreatedUser != null)
                    hash = hash * 59 + this.CreatedUser.GetHashCode();

                if (this.PublishedUser != null)
                    hash = hash * 59 + this.PublishedUser.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
