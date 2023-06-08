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
    /// DynamicGroupQuery
    /// </summary>
    [DataContract]
    public partial class DynamicGroupQuery :  IEquatable<DynamicGroupQuery>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicGroupQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicGroupQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicGroupQuery" /> class.
        /// </summary>
        /// <param name="SkillConditions">The skill conditions that need to be used for this dynamic group (required).</param>
        public DynamicGroupQuery(List<DynamicGroupSkillCondition> SkillConditions = null)
        {
            this.SkillConditions = SkillConditions;
            
        }
        


        /// <summary>
        /// The skill conditions that need to be used for this dynamic group
        /// </summary>
        /// <value>The skill conditions that need to be used for this dynamic group</value>
        [DataMember(Name="skillConditions", EmitDefaultValue=false)]
        public List<DynamicGroupSkillCondition> SkillConditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicGroupQuery {\n");

            sb.Append("  SkillConditions: ").Append(SkillConditions).Append("\n");
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
            return this.Equals(obj as DynamicGroupQuery);
        }

        /// <summary>
        /// Returns true if DynamicGroupQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of DynamicGroupQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicGroupQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SkillConditions == other.SkillConditions ||
                    this.SkillConditions != null &&
                    this.SkillConditions.SequenceEqual(other.SkillConditions)
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
                if (this.SkillConditions != null)
                    hash = hash * 59 + this.SkillConditions.GetHashCode();

                return hash;
            }
        }
    }

}
