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
    /// PatchShiftTradeRequest
    /// </summary>
    [DataContract]
    public partial class PatchShiftTradeRequest :  IEquatable<PatchShiftTradeRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchShiftTradeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchShiftTradeRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchShiftTradeRequest" /> class.
        /// </summary>
        /// <param name="ReceivingUserId">Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user..</param>
        /// <param name="Expiration">Update the expiration time for this shift trade..</param>
        /// <param name="AcceptableIntervals">Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request.</param>
        /// <param name="Metadata">Version metadata (required).</param>
        public PatchShiftTradeRequest(ValueWrapperString ReceivingUserId = null, ValueWrapperDate Expiration = null, ListWrapperInterval AcceptableIntervals = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.ReceivingUserId = ReceivingUserId;
            this.Expiration = Expiration;
            this.AcceptableIntervals = AcceptableIntervals;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user.
        /// </summary>
        /// <value>Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user.</value>
        [DataMember(Name="receivingUserId", EmitDefaultValue=false)]
        public ValueWrapperString ReceivingUserId { get; set; }
        
        
        
        /// <summary>
        /// Update the expiration time for this shift trade.
        /// </summary>
        /// <value>Update the expiration time for this shift trade.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public ValueWrapperDate Expiration { get; set; }
        
        
        
        /// <summary>
        /// Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request
        /// </summary>
        /// <value>Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request</value>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public ListWrapperInterval AcceptableIntervals { get; set; }
        
        
        
        /// <summary>
        /// Version metadata
        /// </summary>
        /// <value>Version metadata</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchShiftTradeRequest {\n");
            
            sb.Append("  ReceivingUserId: ").Append(ReceivingUserId).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
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
            return this.Equals(obj as PatchShiftTradeRequest);
        }

        /// <summary>
        /// Returns true if PatchShiftTradeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchShiftTradeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchShiftTradeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReceivingUserId == other.ReceivingUserId ||
                    this.ReceivingUserId != null &&
                    this.ReceivingUserId.Equals(other.ReceivingUserId)
                ) &&
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.Equals(other.AcceptableIntervals)
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
                
                if (this.ReceivingUserId != null)
                    hash = hash * 59 + this.ReceivingUserId.GetHashCode();
                
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                
                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
