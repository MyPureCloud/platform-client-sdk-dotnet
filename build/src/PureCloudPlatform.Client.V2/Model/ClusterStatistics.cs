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
    /// ClusterStatistics
    /// </summary>
    [DataContract]
    public partial class ClusterStatistics :  IEquatable<ClusterStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatistics" /> class.
        /// </summary>
        public ClusterStatistics()
        {
            
        }
        


        /// <summary>
        /// The total number of unique contact clusters found
        /// </summary>
        /// <value>The total number of unique contact clusters found</value>
        [DataMember(Name="totalClusters", EmitDefaultValue=false)]
        public long? TotalClusters { get; private set; }



        /// <summary>
        /// The total number of automatic merge operations that succeeded in this scan
        /// </summary>
        /// <value>The total number of automatic merge operations that succeeded in this scan</value>
        [DataMember(Name="totalAutomaticMergeSuccesses", EmitDefaultValue=false)]
        public long? TotalAutomaticMergeSuccesses { get; private set; }



        /// <summary>
        /// The total number of automatic merge operations that failed in this scan
        /// </summary>
        /// <value>The total number of automatic merge operations that failed in this scan</value>
        [DataMember(Name="totalAutomaticMergeFailures", EmitDefaultValue=false)]
        public long? TotalAutomaticMergeFailures { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterStatistics {\n");

            sb.Append("  TotalClusters: ").Append(TotalClusters).Append("\n");
            sb.Append("  TotalAutomaticMergeSuccesses: ").Append(TotalAutomaticMergeSuccesses).Append("\n");
            sb.Append("  TotalAutomaticMergeFailures: ").Append(TotalAutomaticMergeFailures).Append("\n");
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
            return this.Equals(obj as ClusterStatistics);
        }

        /// <summary>
        /// Returns true if ClusterStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalClusters == other.TotalClusters ||
                    this.TotalClusters != null &&
                    this.TotalClusters.Equals(other.TotalClusters)
                ) &&
                (
                    this.TotalAutomaticMergeSuccesses == other.TotalAutomaticMergeSuccesses ||
                    this.TotalAutomaticMergeSuccesses != null &&
                    this.TotalAutomaticMergeSuccesses.Equals(other.TotalAutomaticMergeSuccesses)
                ) &&
                (
                    this.TotalAutomaticMergeFailures == other.TotalAutomaticMergeFailures ||
                    this.TotalAutomaticMergeFailures != null &&
                    this.TotalAutomaticMergeFailures.Equals(other.TotalAutomaticMergeFailures)
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
                if (this.TotalClusters != null)
                    hash = hash * 59 + this.TotalClusters.GetHashCode();

                if (this.TotalAutomaticMergeSuccesses != null)
                    hash = hash * 59 + this.TotalAutomaticMergeSuccesses.GetHashCode();

                if (this.TotalAutomaticMergeFailures != null)
                    hash = hash * 59 + this.TotalAutomaticMergeFailures.GetHashCode();

                return hash;
            }
        }
    }

}
