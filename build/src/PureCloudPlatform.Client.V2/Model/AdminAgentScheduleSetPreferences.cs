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
    /// AdminAgentScheduleSetPreferences
    /// </summary>
    [DataContract]
    public partial class AdminAgentScheduleSetPreferences :  IEquatable<AdminAgentScheduleSetPreferences>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentScheduleSetPreferences" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminAgentScheduleSetPreferences() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentScheduleSetPreferences" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Bid">The schedule bid.</param>
        /// <param name="BidGroup">The schedule bid group.</param>
        /// <param name="AgentsScheduleBidPreferences">The agents&#39; schedule bidding preferences (required).</param>
        public AdminAgentScheduleSetPreferences(string Id = null, ScheduleBidReference Bid = null, ScheduleBidGroupReference BidGroup = null, List<AdminAgentScheduleBidBiddingPreference> AgentsScheduleBidPreferences = null)
        {
            this.Id = Id;
            this.Bid = Bid;
            this.BidGroup = BidGroup;
            this.AgentsScheduleBidPreferences = AgentsScheduleBidPreferences;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The schedule bid
        /// </summary>
        /// <value>The schedule bid</value>
        [DataMember(Name="bid", EmitDefaultValue=false)]
        public ScheduleBidReference Bid { get; set; }



        /// <summary>
        /// The schedule bid group
        /// </summary>
        /// <value>The schedule bid group</value>
        [DataMember(Name="bidGroup", EmitDefaultValue=false)]
        public ScheduleBidGroupReference BidGroup { get; set; }



        /// <summary>
        /// The agents&#39; schedule bidding preferences
        /// </summary>
        /// <value>The agents&#39; schedule bidding preferences</value>
        [DataMember(Name="agentsScheduleBidPreferences", EmitDefaultValue=false)]
        public List<AdminAgentScheduleBidBiddingPreference> AgentsScheduleBidPreferences { get; set; }



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
            sb.Append("class AdminAgentScheduleSetPreferences {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  BidGroup: ").Append(BidGroup).Append("\n");
            sb.Append("  AgentsScheduleBidPreferences: ").Append(AgentsScheduleBidPreferences).Append("\n");
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
            return this.Equals(obj as AdminAgentScheduleSetPreferences);
        }

        /// <summary>
        /// Returns true if AdminAgentScheduleSetPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminAgentScheduleSetPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAgentScheduleSetPreferences other)
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
                    this.Bid == other.Bid ||
                    this.Bid != null &&
                    this.Bid.Equals(other.Bid)
                ) &&
                (
                    this.BidGroup == other.BidGroup ||
                    this.BidGroup != null &&
                    this.BidGroup.Equals(other.BidGroup)
                ) &&
                (
                    this.AgentsScheduleBidPreferences == other.AgentsScheduleBidPreferences ||
                    this.AgentsScheduleBidPreferences != null &&
                    this.AgentsScheduleBidPreferences.SequenceEqual(other.AgentsScheduleBidPreferences)
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

                if (this.Bid != null)
                    hash = hash * 59 + this.Bid.GetHashCode();

                if (this.BidGroup != null)
                    hash = hash * 59 + this.BidGroup.GetHashCode();

                if (this.AgentsScheduleBidPreferences != null)
                    hash = hash * 59 + this.AgentsScheduleBidPreferences.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
