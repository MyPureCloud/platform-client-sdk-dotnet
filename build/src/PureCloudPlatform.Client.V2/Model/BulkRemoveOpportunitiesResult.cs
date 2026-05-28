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
    /// BulkRemoveOpportunitiesResult
    /// </summary>
    [DataContract]
    public partial class BulkRemoveOpportunitiesResult :  IEquatable<BulkRemoveOpportunitiesResult>
    {
        /// <summary>
        /// The status indicating the result of the bulk operation for this item
        /// </summary>
        /// <value>The status indicating the result of the bulk operation for this item</value>
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
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The status indicating the result of the bulk operation for this item
        /// </summary>
        /// <value>The status indicating the result of the bulk operation for this item</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveOpportunitiesResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkRemoveOpportunitiesResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveOpportunitiesResult" /> class.
        /// </summary>
        /// <param name="Status">The status indicating the result of the bulk operation for this item (required).</param>
        /// <param name="Error">The error result if the operation failed.</param>
        /// <param name="OpportunityId">The ID of the opportunity (required).</param>
        public BulkRemoveOpportunitiesResult(StatusEnum? Status = null, BulkOpportunitiesError Error = null, string OpportunityId = null)
        {
            this.Status = Status;
            this.Error = Error;
            this.OpportunityId = OpportunityId;
            
        }
        




        /// <summary>
        /// The error result if the operation failed
        /// </summary>
        /// <value>The error result if the operation failed</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public BulkOpportunitiesError Error { get; set; }



        /// <summary>
        /// The ID of the opportunity
        /// </summary>
        /// <value>The ID of the opportunity</value>
        [DataMember(Name="opportunityId", EmitDefaultValue=false)]
        public string OpportunityId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkRemoveOpportunitiesResult {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  OpportunityId: ").Append(OpportunityId).Append("\n");
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
            return this.Equals(obj as BulkRemoveOpportunitiesResult);
        }

        /// <summary>
        /// Returns true if BulkRemoveOpportunitiesResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkRemoveOpportunitiesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkRemoveOpportunitiesResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.OpportunityId == other.OpportunityId ||
                    this.OpportunityId != null &&
                    this.OpportunityId.Equals(other.OpportunityId)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.OpportunityId != null)
                    hash = hash * 59 + this.OpportunityId.GetHashCode();

                return hash;
            }
        }
    }

}
