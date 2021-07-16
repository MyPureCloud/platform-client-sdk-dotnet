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
    /// Object representing the guest model of a media request of a chat conversation.
    /// </summary>
    [DataContract]
    public partial class WebChatGuestMediaRequest :  IEquatable<WebChatGuestMediaRequest>
    {
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Cobrowse for "COBROWSE"
            /// </summary>
            [EnumMember(Value = "COBROWSE")]
            Cobrowse,
            
            /// <summary>
            /// Enum Screenshare for "SCREENSHARE"
            /// </summary>
            [EnumMember(Value = "SCREENSHARE")]
            Screenshare
        }
        
        
        
        
        /// <summary>
        /// The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.
        /// </summary>
        /// <value>The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.</value>
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
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Accepted for "ACCEPTED"
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            
            /// <summary>
            /// Enum Declined for "DECLINED"
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            Declined,
            
            /// <summary>
            /// Enum Timedout for "TIMEDOUT"
            /// </summary>
            [EnumMember(Value = "TIMEDOUT")]
            Timedout,
            
            /// <summary>
            /// Enum Cancelled for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            
            /// <summary>
            /// Enum Errored for "ERRORED"
            /// </summary>
            [EnumMember(Value = "ERRORED")]
            Errored
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.
        /// </summary>
        /// <value>The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatGuestMediaRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebChatGuestMediaRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatGuestMediaRequest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Types">The types of media being requested. (required).</param>
        /// <param name="State">The state of the media request, one of PENDING|ACCEPTED|DECLINED|TIMEDOUT|CANCELLED|ERRORED. (required).</param>
        /// <param name="CommunicationId">The ID of the new media communication, if applicable..</param>
        /// <param name="SecurityKey">The security information related to a media request..</param>
        public WebChatGuestMediaRequest(string Name = null, List<TypesEnum> Types = null, StateEnum? State = null, string CommunicationId = null, string SecurityKey = null)
        {
            this.Name = Name;
            this.Types = Types;
            this.State = State;
            this.CommunicationId = CommunicationId;
            this.SecurityKey = SecurityKey;
            
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
        /// The types of media being requested.
        /// </summary>
        /// <value>The types of media being requested.</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<TypesEnum> Types { get; set; }
        
        
        
        
        
        /// <summary>
        /// The ID of the new media communication, if applicable.
        /// </summary>
        /// <value>The ID of the new media communication, if applicable.</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }
        
        
        
        /// <summary>
        /// The security information related to a media request.
        /// </summary>
        /// <value>The security information related to a media request.</value>
        [DataMember(Name="securityKey", EmitDefaultValue=false)]
        public string SecurityKey { get; set; }
        
        
        
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
            sb.Append("class WebChatGuestMediaRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  SecurityKey: ").Append(SecurityKey).Append("\n");
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
            return this.Equals(obj as WebChatGuestMediaRequest);
        }

        /// <summary>
        /// Returns true if WebChatGuestMediaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatGuestMediaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatGuestMediaRequest other)
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
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.SecurityKey == other.SecurityKey ||
                    this.SecurityKey != null &&
                    this.SecurityKey.Equals(other.SecurityKey)
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
                
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();
                
                if (this.SecurityKey != null)
                    hash = hash * 59 + this.SecurityKey.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
