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
    /// TrunkMetricsQoS
    /// </summary>
    [DataContract]
    public partial class TrunkMetricsQoS :  IEquatable<TrunkMetricsQoS>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetricsQoS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrunkMetricsQoS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetricsQoS" /> class.
        /// </summary>
        /// <param name="MismatchCount">Total number of QoS mismatches over the course of the last 24-hour period (sliding window). (required).</param>
        public TrunkMetricsQoS(int? MismatchCount = null)
        {
            this.MismatchCount = MismatchCount;
            
        }
        


        /// <summary>
        /// Total number of QoS mismatches over the course of the last 24-hour period (sliding window).
        /// </summary>
        /// <value>Total number of QoS mismatches over the course of the last 24-hour period (sliding window).</value>
        [DataMember(Name="mismatchCount", EmitDefaultValue=false)]
        public int? MismatchCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkMetricsQoS {\n");

            sb.Append("  MismatchCount: ").Append(MismatchCount).Append("\n");
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
            return this.Equals(obj as TrunkMetricsQoS);
        }

        /// <summary>
        /// Returns true if TrunkMetricsQoS instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkMetricsQoS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkMetricsQoS other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MismatchCount == other.MismatchCount ||
                    this.MismatchCount != null &&
                    this.MismatchCount.Equals(other.MismatchCount)
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
                if (this.MismatchCount != null)
                    hash = hash * 59 + this.MismatchCount.GetHashCode();

                return hash;
            }
        }
    }

}
