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
    /// NluUtteranceSegment
    /// </summary>
    [DataContract]
    public partial class NluUtteranceSegment :  IEquatable<NluUtteranceSegment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluUtteranceSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluUtteranceSegment() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluUtteranceSegment" /> class.
        /// </summary>
        /// <param name="Text">The text of the segment. (required).</param>
        /// <param name="Entity">The entity annotation of the segment..</param>
        public NluUtteranceSegment(string Text = null, NamedEntityAnnotation Entity = null)
        {
            this.Text = Text;
            this.Entity = Entity;
            
        }
        
        
        
        /// <summary>
        /// The text of the segment.
        /// </summary>
        /// <value>The text of the segment.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// The entity annotation of the segment.
        /// </summary>
        /// <value>The entity annotation of the segment.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public NamedEntityAnnotation Entity { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluUtteranceSegment {\n");
            
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(obj as NluUtteranceSegment);
        }

        /// <summary>
        /// Returns true if NluUtteranceSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of NluUtteranceSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluUtteranceSegment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                return hash;
            }
        }
    }

}
