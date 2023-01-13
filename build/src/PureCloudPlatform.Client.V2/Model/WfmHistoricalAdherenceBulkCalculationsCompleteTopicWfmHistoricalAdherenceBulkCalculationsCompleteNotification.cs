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
    /// WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification :  IEquatable<WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification>
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
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DownloadUrls">DownloadUrls.</param>
        /// <param name="QueryState">QueryState.</param>
        public WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification(string Id = null, List<string> DownloadUrls = null, QueryStateEnum? QueryState = null)
        {
            this.Id = Id;
            this.DownloadUrls = DownloadUrls;
            this.QueryState = QueryState;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets DownloadUrls
        /// </summary>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  QueryState: ").Append(QueryState).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkCalculationsCompleteTopicWfmHistoricalAdherenceBulkCalculationsCompleteNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DownloadUrls == other.DownloadUrls ||
                    this.DownloadUrls != null &&
                    this.DownloadUrls.SequenceEqual(other.DownloadUrls)
                ) &&
                (
                    this.QueryState == other.QueryState ||
                    this.QueryState != null &&
                    this.QueryState.Equals(other.QueryState)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.QueryState != null)
                    hash = hash * 59 + this.QueryState.GetHashCode();

                return hash;
            }
        }
    }

}
