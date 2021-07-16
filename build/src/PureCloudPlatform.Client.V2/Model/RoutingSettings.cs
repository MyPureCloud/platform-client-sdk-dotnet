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
    /// RoutingSettings
    /// </summary>
    [DataContract]
    public partial class RoutingSettings :  IEquatable<RoutingSettings>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingSettings" /> class.
        /// </summary>
        /// <param name="ResetAgentScoreOnPresenceChange">Reset agent score when agent presence changes from off-queue to on-queue.</param>
        public RoutingSettings(bool? ResetAgentScoreOnPresenceChange = null)
        {
            this.ResetAgentScoreOnPresenceChange = ResetAgentScoreOnPresenceChange;
            
        }
        
        
        
        /// <summary>
        /// Reset agent score when agent presence changes from off-queue to on-queue
        /// </summary>
        /// <value>Reset agent score when agent presence changes from off-queue to on-queue</value>
        [DataMember(Name="resetAgentScoreOnPresenceChange", EmitDefaultValue=false)]
        public bool? ResetAgentScoreOnPresenceChange { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingSettings {\n");
            
            sb.Append("  ResetAgentScoreOnPresenceChange: ").Append(ResetAgentScoreOnPresenceChange).Append("\n");
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
            return this.Equals(obj as RoutingSettings);
        }

        /// <summary>
        /// Returns true if RoutingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ResetAgentScoreOnPresenceChange == other.ResetAgentScoreOnPresenceChange ||
                    this.ResetAgentScoreOnPresenceChange != null &&
                    this.ResetAgentScoreOnPresenceChange.Equals(other.ResetAgentScoreOnPresenceChange)
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
                
                if (this.ResetAgentScoreOnPresenceChange != null)
                    hash = hash * 59 + this.ResetAgentScoreOnPresenceChange.GetHashCode();
                
                return hash;
            }
        }
    }

}
