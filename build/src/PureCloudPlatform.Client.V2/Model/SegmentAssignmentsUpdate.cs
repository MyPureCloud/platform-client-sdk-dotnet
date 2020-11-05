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
    /// SegmentAssignmentsUpdate
    /// </summary>
    [DataContract]
    public partial class SegmentAssignmentsUpdate :  IEquatable<SegmentAssignmentsUpdate>
    {
        
        
        
        
        
        /// <summary>
        /// Segment assignment state
        /// </summary>
        /// <value>Segment assignment state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Assigned for "Assigned"
            /// </summary>
            [EnumMember(Value = "Assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Unassigned for "Unassigned"
            /// </summary>
            [EnumMember(Value = "Unassigned")]
            Unassigned
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Segment assignment state
        /// </summary>
        /// <value>Segment assignment state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignmentsUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SegmentAssignmentsUpdate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignmentsUpdate" /> class.
        /// </summary>
        /// <param name="SegmentId">ID of segment to be assigned/unnassigned (required).</param>
        /// <param name="State">Segment assignment state (required).</param>
        public SegmentAssignmentsUpdate(string SegmentId = null, StateEnum? State = null)
        {
            this.SegmentId = SegmentId;
            this.State = State;
            
        }
        
        
        
        /// <summary>
        /// ID of segment to be assigned/unnassigned
        /// </summary>
        /// <value>ID of segment to be assigned/unnassigned</value>
        [DataMember(Name="segmentId", EmitDefaultValue=false)]
        public string SegmentId { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentAssignmentsUpdate {\n");
            
            sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as SegmentAssignmentsUpdate);
        }

        /// <summary>
        /// Returns true if SegmentAssignmentsUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentAssignmentsUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentAssignmentsUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SegmentId == other.SegmentId ||
                    this.SegmentId != null &&
                    this.SegmentId.Equals(other.SegmentId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.SegmentId != null)
                    hash = hash * 59 + this.SegmentId.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                return hash;
            }
        }
    }

}
