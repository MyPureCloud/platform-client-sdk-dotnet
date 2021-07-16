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
    /// Represents an organization skill assigned to a user. When assigning to a user specify the organization skill id as the id.
    /// </summary>
    [DataContract]
    public partial class UserRoutingSkill :  IEquatable<UserRoutingSkill>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Activate or deactivate this routing skill.
        /// </summary>
        /// <value>Activate or deactivate this routing skill.</value>
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
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Activate or deactivate this routing skill.
        /// </summary>
        /// <value>Activate or deactivate this routing skill.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoutingSkill" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Proficiency">A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings..</param>
        /// <param name="State">Activate or deactivate this routing skill..</param>
        public UserRoutingSkill(string Name = null, double? Proficiency = null, StateEnum? State = null)
        {
            this.Name = Name;
            this.Proficiency = Proficiency;
            this.State = State;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.
        /// </summary>
        /// <value>A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.</value>
        [DataMember(Name="proficiency", EmitDefaultValue=false)]
        public double? Proficiency { get; set; }
        
        
        
        
        
        /// <summary>
        /// URI to the organization skill used by this user skill.
        /// </summary>
        /// <value>URI to the organization skill used by this user skill.</value>
        [DataMember(Name="skillUri", EmitDefaultValue=false)]
        public string SkillUri { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoutingSkill {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SkillUri: ").Append(SkillUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as UserRoutingSkill);
        }

        /// <summary>
        /// Returns true if UserRoutingSkill instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRoutingSkill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoutingSkill other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Proficiency == other.Proficiency ||
                    this.Proficiency != null &&
                    this.Proficiency.Equals(other.Proficiency)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.SkillUri == other.SkillUri ||
                    this.SkillUri != null &&
                    this.SkillUri.Equals(other.SkillUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Proficiency != null)
                    hash = hash * 59 + this.Proficiency.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.SkillUri != null)
                    hash = hash * 59 + this.SkillUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
