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
    /// EdgeMetricsProcessor
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsProcessor :  IEquatable<EdgeMetricsProcessor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsProcessor" /> class.
        /// </summary>
        /// <param name="ActiveTimePct">Percent time processor was active..</param>
        /// <param name="CpuId">Machine CPU identifier. &#39;total&#39; will always be included in the array and is the total of all CPU resources..</param>
        /// <param name="IdleTimePct">Percent time processor was idle..</param>
        /// <param name="PrivilegedTimePct">Percent time processor spent in privileged mode..</param>
        /// <param name="UserTimePct">Percent time processor spent in user mode..</param>
        public EdgeMetricsProcessor(double? ActiveTimePct = null, string CpuId = null, double? IdleTimePct = null, double? PrivilegedTimePct = null, double? UserTimePct = null)
        {
            this.ActiveTimePct = ActiveTimePct;
            this.CpuId = CpuId;
            this.IdleTimePct = IdleTimePct;
            this.PrivilegedTimePct = PrivilegedTimePct;
            this.UserTimePct = UserTimePct;
            
        }
        


        /// <summary>
        /// Percent time processor was active.
        /// </summary>
        /// <value>Percent time processor was active.</value>
        [DataMember(Name="activeTimePct", EmitDefaultValue=false)]
        public double? ActiveTimePct { get; set; }



        /// <summary>
        /// Machine CPU identifier. &#39;total&#39; will always be included in the array and is the total of all CPU resources.
        /// </summary>
        /// <value>Machine CPU identifier. &#39;total&#39; will always be included in the array and is the total of all CPU resources.</value>
        [DataMember(Name="cpuId", EmitDefaultValue=false)]
        public string CpuId { get; set; }



        /// <summary>
        /// Percent time processor was idle.
        /// </summary>
        /// <value>Percent time processor was idle.</value>
        [DataMember(Name="idleTimePct", EmitDefaultValue=false)]
        public double? IdleTimePct { get; set; }



        /// <summary>
        /// Percent time processor spent in privileged mode.
        /// </summary>
        /// <value>Percent time processor spent in privileged mode.</value>
        [DataMember(Name="privilegedTimePct", EmitDefaultValue=false)]
        public double? PrivilegedTimePct { get; set; }



        /// <summary>
        /// Percent time processor spent in user mode.
        /// </summary>
        /// <value>Percent time processor spent in user mode.</value>
        [DataMember(Name="userTimePct", EmitDefaultValue=false)]
        public double? UserTimePct { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsProcessor {\n");

            sb.Append("  ActiveTimePct: ").Append(ActiveTimePct).Append("\n");
            sb.Append("  CpuId: ").Append(CpuId).Append("\n");
            sb.Append("  IdleTimePct: ").Append(IdleTimePct).Append("\n");
            sb.Append("  PrivilegedTimePct: ").Append(PrivilegedTimePct).Append("\n");
            sb.Append("  UserTimePct: ").Append(UserTimePct).Append("\n");
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
            return this.Equals(obj as EdgeMetricsProcessor);
        }

        /// <summary>
        /// Returns true if EdgeMetricsProcessor instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsProcessor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActiveTimePct == other.ActiveTimePct ||
                    this.ActiveTimePct != null &&
                    this.ActiveTimePct.Equals(other.ActiveTimePct)
                ) &&
                (
                    this.CpuId == other.CpuId ||
                    this.CpuId != null &&
                    this.CpuId.Equals(other.CpuId)
                ) &&
                (
                    this.IdleTimePct == other.IdleTimePct ||
                    this.IdleTimePct != null &&
                    this.IdleTimePct.Equals(other.IdleTimePct)
                ) &&
                (
                    this.PrivilegedTimePct == other.PrivilegedTimePct ||
                    this.PrivilegedTimePct != null &&
                    this.PrivilegedTimePct.Equals(other.PrivilegedTimePct)
                ) &&
                (
                    this.UserTimePct == other.UserTimePct ||
                    this.UserTimePct != null &&
                    this.UserTimePct.Equals(other.UserTimePct)
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
                if (this.ActiveTimePct != null)
                    hash = hash * 59 + this.ActiveTimePct.GetHashCode();

                if (this.CpuId != null)
                    hash = hash * 59 + this.CpuId.GetHashCode();

                if (this.IdleTimePct != null)
                    hash = hash * 59 + this.IdleTimePct.GetHashCode();

                if (this.PrivilegedTimePct != null)
                    hash = hash * 59 + this.PrivilegedTimePct.GetHashCode();

                if (this.UserTimePct != null)
                    hash = hash * 59 + this.UserTimePct.GetHashCode();

                return hash;
            }
        }
    }

}
