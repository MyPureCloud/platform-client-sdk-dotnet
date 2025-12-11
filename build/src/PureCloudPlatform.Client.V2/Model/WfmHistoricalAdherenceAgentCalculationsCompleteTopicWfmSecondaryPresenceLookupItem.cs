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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem" /> class.
        /// </summary>
        /// <param name="LookupId">LookupId.</param>
        /// <param name="SecondaryPresence">SecondaryPresence.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem(string LookupId = null, WfmHistoricalAdherenceAgentCalculationsCompleteTopicSecondaryPresenceReference SecondaryPresence = null)
        {
            this.LookupId = LookupId;
            this.SecondaryPresence = SecondaryPresence;
            
        }
        


        /// <summary>
        /// Gets or Sets LookupId
        /// </summary>
        [DataMember(Name="lookupId", EmitDefaultValue=false)]
        public string LookupId { get; set; }



        /// <summary>
        /// Gets or Sets SecondaryPresence
        /// </summary>
        [DataMember(Name="secondaryPresence", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicSecondaryPresenceReference SecondaryPresence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem {\n");

            sb.Append("  LookupId: ").Append(LookupId).Append("\n");
            sb.Append("  SecondaryPresence: ").Append(SecondaryPresence).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LookupId == other.LookupId ||
                    this.LookupId != null &&
                    this.LookupId.Equals(other.LookupId)
                ) &&
                (
                    this.SecondaryPresence == other.SecondaryPresence ||
                    this.SecondaryPresence != null &&
                    this.SecondaryPresence.Equals(other.SecondaryPresence)
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
                if (this.LookupId != null)
                    hash = hash * 59 + this.LookupId.GetHashCode();

                if (this.SecondaryPresence != null)
                    hash = hash * 59 + this.SecondaryPresence.GetHashCode();

                return hash;
            }
        }
    }

}
