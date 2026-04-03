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
    /// ShiftTradeQueryAgentTradesJobResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradeQueryAgentTradesJobResponse :  IEquatable<ShiftTradeQueryAgentTradesJobResponse>
    {
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
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
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The type of the job
        /// </summary>
        /// <value>The type of the job</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Addtrade for "AddTrade"
            /// </summary>
            [EnumMember(Value = "AddTrade")]
            Addtrade,
            
            /// <summary>
            /// Enum Bulkupdatetradestates for "BulkUpdateTradeStates"
            /// </summary>
            [EnumMember(Value = "BulkUpdateTradeStates")]
            Bulkupdatetradestates,
            
            /// <summary>
            /// Enum Evaluatetrades for "EvaluateTrades"
            /// </summary>
            [EnumMember(Value = "EvaluateTrades")]
            Evaluatetrades,
            
            /// <summary>
            /// Enum Matchtrade for "MatchTrade"
            /// </summary>
            [EnumMember(Value = "MatchTrade")]
            Matchtrade,
            
            /// <summary>
            /// Enum Queryagenttrades for "QueryAgentTrades"
            /// </summary>
            [EnumMember(Value = "QueryAgentTrades")]
            Queryagenttrades,
            
            /// <summary>
            /// Enum Querytrades for "QueryTrades"
            /// </summary>
            [EnumMember(Value = "QueryTrades")]
            Querytrades,
            
            /// <summary>
            /// Enum Queryweeksummaries for "QueryWeekSummaries"
            /// </summary>
            [EnumMember(Value = "QueryWeekSummaries")]
            Queryweeksummaries,
            
            /// <summary>
            /// Enum Searchunmatchedtrades for "SearchUnmatchedTrades"
            /// </summary>
            [EnumMember(Value = "SearchUnmatchedTrades")]
            Searchunmatchedtrades,
            
            /// <summary>
            /// Enum Updatetrade for "UpdateTrade"
            /// </summary>
            [EnumMember(Value = "UpdateTrade")]
            Updatetrade,
            
            /// <summary>
            /// Enum Updatetradestate for "UpdateTradeState"
            /// </summary>
            [EnumMember(Value = "UpdateTradeState")]
            Updatetradestate
        }
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of the job
        /// </summary>
        /// <value>The type of the job</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeQueryAgentTradesJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeQueryAgentTradesJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeQueryAgentTradesJobResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the job (required).</param>
        /// <param name="Type">The type of the job (required).</param>
        /// <param name="DownloadUrl">The URL where completed results might be available for download in case the result body for that job type is too large.</param>
        /// <param name="Error">Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;.</param>
        /// <param name="QueryAgentTradesResult">Results for QueryAgentTrades job type.</param>
        public ShiftTradeQueryAgentTradesJobResponse(StatusEnum? Status = null, TypeEnum? Type = null, string DownloadUrl = null, ErrorBody Error = null, ShiftTradeListJobResponse QueryAgentTradesResult = null)
        {
            this.Status = Status;
            this.Type = Type;
            this.DownloadUrl = DownloadUrl;
            this.Error = Error;
            this.QueryAgentTradesResult = QueryAgentTradesResult;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }







        /// <summary>
        /// The URL where completed results might be available for download in case the result body for that job type is too large
        /// </summary>
        /// <value>The URL where completed results might be available for download in case the result body for that job type is too large</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;
        /// </summary>
        /// <value>Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }



        /// <summary>
        /// Results for QueryAgentTrades job type
        /// </summary>
        /// <value>Results for QueryAgentTrades job type</value>
        [DataMember(Name="queryAgentTradesResult", EmitDefaultValue=false)]
        public ShiftTradeListJobResponse QueryAgentTradesResult { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeQueryAgentTradesJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  QueryAgentTradesResult: ").Append(QueryAgentTradesResult).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ShiftTradeQueryAgentTradesJobResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradeQueryAgentTradesJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeQueryAgentTradesJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeQueryAgentTradesJobResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.QueryAgentTradesResult == other.QueryAgentTradesResult ||
                    this.QueryAgentTradesResult != null &&
                    this.QueryAgentTradesResult.Equals(other.QueryAgentTradesResult)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.QueryAgentTradesResult != null)
                    hash = hash * 59 + this.QueryAgentTradesResult.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
