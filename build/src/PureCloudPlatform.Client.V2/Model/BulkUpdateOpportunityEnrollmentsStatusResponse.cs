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
    /// BulkUpdateOpportunityEnrollmentsStatusResponse
    /// </summary>
    [DataContract]
    public partial class BulkUpdateOpportunityEnrollmentsStatusResponse :  IEquatable<BulkUpdateOpportunityEnrollmentsStatusResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateOpportunityEnrollmentsStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkUpdateOpportunityEnrollmentsStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateOpportunityEnrollmentsStatusResponse" /> class.
        /// </summary>
        /// <param name="Results">The result for each requested item (required).</param>
        /// <param name="ErrorCount">The count of failed operations in the bulk request (required).</param>
        public BulkUpdateOpportunityEnrollmentsStatusResponse(List<BulkOpportunitiesEnrollmentResult> Results = null, int? ErrorCount = null)
        {
            this.Results = Results;
            this.ErrorCount = ErrorCount;
            
        }
        


        /// <summary>
        /// The result for each requested item
        /// </summary>
        /// <value>The result for each requested item</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BulkOpportunitiesEnrollmentResult> Results { get; set; }



        /// <summary>
        /// The count of failed operations in the bulk request
        /// </summary>
        /// <value>The count of failed operations in the bulk request</value>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateOpportunityEnrollmentsStatusResponse {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
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
            return this.Equals(obj as BulkUpdateOpportunityEnrollmentsStatusResponse);
        }

        /// <summary>
        /// Returns true if BulkUpdateOpportunityEnrollmentsStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateOpportunityEnrollmentsStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateOpportunityEnrollmentsStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.ErrorCount == other.ErrorCount ||
                    this.ErrorCount != null &&
                    this.ErrorCount.Equals(other.ErrorCount)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.ErrorCount != null)
                    hash = hash * 59 + this.ErrorCount.GetHashCode();

                return hash;
            }
        }
    }

}
