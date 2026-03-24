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
    /// V3SynchronizationStatistics
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationStatistics :  IEquatable<V3SynchronizationStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationStatistics" /> class.
        /// </summary>
        /// <param name="SynchronizedItemCount">The total number of items added, updated or removed in the synchronization..</param>
        /// <param name="FailedItemCount">The number of source items that failed to synchronize..</param>
        public V3SynchronizationStatistics(int? SynchronizedItemCount = null, int? FailedItemCount = null)
        {
            this.SynchronizedItemCount = SynchronizedItemCount;
            this.FailedItemCount = FailedItemCount;
            
        }
        


        /// <summary>
        /// The total number of items added, updated or removed in the synchronization.
        /// </summary>
        /// <value>The total number of items added, updated or removed in the synchronization.</value>
        [DataMember(Name="synchronizedItemCount", EmitDefaultValue=false)]
        public int? SynchronizedItemCount { get; set; }



        /// <summary>
        /// The number of source items that failed to synchronize.
        /// </summary>
        /// <value>The number of source items that failed to synchronize.</value>
        [DataMember(Name="failedItemCount", EmitDefaultValue=false)]
        public int? FailedItemCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationStatistics {\n");

            sb.Append("  SynchronizedItemCount: ").Append(SynchronizedItemCount).Append("\n");
            sb.Append("  FailedItemCount: ").Append(FailedItemCount).Append("\n");
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
            return this.Equals(obj as V3SynchronizationStatistics);
        }

        /// <summary>
        /// Returns true if V3SynchronizationStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SynchronizedItemCount == other.SynchronizedItemCount ||
                    this.SynchronizedItemCount != null &&
                    this.SynchronizedItemCount.Equals(other.SynchronizedItemCount)
                ) &&
                (
                    this.FailedItemCount == other.FailedItemCount ||
                    this.FailedItemCount != null &&
                    this.FailedItemCount.Equals(other.FailedItemCount)
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
                if (this.SynchronizedItemCount != null)
                    hash = hash * 59 + this.SynchronizedItemCount.GetHashCode();

                if (this.FailedItemCount != null)
                    hash = hash * 59 + this.FailedItemCount.GetHashCode();

                return hash;
            }
        }
    }

}
