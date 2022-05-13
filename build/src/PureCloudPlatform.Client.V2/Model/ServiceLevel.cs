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
    /// ServiceLevel
    /// </summary>
    [DataContract]
    public partial class ServiceLevel :  IEquatable<ServiceLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevel" /> class.
        /// </summary>
        /// <param name="Percentage">The desired Service Level. A value between 0 and 1..</param>
        /// <param name="DurationMs">Service Level target in milliseconds..</param>
        public ServiceLevel(double? Percentage = null, long? DurationMs = null)
        {
            this.Percentage = Percentage;
            this.DurationMs = DurationMs;
            
        }
        


        /// <summary>
        /// The desired Service Level. A value between 0 and 1.
        /// </summary>
        /// <value>The desired Service Level. A value between 0 and 1.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public double? Percentage { get; set; }



        /// <summary>
        /// Service Level target in milliseconds.
        /// </summary>
        /// <value>Service Level target in milliseconds.</value>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public long? DurationMs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLevel {\n");

            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
            return this.Equals(obj as ServiceLevel);
        }

        /// <summary>
        /// Returns true if ServiceLevel instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceLevel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) &&
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
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
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();

                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();

                return hash;
            }
        }
    }

}
