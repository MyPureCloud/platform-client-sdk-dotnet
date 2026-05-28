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
    /// QueryExternalActivityOpportunityResult
    /// </summary>
    [DataContract]
    public partial class QueryExternalActivityOpportunityResult :  IEquatable<QueryExternalActivityOpportunityResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExternalActivityOpportunityResult" /> class.
        /// </summary>
        /// <param name="OpportunityName">The name of the opportunity associated with this external activity.</param>
        public QueryExternalActivityOpportunityResult(string OpportunityName = null)
        {
            this.OpportunityName = OpportunityName;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the opportunity associated with this external activity
        /// </summary>
        /// <value>The name of the opportunity associated with this external activity</value>
        [DataMember(Name="opportunityName", EmitDefaultValue=false)]
        public string OpportunityName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryExternalActivityOpportunityResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OpportunityName: ").Append(OpportunityName).Append("\n");
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
            return this.Equals(obj as QueryExternalActivityOpportunityResult);
        }

        /// <summary>
        /// Returns true if QueryExternalActivityOpportunityResult instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryExternalActivityOpportunityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryExternalActivityOpportunityResult other)
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
                    this.OpportunityName == other.OpportunityName ||
                    this.OpportunityName != null &&
                    this.OpportunityName.Equals(other.OpportunityName)
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

                if (this.OpportunityName != null)
                    hash = hash * 59 + this.OpportunityName.GetHashCode();

                return hash;
            }
        }
    }

}
