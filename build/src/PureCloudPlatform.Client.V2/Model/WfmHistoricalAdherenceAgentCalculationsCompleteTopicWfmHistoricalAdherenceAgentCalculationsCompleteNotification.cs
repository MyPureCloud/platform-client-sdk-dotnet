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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification>
    {
        /// <summary>
        /// Gets or Sets QueryState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }
        /// <summary>
        /// Gets or Sets QueryState
        /// </summary>
        [DataMember(Name="queryState", EmitDefaultValue=false)]
        public QueryStateEnum? QueryState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="QueryState">QueryState.</param>
        /// <param name="DownloadUrls">DownloadUrls.</param>
        /// <param name="Result">Result.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification(string JobId = null, QueryStateEnum? QueryState = null, List<string> DownloadUrls = null, WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult Result = null)
        {
            this.JobId = JobId;
            this.QueryState = QueryState;
            this.DownloadUrls = DownloadUrls;
            this.Result = Result;
            
        }
        


        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }





        /// <summary>
        /// Gets or Sets DownloadUrls
        /// </summary>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult Result { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification {\n");

            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  QueryState: ").Append(QueryState).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentCalculationsCompleteNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.QueryState == other.QueryState ||
                    this.QueryState != null &&
                    this.QueryState.Equals(other.QueryState)
                ) &&
                (
                    this.DownloadUrls == other.DownloadUrls ||
                    this.DownloadUrls != null &&
                    this.DownloadUrls.SequenceEqual(other.DownloadUrls)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.QueryState != null)
                    hash = hash * 59 + this.QueryState.GetHashCode();

                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                return hash;
            }
        }
    }

}
