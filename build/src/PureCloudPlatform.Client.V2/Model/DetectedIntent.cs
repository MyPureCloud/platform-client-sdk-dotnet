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
    /// DetectedIntent
    /// </summary>
    [DataContract]
    public partial class DetectedIntent :  IEquatable<DetectedIntent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedIntent" /> class.
        /// </summary>
        /// <param name="Entities">The collection of named entities detected..</param>
        public DetectedIntent(List<DetectedNamedEntity> Entities = null)
        {
            this.Entities = Entities;
            
        }
        
        
        
        /// <summary>
        /// The name of the detected intent.
        /// </summary>
        /// <value>The name of the detected intent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// The probability of the detected intent.
        /// </summary>
        /// <value>The probability of the detected intent.</value>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; private set; }
        
        
        
        /// <summary>
        /// The collection of named entities detected.
        /// </summary>
        /// <value>The collection of named entities detected.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<DetectedNamedEntity> Entities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedIntent {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as DetectedIntent);
        }

        /// <summary>
        /// Returns true if DetectedIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedIntent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                return hash;
            }
        }
    }

}
