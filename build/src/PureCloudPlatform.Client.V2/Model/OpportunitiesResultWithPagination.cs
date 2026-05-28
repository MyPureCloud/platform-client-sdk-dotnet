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
    /// OpportunitiesResultWithPagination
    /// </summary>
    [DataContract]
    public partial class OpportunitiesResultWithPagination :  IEquatable<OpportunitiesResultWithPagination>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunitiesResultWithPagination" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpportunitiesResultWithPagination() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunitiesResultWithPagination" /> class.
        /// </summary>
        /// <param name="NextStartDate">The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results.</param>
        /// <param name="Opportunities">The list of opportunities (required).</param>
        public OpportunitiesResultWithPagination(DateTime? NextStartDate = null, List<OpportunityResult> Opportunities = null)
        {
            this.NextStartDate = NextStartDate;
            this.Opportunities = Opportunities;
            
        }
        


        /// <summary>
        /// The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results
        /// </summary>
        /// <value>The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results</value>
        [DataMember(Name="nextStartDate", EmitDefaultValue=false)]
        public DateTime? NextStartDate { get; set; }



        /// <summary>
        /// The list of opportunities
        /// </summary>
        /// <value>The list of opportunities</value>
        [DataMember(Name="opportunities", EmitDefaultValue=false)]
        public List<OpportunityResult> Opportunities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpportunitiesResultWithPagination {\n");

            sb.Append("  NextStartDate: ").Append(NextStartDate).Append("\n");
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
            return this.Equals(obj as OpportunitiesResultWithPagination);
        }

        /// <summary>
        /// Returns true if OpportunitiesResultWithPagination instances are equal
        /// </summary>
        /// <param name="other">Instance of OpportunitiesResultWithPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunitiesResultWithPagination other)
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

                if (this.Opportunities != null)
                    hash = hash * 59 + this.Opportunities.GetHashCode();

                return hash;
            }
        }
    }

}
