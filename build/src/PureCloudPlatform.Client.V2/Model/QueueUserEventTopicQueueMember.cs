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
    /// QueueUserEventTopicQueueMember
    /// </summary>
    [DataContract]
    public partial class QueueUserEventTopicQueueMember :  IEquatable<QueueUserEventTopicQueueMember>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueUserEventTopicQueueMember" /> class.
        /// </summary>
        /// <param name="MemberId">MemberId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RingNumber">RingNumber.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Joined">Joined.</param>
        public QueueUserEventTopicQueueMember(string MemberId = null, string Name = null, int? RingNumber = null, string Type = null, bool? Joined = null)
        {
            this.MemberId = MemberId;
            this.Name = Name;
            this.RingNumber = RingNumber;
            this.Type = Type;
            this.Joined = Joined;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="memberId", EmitDefaultValue=false)]
        public string MemberId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RingNumber
        /// </summary>
        [DataMember(Name="ringNumber", EmitDefaultValue=false)]
        public int? RingNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Joined
        /// </summary>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public bool? Joined { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueUserEventTopicQueueMember {\n");
            
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RingNumber: ").Append(RingNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
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
            return this.Equals(obj as QueueUserEventTopicQueueMember);
        }

        /// <summary>
        /// Returns true if QueueUserEventTopicQueueMember instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueUserEventTopicQueueMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueUserEventTopicQueueMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MemberId == other.MemberId ||
                    this.MemberId != null &&
                    this.MemberId.Equals(other.MemberId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.RingNumber == other.RingNumber ||
                    this.RingNumber != null &&
                    this.RingNumber.Equals(other.RingNumber)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Joined == other.Joined ||
                    this.Joined != null &&
                    this.Joined.Equals(other.Joined)
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
                
                if (this.MemberId != null)
                    hash = hash * 59 + this.MemberId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.RingNumber != null)
                    hash = hash * 59 + this.RingNumber.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Joined != null)
                    hash = hash * 59 + this.Joined.GetHashCode();
                
                return hash;
            }
        }
    }

}
