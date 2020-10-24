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
    /// ConversationDetailsDatalakeAvailabilityTopicDateTime
    /// </summary>
    [DataContract]
    public partial class ConversationDetailsDatalakeAvailabilityTopicDateTime :  IEquatable<ConversationDetailsDatalakeAvailabilityTopicDateTime>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDetailsDatalakeAvailabilityTopicDateTime" /> class.
        /// </summary>
        /// <param name="IMillis">IMillis.</param>
        /// <param name="BeforeNow">BeforeNow.</param>
        /// <param name="AfterNow">AfterNow.</param>
        /// <param name="EqualNow">EqualNow.</param>
        public ConversationDetailsDatalakeAvailabilityTopicDateTime(int? IMillis = null, bool? BeforeNow = null, bool? AfterNow = null, bool? EqualNow = null)
        {
            this.IMillis = IMillis;
            this.BeforeNow = BeforeNow;
            this.AfterNow = AfterNow;
            this.EqualNow = EqualNow;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets IMillis
        /// </summary>
        [DataMember(Name="iMillis", EmitDefaultValue=false)]
        public int? IMillis { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets BeforeNow
        /// </summary>
        [DataMember(Name="beforeNow", EmitDefaultValue=false)]
        public bool? BeforeNow { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AfterNow
        /// </summary>
        [DataMember(Name="afterNow", EmitDefaultValue=false)]
        public bool? AfterNow { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EqualNow
        /// </summary>
        [DataMember(Name="equalNow", EmitDefaultValue=false)]
        public bool? EqualNow { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationDetailsDatalakeAvailabilityTopicDateTime {\n");
            
            sb.Append("  IMillis: ").Append(IMillis).Append("\n");
            sb.Append("  BeforeNow: ").Append(BeforeNow).Append("\n");
            sb.Append("  AfterNow: ").Append(AfterNow).Append("\n");
            sb.Append("  EqualNow: ").Append(EqualNow).Append("\n");
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
            return this.Equals(obj as ConversationDetailsDatalakeAvailabilityTopicDateTime);
        }

        /// <summary>
        /// Returns true if ConversationDetailsDatalakeAvailabilityTopicDateTime instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationDetailsDatalakeAvailabilityTopicDateTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationDetailsDatalakeAvailabilityTopicDateTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IMillis == other.IMillis ||
                    this.IMillis != null &&
                    this.IMillis.Equals(other.IMillis)
                ) &&
                (
                    this.BeforeNow == other.BeforeNow ||
                    this.BeforeNow != null &&
                    this.BeforeNow.Equals(other.BeforeNow)
                ) &&
                (
                    this.AfterNow == other.AfterNow ||
                    this.AfterNow != null &&
                    this.AfterNow.Equals(other.AfterNow)
                ) &&
                (
                    this.EqualNow == other.EqualNow ||
                    this.EqualNow != null &&
                    this.EqualNow.Equals(other.EqualNow)
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
                
                if (this.IMillis != null)
                    hash = hash * 59 + this.IMillis.GetHashCode();
                
                if (this.BeforeNow != null)
                    hash = hash * 59 + this.BeforeNow.GetHashCode();
                
                if (this.AfterNow != null)
                    hash = hash * 59 + this.AfterNow.GetHashCode();
                
                if (this.EqualNow != null)
                    hash = hash * 59 + this.EqualNow.GetHashCode();
                
                return hash;
            }
        }
    }

}
