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
    /// QueryOpportunityEnrollmentsRequest
    /// </summary>
    [DataContract]
    public partial class QueryOpportunityEnrollmentsRequest :  IEquatable<QueryOpportunityEnrollmentsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOpportunityEnrollmentsRequest" /> class.
        /// </summary>
        /// <param name="Range">The date range for the query. Exactly one of opportunityId or range must be set.</param>
        /// <param name="OpportunityId">The ID of the specific opportunity by which to filter. Exactly one of opportunityId or range must be set.</param>
        public QueryOpportunityEnrollmentsRequest(RequiredDateRange Range = null, string OpportunityId = null)
        {
            this.Range = Range;
            this.OpportunityId = OpportunityId;
            
        }
        


        /// <summary>
        /// The date range for the query. Exactly one of opportunityId or range must be set
        /// </summary>
        /// <value>The date range for the query. Exactly one of opportunityId or range must be set</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public RequiredDateRange Range { get; set; }



        /// <summary>
        /// The ID of the specific opportunity by which to filter. Exactly one of opportunityId or range must be set
        /// </summary>
        /// <value>The ID of the specific opportunity by which to filter. Exactly one of opportunityId or range must be set</value>
        [DataMember(Name="opportunityId", EmitDefaultValue=false)]
        public string OpportunityId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOpportunityEnrollmentsRequest {\n");

            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as QueryOpportunityEnrollmentsRequest);
        }

        /// <summary>
        /// Returns true if QueryOpportunityEnrollmentsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOpportunityEnrollmentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOpportunityEnrollmentsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                if (this.OpportunityId != null)
                    hash = hash * 59 + this.OpportunityId.GetHashCode();

                return hash;
            }
        }
    }

}
