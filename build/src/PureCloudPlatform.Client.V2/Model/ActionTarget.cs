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
    /// ActionTarget
    /// </summary>
    [DataContract]
    public partial class ActionTarget :  IEquatable<ActionTarget>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets SupportedMediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SupportedMediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Call for "call"
            /// </summary>
            [EnumMember(Value = "call")]
            Call,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Generic for "generic"
            /// </summary>
            [EnumMember(Value = "generic")]
            Generic,
            
            /// <summary>
            /// Enum Messaging for "messaging"
            /// </summary>
            [EnumMember(Value = "messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Social for "social"
            /// </summary>
            [EnumMember(Value = "social")]
            Social,
            
            /// <summary>
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat
        }
        
        
        
        
        /// <summary>
        /// Indicates the state of the target.
        /// </summary>
        /// <value>Indicates the state of the target.</value>
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
        /// Indicates the state of the target.
        /// </summary>
        /// <value>Indicates the state of the target.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTarget" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="UserData">Additional user data associated with the target in key/value format..</param>
        /// <param name="SupportedMediaTypes">Supported media types of the target..</param>
        /// <param name="State">Indicates the state of the target..</param>
        /// <param name="Description">Description of the target..</param>
        /// <param name="ServiceLevel">Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level..</param>
        /// <param name="CreatedDate">The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedDate">The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ActionTarget(string Name = null, List<KeyValue> UserData = null, List<SupportedMediaTypesEnum> SupportedMediaTypes = null, StateEnum? State = null, string Description = null, ServiceLevel ServiceLevel = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
        {
            this.Name = Name;
            this.UserData = UserData;
            this.SupportedMediaTypes = SupportedMediaTypes;
            this.State = State;
            this.Description = Description;
            this.ServiceLevel = ServiceLevel;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            
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
        /// Additional user data associated with the target in key/value format.
        /// </summary>
        /// <value>Additional user data associated with the target in key/value format.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<KeyValue> UserData { get; set; }
        
        
        
        /// <summary>
        /// Supported media types of the target.
        /// </summary>
        /// <value>Supported media types of the target.</value>
        [DataMember(Name="supportedMediaTypes", EmitDefaultValue=false)]
        public List<SupportedMediaTypesEnum> SupportedMediaTypes { get; set; }
        
        
        
        
        
        /// <summary>
        /// Description of the target.
        /// </summary>
        /// <value>Description of the target.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.
        /// </summary>
        /// <value>Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ServiceLevel ServiceLevel { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionTarget {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  SupportedMediaTypes: ").Append(SupportedMediaTypes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as ActionTarget);
        }

        /// <summary>
        /// Returns true if ActionTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionTarget other)
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
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(other.UserData)
                ) &&
                (
                    this.SupportedMediaTypes == other.SupportedMediaTypes ||
                    this.SupportedMediaTypes != null &&
                    this.SupportedMediaTypes.SequenceEqual(other.SupportedMediaTypes)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                
                if (this.SupportedMediaTypes != null)
                    hash = hash * 59 + this.SupportedMediaTypes.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
