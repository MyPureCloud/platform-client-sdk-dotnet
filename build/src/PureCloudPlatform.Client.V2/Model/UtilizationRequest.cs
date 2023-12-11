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
    /// UtilizationRequest
    /// </summary>
    [DataContract]
    public partial class UtilizationRequest :  IEquatable<UtilizationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilizationRequest" /> class.
        /// </summary>
        /// <param name="Utilization">Map of media type to utilization settings..</param>
        public UtilizationRequest(Dictionary<string, MediaUtilization> Utilization = null)
        {
            this.Utilization = Utilization;
            
        }
        


        /// <summary>
        /// Map of media type to utilization settings.
        /// </summary>
        /// <value>Map of media type to utilization settings.</value>
        [DataMember(Name="utilization", EmitDefaultValue=false)]
        public Dictionary<string, MediaUtilization> Utilization { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UtilizationRequest {\n");

            sb.Append("  Utilization: ").Append(Utilization).Append("\n");
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
            return this.Equals(obj as UtilizationRequest);
        }

        /// <summary>
        /// Returns true if UtilizationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UtilizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UtilizationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Utilization == other.Utilization ||
                    this.Utilization != null &&
                    this.Utilization.SequenceEqual(other.Utilization)
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
                if (this.Utilization != null)
                    hash = hash * 59 + this.Utilization.GetHashCode();

                return hash;
            }
        }
    }

}
