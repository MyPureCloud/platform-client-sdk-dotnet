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
    /// DataColumn
    /// </summary>
    [DataContract]
    public partial class DataColumn :  IEquatable<DataColumn>
    {
        
        
        
        
        
        /// <summary>
        /// The type of column being requested
        /// </summary>
        /// <value>The type of column being requested</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DataColumnTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum IntervalStart for "INTERVAL_START"
            /// </summary>
            [EnumMember(Value = "INTERVAL_START")]
            IntervalStart,
            
            /// <summary>
            /// Enum IntervalEnd for "INTERVAL_END"
            /// </summary>
            [EnumMember(Value = "INTERVAL_END")]
            IntervalEnd,
            
            /// <summary>
            /// Enum IntervalComplete for "INTERVAL_COMPLETE"
            /// </summary>
            [EnumMember(Value = "INTERVAL_COMPLETE")]
            IntervalComplete,
            
            /// <summary>
            /// Enum MediaType for "MEDIA_TYPE"
            /// </summary>
            [EnumMember(Value = "MEDIA_TYPE")]
            MediaType,
            
            /// <summary>
            /// Enum QueueId for "QUEUE_ID"
            /// </summary>
            [EnumMember(Value = "QUEUE_ID")]
            QueueId,
            
            /// <summary>
            /// Enum QueueName for "QUEUE_NAME"
            /// </summary>
            [EnumMember(Value = "QUEUE_NAME")]
            QueueName,
            
            /// <summary>
            /// Enum Offer for "OFFER"
            /// </summary>
            [EnumMember(Value = "OFFER")]
            Offer,
            
            /// <summary>
            /// Enum Answer for "ANSWER"
            /// </summary>
            [EnumMember(Value = "ANSWER")]
            Answer,
            
            /// <summary>
            /// Enum AnswerPercent for "ANSWER_PERCENT"
            /// </summary>
            [EnumMember(Value = "ANSWER_PERCENT")]
            AnswerPercent,
            
            /// <summary>
            /// Enum Abandon for "ABANDON"
            /// </summary>
            [EnumMember(Value = "ABANDON")]
            Abandon,
            
            /// <summary>
            /// Enum AbandonPercent for "ABANDON_PERCENT"
            /// </summary>
            [EnumMember(Value = "ABANDON_PERCENT")]
            AbandonPercent,
            
            /// <summary>
            /// Enum TimeToAbandon for "TIME_TO_ABANDON"
            /// </summary>
            [EnumMember(Value = "TIME_TO_ABANDON")]
            TimeToAbandon,
            
            /// <summary>
            /// Enum Asa for "ASA"
            /// </summary>
            [EnumMember(Value = "ASA")]
            Asa,
            
            /// <summary>
            /// Enum ServiceLevelPercent for "SERVICE_LEVEL_PERCENT"
            /// </summary>
            [EnumMember(Value = "SERVICE_LEVEL_PERCENT")]
            ServiceLevelPercent,
            
            /// <summary>
            /// Enum SlaLevelPercentTarget for "SLA_LEVEL_PERCENT_TARGET"
            /// </summary>
            [EnumMember(Value = "SLA_LEVEL_PERCENT_TARGET")]
            SlaLevelPercentTarget,
            
            /// <summary>
            /// Enum AverageHandle for "AVERAGE_HANDLE"
            /// </summary>
            [EnumMember(Value = "AVERAGE_HANDLE")]
            AverageHandle,
            
            /// <summary>
            /// Enum TotalHandle for "TOTAL_HANDLE"
            /// </summary>
            [EnumMember(Value = "TOTAL_HANDLE")]
            TotalHandle,
            
            /// <summary>
            /// Enum AverageTalk for "AVERAGE_TALK"
            /// </summary>
            [EnumMember(Value = "AVERAGE_TALK")]
            AverageTalk,
            
            /// <summary>
            /// Enum TotalTalk for "TOTAL_TALK"
            /// </summary>
            [EnumMember(Value = "TOTAL_TALK")]
            TotalTalk,
            
            /// <summary>
            /// Enum AverageHold for "AVERAGE_HOLD"
            /// </summary>
            [EnumMember(Value = "AVERAGE_HOLD")]
            AverageHold,
            
            /// <summary>
            /// Enum TotalHold for "TOTAL_HOLD"
            /// </summary>
            [EnumMember(Value = "TOTAL_HOLD")]
            TotalHold,
            
            /// <summary>
            /// Enum AverageAcw for "AVERAGE_ACW"
            /// </summary>
            [EnumMember(Value = "AVERAGE_ACW")]
            AverageAcw,
            
            /// <summary>
            /// Enum TotalAcw for "TOTAL_ACW"
            /// </summary>
            [EnumMember(Value = "TOTAL_ACW")]
            TotalAcw,
            
            /// <summary>
            /// Enum Hold for "HOLD"
            /// </summary>
            [EnumMember(Value = "HOLD")]
            Hold,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferPercent for "TRANSFER_PERCENT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_PERCENT")]
            TransferPercent,
            
            /// <summary>
            /// Enum FlowOut for "FLOW_OUT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUT")]
            FlowOut,
            
            /// <summary>
            /// Enum Handle for "HANDLE"
            /// </summary>
            [EnumMember(Value = "HANDLE")]
            Handle,
            
            /// <summary>
            /// Enum AverageWait for "AVERAGE_WAIT"
            /// </summary>
            [EnumMember(Value = "AVERAGE_WAIT")]
            AverageWait
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The type of column being requested
        /// </summary>
        /// <value>The type of column being requested</value>
        [DataMember(Name="dataColumnType", EmitDefaultValue=false)]
        public DataColumnTypeEnum? DataColumnType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataColumn() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataColumn" /> class.
        /// </summary>
        
        
        /// <param name="ColumnName">The localized value of the column name as provided by the client (required).</param>
        
        
        
        /// <param name="DataColumnType">The type of column being requested (required).</param>
        
        
        public DataColumn(string ColumnName = null, DataColumnTypeEnum? DataColumnType = null)
        {
            
            
            
            // to ensure "ColumnName" is required (not null)
            if (ColumnName == null)
            {
                throw new InvalidDataException("ColumnName is a required property for DataColumn and cannot be null");
            }
            else
            {
                this.ColumnName = ColumnName;
            }
            
            
            
            
            
            // to ensure "DataColumnType" is required (not null)
            if (DataColumnType == null)
            {
                throw new InvalidDataException("DataColumnType is a required property for DataColumn and cannot be null");
            }
            else
            {
                this.DataColumnType = DataColumnType;
            }
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The localized value of the column name as provided by the client
        /// </summary>
        /// <value>The localized value of the column name as provided by the client</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataColumn {\n");
            
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            
            sb.Append("  DataColumnType: ").Append(DataColumnType).Append("\n");
            
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
            return this.Equals(obj as DataColumn);
        }

        /// <summary>
        /// Returns true if DataColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of DataColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) &&
                (
                    this.DataColumnType == other.DataColumnType ||
                    this.DataColumnType != null &&
                    this.DataColumnType.Equals(other.DataColumnType)
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
                
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();
                
                if (this.DataColumnType != null)
                    hash = hash * 59 + this.DataColumnType.GetHashCode();
                
                return hash;
            }
        }
    }

}
