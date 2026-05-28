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
    /// BulkOpportunitiesReferenceResult
    /// </summary>
    [DataContract]
    public partial class BulkOpportunitiesReferenceResult :  IEquatable<BulkOpportunitiesReferenceResult>
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
        /// Initializes a new instance of the <see cref="BulkOpportunitiesReferenceResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkOpportunitiesReferenceResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunitiesReferenceResult" /> class.
        /// </summary>
        /// <param name="Status">The status indicating the result of the bulk operation for this item (required).</param>
        /// <param name="Error">The error result if the operation failed.</param>
        /// <param name="Opportunity">Reference to the opportunity (required).</param>
        public BulkOpportunitiesReferenceResult(StatusEnum? Status = null, BulkOpportunitiesError Error = null, OpportunityReference Opportunity = null)
        {
            this.Status = Status;
            this.Error = Error;
            this.Opportunity = Opportunity;
            
        }
        




        /// <summary>
        /// The error result if the operation failed
        /// </summary>
        /// <value>The error result if the operation failed</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public BulkOpportunitiesError Error { get; set; }



        /// <summary>
        /// Reference to the opportunity
        /// </summary>
        /// <value>Reference to the opportunity</value>
        [DataMember(Name="opportunity", EmitDefaultValue=false)]
        public OpportunityReference Opportunity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkOpportunitiesReferenceResult {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Opportunity: ").Append(Opportunity).Append("\n");
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
            return this.Equals(obj as BulkOpportunitiesReferenceResult);
        }

        /// <summary>
        /// Returns true if BulkOpportunitiesReferenceResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkOpportunitiesReferenceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkOpportunitiesReferenceResult other)
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
                    this.Opportunity == other.Opportunity ||
                    this.Opportunity != null &&
                    this.Opportunity.Equals(other.Opportunity)
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

                if (this.Opportunity != null)
                    hash = hash * 59 + this.Opportunity.GetHashCode();

                return hash;
            }
        }
    }

}
