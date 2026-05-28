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
    /// QueryOpportunitiesRequest
    /// </summary>
    [DataContract]
    public partial class QueryOpportunitiesRequest :  IEquatable<QueryOpportunitiesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOpportunitiesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryOpportunitiesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOpportunitiesRequest" /> class.
        /// </summary>
        /// <param name="Range">The date range for the query (required).</param>
        public QueryOpportunitiesRequest(RequiredDateRange Range = null)
        {
            this.Range = Range;
            
        }
        


        /// <summary>
        /// The date range for the query
        /// </summary>
        /// <value>The date range for the query</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public RequiredDateRange Range { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOpportunitiesRequest {\n");

            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as QueryOpportunitiesRequest);
        }

        /// <summary>
        /// Returns true if QueryOpportunitiesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOpportunitiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOpportunitiesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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

                return hash;
            }
        }
    }

}
