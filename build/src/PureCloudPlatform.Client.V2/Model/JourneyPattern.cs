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
    /// JourneyPattern
    /// </summary>
    [DataContract]
    public partial class JourneyPattern :  IEquatable<JourneyPattern>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyPattern" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyPattern() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyPattern" /> class.
        /// </summary>
        /// <param name="Criteria">A list of one or more criteria to satisfy. (required).</param>
        /// <param name="Count">The number of times the pattern must match..</param>
        public JourneyPattern(List<Criteria> Criteria = null, int? Count = null)
        {
            this.Criteria = Criteria;
            this.Count = Count;
            
        }
        
        
        
        /// <summary>
        /// A list of one or more criteria to satisfy.
        /// </summary>
        /// <value>A list of one or more criteria to satisfy.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<Criteria> Criteria { get; set; }
        
        
        
        /// <summary>
        /// The number of times the pattern must match.
        /// </summary>
        /// <value>The number of times the pattern must match.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyPattern {\n");
            
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return this.Equals(obj as JourneyPattern);
        }

        /// <summary>
        /// Returns true if JourneyPattern instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyPattern other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
                ) &&
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
                
                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                return hash;
            }
        }
    }

}
