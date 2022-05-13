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
    /// Used to query for responses
    /// </summary>
    [DataContract]
    public partial class ResponseQueryRequest :  IEquatable<ResponseQueryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueryRequest" /> class.
        /// </summary>
        /// <param name="QueryPhrase">Query phrase to search response text and name. If not set will match all..</param>
        /// <param name="PageSize">The maximum number of hits to return. Default: 25, Maximum: 500..</param>
        /// <param name="Filters">Filter the query results..</param>
        public ResponseQueryRequest(string QueryPhrase = null, int? PageSize = null, List<ResponseFilter> Filters = null)
        {
            this.QueryPhrase = QueryPhrase;
            this.PageSize = PageSize;
            this.Filters = Filters;
            
        }
        


        /// <summary>
        /// Query phrase to search response text and name. If not set will match all.
        /// </summary>
        /// <value>Query phrase to search response text and name. If not set will match all.</value>
        [DataMember(Name="queryPhrase", EmitDefaultValue=false)]
        public string QueryPhrase { get; set; }



        /// <summary>
        /// The maximum number of hits to return. Default: 25, Maximum: 500.
        /// </summary>
        /// <value>The maximum number of hits to return. Default: 25, Maximum: 500.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Filter the query results.
        /// </summary>
        /// <value>Filter the query results.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<ResponseFilter> Filters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseQueryRequest {\n");

            sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as ResponseQueryRequest);
        }

        /// <summary>
        /// Returns true if ResponseQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueryPhrase == other.QueryPhrase ||
                    this.QueryPhrase != null &&
                    this.QueryPhrase.Equals(other.QueryPhrase)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
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
                if (this.QueryPhrase != null)
                    hash = hash * 59 + this.QueryPhrase.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                return hash;
            }
        }
    }

}
