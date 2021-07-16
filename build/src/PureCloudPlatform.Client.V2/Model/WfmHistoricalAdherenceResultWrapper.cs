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
    /// WfmHistoricalAdherenceResultWrapper
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceResultWrapper :  IEquatable<WfmHistoricalAdherenceResultWrapper>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceResultWrapper" /> class.
        /// </summary>
        /// <param name="EntityId">The operation ID of the historical adherence query.</param>
        /// <param name="Data">The list of historical adherence query results.</param>
        /// <param name="LookupIdToSecondaryPresenceId">Map of secondary presence lookup ID to corresponding secondary presence ID.</param>
        public WfmHistoricalAdherenceResultWrapper(string EntityId = null, List<HistoricalAdherenceQueryResult> Data = null, Dictionary<string, string> LookupIdToSecondaryPresenceId = null)
        {
            this.EntityId = EntityId;
            this.Data = Data;
            this.LookupIdToSecondaryPresenceId = LookupIdToSecondaryPresenceId;
            
        }
        
        
        
        /// <summary>
        /// The operation ID of the historical adherence query
        /// </summary>
        /// <value>The operation ID of the historical adherence query</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }
        
        
        
        /// <summary>
        /// The list of historical adherence query results
        /// </summary>
        /// <value>The list of historical adherence query results</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<HistoricalAdherenceQueryResult> Data { get; set; }
        
        
        
        /// <summary>
        /// Map of secondary presence lookup ID to corresponding secondary presence ID
        /// </summary>
        /// <value>Map of secondary presence lookup ID to corresponding secondary presence ID</value>
        [DataMember(Name="lookupIdToSecondaryPresenceId", EmitDefaultValue=false)]
        public Dictionary<string, string> LookupIdToSecondaryPresenceId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceResultWrapper {\n");
            
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  LookupIdToSecondaryPresenceId: ").Append(LookupIdToSecondaryPresenceId).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceResultWrapper);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceResultWrapper instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceResultWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceResultWrapper other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.LookupIdToSecondaryPresenceId == other.LookupIdToSecondaryPresenceId ||
                    this.LookupIdToSecondaryPresenceId != null &&
                    this.LookupIdToSecondaryPresenceId.SequenceEqual(other.LookupIdToSecondaryPresenceId)
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
                
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.LookupIdToSecondaryPresenceId != null)
                    hash = hash * 59 + this.LookupIdToSecondaryPresenceId.GetHashCode();
                
                return hash;
            }
        }
    }

}
