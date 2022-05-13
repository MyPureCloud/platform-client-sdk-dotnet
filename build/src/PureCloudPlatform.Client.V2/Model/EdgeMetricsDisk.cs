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
    /// EdgeMetricsDisk
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsDisk :  IEquatable<EdgeMetricsDisk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsDisk" /> class.
        /// </summary>
        /// <param name="AvailableBytes">Available memory in bytes..</param>
        /// <param name="PartitionName">Disk partition name..</param>
        /// <param name="TotalBytes">Total memory in bytes..</param>
        public EdgeMetricsDisk(double? AvailableBytes = null, string PartitionName = null, double? TotalBytes = null)
        {
            this.AvailableBytes = AvailableBytes;
            this.PartitionName = PartitionName;
            this.TotalBytes = TotalBytes;
            
        }
        


        /// <summary>
        /// Available memory in bytes.
        /// </summary>
        /// <value>Available memory in bytes.</value>
        [DataMember(Name="availableBytes", EmitDefaultValue=false)]
        public double? AvailableBytes { get; set; }



        /// <summary>
        /// Disk partition name.
        /// </summary>
        /// <value>Disk partition name.</value>
        [DataMember(Name="partitionName", EmitDefaultValue=false)]
        public string PartitionName { get; set; }



        /// <summary>
        /// Total memory in bytes.
        /// </summary>
        /// <value>Total memory in bytes.</value>
        [DataMember(Name="totalBytes", EmitDefaultValue=false)]
        public double? TotalBytes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsDisk {\n");

            sb.Append("  AvailableBytes: ").Append(AvailableBytes).Append("\n");
            sb.Append("  PartitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  TotalBytes: ").Append(TotalBytes).Append("\n");
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
            return this.Equals(obj as EdgeMetricsDisk);
        }

        /// <summary>
        /// Returns true if EdgeMetricsDisk instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsDisk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AvailableBytes == other.AvailableBytes ||
                    this.AvailableBytes != null &&
                    this.AvailableBytes.Equals(other.AvailableBytes)
                ) &&
                (
                    this.PartitionName == other.PartitionName ||
                    this.PartitionName != null &&
                    this.PartitionName.Equals(other.PartitionName)
                ) &&
                (
                    this.TotalBytes == other.TotalBytes ||
                    this.TotalBytes != null &&
                    this.TotalBytes.Equals(other.TotalBytes)
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
                if (this.AvailableBytes != null)
                    hash = hash * 59 + this.AvailableBytes.GetHashCode();

                if (this.PartitionName != null)
                    hash = hash * 59 + this.PartitionName.GetHashCode();

                if (this.TotalBytes != null)
                    hash = hash * 59 + this.TotalBytes.GetHashCode();

                return hash;
            }
        }
    }

}
