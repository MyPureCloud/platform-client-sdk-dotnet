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
    /// WebChatMemberInfo
    /// </summary>
    [DataContract]
    public partial class WebChatMemberInfo :  IEquatable<WebChatMemberInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The role of the member, one of [agent, customer, acd, workflow]
        /// </summary>
        /// <value>The role of the member, one of [agent, customer, acd, workflow]</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agent for "AGENT"
            /// </summary>
            [EnumMember(Value = "AGENT")]
            Agent,
            
            /// <summary>
            /// Enum Customer for "CUSTOMER"
            /// </summary>
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow,
            
            /// <summary>
            /// Enum Acd for "ACD"
            /// </summary>
            [EnumMember(Value = "ACD")]
            Acd
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The connection state of this member.
        /// </summary>
        /// <value>The connection state of this member.</value>
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
            /// Enum Connected for "CONNECTED"
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            /// <summary>
            /// Enum Alerting for "ALERTING"
            /// </summary>
            [EnumMember(Value = "ALERTING")]
            Alerting
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The role of the member, one of [agent, customer, acd, workflow]
        /// </summary>
        /// <value>The role of the member, one of [agent, customer, acd, workflow]</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The connection state of this member.
        /// </summary>
        /// <value>The connection state of this member.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatMemberInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebChatMemberInfo() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatMemberInfo" /> class.
        /// </summary>
        /// <param name="Id">The communicationId of this member..</param>
        /// <param name="DisplayName">The display name of the member..</param>
        /// <param name="FirstName">The first name of the member..</param>
        /// <param name="LastName">The last name of the member..</param>
        /// <param name="Email">The email address of the member..</param>
        /// <param name="PhoneNumber">The phone number of the member..</param>
        /// <param name="AvatarImageUrl">The url to the avatar image of the member..</param>
        /// <param name="Role">The role of the member, one of [agent, customer, acd, workflow] (required).</param>
        /// <param name="JoinDate">The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LeaveDate">The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AuthenticatedGuest">If true, the guest member is an authenticated guest..</param>
        /// <param name="CustomFields">Any custom fields of information pertaining to this member..</param>
        /// <param name="State">The connection state of this member..</param>
        public WebChatMemberInfo(string Id = null, string DisplayName = null, string FirstName = null, string LastName = null, string Email = null, string PhoneNumber = null, string AvatarImageUrl = null, RoleEnum? Role = null, DateTime? JoinDate = null, DateTime? LeaveDate = null, bool? AuthenticatedGuest = null, Dictionary<string, string> CustomFields = null, StateEnum? State = null)
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.AvatarImageUrl = AvatarImageUrl;
            this.Role = Role;
            this.JoinDate = JoinDate;
            this.LeaveDate = LeaveDate;
            this.AuthenticatedGuest = AuthenticatedGuest;
            this.CustomFields = CustomFields;
            this.State = State;
            
        }
        
        
        
        /// <summary>
        /// The communicationId of this member.
        /// </summary>
        /// <value>The communicationId of this member.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The display name of the member.
        /// </summary>
        /// <value>The display name of the member.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// The first name of the member.
        /// </summary>
        /// <value>The first name of the member.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        
        
        
        /// <summary>
        /// The last name of the member.
        /// </summary>
        /// <value>The last name of the member.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        
        
        
        /// <summary>
        /// The email address of the member.
        /// </summary>
        /// <value>The email address of the member.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        
        
        
        /// <summary>
        /// The phone number of the member.
        /// </summary>
        /// <value>The phone number of the member.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// The url to the avatar image of the member.
        /// </summary>
        /// <value>The url to the avatar image of the member.</value>
        [DataMember(Name="avatarImageUrl", EmitDefaultValue=false)]
        public string AvatarImageUrl { get; set; }
        
        
        
        
        
        /// <summary>
        /// The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="joinDate", EmitDefaultValue=false)]
        public DateTime? JoinDate { get; set; }
        
        
        
        /// <summary>
        /// The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="leaveDate", EmitDefaultValue=false)]
        public DateTime? LeaveDate { get; set; }
        
        
        
        /// <summary>
        /// If true, the guest member is an authenticated guest.
        /// </summary>
        /// <value>If true, the guest member is an authenticated guest.</value>
        [DataMember(Name="authenticatedGuest", EmitDefaultValue=false)]
        public bool? AuthenticatedGuest { get; set; }
        
        
        
        /// <summary>
        /// Any custom fields of information pertaining to this member.
        /// </summary>
        /// <value>Any custom fields of information pertaining to this member.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomFields { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebChatMemberInfo {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
            sb.Append("  LeaveDate: ").Append(LeaveDate).Append("\n");
            sb.Append("  AuthenticatedGuest: ").Append(AuthenticatedGuest).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as WebChatMemberInfo);
        }

        /// <summary>
        /// Returns true if WebChatMemberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatMemberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatMemberInfo other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.AvatarImageUrl == other.AvatarImageUrl ||
                    this.AvatarImageUrl != null &&
                    this.AvatarImageUrl.Equals(other.AvatarImageUrl)
                ) &&
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) &&
                (
                    this.JoinDate == other.JoinDate ||
                    this.JoinDate != null &&
                    this.JoinDate.Equals(other.JoinDate)
                ) &&
                (
                    this.LeaveDate == other.LeaveDate ||
                    this.LeaveDate != null &&
                    this.LeaveDate.Equals(other.LeaveDate)
                ) &&
                (
                    this.AuthenticatedGuest == other.AuthenticatedGuest ||
                    this.AuthenticatedGuest != null &&
                    this.AuthenticatedGuest.Equals(other.AuthenticatedGuest)
                ) &&
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.AvatarImageUrl != null)
                    hash = hash * 59 + this.AvatarImageUrl.GetHashCode();
                
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                
                if (this.JoinDate != null)
                    hash = hash * 59 + this.JoinDate.GetHashCode();
                
                if (this.LeaveDate != null)
                    hash = hash * 59 + this.LeaveDate.GetHashCode();
                
                if (this.AuthenticatedGuest != null)
                    hash = hash * 59 + this.AuthenticatedGuest.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                return hash;
            }
        }
    }

}
