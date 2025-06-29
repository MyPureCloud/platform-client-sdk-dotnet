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
    /// Auto assign request
    /// </summary>
    [DataContract]
    public partial class LearningModuleAutoAssignRequest :  IEquatable<LearningModuleAutoAssignRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleAutoAssignRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModuleAutoAssignRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleAutoAssignRequest" /> class.
        /// </summary>
        /// <param name="RuleId">The id of the rule (required).</param>
        /// <param name="Enabled">Whether the rule is enabled for the module (required).</param>
        public LearningModuleAutoAssignRequest(string RuleId = null, bool? Enabled = null)
        {
            this.RuleId = RuleId;
            this.Enabled = Enabled;
            
        }
        


        /// <summary>
        /// The id of the rule
        /// </summary>
        /// <value>The id of the rule</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; set; }



        /// <summary>
        /// Whether the rule is enabled for the module
        /// </summary>
        /// <value>Whether the rule is enabled for the module</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleAutoAssignRequest {\n");

            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as LearningModuleAutoAssignRequest);
        }

        /// <summary>
        /// Returns true if LearningModuleAutoAssignRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleAutoAssignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleAutoAssignRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RuleId == other.RuleId ||
                    this.RuleId != null &&
                    this.RuleId.Equals(other.RuleId)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                if (this.RuleId != null)
                    hash = hash * 59 + this.RuleId.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                return hash;
            }
        }
    }

}
