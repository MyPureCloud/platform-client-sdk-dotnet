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
    /// HistoryEntry
    /// </summary>
    [DataContract]
    public partial class HistoryEntry :  IEquatable<HistoryEntry>
    {
        
        
        /// <summary>
        /// The action performed
        /// </summary>
        /// <value>The action performed</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Checkin for "CHECKIN"
            /// </summary>
            [EnumMember(Value = "CHECKIN")]
            Checkin,
            
            /// <summary>
            /// Enum Checkout for "CHECKOUT"
            /// </summary>
            [EnumMember(Value = "CHECKOUT")]
            Checkout,
            
            /// <summary>
            /// Enum Create for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            Create,
            
            /// <summary>
            /// Enum Deactivate for "DEACTIVATE"
            /// </summary>
            [EnumMember(Value = "DEACTIVATE")]
            Deactivate,
            
            /// <summary>
            /// Enum Debug for "DEBUG"
            /// </summary>
            [EnumMember(Value = "DEBUG")]
            Debug,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Publish for "PUBLISH"
            /// </summary>
            [EnumMember(Value = "PUBLISH")]
            Publish,
            
            /// <summary>
            /// Enum Revert for "REVERT"
            /// </summary>
            [EnumMember(Value = "REVERT")]
            Revert,
            
            /// <summary>
            /// Enum Save for "SAVE"
            /// </summary>
            [EnumMember(Value = "SAVE")]
            Save,
            
            /// <summary>
            /// Enum Transcode for "TRANSCODE"
            /// </summary>
            [EnumMember(Value = "TRANSCODE")]
            Transcode,
            
            /// <summary>
            /// Enum Update for "UPDATE"
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            Update,
            
            /// <summary>
            /// Enum Upload for "UPLOAD"
            /// </summary>
            [EnumMember(Value = "UPLOAD")]
            Upload
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The action performed
        /// </summary>
        /// <value>The action performed</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryEntry" /> class.
        /// </summary>
        /// <param name="Action">The action performed.</param>
        /// <param name="Resource">For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name..</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="User">User associated with this entry..</param>
        /// <param name="Client">OAuth client associated with this entry..</param>
        /// <param name="Version">Version.</param>
        /// <param name="Secure">Secure.</param>
        public HistoryEntry(ActionEnum? Action = null, string Resource = null, DateTime? Timestamp = null, User User = null, DomainEntityRef Client = null, string Version = null, bool? Secure = null)
        {
            this.Action = Action;
            this.Resource = Resource;
            this.Timestamp = Timestamp;
            this.User = User;
            this.Client = Client;
            this.Version = Version;
            this.Secure = Secure;
            
        }
        
        
        
        
        
        /// <summary>
        /// For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.
        /// </summary>
        /// <value>For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        
        /// <summary>
        /// User associated with this entry.
        /// </summary>
        /// <value>User associated with this entry.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// OAuth client associated with this entry.
        /// </summary>
        /// <value>OAuth client associated with this entry.</value>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public DomainEntityRef Client { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryEntry {\n");
            
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
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
            return this.Equals(obj as HistoryEntry);
        }

        /// <summary>
        /// Returns true if HistoryEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Resource == other.Resource ||
                    this.Resource != null &&
                    this.Resource.Equals(other.Resource)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
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
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Resource != null)
                    hash = hash * 59 + this.Resource.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                return hash;
            }
        }
    }

}
