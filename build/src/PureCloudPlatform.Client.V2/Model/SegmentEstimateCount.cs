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
    /// SegmentEstimateCount
    /// </summary>
    [DataContract]
    public partial class SegmentEstimateCount :  IEquatable<SegmentEstimateCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentEstimateCount" /> class.
        /// </summary>
        /// <param name="SegmentId">ID of Segment..</param>
        /// <param name="Count">Estimate count per segment..</param>
        public SegmentEstimateCount(string SegmentId = null, int? Count = null)
        {
            this.SegmentId = SegmentId;
            this.Count = Count;
            
        }
        


        /// <summary>
        /// ID of Segment.
        /// </summary>
        /// <value>ID of Segment.</value>
        [DataMember(Name="segmentId", EmitDefaultValue=false)]
        public string SegmentId { get; set; }



        /// <summary>
        /// Estimate count per segment.
        /// </summary>
        /// <value>Estimate count per segment.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentEstimateCount {\n");

            sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as SegmentEstimateCount);
        }

        /// <summary>
        /// Returns true if SegmentEstimateCount instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentEstimateCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentEstimateCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SegmentId == other.SegmentId ||
                    this.SegmentId != null &&
                    this.SegmentId.Equals(other.SegmentId)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.SegmentId != null)
                    hash = hash * 59 + this.SegmentId.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
