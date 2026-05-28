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
    /// BulkAddOpportunitiesResponse
    /// </summary>
    [DataContract]
    public partial class BulkAddOpportunitiesResponse :  IEquatable<BulkAddOpportunitiesResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddOpportunitiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkAddOpportunitiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddOpportunitiesResponse" /> class.
        /// </summary>
        /// <param name="Opportunities">The list of opportunities (required).</param>
        public BulkAddOpportunitiesResponse(List<OpportunityResult> Opportunities = null)
        {
            this.Opportunities = Opportunities;
            
        }
        


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
            sb.Append("class BulkAddOpportunitiesResponse {\n");

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
            return this.Equals(obj as BulkAddOpportunitiesResponse);
        }

        /// <summary>
        /// Returns true if BulkAddOpportunitiesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkAddOpportunitiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAddOpportunitiesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Opportunities != null)
                    hash = hash * 59 + this.Opportunities.GetHashCode();

                return hash;
            }
        }
    }

}
