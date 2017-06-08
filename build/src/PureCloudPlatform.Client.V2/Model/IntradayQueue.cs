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
    /// IntradayQueue
    /// </summary>
    [DataContract]
    public partial class IntradayQueue :  IEquatable<IntradayQueue>
    {
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email
        }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayQueue" /> class.
        /// </summary>
        
        
        /// <param name="Id">Queue ID.</param>
        
        
        
        /// <param name="Name">Queue name.</param>
        
        
        
        /// <param name="MediaTypes">The media types valid for this queue as defined by the service goal groups in this management unit.</param>
        
        
        public IntradayQueue(string Id = null, string Name = null, List<MediaTypesEnum> MediaTypes = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.MediaTypes = MediaTypes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Queue ID
        /// </summary>
        /// <value>Queue ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Queue name
        /// </summary>
        /// <value>Queue name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The media types valid for this queue as defined by the service goal groups in this management unit
        /// </summary>
        /// <value>The media types valid for this queue as defined by the service goal groups in this management unit</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayQueue {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            
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
            return this.Equals(obj as IntradayQueue);
        }

        /// <summary>
        /// Returns true if IntradayQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayQueue other)
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
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
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
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                return hash;
            }
        }
    }

}
