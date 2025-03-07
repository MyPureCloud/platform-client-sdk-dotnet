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
    /// A group of logical or a singular criteria used to create a query of executionData
    /// </summary>
    [DataContract]
    public partial class CriteriaGroup :  IEquatable<CriteriaGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaGroup" /> class.
        /// </summary>
        /// <param name="And">These criteriaItems will be AND&#39;d together to find a match..</param>
        /// <param name="Or">These criteriaItems will be OR&#39;d together to find a match..</param>
        /// <param name="Not">These criteriaItems must all be false to find a match..</param>
        /// <param name="Criteria">A singular critieriaItem to match..</param>
        public CriteriaGroup(List<CriteriaItem> And = null, List<CriteriaItem> Or = null, List<CriteriaItem> Not = null, CriteriaItem Criteria = null)
        {
            this.And = And;
            this.Or = Or;
            this.Not = Not;
            this.Criteria = Criteria;
            
        }
        


        /// <summary>
        /// These criteriaItems will be AND&#39;d together to find a match.
        /// </summary>
        /// <value>These criteriaItems will be AND&#39;d together to find a match.</value>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public List<CriteriaItem> And { get; set; }



        /// <summary>
        /// These criteriaItems will be OR&#39;d together to find a match.
        /// </summary>
        /// <value>These criteriaItems will be OR&#39;d together to find a match.</value>
        [DataMember(Name="or", EmitDefaultValue=false)]
        public List<CriteriaItem> Or { get; set; }



        /// <summary>
        /// These criteriaItems must all be false to find a match.
        /// </summary>
        /// <value>These criteriaItems must all be false to find a match.</value>
        [DataMember(Name="not", EmitDefaultValue=false)]
        public List<CriteriaItem> Not { get; set; }



        /// <summary>
        /// A singular critieriaItem to match.
        /// </summary>
        /// <value>A singular critieriaItem to match.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public CriteriaItem Criteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriteriaGroup {\n");

            sb.Append("  And: ").Append(And).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
            sb.Append("  Not: ").Append(Not).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return this.Equals(obj as CriteriaGroup);
        }

        /// <summary>
        /// Returns true if CriteriaGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of CriteriaGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CriteriaGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.And == other.And ||
                    this.And != null &&
                    this.And.SequenceEqual(other.And)
                ) &&
                (
                    this.Or == other.Or ||
                    this.Or != null &&
                    this.Or.SequenceEqual(other.Or)
                ) &&
                (
                    this.Not == other.Not ||
                    this.Not != null &&
                    this.Not.SequenceEqual(other.Not)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.Equals(other.Criteria)
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
                if (this.And != null)
                    hash = hash * 59 + this.And.GetHashCode();

                if (this.Or != null)
                    hash = hash * 59 + this.Or.GetHashCode();

                if (this.Not != null)
                    hash = hash * 59 + this.Not.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                return hash;
            }
        }
    }

}
