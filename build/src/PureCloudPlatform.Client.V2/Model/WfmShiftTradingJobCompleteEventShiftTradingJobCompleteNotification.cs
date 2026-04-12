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
    /// WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification :  IEquatable<WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            Updatetradestate,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Trade">Trade.</param>
        /// <param name="WeekSummaries">WeekSummaries.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="Error">Error.</param>
        public WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification(string Id = null, TypeEnum? Type = null, StatusEnum? Status = null, WfmShiftTradingJobCompleteEventTradeEntity Trade = null, WfmShiftTradingJobCompleteEventWeekSummaryList WeekSummaries = null, string DownloadUrl = null, WfmShiftTradingJobCompleteEventErrorBody Error = null)
        {
            this.Id = Id;
            this.Type = Type;
            this.Status = Status;
            this.Trade = Trade;
            this.WeekSummaries = WeekSummaries;
            this.DownloadUrl = DownloadUrl;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }







        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [DataMember(Name="trade", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventTradeEntity Trade { get; set; }



        /// <summary>
        /// Gets or Sets WeekSummaries
        /// </summary>
        [DataMember(Name="weekSummaries", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventWeekSummaryList WeekSummaries { get; set; }



        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventErrorBody Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  WeekSummaries: ").Append(WeekSummaries).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventShiftTradingJobCompleteNotification other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Trade == other.Trade ||
                    this.Trade != null &&
                    this.Trade.Equals(other.Trade)
                ) &&
                (
                    this.WeekSummaries == other.WeekSummaries ||
                    this.WeekSummaries != null &&
                    this.WeekSummaries.Equals(other.WeekSummaries)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Trade != null)
                    hash = hash * 59 + this.Trade.GetHashCode();

                if (this.WeekSummaries != null)
                    hash = hash * 59 + this.WeekSummaries.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
