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
    /// BulkUpdateAgentUnavailableTimesResponse
    /// </summary>
    [DataContract]
    public partial class BulkUpdateAgentUnavailableTimesResponse :  IEquatable<BulkUpdateAgentUnavailableTimesResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateAgentUnavailableTimesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkUpdateAgentUnavailableTimesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateAgentUnavailableTimesResponse" /> class.
        /// </summary>
        /// <param name="Results">The result of each unavailable time operation, in the order the operations were requested (required).</param>
        /// <param name="Error">The error that stopped processing, populated when one or more operations failed.</param>
        public BulkUpdateAgentUnavailableTimesResponse(List<BulkUpdateAgentUnavailableTimesResultItem> Results = null, ErrorBody Error = null)
        {
            this.Results = Results;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The result of each unavailable time operation, in the order the operations were requested
        /// </summary>
        /// <value>The result of each unavailable time operation, in the order the operations were requested</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BulkUpdateAgentUnavailableTimesResultItem> Results { get; set; }



        /// <summary>
        /// The error that stopped processing, populated when one or more operations failed
        /// </summary>
        /// <value>The error that stopped processing, populated when one or more operations failed</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateAgentUnavailableTimesResponse {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as BulkUpdateAgentUnavailableTimesResponse);
        }

        /// <summary>
        /// Returns true if BulkUpdateAgentUnavailableTimesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateAgentUnavailableTimesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateAgentUnavailableTimesResponse other)
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
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
