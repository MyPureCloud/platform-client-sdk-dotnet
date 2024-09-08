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
    /// RuleConfig
    /// </summary>
    [DataContract]
    public partial class RuleConfig :  IEquatable<RuleConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleConfig" /> class.
        /// </summary>
        /// <param name="Id">Rule ID..</param>
        /// <param name="Enabled">Rule enabled. (required).</param>
        /// <param name="Rule">Rule configuration. (required).</param>
        public RuleConfig(string Id = null, bool? Enabled = null, CopilotRule Rule = null)
        {
            this.Id = Id;
            this.Enabled = Enabled;
            this.Rule = Rule;
            
        }
        


        /// <summary>
        /// Rule ID.
        /// </summary>
        /// <value>Rule ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Rule enabled.
        /// </summary>
        /// <value>Rule enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Rule configuration.
        /// </summary>
        /// <value>Rule configuration.</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public CopilotRule Rule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleConfig {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
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
            return this.Equals(obj as RuleConfig);
        }

        /// <summary>
        /// Returns true if RuleConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleConfig other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
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

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();

                return hash;
            }
        }
    }

}
