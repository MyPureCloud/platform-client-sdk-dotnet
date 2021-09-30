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
    /// IntentDefinition
    /// </summary>
    [DataContract]
    public partial class IntentDefinition :  IEquatable<IntentDefinition>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntentDefinition() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentDefinition" /> class.
        /// </summary>
        /// <param name="Name">The name of the intent. (required).</param>
        /// <param name="EntityTypeBindings">The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities.</param>
        /// <param name="Utterances">The utterances that act as training phrases for the intent. (required).</param>
        public IntentDefinition(string Name = null, List<NamedEntityTypeBinding> EntityTypeBindings = null, List<NluUtterance> Utterances = null)
        {
            this.Name = Name;
            this.EntityTypeBindings = EntityTypeBindings;
            this.Utterances = Utterances;
            
        }
        
        
        
        /// <summary>
        /// The name of the intent.
        /// </summary>
        /// <value>The name of the intent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities
        /// </summary>
        /// <value>The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities</value>
        [DataMember(Name="entityTypeBindings", EmitDefaultValue=false)]
        public List<NamedEntityTypeBinding> EntityTypeBindings { get; set; }
        
        
        
        /// <summary>
        /// The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings
        /// </summary>
        /// <value>The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings</value>
        [DataMember(Name="entityNameReferences", EmitDefaultValue=false)]
        public List<string> EntityNameReferences { get; private set; }
        
        
        
        /// <summary>
        /// The utterances that act as training phrases for the intent.
        /// </summary>
        /// <value>The utterances that act as training phrases for the intent.</value>
        [DataMember(Name="utterances", EmitDefaultValue=false)]
        public List<NluUtterance> Utterances { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntentDefinition {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EntityTypeBindings: ").Append(EntityTypeBindings).Append("\n");
            sb.Append("  EntityNameReferences: ").Append(EntityNameReferences).Append("\n");
            sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
            return this.Equals(obj as IntentDefinition);
        }

        /// <summary>
        /// Returns true if IntentDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of IntentDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntentDefinition other)
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
                    this.EntityTypeBindings == other.EntityTypeBindings ||
                    this.EntityTypeBindings != null &&
                    this.EntityTypeBindings.SequenceEqual(other.EntityTypeBindings)
                ) &&
                (
                    this.EntityNameReferences == other.EntityNameReferences ||
                    this.EntityNameReferences != null &&
                    this.EntityNameReferences.SequenceEqual(other.EntityNameReferences)
                ) &&
                (
                    this.Utterances == other.Utterances ||
                    this.Utterances != null &&
                    this.Utterances.SequenceEqual(other.Utterances)
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
                
                if (this.EntityTypeBindings != null)
                    hash = hash * 59 + this.EntityTypeBindings.GetHashCode();
                
                if (this.EntityNameReferences != null)
                    hash = hash * 59 + this.EntityNameReferences.GetHashCode();
                
                if (this.Utterances != null)
                    hash = hash * 59 + this.Utterances.GetHashCode();
                
                return hash;
            }
        }
    }

}
