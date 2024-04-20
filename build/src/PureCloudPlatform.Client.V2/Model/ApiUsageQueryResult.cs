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
    /// ApiUsageQueryResult
    /// </summary>
    [DataContract]
    public partial class ApiUsageQueryResult :  IEquatable<ApiUsageQueryResult>
    {
        /// <summary>
        /// Query status
        /// </summary>
        /// <value>Query status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Running for "Running"
            /// </summary>
            [EnumMember(Value = "Running")]
            Running
        }
        /// <summary>
        /// Query status
        /// </summary>
        /// <value>Query status</value>
        [DataMember(Name="queryStatus", EmitDefaultValue=false)]
        public QueryStatusEnum? QueryStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsageQueryResult" /> class.
        /// </summary>
        /// <param name="Results">Query results.</param>
        /// <param name="QueryStatus">Query status.</param>
        /// <param name="Cursors">Cursor tokens to be used for navigating paginated results.</param>
        public ApiUsageQueryResult(List<ApiUsageRow> Results = null, QueryStatusEnum? QueryStatus = null, Cursors Cursors = null)
        {
            this.Results = Results;
            this.QueryStatus = QueryStatus;
            this.Cursors = Cursors;
            
        }
        


        /// <summary>
        /// Query results
        /// </summary>
        /// <value>Query results</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<ApiUsageRow> Results { get; set; }





        /// <summary>
        /// Cursor tokens to be used for navigating paginated results
        /// </summary>
        /// <value>Cursor tokens to be used for navigating paginated results</value>
        [DataMember(Name="cursors", EmitDefaultValue=false)]
        public Cursors Cursors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiUsageQueryResult {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  QueryStatus: ").Append(QueryStatus).Append("\n");
            sb.Append("  Cursors: ").Append(Cursors).Append("\n");
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
            return this.Equals(obj as ApiUsageQueryResult);
        }

        /// <summary>
        /// Returns true if ApiUsageQueryResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiUsageQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiUsageQueryResult other)
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
                    this.QueryStatus == other.QueryStatus ||
                    this.QueryStatus != null &&
                    this.QueryStatus.Equals(other.QueryStatus)
                ) &&
                (
                    this.Cursors == other.Cursors ||
                    this.Cursors != null &&
                    this.Cursors.Equals(other.Cursors)
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

                if (this.QueryStatus != null)
                    hash = hash * 59 + this.QueryStatus.GetHashCode();

                if (this.Cursors != null)
                    hash = hash * 59 + this.Cursors.GetHashCode();

                return hash;
            }
        }
    }

}
