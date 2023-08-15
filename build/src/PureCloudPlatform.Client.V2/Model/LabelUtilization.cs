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
    /// LabelUtilization
    /// </summary>
    [DataContract]
    public partial class LabelUtilization :  IEquatable<LabelUtilization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelUtilization" /> class.
        /// </summary>
        /// <param name="MaximumCapacity">Defines the maximum number of interactions with this label that an agent can handle at one time..</param>
        /// <param name="InterruptingLabelIds">Defines other labels that can interrupt an interaction with this label..</param>
        public LabelUtilization(int? MaximumCapacity = null, List<string> InterruptingLabelIds = null)
        {
            this.MaximumCapacity = MaximumCapacity;
            this.InterruptingLabelIds = InterruptingLabelIds;
            
        }
        


        /// <summary>
        /// Defines the maximum number of interactions with this label that an agent can handle at one time.
        /// </summary>
        /// <value>Defines the maximum number of interactions with this label that an agent can handle at one time.</value>
        [DataMember(Name="maximumCapacity", EmitDefaultValue=false)]
        public int? MaximumCapacity { get; set; }



        /// <summary>
        /// Defines other labels that can interrupt an interaction with this label.
        /// </summary>
        /// <value>Defines other labels that can interrupt an interaction with this label.</value>
        [DataMember(Name="interruptingLabelIds", EmitDefaultValue=false)]
        public List<string> InterruptingLabelIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelUtilization {\n");

            sb.Append("  MaximumCapacity: ").Append(MaximumCapacity).Append("\n");
            sb.Append("  InterruptingLabelIds: ").Append(InterruptingLabelIds).Append("\n");
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
            return this.Equals(obj as LabelUtilization);
        }

        /// <summary>
        /// Returns true if LabelUtilization instances are equal
        /// </summary>
        /// <param name="other">Instance of LabelUtilization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelUtilization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MaximumCapacity == other.MaximumCapacity ||
                    this.MaximumCapacity != null &&
                    this.MaximumCapacity.Equals(other.MaximumCapacity)
                ) &&
                (
                    this.InterruptingLabelIds == other.InterruptingLabelIds ||
                    this.InterruptingLabelIds != null &&
                    this.InterruptingLabelIds.SequenceEqual(other.InterruptingLabelIds)
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
                if (this.MaximumCapacity != null)
                    hash = hash * 59 + this.MaximumCapacity.GetHashCode();

                if (this.InterruptingLabelIds != null)
                    hash = hash * 59 + this.InterruptingLabelIds.GetHashCode();

                return hash;
            }
        }
    }

}
