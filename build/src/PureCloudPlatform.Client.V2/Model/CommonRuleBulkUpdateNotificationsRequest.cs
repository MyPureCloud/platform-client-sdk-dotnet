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
    /// CommonRuleBulkUpdateNotificationsRequest
    /// </summary>
    [DataContract]
    public partial class CommonRuleBulkUpdateNotificationsRequest :  IEquatable<CommonRuleBulkUpdateNotificationsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRuleBulkUpdateNotificationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonRuleBulkUpdateNotificationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRuleBulkUpdateNotificationsRequest" /> class.
        /// </summary>
        /// <param name="RuleIds">The user supplied rules ids to be updated (required).</param>
        /// <param name="Properties">The rule properties to be updated (required).</param>
        public CommonRuleBulkUpdateNotificationsRequest(List<string> RuleIds = null, ModifiableRuleProperties Properties = null)
        {
            this.RuleIds = RuleIds;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The user supplied rules ids to be updated
        /// </summary>
        /// <value>The user supplied rules ids to be updated</value>
        [DataMember(Name="ruleIds", EmitDefaultValue=false)]
        public List<string> RuleIds { get; set; }



        /// <summary>
        /// The rule properties to be updated
        /// </summary>
        /// <value>The rule properties to be updated</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public ModifiableRuleProperties Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonRuleBulkUpdateNotificationsRequest {\n");

            sb.Append("  RuleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as CommonRuleBulkUpdateNotificationsRequest);
        }

        /// <summary>
        /// Returns true if CommonRuleBulkUpdateNotificationsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonRuleBulkUpdateNotificationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonRuleBulkUpdateNotificationsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RuleIds == other.RuleIds ||
                    this.RuleIds != null &&
                    this.RuleIds.SequenceEqual(other.RuleIds)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                if (this.RuleIds != null)
                    hash = hash * 59 + this.RuleIds.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
