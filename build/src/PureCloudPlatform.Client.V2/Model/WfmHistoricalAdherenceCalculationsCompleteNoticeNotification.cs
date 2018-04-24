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
    /// WfmHistoricalAdherenceCalculationsCompleteNoticeNotification
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceCalculationsCompleteNoticeNotification :  IEquatable<WfmHistoricalAdherenceCalculationsCompleteNoticeNotification>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets QueryState
        /// </summary>
        [DataMember(Name="queryState", EmitDefaultValue=false)]
        public QueryStateEnum? QueryState { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceCalculationsCompleteNoticeNotification" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="DownloadUrl">DownloadUrl.</param>
        
        
        
        /// <param name="QueryState">QueryState.</param>
        
        
        public WfmHistoricalAdherenceCalculationsCompleteNoticeNotification(string Id = null, string DownloadUrl = null, QueryStateEnum? QueryState = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.DownloadUrl = DownloadUrl;
            
            
            
            
            
            
            
            
this.QueryState = QueryState;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceCalculationsCompleteNoticeNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WfmHistoricalAdherenceCalculationsCompleteNoticeNotification);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceCalculationsCompleteNoticeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceCalculationsCompleteNoticeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceCalculationsCompleteNoticeNotification other)
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
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                
                if (this.QueryState != null)
                    hash = hash * 59 + this.QueryState.GetHashCode();
                
                return hash;
            }
        }
    }

}
