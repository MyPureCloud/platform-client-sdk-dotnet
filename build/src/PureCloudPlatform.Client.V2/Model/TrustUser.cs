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
    /// TrustUser
    /// </summary>
    [DataContract]
    public partial class TrustUser :  IEquatable<TrustUser>
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
        /// Initializes a new instance of the <see cref="TrustUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustUser() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustUser" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Manager">Manager.</param>
        /// <param name="Images">Images.</param>
        /// <param name="Version">Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. (required).</param>
        /// <param name="Certifications">Certifications.</param>
        /// <param name="Biography">Biography.</param>
        /// <param name="EmployerInfo">EmployerInfo.</param>
        /// <param name="AcdAutoAnswer">acd auto answer.</param>
        /// <param name="LastTokenIssued">LastTokenIssued.</param>
        /// <param name="TrustUserDetails">TrustUserDetails.</param>
        public TrustUser(string Name = null, Division Division = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Username = null, User Manager = null, List<UserImage> Images = null, int? Version = null, List<string> Certifications = null, Biography Biography = null, EmployerInfo EmployerInfo = null, bool? AcdAutoAnswer = null, OAuthLastTokenIssued LastTokenIssued = null, TrustUserDetails TrustUserDetails = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Chat = Chat;
            this.Department = Department;
            this.Email = Email;
            this.Addresses = Addresses;
            this.Title = Title;
            this.Username = Username;
            this.Manager = Manager;
            this.Images = Images;
            this.Version = Version;
            this.Certifications = Certifications;
            this.Biography = Biography;
            this.EmployerInfo = EmployerInfo;
            this.AcdAutoAnswer = AcdAutoAnswer;
            this.LastTokenIssued = LastTokenIssued;
            this.TrustUserDetails = TrustUserDetails;
            
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
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }
        
        
        
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
        public List<Contact> PrimaryContactInfo { get; private set; }
        
        
        
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
        /// Gets or Sets Certifications
        /// </summary>
        [DataMember(Name="certifications", EmitDefaultValue=false)]
        public List<string> Certifications { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Biography
        /// </summary>
        [DataMember(Name="biography", EmitDefaultValue=false)]
        public Biography Biography { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmployerInfo
        /// </summary>
        [DataMember(Name="employerInfo", EmitDefaultValue=false)]
        public EmployerInfo EmployerInfo { get; set; }
        
        
        
        /// <summary>
        /// ACD routing status
        /// </summary>
        /// <value>ACD routing status</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; private set; }
        
        
        
        /// <summary>
        /// Active presence
        /// </summary>
        /// <value>Active presence</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public UserPresence Presence { get; private set; }
        
        
        
        /// <summary>
        /// Summary of conversion statistics for conversation types.
        /// </summary>
        /// <value>Summary of conversion statistics for conversation types.</value>
        [DataMember(Name="conversationSummary", EmitDefaultValue=false)]
        public UserConversationSummary ConversationSummary { get; private set; }
        
        
        
        /// <summary>
        /// Determine if out of office is enabled
        /// </summary>
        /// <value>Determine if out of office is enabled</value>
        [DataMember(Name="outOfOffice", EmitDefaultValue=false)]
        public OutOfOffice OutOfOffice { get; private set; }
        
        
        
        /// <summary>
        /// Current geolocation position
        /// </summary>
        /// <value>Current geolocation position</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public Geolocation Geolocation { get; private set; }
        
        
        
        /// <summary>
        /// Effective, default, and last station information
        /// </summary>
        /// <value>Effective, default, and last station information</value>
        [DataMember(Name="station", EmitDefaultValue=false)]
        public UserStations Station { get; private set; }
        
        
        
        /// <summary>
        /// Roles and permissions assigned to the user
        /// </summary>
        /// <value>Roles and permissions assigned to the user</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public UserAuthorization Authorization { get; private set; }
        
        
        
        /// <summary>
        /// Profile skills possessed by the user
        /// </summary>
        /// <value>Profile skills possessed by the user</value>
        [DataMember(Name="profileSkills", EmitDefaultValue=false)]
        public List<string> ProfileSkills { get; private set; }
        
        
        
        /// <summary>
        /// The user placement at each site location.
        /// </summary>
        /// <value>The user placement at each site location.</value>
        [DataMember(Name="locations", EmitDefaultValue=false)]
        public List<Location> Locations { get; private set; }
        
        
        
        /// <summary>
        /// The groups the user is a member of
        /// </summary>
        /// <value>The groups the user is a member of</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Group> Groups { get; private set; }
        
        
        
        /// <summary>
        /// The team the user is a member of
        /// </summary>
        /// <value>The team the user is a member of</value>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; private set; }
        
        
        
        /// <summary>
        /// Routing (ACD) skills possessed by the user
        /// </summary>
        /// <value>Routing (ACD) skills possessed by the user</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<UserRoutingSkill> Skills { get; private set; }
        
        
        
        /// <summary>
        /// Routing (ACD) languages possessed by the user
        /// </summary>
        /// <value>Routing (ACD) languages possessed by the user</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<UserRoutingLanguage> Languages { get; private set; }
        
        
        
        /// <summary>
        /// acd auto answer
        /// </summary>
        /// <value>acd auto answer</value>
        [DataMember(Name="acdAutoAnswer", EmitDefaultValue=false)]
        public bool? AcdAutoAnswer { get; set; }
        
        
        
        /// <summary>
        /// preferred language by the user
        /// </summary>
        /// <value>preferred language by the user</value>
        [DataMember(Name="languagePreference", EmitDefaultValue=false)]
        public string LanguagePreference { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets LastTokenIssued
        /// </summary>
        [DataMember(Name="lastTokenIssued", EmitDefaultValue=false)]
        public OAuthLastTokenIssued LastTokenIssued { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TrustUserDetails
        /// </summary>
        [DataMember(Name="trustUserDetails", EmitDefaultValue=false)]
        public TrustUserDetails TrustUserDetails { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustUser {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
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
            sb.Append("  Certifications: ").Append(Certifications).Append("\n");
            sb.Append("  Biography: ").Append(Biography).Append("\n");
            sb.Append("  EmployerInfo: ").Append(EmployerInfo).Append("\n");
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
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  AcdAutoAnswer: ").Append(AcdAutoAnswer).Append("\n");
            sb.Append("  LanguagePreference: ").Append(LanguagePreference).Append("\n");
            sb.Append("  LastTokenIssued: ").Append(LastTokenIssued).Append("\n");
            sb.Append("  TrustUserDetails: ").Append(TrustUserDetails).Append("\n");
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
            return this.Equals(obj as TrustUser);
        }

        /// <summary>
        /// Returns true if TrustUser instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustUser other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                    this.Certifications == other.Certifications ||
                    this.Certifications != null &&
                    this.Certifications.SequenceEqual(other.Certifications)
                ) &&
                (
                    this.Biography == other.Biography ||
                    this.Biography != null &&
                    this.Biography.Equals(other.Biography)
                ) &&
                (
                    this.EmployerInfo == other.EmployerInfo ||
                    this.EmployerInfo != null &&
                    this.EmployerInfo.Equals(other.EmployerInfo)
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
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
                ) &&
                (
                    this.AcdAutoAnswer == other.AcdAutoAnswer ||
                    this.AcdAutoAnswer != null &&
                    this.AcdAutoAnswer.Equals(other.AcdAutoAnswer)
                ) &&
                (
                    this.LanguagePreference == other.LanguagePreference ||
                    this.LanguagePreference != null &&
                    this.LanguagePreference.Equals(other.LanguagePreference)
                ) &&
                (
                    this.LastTokenIssued == other.LastTokenIssued ||
                    this.LastTokenIssued != null &&
                    this.LastTokenIssued.Equals(other.LastTokenIssued)
                ) &&
                (
                    this.TrustUserDetails == other.TrustUserDetails ||
                    this.TrustUserDetails != null &&
                    this.TrustUserDetails.Equals(other.TrustUserDetails)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
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
                
                if (this.Certifications != null)
                    hash = hash * 59 + this.Certifications.GetHashCode();
                
                if (this.Biography != null)
                    hash = hash * 59 + this.Biography.GetHashCode();
                
                if (this.EmployerInfo != null)
                    hash = hash * 59 + this.EmployerInfo.GetHashCode();
                
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
                
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();
                
                if (this.AcdAutoAnswer != null)
                    hash = hash * 59 + this.AcdAutoAnswer.GetHashCode();
                
                if (this.LanguagePreference != null)
                    hash = hash * 59 + this.LanguagePreference.GetHashCode();
                
                if (this.LastTokenIssued != null)
                    hash = hash * 59 + this.LastTokenIssued.GetHashCode();
                
                if (this.TrustUserDetails != null)
                    hash = hash * 59 + this.TrustUserDetails.GetHashCode();
                
                return hash;
            }
        }
    }

}
