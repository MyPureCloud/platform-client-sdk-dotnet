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
    /// ShiftTradeMatchViolation
    /// </summary>
    [DataContract]
    public partial class ShiftTradeMatchViolation :  IEquatable<ShiftTradeMatchViolation>
    {
        
        
        /// <summary>
        /// The type of constraint violation
        /// </summary>
        /// <value>The type of constraint violation</value>
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
            /// Enum Agentcapabilitymismatch for "AgentCapabilityMismatch"
            /// </summary>
            [EnumMember(Value = "AgentCapabilityMismatch")]
            Agentcapabilitymismatch,
            
            /// <summary>
            /// Enum Cannottradewithyourself for "CannotTradeWithYourself"
            /// </summary>
            [EnumMember(Value = "CannotTradeWithYourself")]
            Cannottradewithyourself,
            
            /// <summary>
            /// Enum Directtradeforotheruser for "DirectTradeForOtherUser"
            /// </summary>
            [EnumMember(Value = "DirectTradeForOtherUser")]
            Directtradeforotheruser,
            
            /// <summary>
            /// Enum Initiatingagentscheduledoesnotexist for "InitiatingAgentScheduleDoesNotExist"
            /// </summary>
            [EnumMember(Value = "InitiatingAgentScheduleDoesNotExist")]
            Initiatingagentscheduledoesnotexist,
            
            /// <summary>
            /// Enum Initiatingshiftdisallowedactivitycategory for "InitiatingShiftDisallowedActivityCategory"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftDisallowedActivityCategory")]
            Initiatingshiftdisallowedactivitycategory,
            
            /// <summary>
            /// Enum Initiatingshiftdoesnotexist for "InitiatingShiftDoesNotExist"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftDoesNotExist")]
            Initiatingshiftdoesnotexist,
            
            /// <summary>
            /// Enum Initiatingshifthasexternalactivities for "InitiatingShiftHasExternalActivities"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftHasExternalActivities")]
            Initiatingshifthasexternalactivities,
            
            /// <summary>
            /// Enum Initiatingshiftoverlapsexisting for "InitiatingShiftOverlapsExisting"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftOverlapsExisting")]
            Initiatingshiftoverlapsexisting,
            
            /// <summary>
            /// Enum Initiatingshiftstarttooclose for "InitiatingShiftStartTooClose"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftStartTooClose")]
            Initiatingshiftstarttooclose,
            
            /// <summary>
            /// Enum Initiatingshifttimeschanged for "InitiatingShiftTimesChanged"
            /// </summary>
            [EnumMember(Value = "InitiatingShiftTimesChanged")]
            Initiatingshifttimeschanged,
            
            /// <summary>
            /// Enum Initiatingweeklymaxpaidtime for "InitiatingWeeklyMaxPaidTime"
            /// </summary>
            [EnumMember(Value = "InitiatingWeeklyMaxPaidTime")]
            Initiatingweeklymaxpaidtime,
            
            /// <summary>
            /// Enum Initiatingweeklyminpaidtime for "InitiatingWeeklyMinPaidTime"
            /// </summary>
            [EnumMember(Value = "InitiatingWeeklyMinPaidTime")]
            Initiatingweeklyminpaidtime,
            
            /// <summary>
            /// Enum Invalidstate for "InvalidState"
            /// </summary>
            [EnumMember(Value = "InvalidState")]
            Invalidstate,
            
            /// <summary>
            /// Enum Onesidedtradecreation for "OneSidedTradeCreation"
            /// </summary>
            [EnumMember(Value = "OneSidedTradeCreation")]
            Onesidedtradecreation,
            
            /// <summary>
            /// Enum Receivingagentscheduledoesnotexist for "ReceivingAgentScheduleDoesNotExist"
            /// </summary>
            [EnumMember(Value = "ReceivingAgentScheduleDoesNotExist")]
            Receivingagentscheduledoesnotexist,
            
            /// <summary>
            /// Enum Receivingshiftdisallowedactivitycategory for "ReceivingShiftDisallowedActivityCategory"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftDisallowedActivityCategory")]
            Receivingshiftdisallowedactivitycategory,
            
            /// <summary>
            /// Enum Receivingshiftdoesnotexist for "ReceivingShiftDoesNotExist"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftDoesNotExist")]
            Receivingshiftdoesnotexist,
            
            /// <summary>
            /// Enum Receivingshiftforonesidedtrade for "ReceivingShiftForOneSidedTrade"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftForOneSidedTrade")]
            Receivingshiftforonesidedtrade,
            
            /// <summary>
            /// Enum Receivingshifthasexternalactivities for "ReceivingShiftHasExternalActivities"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftHasExternalActivities")]
            Receivingshifthasexternalactivities,
            
            /// <summary>
            /// Enum Receivingshiftmissingfortwosidedtrade for "ReceivingShiftMissingForTwoSidedTrade"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftMissingForTwoSidedTrade")]
            Receivingshiftmissingfortwosidedtrade,
            
            /// <summary>
            /// Enum Receivingshiftoutsideacceptableintervals for "ReceivingShiftOutsideAcceptableIntervals"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftOutsideAcceptableIntervals")]
            Receivingshiftoutsideacceptableintervals,
            
            /// <summary>
            /// Enum Receivingshiftoverlapsexisting for "ReceivingShiftOverlapsExisting"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftOverlapsExisting")]
            Receivingshiftoverlapsexisting,
            
            /// <summary>
            /// Enum Receivingshiftstarttooclose for "ReceivingShiftStartTooClose"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftStartTooClose")]
            Receivingshiftstarttooclose,
            
            /// <summary>
            /// Enum Receivingshifttimeschanged for "ReceivingShiftTimesChanged"
            /// </summary>
            [EnumMember(Value = "ReceivingShiftTimesChanged")]
            Receivingshifttimeschanged,
            
            /// <summary>
            /// Enum Receivingweeklymaxpaidtime for "ReceivingWeeklyMaxPaidTime"
            /// </summary>
            [EnumMember(Value = "ReceivingWeeklyMaxPaidTime")]
            Receivingweeklymaxpaidtime,
            
            /// <summary>
            /// Enum Receivingweeklyminpaidtime for "ReceivingWeeklyMinPaidTime"
            /// </summary>
            [EnumMember(Value = "ReceivingWeeklyMinPaidTime")]
            Receivingweeklyminpaidtime,
            
            /// <summary>
            /// Enum Shifttradingnotenabled for "ShiftTradingNotEnabled"
            /// </summary>
            [EnumMember(Value = "ShiftTradingNotEnabled")]
            Shifttradingnotenabled,
            
            /// <summary>
            /// Enum Unequalpaidtime for "UnequalPaidTime"
            /// </summary>
            [EnumMember(Value = "UnequalPaidTime")]
            Unequalpaidtime,
            
            /// <summary>
            /// Enum Weekscheduledifferent for "WeekScheduleDifferent"
            /// </summary>
            [EnumMember(Value = "WeekScheduleDifferent")]
            Weekscheduledifferent,
            
            /// <summary>
            /// Enum Weekscheduledoesnotexist for "WeekScheduleDoesNotExist"
            /// </summary>
            [EnumMember(Value = "WeekScheduleDoesNotExist")]
            Weekscheduledoesnotexist,
            
            /// <summary>
            /// Enum Weekscheduleunpublished for "WeekScheduleUnpublished"
            /// </summary>
            [EnumMember(Value = "WeekScheduleUnpublished")]
            Weekscheduleunpublished
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of constraint violation
        /// </summary>
        /// <value>The type of constraint violation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeMatchViolation" /> class.
        /// </summary>
        /// <param name="Type">The type of constraint violation.</param>
        /// <param name="_Params">Clarifying user params for constructing helpful error messages.</param>
        public ShiftTradeMatchViolation(TypeEnum? Type = null, Dictionary<string, string> _Params = null)
        {
            this.Type = Type;
            this._Params = _Params;
            
        }
        
        
        
        
        
        /// <summary>
        /// Clarifying user params for constructing helpful error messages
        /// </summary>
        /// <value>Clarifying user params for constructing helpful error messages</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Dictionary<string, string> _Params { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeMatchViolation {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
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
            return this.Equals(obj as ShiftTradeMatchViolation);
        }

        /// <summary>
        /// Returns true if ShiftTradeMatchViolation instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeMatchViolation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeMatchViolation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.SequenceEqual(other._Params)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                
                return hash;
            }
        }
    }

}
