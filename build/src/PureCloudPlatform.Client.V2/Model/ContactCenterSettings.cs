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
    /// ContactCenterSettings
    /// </summary>
    [DataContract]
    public partial class ContactCenterSettings :  IEquatable<ContactCenterSettings>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCenterSettings" /> class.
        /// </summary>
        /// <param name="RemoveSkillsFromBlindTransfer">Strip skills from transfer.</param>
        public ContactCenterSettings(bool? RemoveSkillsFromBlindTransfer = null)
        {
            this.RemoveSkillsFromBlindTransfer = RemoveSkillsFromBlindTransfer;
            
        }
        
        
        
        /// <summary>
        /// Strip skills from transfer
        /// </summary>
        /// <value>Strip skills from transfer</value>
        [DataMember(Name="removeSkillsFromBlindTransfer", EmitDefaultValue=false)]
        public bool? RemoveSkillsFromBlindTransfer { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactCenterSettings {\n");
            
            sb.Append("  RemoveSkillsFromBlindTransfer: ").Append(RemoveSkillsFromBlindTransfer).Append("\n");
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
            return this.Equals(obj as ContactCenterSettings);
        }

        /// <summary>
        /// Returns true if ContactCenterSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactCenterSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactCenterSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RemoveSkillsFromBlindTransfer == other.RemoveSkillsFromBlindTransfer ||
                    this.RemoveSkillsFromBlindTransfer != null &&
                    this.RemoveSkillsFromBlindTransfer.Equals(other.RemoveSkillsFromBlindTransfer)
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
                
                if (this.RemoveSkillsFromBlindTransfer != null)
                    hash = hash * 59 + this.RemoveSkillsFromBlindTransfer.GetHashCode();
                
                return hash;
            }
        }
    }

}
