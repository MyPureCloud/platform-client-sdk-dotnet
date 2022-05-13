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
    /// Response for Historical Adherence Query, intended to tell the client what to listen for on a notification topic
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceResponse :  IEquatable<WfmHistoricalAdherenceResponse>
    {
        /// <summary>
        /// The state of the adherence query
        /// </summary>
        /// <value>The state of the adherence query</value>
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
        /// The state of the adherence query
        /// </summary>
        /// <value>The state of the adherence query</value>
        [DataMember(Name="queryState", EmitDefaultValue=false)]
        public QueryStateEnum? QueryState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceResponse" /> class.
        /// </summary>
        /// <param name="Id">The query ID to listen for.</param>
        /// <param name="DownloadUrl">Deprecated. Use downloadUrls instead..</param>
        /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
        /// <param name="DownloadUrls">The uri list to GET the results of the Historical Adherence query. For notification purposes only.</param>
        /// <param name="QueryState">The state of the adherence query.</param>
        public WfmHistoricalAdherenceResponse(string Id = null, string DownloadUrl = null, WfmHistoricalAdherenceResultWrapper DownloadResult = null, List<string> DownloadUrls = null, QueryStateEnum? QueryState = null)
        {
            this.Id = Id;
            this.DownloadUrl = DownloadUrl;
            this.DownloadResult = DownloadResult;
            this.DownloadUrls = DownloadUrls;
            this.QueryState = QueryState;
            
        }
        


        /// <summary>
        /// The query ID to listen for
        /// </summary>
        /// <value>The query ID to listen for</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Deprecated. Use downloadUrls instead.
        /// </summary>
        /// <value>Deprecated. Use downloadUrls instead.</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Result will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResult", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceResultWrapper DownloadResult { get; set; }



        /// <summary>
        /// The uri list to GET the results of the Historical Adherence query. For notification purposes only
        /// </summary>
        /// <value>The uri list to GET the results of the Historical Adherence query. For notification purposes only</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceResponse);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceResponse other)
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
                    this.DownloadResult == other.DownloadResult ||
                    this.DownloadResult != null &&
                    this.DownloadResult.Equals(other.DownloadResult)
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

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadResult != null)
                    hash = hash * 59 + this.DownloadResult.GetHashCode();

                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.QueryState != null)
                    hash = hash * 59 + this.QueryState.GetHashCode();

                return hash;
            }
        }
    }

}
