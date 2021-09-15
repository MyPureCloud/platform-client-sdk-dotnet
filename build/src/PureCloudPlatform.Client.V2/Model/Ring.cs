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
    /// Ring
    /// </summary>
    [DataContract]
    public partial class Ring :  IEquatable<Ring>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Ring" /> class.
        /// </summary>
        /// <param name="ExpansionCriteria">The conditions that will trigger conversations to move to the next bullseye ring..</param>
        /// <param name="Actions">The actions that will be performed just before moving conversations to the next bullseye ring..</param>
        public Ring(List<ExpansionCriterium> ExpansionCriteria = null, Actions Actions = null)
        {
            this.ExpansionCriteria = ExpansionCriteria;
            this.Actions = Actions;
            
        }
        
        
        
        /// <summary>
        /// The conditions that will trigger conversations to move to the next bullseye ring.
        /// </summary>
        /// <value>The conditions that will trigger conversations to move to the next bullseye ring.</value>
        [DataMember(Name="expansionCriteria", EmitDefaultValue=false)]
        public List<ExpansionCriterium> ExpansionCriteria { get; set; }
        
        
        
        /// <summary>
        /// The actions that will be performed just before moving conversations to the next bullseye ring.
        /// </summary>
        /// <value>The actions that will be performed just before moving conversations to the next bullseye ring.</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public Actions Actions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ring {\n");
            
            sb.Append("  ExpansionCriteria: ").Append(ExpansionCriteria).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as Ring);
        }

        /// <summary>
        /// Returns true if Ring instances are equal
        /// </summary>
        /// <param name="other">Instance of Ring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ring other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExpansionCriteria == other.ExpansionCriteria ||
                    this.ExpansionCriteria != null &&
                    this.ExpansionCriteria.SequenceEqual(other.ExpansionCriteria)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
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
                
                if (this.ExpansionCriteria != null)
                    hash = hash * 59 + this.ExpansionCriteria.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }
    }

}
