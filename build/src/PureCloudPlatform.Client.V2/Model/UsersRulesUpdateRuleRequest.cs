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
    /// Update users rule request
    /// </summary>
    [DataContract]
    public partial class UsersRulesUpdateRuleRequest :  IEquatable<UsersRulesUpdateRuleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesUpdateRuleRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the rule.</param>
        /// <param name="Description">The description of the rule.</param>
        /// <param name="Criteria">The criteria of the rule.</param>
        /// <param name="LockedCriteria">LockedCriteria.</param>
        public UsersRulesUpdateRuleRequest(string Name = null, string Description = null, List<UsersRulesCriteria> Criteria = null, List<UsersRulesCriteria> LockedCriteria = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Criteria = Criteria;
            this.LockedCriteria = LockedCriteria;
            
        }
        


        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the rule
        /// </summary>
        /// <value>The description of the rule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The criteria of the rule
        /// </summary>
        /// <value>The criteria of the rule</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<UsersRulesCriteria> Criteria { get; set; }



        /// <summary>
        /// Gets or Sets LockedCriteria
        /// </summary>
        [DataMember(Name="lockedCriteria", EmitDefaultValue=false)]
        public List<UsersRulesCriteria> LockedCriteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersRulesUpdateRuleRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  LockedCriteria: ").Append(LockedCriteria).Append("\n");
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
            return this.Equals(obj as UsersRulesUpdateRuleRequest);
        }

        /// <summary>
        /// Returns true if UsersRulesUpdateRuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersRulesUpdateRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersRulesUpdateRuleRequest other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
                ) &&
                (
                    this.LockedCriteria == other.LockedCriteria ||
                    this.LockedCriteria != null &&
                    this.LockedCriteria.SequenceEqual(other.LockedCriteria)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                if (this.LockedCriteria != null)
                    hash = hash * 59 + this.LockedCriteria.GetHashCode();

                return hash;
            }
        }
    }

}
