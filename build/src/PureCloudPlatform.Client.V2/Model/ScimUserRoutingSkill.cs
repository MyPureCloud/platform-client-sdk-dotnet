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
    /// The routing skill assigned to a user.
    /// </summary>
    [DataContract]
    public partial class ScimUserRoutingSkill :  IEquatable<ScimUserRoutingSkill>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimUserRoutingSkill() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
        /// </summary>
        /// <param name="Name">The case-sensitive name of a routing skill configured in Genesys Cloud. (required).</param>
        /// <param name="Proficiency">A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings..</param>
        public ScimUserRoutingSkill(string Name = null, double? Proficiency = null)
        {
            this.Name = Name;
            this.Proficiency = Proficiency;
            
        }
        
        
        
        /// <summary>
        /// The case-sensitive name of a routing skill configured in Genesys Cloud.
        /// </summary>
        /// <value>The case-sensitive name of a routing skill configured in Genesys Cloud.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.
        /// </summary>
        /// <value>A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.</value>
        [DataMember(Name="proficiency", EmitDefaultValue=false)]
        public double? Proficiency { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimUserRoutingSkill {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
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
            return this.Equals(obj as ScimUserRoutingSkill);
        }

        /// <summary>
        /// Returns true if ScimUserRoutingSkill instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimUserRoutingSkill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimUserRoutingSkill other)
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
                    this.Proficiency == other.Proficiency ||
                    this.Proficiency != null &&
                    this.Proficiency.Equals(other.Proficiency)
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
                
                if (this.Proficiency != null)
                    hash = hash * 59 + this.Proficiency.GetHashCode();
                
                return hash;
            }
        }
    }

}
