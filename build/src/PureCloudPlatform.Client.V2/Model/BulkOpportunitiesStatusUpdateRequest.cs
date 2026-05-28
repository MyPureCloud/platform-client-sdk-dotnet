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
    /// BulkOpportunitiesStatusUpdateRequest
    /// </summary>
    [DataContract]
    public partial class BulkOpportunitiesStatusUpdateRequest :  IEquatable<BulkOpportunitiesStatusUpdateRequest>
    {
        /// <summary>
        /// The status to set for all opportunities specified in this request
        /// </summary>
        /// <value>The status to set for all opportunities specified in this request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed
        }
        /// <summary>
        /// The status to set for all opportunities specified in this request
        /// </summary>
        /// <value>The status to set for all opportunities specified in this request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunitiesStatusUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkOpportunitiesStatusUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunitiesStatusUpdateRequest" /> class.
        /// </summary>
        /// <param name="OpportunityIds">The IDs of the opportunities to update (required).</param>
        /// <param name="Status">The status to set for all opportunities specified in this request (required).</param>
        public BulkOpportunitiesStatusUpdateRequest(List<string> OpportunityIds = null, StatusEnum? Status = null)
        {
            this.OpportunityIds = OpportunityIds;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// The IDs of the opportunities to update
        /// </summary>
        /// <value>The IDs of the opportunities to update</value>
        [DataMember(Name="opportunityIds", EmitDefaultValue=false)]
        public List<string> OpportunityIds { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkOpportunitiesStatusUpdateRequest {\n");

            sb.Append("  OpportunityIds: ").Append(OpportunityIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as BulkOpportunitiesStatusUpdateRequest);
        }

        /// <summary>
        /// Returns true if BulkOpportunitiesStatusUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkOpportunitiesStatusUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkOpportunitiesStatusUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OpportunityIds == other.OpportunityIds ||
                    this.OpportunityIds != null &&
                    this.OpportunityIds.SequenceEqual(other.OpportunityIds)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.OpportunityIds != null)
                    hash = hash * 59 + this.OpportunityIds.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
