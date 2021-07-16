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
    /// InteractionStatsAlert
    /// </summary>
    [DataContract]
    public partial class InteractionStatsAlert :  IEquatable<InteractionStatsAlert>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The dimension of concern.
        /// </summary>
        /// <value>The dimension of concern.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The metric to be assessed.
        /// </summary>
        /// <value>The metric to be assessed.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Tabandon for "tAbandon"
            /// </summary>
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            /// <summary>
            /// Enum Tanswered for "tAnswered"
            /// </summary>
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            /// <summary>
            /// Enum Ttalk for "tTalk"
            /// </summary>
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            /// <summary>
            /// Enum Noffered for "nOffered"
            /// </summary>
            [EnumMember(Value = "nOffered")]
            Noffered,
            
            /// <summary>
            /// Enum Thandle for "tHandle"
            /// </summary>
            [EnumMember(Value = "tHandle")]
            Thandle,
            
            /// <summary>
            /// Enum Ntransferred for "nTransferred"
            /// </summary>
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            /// <summary>
            /// Enum Oservicelevel for "oServiceLevel"
            /// </summary>
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
            /// <summary>
            /// Enum Twait for "tWait"
            /// </summary>
            [EnumMember(Value = "tWait")]
            Twait,
            
            /// <summary>
            /// Enum Theld for "tHeld"
            /// </summary>
            [EnumMember(Value = "tHeld")]
            Theld,
            
            /// <summary>
            /// Enum Tacw for "tAcw"
            /// </summary>
            [EnumMember(Value = "tAcw")]
            Tacw
        }
        
        
        
        
        /// <summary>
        /// The media type.
        /// </summary>
        /// <value>The media type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        
        
        
        
        /// <summary>
        /// The comparison descriptor used against the metric's value.
        /// </summary>
        /// <value>The comparison descriptor used against the metric's value.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NumericRangeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Gt for "gt"
            /// </summary>
            [EnumMember(Value = "gt")]
            Gt,
            
            /// <summary>
            /// Enum Gte for "gte"
            /// </summary>
            [EnumMember(Value = "gte")]
            Gte,
            
            /// <summary>
            /// Enum Lt for "lt"
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt,
            
            /// <summary>
            /// Enum Lte for "lte"
            /// </summary>
            [EnumMember(Value = "lte")]
            Lte,
            
            /// <summary>
            /// Enum Eq for "eq"
            /// </summary>
            [EnumMember(Value = "eq")]
            Eq,
            
            /// <summary>
            /// Enum Ne for "ne"
            /// </summary>
            [EnumMember(Value = "ne")]
            Ne
        }
        
        
        
        
        /// <summary>
        /// The statistic of concern for the metric.
        /// </summary>
        /// <value>The statistic of concern for the metric.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatisticEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Count for "count"
            /// </summary>
            [EnumMember(Value = "count")]
            Count,
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Ratio for "ratio"
            /// </summary>
            [EnumMember(Value = "ratio")]
            Ratio,
            
            /// <summary>
            /// Enum Max for "max"
            /// </summary>
            [EnumMember(Value = "max")]
            Max
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets AlertTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlertTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Device for "DEVICE"
            /// </summary>
            [EnumMember(Value = "DEVICE")]
            Device,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The dimension of concern.
        /// </summary>
        /// <value>The dimension of concern.</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
        
        
        
        
        
        /// <summary>
        /// The metric to be assessed.
        /// </summary>
        /// <value>The metric to be assessed.</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        
        
        
        /// <summary>
        /// The media type.
        /// </summary>
        /// <value>The media type.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        /// <summary>
        /// The comparison descriptor used against the metric's value.
        /// </summary>
        /// <value>The comparison descriptor used against the metric's value.</value>
        [DataMember(Name="numericRange", EmitDefaultValue=false)]
        public NumericRangeEnum? NumericRange { get; set; }
        
        
        
        /// <summary>
        /// The statistic of concern for the metric.
        /// </summary>
        /// <value>The statistic of concern for the metric.</value>
        [DataMember(Name="statistic", EmitDefaultValue=false)]
        public StatisticEnum? Statistic { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionStatsAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InteractionStatsAlert() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionStatsAlert" /> class.
        /// </summary>
        /// <param name="Unread">Indicates if the alert has been read. (required).</param>
        /// <param name="NotificationUsers">The ids of users who were notified of alarm state change. (required).</param>
        /// <param name="AlertTypes">A collection of notification methods. (required).</param>
        /// <param name="RuleUri">RuleUri.</param>
        public InteractionStatsAlert(bool? Unread = null, List<User> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null, string RuleUri = null)
        {
            this.Unread = Unread;
            this.NotificationUsers = NotificationUsers;
            this.AlertTypes = AlertTypes;
            this.RuleUri = RuleUri;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Name of the rule that generated the alert
        /// </summary>
        /// <value>Name of the rule that generated the alert</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        
        
        /// <summary>
        /// The value of the dimension.
        /// </summary>
        /// <value>The value of the dimension.</value>
        [DataMember(Name="dimensionValue", EmitDefaultValue=false)]
        public string DimensionValue { get; private set; }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The threshold value.
        /// </summary>
        /// <value>The threshold value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; private set; }
        
        
        
        /// <summary>
        /// The id of the rule.
        /// </summary>
        /// <value>The id of the rule.</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; private set; }
        
        
        
        /// <summary>
        /// Indicates if the alert has been read.
        /// </summary>
        /// <value>Indicates if the alert has been read.</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool? Unread { get; set; }
        
        
        
        /// <summary>
        /// The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; private set; }
        
        
        
        /// <summary>
        /// The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; private set; }
        
        
        
        /// <summary>
        /// The ids of users who were notified of alarm state change.
        /// </summary>
        /// <value>The ids of users who were notified of alarm state change.</value>
        [DataMember(Name="notificationUsers", EmitDefaultValue=false)]
        public List<User> NotificationUsers { get; set; }
        
        
        
        /// <summary>
        /// A collection of notification methods.
        /// </summary>
        /// <value>A collection of notification methods.</value>
        [DataMember(Name="alertTypes", EmitDefaultValue=false)]
        public List<AlertTypesEnum> AlertTypes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RuleUri
        /// </summary>
        [DataMember(Name="ruleUri", EmitDefaultValue=false)]
        public string RuleUri { get; set; }
        
        
        
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
            sb.Append("class InteractionStatsAlert {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  DimensionValue: ").Append(DimensionValue).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  NumericRange: ").Append(NumericRange).Append("\n");
            sb.Append("  Statistic: ").Append(Statistic).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  NotificationUsers: ").Append(NotificationUsers).Append("\n");
            sb.Append("  AlertTypes: ").Append(AlertTypes).Append("\n");
            sb.Append("  RuleUri: ").Append(RuleUri).Append("\n");
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
            return this.Equals(obj as InteractionStatsAlert);
        }

        /// <summary>
        /// Returns true if InteractionStatsAlert instances are equal
        /// </summary>
        /// <param name="other">Instance of InteractionStatsAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionStatsAlert other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.DimensionValue == other.DimensionValue ||
                    this.DimensionValue != null &&
                    this.DimensionValue.Equals(other.DimensionValue)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.NumericRange == other.NumericRange ||
                    this.NumericRange != null &&
                    this.NumericRange.Equals(other.NumericRange)
                ) &&
                (
                    this.Statistic == other.Statistic ||
                    this.Statistic != null &&
                    this.Statistic.Equals(other.Statistic)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.RuleId == other.RuleId ||
                    this.RuleId != null &&
                    this.RuleId.Equals(other.RuleId)
                ) &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.NotificationUsers == other.NotificationUsers ||
                    this.NotificationUsers != null &&
                    this.NotificationUsers.SequenceEqual(other.NotificationUsers)
                ) &&
                (
                    this.AlertTypes == other.AlertTypes ||
                    this.AlertTypes != null &&
                    this.AlertTypes.SequenceEqual(other.AlertTypes)
                ) &&
                (
                    this.RuleUri == other.RuleUri ||
                    this.RuleUri != null &&
                    this.RuleUri.Equals(other.RuleUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                
                if (this.DimensionValue != null)
                    hash = hash * 59 + this.DimensionValue.GetHashCode();
                
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.NumericRange != null)
                    hash = hash * 59 + this.NumericRange.GetHashCode();
                
                if (this.Statistic != null)
                    hash = hash * 59 + this.Statistic.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.RuleId != null)
                    hash = hash * 59 + this.RuleId.GetHashCode();
                
                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.NotificationUsers != null)
                    hash = hash * 59 + this.NotificationUsers.GetHashCode();
                
                if (this.AlertTypes != null)
                    hash = hash * 59 + this.AlertTypes.GetHashCode();
                
                if (this.RuleUri != null)
                    hash = hash * 59 + this.RuleUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
