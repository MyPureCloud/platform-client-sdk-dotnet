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
    /// WorkPlanBidRanks
    /// </summary>
    [DataContract]
    public partial class WorkPlanBidRanks :  IEquatable<WorkPlanBidRanks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanBidRanks" /> class.
        /// </summary>
        /// <param name="WorkPlanBiddingPerformance">Work plan bidding agent performance ranking. The range of values is between 0 and 9999..</param>
        /// <param name="BiddingTieBreaker">Custom agent ranking metric that some customers can use..</param>
        public WorkPlanBidRanks(int? WorkPlanBiddingPerformance = null, string BiddingTieBreaker = null)
        {
            this.WorkPlanBiddingPerformance = WorkPlanBiddingPerformance;
            this.BiddingTieBreaker = BiddingTieBreaker;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Work plan bidding agent performance ranking. The range of values is between 0 and 9999.
        /// </summary>
        /// <value>Work plan bidding agent performance ranking. The range of values is between 0 and 9999.</value>
        [DataMember(Name="workPlanBiddingPerformance", EmitDefaultValue=false)]
        public int? WorkPlanBiddingPerformance { get; set; }



        /// <summary>
        /// Custom agent ranking metric that some customers can use.
        /// </summary>
        /// <value>Custom agent ranking metric that some customers can use.</value>
        [DataMember(Name="biddingTieBreaker", EmitDefaultValue=false)]
        public string BiddingTieBreaker { get; set; }



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
            sb.Append("class WorkPlanBidRanks {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkPlanBiddingPerformance: ").Append(WorkPlanBiddingPerformance).Append("\n");
            sb.Append("  BiddingTieBreaker: ").Append(BiddingTieBreaker).Append("\n");
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
            return this.Equals(obj as WorkPlanBidRanks);
        }

        /// <summary>
        /// Returns true if WorkPlanBidRanks instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanBidRanks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanBidRanks other)
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
                    this.WorkPlanBiddingPerformance == other.WorkPlanBiddingPerformance ||
                    this.WorkPlanBiddingPerformance != null &&
                    this.WorkPlanBiddingPerformance.Equals(other.WorkPlanBiddingPerformance)
                ) &&
                (
                    this.BiddingTieBreaker == other.BiddingTieBreaker ||
                    this.BiddingTieBreaker != null &&
                    this.BiddingTieBreaker.Equals(other.BiddingTieBreaker)
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

                if (this.WorkPlanBiddingPerformance != null)
                    hash = hash * 59 + this.WorkPlanBiddingPerformance.GetHashCode();

                if (this.BiddingTieBreaker != null)
                    hash = hash * 59 + this.BiddingTieBreaker.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
