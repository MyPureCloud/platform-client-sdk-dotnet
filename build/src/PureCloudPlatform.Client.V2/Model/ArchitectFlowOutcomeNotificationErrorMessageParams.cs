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
    /// The error message params, if the action failed
    /// </summary>
    [DataContract]
    public partial class ArchitectFlowOutcomeNotificationErrorMessageParams :  IEquatable<ArchitectFlowOutcomeNotificationErrorMessageParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectFlowOutcomeNotificationErrorMessageParams" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
        public ArchitectFlowOutcomeNotificationErrorMessageParams(Dictionary<string, string> AdditionalProperties = null, Dictionary<string, string> GetAdditionalProperties = null)
        {
            this.AdditionalProperties = AdditionalProperties;
            this.GetAdditionalProperties = GetAdditionalProperties;
            
        }
        


        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalProperties { get; set; }



        /// <summary>
        /// Gets or Sets GetAdditionalProperties
        /// </summary>
        [DataMember(Name="getAdditionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, string> GetAdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectFlowOutcomeNotificationErrorMessageParams {\n");

            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
            return this.Equals(obj as ArchitectFlowOutcomeNotificationErrorMessageParams);
        }

        /// <summary>
        /// Returns true if ArchitectFlowOutcomeNotificationErrorMessageParams instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectFlowOutcomeNotificationErrorMessageParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectFlowOutcomeNotificationErrorMessageParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.GetAdditionalProperties == other.GetAdditionalProperties ||
                    this.GetAdditionalProperties != null &&
                    this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.GetAdditionalProperties != null)
                    hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
