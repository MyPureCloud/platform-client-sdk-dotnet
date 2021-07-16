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
    /// MatchShiftTradeRequest
    /// </summary>
    [DataContract]
    public partial class MatchShiftTradeRequest :  IEquatable<MatchShiftTradeRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchShiftTradeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchShiftTradeRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchShiftTradeRequest" /> class.
        /// </summary>
        /// <param name="ReceivingScheduleId">The ID of the schedule with which the shift trade is associated (required).</param>
        /// <param name="ReceivingShiftId">The ID of the shift the receiving user is giving up in trade, if applicable.</param>
        /// <param name="Metadata">Version metadata for the shift trade (required).</param>
        public MatchShiftTradeRequest(string ReceivingScheduleId = null, string ReceivingShiftId = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.ReceivingScheduleId = ReceivingScheduleId;
            this.ReceivingShiftId = ReceivingShiftId;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The ID of the schedule with which the shift trade is associated
        /// </summary>
        /// <value>The ID of the schedule with which the shift trade is associated</value>
        [DataMember(Name="receivingScheduleId", EmitDefaultValue=false)]
        public string ReceivingScheduleId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the shift the receiving user is giving up in trade, if applicable
        /// </summary>
        /// <value>The ID of the shift the receiving user is giving up in trade, if applicable</value>
        [DataMember(Name="receivingShiftId", EmitDefaultValue=false)]
        public string ReceivingShiftId { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for the shift trade
        /// </summary>
        /// <value>Version metadata for the shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchShiftTradeRequest {\n");
            
            sb.Append("  ReceivingScheduleId: ").Append(ReceivingScheduleId).Append("\n");
            sb.Append("  ReceivingShiftId: ").Append(ReceivingShiftId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as MatchShiftTradeRequest);
        }

        /// <summary>
        /// Returns true if MatchShiftTradeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchShiftTradeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchShiftTradeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReceivingScheduleId == other.ReceivingScheduleId ||
                    this.ReceivingScheduleId != null &&
                    this.ReceivingScheduleId.Equals(other.ReceivingScheduleId)
                ) &&
                (
                    this.ReceivingShiftId == other.ReceivingShiftId ||
                    this.ReceivingShiftId != null &&
                    this.ReceivingShiftId.Equals(other.ReceivingShiftId)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.ReceivingScheduleId != null)
                    hash = hash * 59 + this.ReceivingScheduleId.GetHashCode();
                
                if (this.ReceivingShiftId != null)
                    hash = hash * 59 + this.ReceivingShiftId.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
