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
    /// Cluster
    /// </summary>
    [DataContract]
    public partial class Cluster :  IEquatable<Cluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        public Cluster()
        {
            
        }
        


        /// <summary>
        /// The unique ID of this cluster within its associated scan
        /// </summary>
        /// <value>The unique ID of this cluster within its associated scan</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The division all contacts in this cluster are associated to
        /// </summary>
        /// <value>The division all contacts in this cluster are associated to</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public StarrableDivision Division { get; private set; }



        /// <summary>
        /// The scan that this cluster belongs to
        /// </summary>
        /// <value>The scan that this cluster belongs to</value>
        [DataMember(Name="clusterScan", EmitDefaultValue=false)]
        public ClusterScan ClusterScan { get; private set; }



        /// <summary>
        /// Information related to merge operations taken on this cluster
        /// </summary>
        /// <value>Information related to merge operations taken on this cluster</value>
        [DataMember(Name="mergeInfo", EmitDefaultValue=false)]
        public MergeInfo MergeInfo { get; private set; }



        /// <summary>
        /// The graph of contacts and identifiers that make up this cluster
        /// </summary>
        /// <value>The graph of contacts and identifiers that make up this cluster</value>
        [DataMember(Name="graph", EmitDefaultValue=false)]
        public Graph Graph { get; private set; }



        /// <summary>
        /// The date this cluster was discovered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date this cluster was discovered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cluster {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ClusterScan: ").Append(ClusterScan).Append("\n");
            sb.Append("  MergeInfo: ").Append(MergeInfo).Append("\n");
            sb.Append("  Graph: ").Append(Graph).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Cluster);
        }

        /// <summary>
        /// Returns true if Cluster instances are equal
        /// </summary>
        /// <param name="other">Instance of Cluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cluster other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.ClusterScan == other.ClusterScan ||
                    this.ClusterScan != null &&
                    this.ClusterScan.Equals(other.ClusterScan)
                ) &&
                (
                    this.MergeInfo == other.MergeInfo ||
                    this.MergeInfo != null &&
                    this.MergeInfo.Equals(other.MergeInfo)
                ) &&
                (
                    this.Graph == other.Graph ||
                    this.Graph != null &&
                    this.Graph.Equals(other.Graph)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.ClusterScan != null)
                    hash = hash * 59 + this.ClusterScan.GetHashCode();

                if (this.MergeInfo != null)
                    hash = hash * 59 + this.MergeInfo.GetHashCode();

                if (this.Graph != null)
                    hash = hash * 59 + this.Graph.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
