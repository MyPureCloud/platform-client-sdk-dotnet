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
    /// RowSearchFilter
    /// </summary>
    [DataContract]
    public partial class RowSearchFilter :  IEquatable<RowSearchFilter>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RowSearchFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RowSearchFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RowSearchFilter" /> class.
        /// </summary>
        /// <param name="Predicates">The predicates that each row matches in the search results must match (required).</param>
        public RowSearchFilter(List<RowSearchPredicate> Predicates = null)
        {
            this.Predicates = Predicates;
            
        }
        


        /// <summary>
        /// The predicates that each row matches in the search results must match
        /// </summary>
        /// <value>The predicates that each row matches in the search results must match</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<RowSearchPredicate> Predicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowSearchFilter {\n");

            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as RowSearchFilter);
        }

        /// <summary>
        /// Returns true if RowSearchFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of RowSearchFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowSearchFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                return hash;
            }
        }
    }

}
