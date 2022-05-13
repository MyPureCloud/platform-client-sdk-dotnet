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
    /// EdgeMetricsNetwork
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsNetwork :  IEquatable<EdgeMetricsNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsNetwork" /> class.
        /// </summary>
        /// <param name="Ifname">Identifier for the network adapter..</param>
        /// <param name="SentBytesPerSec">Number of byes sent per second..</param>
        /// <param name="ReceivedBytesPerSec">Number of byes received per second..</param>
        /// <param name="BandwidthBitsPerSec">Total bandwidth of the adapter in bits per second..</param>
        /// <param name="UtilizationPct">Percent utilization of the network adapter..</param>
        public EdgeMetricsNetwork(string Ifname = null, int? SentBytesPerSec = null, int? ReceivedBytesPerSec = null, double? BandwidthBitsPerSec = null, double? UtilizationPct = null)
        {
            this.Ifname = Ifname;
            this.SentBytesPerSec = SentBytesPerSec;
            this.ReceivedBytesPerSec = ReceivedBytesPerSec;
            this.BandwidthBitsPerSec = BandwidthBitsPerSec;
            this.UtilizationPct = UtilizationPct;
            
        }
        


        /// <summary>
        /// Identifier for the network adapter.
        /// </summary>
        /// <value>Identifier for the network adapter.</value>
        [DataMember(Name="ifname", EmitDefaultValue=false)]
        public string Ifname { get; set; }



        /// <summary>
        /// Number of byes sent per second.
        /// </summary>
        /// <value>Number of byes sent per second.</value>
        [DataMember(Name="sentBytesPerSec", EmitDefaultValue=false)]
        public int? SentBytesPerSec { get; set; }



        /// <summary>
        /// Number of byes received per second.
        /// </summary>
        /// <value>Number of byes received per second.</value>
        [DataMember(Name="receivedBytesPerSec", EmitDefaultValue=false)]
        public int? ReceivedBytesPerSec { get; set; }



        /// <summary>
        /// Total bandwidth of the adapter in bits per second.
        /// </summary>
        /// <value>Total bandwidth of the adapter in bits per second.</value>
        [DataMember(Name="bandwidthBitsPerSec", EmitDefaultValue=false)]
        public double? BandwidthBitsPerSec { get; set; }



        /// <summary>
        /// Percent utilization of the network adapter.
        /// </summary>
        /// <value>Percent utilization of the network adapter.</value>
        [DataMember(Name="utilizationPct", EmitDefaultValue=false)]
        public double? UtilizationPct { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsNetwork {\n");

            sb.Append("  Ifname: ").Append(Ifname).Append("\n");
            sb.Append("  SentBytesPerSec: ").Append(SentBytesPerSec).Append("\n");
            sb.Append("  ReceivedBytesPerSec: ").Append(ReceivedBytesPerSec).Append("\n");
            sb.Append("  BandwidthBitsPerSec: ").Append(BandwidthBitsPerSec).Append("\n");
            sb.Append("  UtilizationPct: ").Append(UtilizationPct).Append("\n");
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
            return this.Equals(obj as EdgeMetricsNetwork);
        }

        /// <summary>
        /// Returns true if EdgeMetricsNetwork instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsNetwork other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ifname == other.Ifname ||
                    this.Ifname != null &&
                    this.Ifname.Equals(other.Ifname)
                ) &&
                (
                    this.SentBytesPerSec == other.SentBytesPerSec ||
                    this.SentBytesPerSec != null &&
                    this.SentBytesPerSec.Equals(other.SentBytesPerSec)
                ) &&
                (
                    this.ReceivedBytesPerSec == other.ReceivedBytesPerSec ||
                    this.ReceivedBytesPerSec != null &&
                    this.ReceivedBytesPerSec.Equals(other.ReceivedBytesPerSec)
                ) &&
                (
                    this.BandwidthBitsPerSec == other.BandwidthBitsPerSec ||
                    this.BandwidthBitsPerSec != null &&
                    this.BandwidthBitsPerSec.Equals(other.BandwidthBitsPerSec)
                ) &&
                (
                    this.UtilizationPct == other.UtilizationPct ||
                    this.UtilizationPct != null &&
                    this.UtilizationPct.Equals(other.UtilizationPct)
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
                if (this.Ifname != null)
                    hash = hash * 59 + this.Ifname.GetHashCode();

                if (this.SentBytesPerSec != null)
                    hash = hash * 59 + this.SentBytesPerSec.GetHashCode();

                if (this.ReceivedBytesPerSec != null)
                    hash = hash * 59 + this.ReceivedBytesPerSec.GetHashCode();

                if (this.BandwidthBitsPerSec != null)
                    hash = hash * 59 + this.BandwidthBitsPerSec.GetHashCode();

                if (this.UtilizationPct != null)
                    hash = hash * 59 + this.UtilizationPct.GetHashCode();

                return hash;
            }
        }
    }

}
