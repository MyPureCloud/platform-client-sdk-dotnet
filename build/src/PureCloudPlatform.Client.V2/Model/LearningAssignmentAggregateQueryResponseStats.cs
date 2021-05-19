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
    /// LearningAssignmentAggregateQueryResponseStats
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentAggregateQueryResponseStats :  IEquatable<LearningAssignmentAggregateQueryResponseStats>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryResponseStats" /> class.
        /// </summary>
        /// <param name="Count">The count for this metric.</param>
        public LearningAssignmentAggregateQueryResponseStats(int? Count = null)
        {
            this.Count = Count;
            
        }
        
        
        
        /// <summary>
        /// The count for this metric
        /// </summary>
        /// <value>The count for this metric</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentAggregateQueryResponseStats {\n");
            
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as LearningAssignmentAggregateQueryResponseStats);
        }

        /// <summary>
        /// Returns true if LearningAssignmentAggregateQueryResponseStats instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentAggregateQueryResponseStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentAggregateQueryResponseStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                return hash;
            }
        }
    }

}
