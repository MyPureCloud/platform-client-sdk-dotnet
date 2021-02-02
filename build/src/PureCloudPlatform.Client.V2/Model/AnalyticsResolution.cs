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
    /// AnalyticsResolution
    /// </summary>
    [DataContract]
    public partial class AnalyticsResolution :  IEquatable<AnalyticsResolution>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsResolution" /> class.
        /// </summary>
        /// <param name="QueueId">The ID of the last queue on which the conversation was handled..</param>
        /// <param name="UserId">The ID of the last user who handled the conversation..</param>
        /// <param name="GetnNextContactAvoided">The number of interactions for which next contact was avoided..</param>
        public AnalyticsResolution(string QueueId = null, string UserId = null, long? GetnNextContactAvoided = null)
        {
            this.QueueId = QueueId;
            this.UserId = UserId;
            this.GetnNextContactAvoided = GetnNextContactAvoided;
            
        }
        
        
        
        /// <summary>
        /// The ID of the last queue on which the conversation was handled.
        /// </summary>
        /// <value>The ID of the last queue on which the conversation was handled.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the last user who handled the conversation.
        /// </summary>
        /// <value>The ID of the last user who handled the conversation.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// The number of interactions for which next contact was avoided.
        /// </summary>
        /// <value>The number of interactions for which next contact was avoided.</value>
        [DataMember(Name="getnNextContactAvoided", EmitDefaultValue=false)]
        public long? GetnNextContactAvoided { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsResolution {\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  GetnNextContactAvoided: ").Append(GetnNextContactAvoided).Append("\n");
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
            return this.Equals(obj as AnalyticsResolution);
        }

        /// <summary>
        /// Returns true if AnalyticsResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsResolution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.GetnNextContactAvoided == other.GetnNextContactAvoided ||
                    this.GetnNextContactAvoided != null &&
                    this.GetnNextContactAvoided.Equals(other.GetnNextContactAvoided)
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
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.GetnNextContactAvoided != null)
                    hash = hash * 59 + this.GetnNextContactAvoided.GetHashCode();
                
                return hash;
            }
        }
    }

}
