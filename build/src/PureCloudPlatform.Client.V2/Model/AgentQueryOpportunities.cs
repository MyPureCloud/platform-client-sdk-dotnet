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
    /// AgentQueryOpportunities
    /// </summary>
    [DataContract]
    public partial class AgentQueryOpportunities :  IEquatable<AgentQueryOpportunities>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueryOpportunities" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentQueryOpportunities() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueryOpportunities" /> class.
        /// </summary>
        /// <param name="NextStartDate">The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results.</param>
        /// <param name="BusinessUnits">The opportunities for the agent grouped by business unit (required).</param>
        public AgentQueryOpportunities(DateTime? NextStartDate = null, List<AgentBusinessUnitOpportunities> BusinessUnits = null)
        {
            this.NextStartDate = NextStartDate;
            this.BusinessUnits = BusinessUnits;
            
        }
        


        /// <summary>
        /// The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results
        /// </summary>
        /// <value>The start date to use for the next query to retrieve additional results in ISO-8601 format. Null if there are no more results</value>
        [DataMember(Name="nextStartDate", EmitDefaultValue=false)]
        public DateTime? NextStartDate { get; set; }



        /// <summary>
        /// The opportunities for the agent grouped by business unit
        /// </summary>
        /// <value>The opportunities for the agent grouped by business unit</value>
        [DataMember(Name="businessUnits", EmitDefaultValue=false)]
        public List<AgentBusinessUnitOpportunities> BusinessUnits { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentQueryOpportunities {\n");

            sb.Append("  NextStartDate: ").Append(NextStartDate).Append("\n");
            sb.Append("  BusinessUnits: ").Append(BusinessUnits).Append("\n");
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
            return this.Equals(obj as AgentQueryOpportunities);
        }

        /// <summary>
        /// Returns true if AgentQueryOpportunities instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentQueryOpportunities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentQueryOpportunities other)
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
                    this.BusinessUnits == other.BusinessUnits ||
                    this.BusinessUnits != null &&
                    this.BusinessUnits.SequenceEqual(other.BusinessUnits)
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

                if (this.BusinessUnits != null)
                    hash = hash * 59 + this.BusinessUnits.GetHashCode();

                return hash;
            }
        }
    }

}
