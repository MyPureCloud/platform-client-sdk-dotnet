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
    /// CallForwarding
    /// </summary>
    [DataContract]
    public partial class CallForwarding :  IEquatable<CallForwarding>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of voicemail to use with the callForwarding configuration
        /// </summary>
        /// <value>The type of voicemail to use with the callForwarding configuration</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VoicemailEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Purecloud for "PURECLOUD"
            /// </summary>
            [EnumMember(Value = "PURECLOUD")]
            Purecloud,
            
            /// <summary>
            /// Enum Lastcall for "LASTCALL"
            /// </summary>
            [EnumMember(Value = "LASTCALL")]
            Lastcall,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of voicemail to use with the callForwarding configuration
        /// </summary>
        /// <value>The type of voicemail to use with the callForwarding configuration</value>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public VoicemailEnum? Voicemail { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallForwarding" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="Enabled">Whether or not CallForwarding is enabled.</param>
        /// <param name="PhoneNumber">This property is deprecated. Please use the calls property.</param>
        /// <param name="Calls">An ordered list of CallRoutes to be executed when CallForwarding is enabled.</param>
        /// <param name="Voicemail">The type of voicemail to use with the callForwarding configuration.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public CallForwarding(string Name = null, User User = null, bool? Enabled = null, string PhoneNumber = null, List<CallRoute> Calls = null, VoicemailEnum? Voicemail = null, DateTime? ModifiedDate = null)
        {
            this.Name = Name;
            this.User = User;
            this.Enabled = Enabled;
            this.PhoneNumber = PhoneNumber;
            this.Calls = Calls;
            this.Voicemail = Voicemail;
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// Whether or not CallForwarding is enabled
        /// </summary>
        /// <value>Whether or not CallForwarding is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// This property is deprecated. Please use the calls property
        /// </summary>
        /// <value>This property is deprecated. Please use the calls property</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// An ordered list of CallRoutes to be executed when CallForwarding is enabled
        /// </summary>
        /// <value>An ordered list of CallRoutes to be executed when CallForwarding is enabled</value>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<CallRoute> Calls { get; set; }
        
        
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
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
            sb.Append("class CallForwarding {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as CallForwarding);
        }

        /// <summary>
        /// Returns true if CallForwarding instances are equal
        /// </summary>
        /// <param name="other">Instance of CallForwarding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallForwarding other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) &&
                (
                    this.Voicemail == other.Voicemail ||
                    this.Voicemail != null &&
                    this.Voicemail.Equals(other.Voicemail)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();
                
                if (this.Voicemail != null)
                    hash = hash * 59 + this.Voicemail.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
