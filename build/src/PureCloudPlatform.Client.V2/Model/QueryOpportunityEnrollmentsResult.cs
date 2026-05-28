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
    /// QueryOpportunityEnrollmentsResult
    /// </summary>
    [DataContract]
    public partial class QueryOpportunityEnrollmentsResult :  IEquatable<QueryOpportunityEnrollmentsResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOpportunityEnrollmentsResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryOpportunityEnrollmentsResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOpportunityEnrollmentsResult" /> class.
        /// </summary>
        /// <param name="NextStartDate">The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results.</param>
        /// <param name="Enrollments">The enrollments for the query operation (required).</param>
        /// <param name="Opportunities">The referenced opportunities when expand&#x3D;opportunities is specified.</param>
        public QueryOpportunityEnrollmentsResult(DateTime? NextStartDate = null, List<QueryOpportunityEnrollmentResult> Enrollments = null, List<QueryEnrollmentOpportunityResult> Opportunities = null)
        {
            this.NextStartDate = NextStartDate;
            this.Enrollments = Enrollments;
            this.Opportunities = Opportunities;
            
        }
        


        /// <summary>
        /// The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results
        /// </summary>
        /// <value>The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results</value>
        [DataMember(Name="nextStartDate", EmitDefaultValue=false)]
        public DateTime? NextStartDate { get; set; }



        /// <summary>
        /// The enrollments for the query operation
        /// </summary>
        /// <value>The enrollments for the query operation</value>
        [DataMember(Name="enrollments", EmitDefaultValue=false)]
        public List<QueryOpportunityEnrollmentResult> Enrollments { get; set; }



        /// <summary>
        /// The referenced opportunities when expand&#x3D;opportunities is specified
        /// </summary>
        /// <value>The referenced opportunities when expand&#x3D;opportunities is specified</value>
        [DataMember(Name="opportunities", EmitDefaultValue=false)]
        public List<QueryEnrollmentOpportunityResult> Opportunities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOpportunityEnrollmentsResult {\n");

            sb.Append("  NextStartDate: ").Append(NextStartDate).Append("\n");
            sb.Append("  Enrollments: ").Append(Enrollments).Append("\n");
            sb.Append("  Opportunities: ").Append(Opportunities).Append("\n");
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
            return this.Equals(obj as QueryOpportunityEnrollmentsResult);
        }

        /// <summary>
        /// Returns true if QueryOpportunityEnrollmentsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOpportunityEnrollmentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOpportunityEnrollmentsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NextStartDate == other.NextStartDate ||
                    this.NextStartDate != null &&
                    this.NextStartDate.Equals(other.NextStartDate)
                ) &&
                (
                    this.Enrollments == other.Enrollments ||
                    this.Enrollments != null &&
                    this.Enrollments.SequenceEqual(other.Enrollments)
                ) &&
                (
                    this.Opportunities == other.Opportunities ||
                    this.Opportunities != null &&
                    this.Opportunities.SequenceEqual(other.Opportunities)
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
                if (this.NextStartDate != null)
                    hash = hash * 59 + this.NextStartDate.GetHashCode();

                if (this.Enrollments != null)
                    hash = hash * 59 + this.Enrollments.GetHashCode();

                if (this.Opportunities != null)
                    hash = hash * 59 + this.Opportunities.GetHashCode();

                return hash;
            }
        }
    }

}
