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
    /// ServiceGoalTemplateImpactOverride
    /// </summary>
    [DataContract]
    public partial class ServiceGoalTemplateImpactOverride :  IEquatable<ServiceGoalTemplateImpactOverride>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGoalTemplateImpactOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceGoalTemplateImpactOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGoalTemplateImpactOverride" /> class.
        /// </summary>
        /// <param name="Enabled">Whether service goal overrides are enabled for this service goal template (required).</param>
        /// <param name="Impact">Settings controlling max percent increase and decrease of service goals for this service goal template (required).</param>
        public ServiceGoalTemplateImpactOverride(bool? Enabled = null, WfmServiceGoalImpactSettings Impact = null)
        {
            this.Enabled = Enabled;
            this.Impact = Impact;
            
        }
        


        /// <summary>
        /// Whether service goal overrides are enabled for this service goal template
        /// </summary>
        /// <value>Whether service goal overrides are enabled for this service goal template</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Settings controlling max percent increase and decrease of service goals for this service goal template
        /// </summary>
        /// <value>Settings controlling max percent increase and decrease of service goals for this service goal template</value>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public WfmServiceGoalImpactSettings Impact { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGoalTemplateImpactOverride {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
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
            return this.Equals(obj as ServiceGoalTemplateImpactOverride);
        }

        /// <summary>
        /// Returns true if ServiceGoalTemplateImpactOverride instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceGoalTemplateImpactOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceGoalTemplateImpactOverride other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Impact == other.Impact ||
                    this.Impact != null &&
                    this.Impact.Equals(other.Impact)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();

                return hash;
            }
        }
    }

}
