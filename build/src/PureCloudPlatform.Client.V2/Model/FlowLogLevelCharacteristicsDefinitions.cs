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
    /// A set of available characteristic definitions
    /// </summary>
    [DataContract]
    public partial class FlowLogLevelCharacteristicsDefinitions :  IEquatable<FlowLogLevelCharacteristicsDefinitions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLogLevelCharacteristicsDefinitions" /> class.
        /// </summary>
        /// <param name="Characteristics">Characteristics.</param>
        public FlowLogLevelCharacteristicsDefinitions(List<FlowLogLevelCharacteristicsDefinition> Characteristics = null)
        {
            this.Characteristics = Characteristics;
            
        }
        


        /// <summary>
        /// Gets or Sets Characteristics
        /// </summary>
        [DataMember(Name="characteristics", EmitDefaultValue=false)]
        public List<FlowLogLevelCharacteristicsDefinition> Characteristics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLogLevelCharacteristicsDefinitions {\n");

            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
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
            return this.Equals(obj as FlowLogLevelCharacteristicsDefinitions);
        }

        /// <summary>
        /// Returns true if FlowLogLevelCharacteristicsDefinitions instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowLogLevelCharacteristicsDefinitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLogLevelCharacteristicsDefinitions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Characteristics == other.Characteristics ||
                    this.Characteristics != null &&
                    this.Characteristics.SequenceEqual(other.Characteristics)
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
                if (this.Characteristics != null)
                    hash = hash * 59 + this.Characteristics.GetHashCode();

                return hash;
            }
        }
    }

}
