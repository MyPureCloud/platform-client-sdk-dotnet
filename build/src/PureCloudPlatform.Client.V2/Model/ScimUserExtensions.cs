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
    /// Genesys Cloud user extensions to SCIM RFC.
    /// </summary>
    [DataContract]
    public partial class ScimUserExtensions :  IEquatable<ScimUserExtensions>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserExtensions" /> class.
        /// </summary>
        /// <param name="RoutingSkills">The list of routing skills assigned to a user. Maximum 50 skills..</param>
        /// <param name="RoutingLanguages">The list of routing languages assigned to a user. Maximum 50 languages..</param>
        /// <param name="ExternalIds">The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;..</param>
        public ScimUserExtensions(List<ScimUserRoutingSkill> RoutingSkills = null, List<ScimUserRoutingLanguage> RoutingLanguages = null, List<ScimGenesysUserExternalId> ExternalIds = null)
        {
            this.RoutingSkills = RoutingSkills;
            this.RoutingLanguages = RoutingLanguages;
            this.ExternalIds = ExternalIds;
            
        }
        
        
        
        /// <summary>
        /// The list of routing skills assigned to a user. Maximum 50 skills.
        /// </summary>
        /// <value>The list of routing skills assigned to a user. Maximum 50 skills.</value>
        [DataMember(Name="routingSkills", EmitDefaultValue=false)]
        public List<ScimUserRoutingSkill> RoutingSkills { get; set; }
        
        
        
        /// <summary>
        /// The list of routing languages assigned to a user. Maximum 50 languages.
        /// </summary>
        /// <value>The list of routing languages assigned to a user. Maximum 50 languages.</value>
        [DataMember(Name="routingLanguages", EmitDefaultValue=false)]
        public List<ScimUserRoutingLanguage> RoutingLanguages { get; set; }
        
        
        
        /// <summary>
        /// The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;.
        /// </summary>
        /// <value>The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;.</value>
        [DataMember(Name="externalIds", EmitDefaultValue=false)]
        public List<ScimGenesysUserExternalId> ExternalIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimUserExtensions {\n");
            
            sb.Append("  RoutingSkills: ").Append(RoutingSkills).Append("\n");
            sb.Append("  RoutingLanguages: ").Append(RoutingLanguages).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
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
            return this.Equals(obj as ScimUserExtensions);
        }

        /// <summary>
        /// Returns true if ScimUserExtensions instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimUserExtensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimUserExtensions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RoutingSkills == other.RoutingSkills ||
                    this.RoutingSkills != null &&
                    this.RoutingSkills.SequenceEqual(other.RoutingSkills)
                ) &&
                (
                    this.RoutingLanguages == other.RoutingLanguages ||
                    this.RoutingLanguages != null &&
                    this.RoutingLanguages.SequenceEqual(other.RoutingLanguages)
                ) &&
                (
                    this.ExternalIds == other.ExternalIds ||
                    this.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(other.ExternalIds)
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
                
                if (this.RoutingSkills != null)
                    hash = hash * 59 + this.RoutingSkills.GetHashCode();
                
                if (this.RoutingLanguages != null)
                    hash = hash * 59 + this.RoutingLanguages.GetHashCode();
                
                if (this.ExternalIds != null)
                    hash = hash * 59 + this.ExternalIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
