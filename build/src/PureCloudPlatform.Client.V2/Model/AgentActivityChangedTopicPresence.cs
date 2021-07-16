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
    /// AgentActivityChangedTopicPresence
    /// </summary>
    [DataContract]
    public partial class AgentActivityChangedTopicPresence :  IEquatable<AgentActivityChangedTopicPresence>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentActivityChangedTopicPresence" /> class.
        /// </summary>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="PresenceMessage">PresenceMessage.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        public AgentActivityChangedTopicPresence(AgentActivityChangedTopicOrganizationPresence PresenceDefinition = null, string PresenceMessage = null, DateTime? ModifiedDate = null)
        {
            this.PresenceDefinition = PresenceDefinition;
            this.PresenceMessage = PresenceMessage;
            this.ModifiedDate = ModifiedDate;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets PresenceDefinition
        /// </summary>
        [DataMember(Name="presenceDefinition", EmitDefaultValue=false)]
        public AgentActivityChangedTopicOrganizationPresence PresenceDefinition { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PresenceMessage
        /// </summary>
        [DataMember(Name="presenceMessage", EmitDefaultValue=false)]
        public string PresenceMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentActivityChangedTopicPresence {\n");
            
            sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
            sb.Append("  PresenceMessage: ").Append(PresenceMessage).Append("\n");
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
            return this.Equals(obj as AgentActivityChangedTopicPresence);
        }

        /// <summary>
        /// Returns true if AgentActivityChangedTopicPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentActivityChangedTopicPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentActivityChangedTopicPresence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PresenceDefinition == other.PresenceDefinition ||
                    this.PresenceDefinition != null &&
                    this.PresenceDefinition.Equals(other.PresenceDefinition)
                ) &&
                (
                    this.PresenceMessage == other.PresenceMessage ||
                    this.PresenceMessage != null &&
                    this.PresenceMessage.Equals(other.PresenceMessage)
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
                
                if (this.PresenceDefinition != null)
                    hash = hash * 59 + this.PresenceDefinition.GetHashCode();
                
                if (this.PresenceMessage != null)
                    hash = hash * 59 + this.PresenceMessage.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
