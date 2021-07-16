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
    /// WfmUserNotificationTopicShiftTradeNotification
    /// </summary>
    [DataContract]
    public partial class WfmUserNotificationTopicShiftTradeNotification :  IEquatable<WfmUserNotificationTopicShiftTradeNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets NewState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NewStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unmatched for "Unmatched"
            /// </summary>
            [EnumMember(Value = "Unmatched")]
            Unmatched,
            
            /// <summary>
            /// Enum Matched for "Matched"
            /// </summary>
            [EnumMember(Value = "Matched")]
            Matched,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets NewState
        /// </summary>
        [DataMember(Name="newState", EmitDefaultValue=false)]
        public NewStateEnum? NewState { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmUserNotificationTopicShiftTradeNotification" /> class.
        /// </summary>
        /// <param name="WeekDate">WeekDate.</param>
        /// <param name="TradeId">TradeId.</param>
        /// <param name="OneSided">OneSided.</param>
        /// <param name="NewState">NewState.</param>
        /// <param name="InitiatingUser">InitiatingUser.</param>
        /// <param name="InitiatingShiftDate">InitiatingShiftDate.</param>
        /// <param name="ReceivingUser">ReceivingUser.</param>
        /// <param name="ReceivingShiftDate">ReceivingShiftDate.</param>
        public WfmUserNotificationTopicShiftTradeNotification(string WeekDate = null, string TradeId = null, bool? OneSided = null, NewStateEnum? NewState = null, WfmUserNotificationTopicUserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, WfmUserNotificationTopicUserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
        {
            this.WeekDate = WeekDate;
            this.TradeId = TradeId;
            this.OneSided = OneSided;
            this.NewState = NewState;
            this.InitiatingUser = InitiatingUser;
            this.InitiatingShiftDate = InitiatingShiftDate;
            this.ReceivingUser = ReceivingUser;
            this.ReceivingShiftDate = ReceivingShiftDate;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets WeekDate
        /// </summary>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public string WeekDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name="tradeId", EmitDefaultValue=false)]
        public string TradeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OneSided
        /// </summary>
        [DataMember(Name="oneSided", EmitDefaultValue=false)]
        public bool? OneSided { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets InitiatingUser
        /// </summary>
        [DataMember(Name="initiatingUser", EmitDefaultValue=false)]
        public WfmUserNotificationTopicUserReference InitiatingUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets InitiatingShiftDate
        /// </summary>
        [DataMember(Name="initiatingShiftDate", EmitDefaultValue=false)]
        public DateTime? InitiatingShiftDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReceivingUser
        /// </summary>
        [DataMember(Name="receivingUser", EmitDefaultValue=false)]
        public WfmUserNotificationTopicUserReference ReceivingUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReceivingShiftDate
        /// </summary>
        [DataMember(Name="receivingShiftDate", EmitDefaultValue=false)]
        public DateTime? ReceivingShiftDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmUserNotificationTopicShiftTradeNotification {\n");
            
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  OneSided: ").Append(OneSided).Append("\n");
            sb.Append("  NewState: ").Append(NewState).Append("\n");
            sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
            sb.Append("  InitiatingShiftDate: ").Append(InitiatingShiftDate).Append("\n");
            sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
            sb.Append("  ReceivingShiftDate: ").Append(ReceivingShiftDate).Append("\n");
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
            return this.Equals(obj as WfmUserNotificationTopicShiftTradeNotification);
        }

        /// <summary>
        /// Returns true if WfmUserNotificationTopicShiftTradeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmUserNotificationTopicShiftTradeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmUserNotificationTopicShiftTradeNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.TradeId == other.TradeId ||
                    this.TradeId != null &&
                    this.TradeId.Equals(other.TradeId)
                ) &&
                (
                    this.OneSided == other.OneSided ||
                    this.OneSided != null &&
                    this.OneSided.Equals(other.OneSided)
                ) &&
                (
                    this.NewState == other.NewState ||
                    this.NewState != null &&
                    this.NewState.Equals(other.NewState)
                ) &&
                (
                    this.InitiatingUser == other.InitiatingUser ||
                    this.InitiatingUser != null &&
                    this.InitiatingUser.Equals(other.InitiatingUser)
                ) &&
                (
                    this.InitiatingShiftDate == other.InitiatingShiftDate ||
                    this.InitiatingShiftDate != null &&
                    this.InitiatingShiftDate.Equals(other.InitiatingShiftDate)
                ) &&
                (
                    this.ReceivingUser == other.ReceivingUser ||
                    this.ReceivingUser != null &&
                    this.ReceivingUser.Equals(other.ReceivingUser)
                ) &&
                (
                    this.ReceivingShiftDate == other.ReceivingShiftDate ||
                    this.ReceivingShiftDate != null &&
                    this.ReceivingShiftDate.Equals(other.ReceivingShiftDate)
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
                
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();
                
                if (this.TradeId != null)
                    hash = hash * 59 + this.TradeId.GetHashCode();
                
                if (this.OneSided != null)
                    hash = hash * 59 + this.OneSided.GetHashCode();
                
                if (this.NewState != null)
                    hash = hash * 59 + this.NewState.GetHashCode();
                
                if (this.InitiatingUser != null)
                    hash = hash * 59 + this.InitiatingUser.GetHashCode();
                
                if (this.InitiatingShiftDate != null)
                    hash = hash * 59 + this.InitiatingShiftDate.GetHashCode();
                
                if (this.ReceivingUser != null)
                    hash = hash * 59 + this.ReceivingUser.GetHashCode();
                
                if (this.ReceivingShiftDate != null)
                    hash = hash * 59 + this.ReceivingShiftDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
