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
    /// TrunkMetricsCalls
    /// </summary>
    [DataContract]
    public partial class TrunkMetricsCalls :  IEquatable<TrunkMetricsCalls>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetricsCalls" /> class.
        /// </summary>
        /// <param name="InboundCallCount">InboundCallCount.</param>
        /// <param name="OutboundCallCount">OutboundCallCount.</param>
        public TrunkMetricsCalls(int? InboundCallCount = null, int? OutboundCallCount = null)
        {
            this.InboundCallCount = InboundCallCount;
            this.OutboundCallCount = OutboundCallCount;
            
        }
        


        /// <summary>
        /// Gets or Sets InboundCallCount
        /// </summary>
        [DataMember(Name="inboundCallCount", EmitDefaultValue=false)]
        public int? InboundCallCount { get; set; }



        /// <summary>
        /// Gets or Sets OutboundCallCount
        /// </summary>
        [DataMember(Name="outboundCallCount", EmitDefaultValue=false)]
        public int? OutboundCallCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkMetricsCalls {\n");

            sb.Append("  InboundCallCount: ").Append(InboundCallCount).Append("\n");
            sb.Append("  OutboundCallCount: ").Append(OutboundCallCount).Append("\n");
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
            return this.Equals(obj as TrunkMetricsCalls);
        }

        /// <summary>
        /// Returns true if TrunkMetricsCalls instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkMetricsCalls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkMetricsCalls other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InboundCallCount == other.InboundCallCount ||
                    this.InboundCallCount != null &&
                    this.InboundCallCount.Equals(other.InboundCallCount)
                ) &&
                (
                    this.OutboundCallCount == other.OutboundCallCount ||
                    this.OutboundCallCount != null &&
                    this.OutboundCallCount.Equals(other.OutboundCallCount)
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
                if (this.InboundCallCount != null)
                    hash = hash * 59 + this.InboundCallCount.GetHashCode();

                if (this.OutboundCallCount != null)
                    hash = hash * 59 + this.OutboundCallCount.GetHashCode();

                return hash;
            }
        }
    }

}
