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
    /// BulkSourceIntentsResponse
    /// </summary>
    [DataContract]
    public partial class BulkSourceIntentsResponse :  IEquatable<BulkSourceIntentsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSourceIntentsResponse" /> class.
        /// </summary>
        /// <param name="Results">Results of operation.</param>
        /// <param name="ErrorCount">Count of errors.</param>
        /// <param name="ErrorResultIds">List of ids failed to be added or removed.</param>
        public BulkSourceIntentsResponse(List<BulkResults> Results = null, int? ErrorCount = null, List<string> ErrorResultIds = null)
        {
            this.Results = Results;
            this.ErrorCount = ErrorCount;
            this.ErrorResultIds = ErrorResultIds;
            
        }
        


        /// <summary>
        /// Results of operation
        /// </summary>
        /// <value>Results of operation</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BulkResults> Results { get; set; }



        /// <summary>
        /// Count of errors
        /// </summary>
        /// <value>Count of errors</value>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }



        /// <summary>
        /// List of ids failed to be added or removed
        /// </summary>
        /// <value>List of ids failed to be added or removed</value>
        [DataMember(Name="errorResultIds", EmitDefaultValue=false)]
        public List<string> ErrorResultIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSourceIntentsResponse {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  ErrorResultIds: ").Append(ErrorResultIds).Append("\n");
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
            return this.Equals(obj as BulkSourceIntentsResponse);
        }

        /// <summary>
        /// Returns true if BulkSourceIntentsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSourceIntentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSourceIntentsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.ErrorCount == other.ErrorCount ||
                    this.ErrorCount != null &&
                    this.ErrorCount.Equals(other.ErrorCount)
                ) &&
                (
                    this.ErrorResultIds == other.ErrorResultIds ||
                    this.ErrorResultIds != null &&
                    this.ErrorResultIds.SequenceEqual(other.ErrorResultIds)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.ErrorCount != null)
                    hash = hash * 59 + this.ErrorCount.GetHashCode();

                if (this.ErrorResultIds != null)
                    hash = hash * 59 + this.ErrorResultIds.GetHashCode();

                return hash;
            }
        }
    }

}
