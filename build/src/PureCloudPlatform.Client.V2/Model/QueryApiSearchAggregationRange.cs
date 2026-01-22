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
    /// QueryApiSearchAggregationRange
    /// </summary>
    [DataContract]
    public partial class QueryApiSearchAggregationRange :  IEquatable<QueryApiSearchAggregationRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryApiSearchAggregationRange" /> class.
        /// </summary>
        /// <param name="To">To.</param>
        /// <param name="From">From.</param>
        public QueryApiSearchAggregationRange(double? To = null, double? From = null)
        {
            this.To = To;
            this.From = From;
            
        }
        


        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public double? To { get; set; }



        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public double? From { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryApiSearchAggregationRange {\n");

            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
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
            return this.Equals(obj as QueryApiSearchAggregationRange);
        }

        /// <summary>
        /// Returns true if QueryApiSearchAggregationRange instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryApiSearchAggregationRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryApiSearchAggregationRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
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
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                return hash;
            }
        }
    }

}
