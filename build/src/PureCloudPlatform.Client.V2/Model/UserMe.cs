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
    /// UserMe
    /// </summary>
    [DataContract]
    public partial class UserMe :  IEquatable<UserMe>
    {
        /// <summary>
        /// The current state for this user.
        /// </summary>
        /// <value>The current state for this user.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        /// <summary>
        /// The current state for this user.
        /// </summary>
        /// <value>The current state for this user.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserMe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMe" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Email">Email.</param>
        /// <param name="PrimaryContactInfo">Auto populated from addresses..</param>
        /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Manager">Manager.</param>
        /// <param name="Images">Images.</param>
        /// <param name="Version">Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. (required).</param>
        /// <param name="RoutingStatus">ACD routing status.</param>
        /// <param name="Presence">Active presence.</param>
        /// <param name="ConversationSummary">Summary of conversion statistics for conversation types..</param>
        /// <param name="OutOfOffice">Determine if out of office is enabled.</param>
        /// <param name="Geolocation">Current geolocation position.</param>
        /// <param name="Station">Effective, default, and last station information.</param>
        /// <param name="Authorization">Roles and permissions assigned to the user.</param>
        /// <param name="ProfileSkills">Skills possessed by the user.</param>
        /// <param name="Locations">The user placement at each site location..</param>
        /// <param name="Groups">The groups the user is a member of.</param>
        /// <param name="Date">The PureCloud system date time..</param>
        /// <param name="GeolocationSettings">Geolocation settings for user&#39;s organization..</param>
        /// <param name="Organization">Organization details for this user..</param>
        /// <param name="PresenceDefinitions">The first 100 presence definitions for user&#39;s organization..</param>
        /// <param name="LocationDefinitions">The first 100 site locations for user&#39;s organization.</param>
        /// <param name="OrgAuthorization">The first 100 organization roles, with applicable permission policies, for user&#39;s organization..</param>
        /// <param name="Favorites">The first 50 favorited users..</param>
        /// <param name="Superiors">The first 50 superiors of this user..</param>
        /// <param name="DirectReports">The first 50 direct reports to this user..</param>
        /// <param name="Adjacents">The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands..</param>
        /// <param name="RoutingSkills">The first 50 routing skills for user&#39;s organizations.</param>
        /// <param name="FieldConfigs">The field config for all entities types of user&#39;s organization.</param>
        public UserMe(string Name = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> PrimaryContactInfo = null, List<Contact> Addresses = null, string Title = null, string Username = null, User Manager = null, List<UserImage> Images = null, int? Version = null, RoutingStatus RoutingStatus = null, UserPresence Presence = null, UserConversationSummary ConversationSummary = null, OutOfOffice OutOfOffice = null, Geolocation Geolocation = null, UserStations Station = null, UserAuthorization Authorization = null, List<string> ProfileSkills = null, List<Location> Locations = null, List<Group> Groups = null, ServerDate Date = null, GeolocationSettings GeolocationSettings = null, Organization Organization = null, List<OrganizationPresence> PresenceDefinitions = null, List<LocationDefinition> LocationDefinitions = null, List<DomainOrganizationRole> OrgAuthorization = null, List<User> Favorites = null, List<User> Superiors = null, List<User> DirectReports = null, Adjacents Adjacents = null, List<RoutingSkill> RoutingSkills = null, FieldConfigs FieldConfigs = null)
        {
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for UserMe and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Name = Name;
            this.Chat = Chat;
            this.Department = Department;
            this.Email = Email;
            this.PrimaryContactInfo = PrimaryContactInfo;
            this.Addresses = Addresses;
            this.Title = Title;
            this.Username = Username;
            this.Manager = Manager;
            this.Images = Images;
            this.RoutingStatus = RoutingStatus;
            this.Presence = Presence;
            this.ConversationSummary = ConversationSummary;
            this.OutOfOffice = OutOfOffice;
            this.Geolocation = Geolocation;
            this.Station = Station;
            this.Authorization = Authorization;
            this.ProfileSkills = ProfileSkills;
            this.Locations = Locations;
            this.Groups = Groups;
            this.Date = Date;
            this.GeolocationSettings = GeolocationSettings;
            this.Organization = Organization;
            this.PresenceDefinitions = PresenceDefinitions;
            this.LocationDefinitions = LocationDefinitions;
            this.OrgAuthorization = OrgAuthorization;
            this.Favorites = Favorites;
            this.Superiors = Superiors;
            this.DirectReports = DirectReports;
            this.Adjacents = Adjacents;
            this.RoutingSkills = RoutingSkills;
            this.FieldConfigs = FieldConfigs;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public Chat Chat { get; set; }
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Auto populated from addresses.
        /// </summary>
        /// <value>Auto populated from addresses.</value>
        [DataMember(Name="primaryContactInfo", EmitDefaultValue=false)]
        public List<Contact> PrimaryContactInfo { get; set; }
        /// <summary>
        /// Email addresses and phone numbers for this user
        /// </summary>
        /// <value>Email addresses and phone numbers for this user</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Contact> Addresses { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public User Manager { get; set; }
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<UserImage> Images { get; set; }
        /// <summary>
        /// Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.
        /// </summary>
        /// <value>Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// ACD routing status
        /// </summary>
        /// <value>ACD routing status</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
        /// <summary>
        /// Active presence
        /// </summary>
        /// <value>Active presence</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public UserPresence Presence { get; set; }
        /// <summary>
        /// Summary of conversion statistics for conversation types.
        /// </summary>
        /// <value>Summary of conversion statistics for conversation types.</value>
        [DataMember(Name="conversationSummary", EmitDefaultValue=false)]
        public UserConversationSummary ConversationSummary { get; set; }
        /// <summary>
        /// Determine if out of office is enabled
        /// </summary>
        /// <value>Determine if out of office is enabled</value>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public OutOfOffice OutOfOffice { get; set; }
        /// <summary>
        /// Current geolocation position
        /// </summary>
        /// <value>Current geolocation position</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public Geolocation Geolocation { get; set; }
        /// <summary>
        /// Effective, default, and last station information
        /// </summary>
        /// <value>Effective, default, and last station information</value>
        [DataMember(Name="station", EmitDefaultValue=false)]
        public UserStations Station { get; set; }
        /// <summary>
        /// Roles and permissions assigned to the user
        /// </summary>
        /// <value>Roles and permissions assigned to the user</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public UserAuthorization Authorization { get; set; }
        /// <summary>
        /// Skills possessed by the user
        /// </summary>
        /// <value>Skills possessed by the user</value>
        [DataMember(Name="profileSkills", EmitDefaultValue=false)]
        public List<string> ProfileSkills { get; set; }
        /// <summary>
        /// The user placement at each site location.
        /// </summary>
        /// <value>The user placement at each site location.</value>
        [DataMember(Name="locations", EmitDefaultValue=false)]
        public List<Location> Locations { get; set; }
        /// <summary>
        /// The groups the user is a member of
        /// </summary>
        /// <value>The groups the user is a member of</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Group> Groups { get; set; }
        /// <summary>
        /// The PureCloud system date time.
        /// </summary>
        /// <value>The PureCloud system date time.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public ServerDate Date { get; set; }
        /// <summary>
        /// Geolocation settings for user&#39;s organization.
        /// </summary>
        /// <value>Geolocation settings for user&#39;s organization.</value>
        [DataMember(Name="geolocationSettings", EmitDefaultValue=false)]
        public GeolocationSettings GeolocationSettings { get; set; }
        /// <summary>
        /// Organization details for this user.
        /// </summary>
        /// <value>Organization details for this user.</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }
        /// <summary>
        /// The first 100 presence definitions for user&#39;s organization.
        /// </summary>
        /// <value>The first 100 presence definitions for user&#39;s organization.</value>
        [DataMember(Name="presenceDefinitions", EmitDefaultValue=false)]
        public List<OrganizationPresence> PresenceDefinitions { get; set; }
        /// <summary>
        /// The first 100 site locations for user&#39;s organization
        /// </summary>
        /// <value>The first 100 site locations for user&#39;s organization</value>
        [DataMember(Name="locationDefinitions", EmitDefaultValue=false)]
        public List<LocationDefinition> LocationDefinitions { get; set; }
        /// <summary>
        /// The first 100 organization roles, with applicable permission policies, for user&#39;s organization.
        /// </summary>
        /// <value>The first 100 organization roles, with applicable permission policies, for user&#39;s organization.</value>
        [DataMember(Name="orgAuthorization", EmitDefaultValue=false)]
        public List<DomainOrganizationRole> OrgAuthorization { get; set; }
        /// <summary>
        /// The first 50 favorited users.
        /// </summary>
        /// <value>The first 50 favorited users.</value>
        [DataMember(Name="favorites", EmitDefaultValue=false)]
        public List<User> Favorites { get; set; }
        /// <summary>
        /// The first 50 superiors of this user.
        /// </summary>
        /// <value>The first 50 superiors of this user.</value>
        [DataMember(Name="superiors", EmitDefaultValue=false)]
        public List<User> Superiors { get; set; }
        /// <summary>
        /// The first 50 direct reports to this user.
        /// </summary>
        /// <value>The first 50 direct reports to this user.</value>
        [DataMember(Name="directReports", EmitDefaultValue=false)]
        public List<User> DirectReports { get; set; }
        /// <summary>
        /// The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands.
        /// </summary>
        /// <value>The first 50 superiors, direct reports, and siblings of this user. Mutually exclusive with superiors and direct reports expands.</value>
        [DataMember(Name="adjacents", EmitDefaultValue=false)]
        public Adjacents Adjacents { get; set; }
        /// <summary>
        /// The first 50 routing skills for user&#39;s organizations
        /// </summary>
        /// <value>The first 50 routing skills for user&#39;s organizations</value>
        [DataMember(Name="routingSkills", EmitDefaultValue=false)]
        public List<RoutingSkill> RoutingSkills { get; set; }
        /// <summary>
        /// The field config for all entities types of user&#39;s organization
        /// </summary>
        /// <value>The field config for all entities types of user&#39;s organization</value>
        [DataMember(Name="fieldConfigs", EmitDefaultValue=false)]
        public FieldConfigs FieldConfigs { get; set; }
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
            sb.Append("class UserMe {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PrimaryContactInfo: ").Append(PrimaryContactInfo).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
            sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  Station: ").Append(Station).Append("\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
            sb.Append("  ProfileSkills: ").Append(ProfileSkills).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  GeolocationSettings: ").Append(GeolocationSettings).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  PresenceDefinitions: ").Append(PresenceDefinitions).Append("\n");
            sb.Append("  LocationDefinitions: ").Append(LocationDefinitions).Append("\n");
            sb.Append("  OrgAuthorization: ").Append(OrgAuthorization).Append("\n");
            sb.Append("  Favorites: ").Append(Favorites).Append("\n");
            sb.Append("  Superiors: ").Append(Superiors).Append("\n");
            sb.Append("  DirectReports: ").Append(DirectReports).Append("\n");
            sb.Append("  Adjacents: ").Append(Adjacents).Append("\n");
            sb.Append("  RoutingSkills: ").Append(RoutingSkills).Append("\n");
            sb.Append("  FieldConfigs: ").Append(FieldConfigs).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserMe);
        }

        /// <summary>
        /// Returns true if UserMe instances are equal
        /// </summary>
        /// <param name="other">Instance of UserMe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMe other)
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
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.PrimaryContactInfo == other.PrimaryContactInfo ||
                    this.PrimaryContactInfo != null &&
                    this.PrimaryContactInfo.SequenceEqual(other.PrimaryContactInfo)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) &&
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) &&
                (
                    this.ConversationSummary == other.ConversationSummary ||
                    this.ConversationSummary != null &&
                    this.ConversationSummary.Equals(other.ConversationSummary)
                ) &&
                (
                    this.OutOfOffice == other.OutOfOffice ||
                    this.OutOfOffice != null &&
                    this.OutOfOffice.Equals(other.OutOfOffice)
                ) &&
                (
                    this.Geolocation == other.Geolocation ||
                    this.Geolocation != null &&
                    this.Geolocation.Equals(other.Geolocation)
                ) &&
                (
                    this.Station == other.Station ||
                    this.Station != null &&
                    this.Station.Equals(other.Station)
                ) &&
                (
                    this.Authorization == other.Authorization ||
                    this.Authorization != null &&
                    this.Authorization.Equals(other.Authorization)
                ) &&
                (
                    this.ProfileSkills == other.ProfileSkills ||
                    this.ProfileSkills != null &&
                    this.ProfileSkills.SequenceEqual(other.ProfileSkills)
                ) &&
                (
                    this.Locations == other.Locations ||
                    this.Locations != null &&
                    this.Locations.SequenceEqual(other.Locations)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.GeolocationSettings == other.GeolocationSettings ||
                    this.GeolocationSettings != null &&
                    this.GeolocationSettings.Equals(other.GeolocationSettings)
                ) &&
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) &&
                (
                    this.PresenceDefinitions == other.PresenceDefinitions ||
                    this.PresenceDefinitions != null &&
                    this.PresenceDefinitions.SequenceEqual(other.PresenceDefinitions)
                ) &&
                (
                    this.LocationDefinitions == other.LocationDefinitions ||
                    this.LocationDefinitions != null &&
                    this.LocationDefinitions.SequenceEqual(other.LocationDefinitions)
                ) &&
                (
                    this.OrgAuthorization == other.OrgAuthorization ||
                    this.OrgAuthorization != null &&
                    this.OrgAuthorization.SequenceEqual(other.OrgAuthorization)
                ) &&
                (
                    this.Favorites == other.Favorites ||
                    this.Favorites != null &&
                    this.Favorites.SequenceEqual(other.Favorites)
                ) &&
                (
                    this.Superiors == other.Superiors ||
                    this.Superiors != null &&
                    this.Superiors.SequenceEqual(other.Superiors)
                ) &&
                (
                    this.DirectReports == other.DirectReports ||
                    this.DirectReports != null &&
                    this.DirectReports.SequenceEqual(other.DirectReports)
                ) &&
                (
                    this.Adjacents == other.Adjacents ||
                    this.Adjacents != null &&
                    this.Adjacents.Equals(other.Adjacents)
                ) &&
                (
                    this.RoutingSkills == other.RoutingSkills ||
                    this.RoutingSkills != null &&
                    this.RoutingSkills.SequenceEqual(other.RoutingSkills)
                ) &&
                (
                    this.FieldConfigs == other.FieldConfigs ||
                    this.FieldConfigs != null &&
                    this.FieldConfigs.Equals(other.FieldConfigs)
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
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PrimaryContactInfo != null)
                    hash = hash * 59 + this.PrimaryContactInfo.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.ConversationSummary != null)
                    hash = hash * 59 + this.ConversationSummary.GetHashCode();
                if (this.OutOfOffice != null)
                    hash = hash * 59 + this.OutOfOffice.GetHashCode();
                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();
                if (this.Station != null)
                    hash = hash * 59 + this.Station.GetHashCode();
                if (this.Authorization != null)
                    hash = hash * 59 + this.Authorization.GetHashCode();
                if (this.ProfileSkills != null)
                    hash = hash * 59 + this.ProfileSkills.GetHashCode();
                if (this.Locations != null)
                    hash = hash * 59 + this.Locations.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.GeolocationSettings != null)
                    hash = hash * 59 + this.GeolocationSettings.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.PresenceDefinitions != null)
                    hash = hash * 59 + this.PresenceDefinitions.GetHashCode();
                if (this.LocationDefinitions != null)
                    hash = hash * 59 + this.LocationDefinitions.GetHashCode();
                if (this.OrgAuthorization != null)
                    hash = hash * 59 + this.OrgAuthorization.GetHashCode();
                if (this.Favorites != null)
                    hash = hash * 59 + this.Favorites.GetHashCode();
                if (this.Superiors != null)
                    hash = hash * 59 + this.Superiors.GetHashCode();
                if (this.DirectReports != null)
                    hash = hash * 59 + this.DirectReports.GetHashCode();
                if (this.Adjacents != null)
                    hash = hash * 59 + this.Adjacents.GetHashCode();
                if (this.RoutingSkills != null)
                    hash = hash * 59 + this.RoutingSkills.GetHashCode();
                if (this.FieldConfigs != null)
                    hash = hash * 59 + this.FieldConfigs.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
