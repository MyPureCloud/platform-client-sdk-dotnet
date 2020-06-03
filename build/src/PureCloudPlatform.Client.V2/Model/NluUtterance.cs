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
    /// NluUtterance
    /// </summary>
    [DataContract]
    public partial class NluUtterance :  IEquatable<NluUtterance>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluUtterance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluUtterance() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluUtterance" /> class.
        /// </summary>
        /// <param name="Segments">The list of segments that that constitute this utterance for the given intent. (required).</param>
        public NluUtterance(List<NluUtteranceSegment> Segments = null)
        {
            this.Segments = Segments;
            
        }
        
        
        
        /// <summary>
        /// The list of segments that that constitute this utterance for the given intent.
        /// </summary>
        /// <value>The list of segments that that constitute this utterance for the given intent.</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<NluUtteranceSegment> Segments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluUtterance {\n");
            
            sb.Append("  Segments: ").Append(Segments).Append("\n");
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
            return this.Equals(obj as NluUtterance);
        }

        /// <summary>
        /// Returns true if NluUtterance instances are equal
        /// </summary>
        /// <param name="other">Instance of NluUtterance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluUtterance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
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
                
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();
                
                return hash;
            }
        }
    }

}
