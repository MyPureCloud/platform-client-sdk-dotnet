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
    /// EvaluationSearchResponse
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchResponse :  IEquatable<EvaluationSearchResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchResponse" /> class.
        /// </summary>
        public EvaluationSearchResponse()
        {
            
        }
        


        /// <summary>
        /// Number of records according to the page size
        /// </summary>
        /// <value>Number of records according to the page size</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; private set; }



        /// <summary>
        /// Current page number for the returned records
        /// </summary>
        /// <value>Current page number for the returned records</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; private set; }



        /// <summary>
        /// Results associated to the search response
        /// </summary>
        /// <value>Results associated to the search response</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<EvaluationResponse> Results { get; private set; }



        /// <summary>
        /// Aggregation results
        /// </summary>
        /// <value>Aggregation results</value>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public Dictionary<string, EvaluationSearchAggregationResponse> Aggregations { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchResponse {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
            return this.Equals(obj as EvaluationSearchResponse);
        }

        /// <summary>
        /// Returns true if EvaluationSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(other.Aggregations)
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
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.Aggregations != null)
                    hash = hash * 59 + this.Aggregations.GetHashCode();

                return hash;
            }
        }
    }

}
