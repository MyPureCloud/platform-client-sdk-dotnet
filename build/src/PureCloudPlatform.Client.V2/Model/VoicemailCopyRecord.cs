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
    /// VoicemailCopyRecord
    /// </summary>
    [DataContract]
    public partial class VoicemailCopyRecord :  IEquatable<VoicemailCopyRecord>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailCopyRecord" /> class.
        /// </summary>
        /// <param name="User">The user that the voicemail message was copied to/from.</param>
        /// <param name="Group">The group that the voicemail message was copied to/from.</param>
        public VoicemailCopyRecord(User User = null, Group Group = null)
        {
            this.User = User;
            this.Group = Group;
            
        }
        
        
        
        /// <summary>
        /// The user that the voicemail message was copied to/from
        /// </summary>
        /// <value>The user that the voicemail message was copied to/from</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// The group that the voicemail message was copied to/from
        /// </summary>
        /// <value>The group that the voicemail message was copied to/from</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        
        
        
        /// <summary>
        /// The date when the voicemail was copied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date when the voicemail was copied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailCopyRecord {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as VoicemailCopyRecord);
        }

        /// <summary>
        /// Returns true if VoicemailCopyRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailCopyRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailCopyRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                return hash;
            }
        }
    }

}
