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
    /// OverrideEscalationTarget
    /// </summary>
    [DataContract]
    public partial class OverrideEscalationTarget :  IEquatable<OverrideEscalationTarget>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideEscalationTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OverrideEscalationTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideEscalationTarget" /> class.
        /// </summary>
        /// <param name="IntegrationId">The ID of the integration. (required).</param>
        public OverrideEscalationTarget(string IntegrationId = null)
        {
            this.IntegrationId = IntegrationId;
            
        }
        


        /// <summary>
        /// The ID of the integration.
        /// </summary>
        /// <value>The ID of the integration.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverrideEscalationTarget {\n");

            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(obj as OverrideEscalationTarget);
        }

        /// <summary>
        /// Returns true if OverrideEscalationTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of OverrideEscalationTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverrideEscalationTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
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
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                return hash;
            }
        }
    }

}
