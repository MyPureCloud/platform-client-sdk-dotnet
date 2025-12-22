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
    /// OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent
    /// </summary>
    [DataContract]
    public partial class OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent :  IEquatable<OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent>
    {
        /// <summary>
        /// Gets or Sets DialingMode
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DialingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Preview for "PREVIEW"
            /// </summary>
            [EnumMember(Value = "PREVIEW")]
            Preview,
            
            /// <summary>
            /// Enum Power for "POWER"
            /// </summary>
            [EnumMember(Value = "POWER")]
            Power,
            
            /// <summary>
            /// Enum Predictive for "PREDICTIVE"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE")]
            Predictive,
            
            /// <summary>
            /// Enum Agentless for "AGENTLESS"
            /// </summary>
            [EnumMember(Value = "AGENTLESS")]
            Agentless,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External,
            
            /// <summary>
            /// Enum Progressive for "PROGRESSIVE"
            /// </summary>
            [EnumMember(Value = "PROGRESSIVE")]
            Progressive
        }
        /// <summary>
        /// Gets or Sets DialingMode
        /// </summary>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="VoiceAttributes">VoiceAttributes.</param>
        /// <param name="WrapupCode">WrapupCode.</param>
        /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
        /// <param name="DialingMode">DialingMode.</param>
        /// <param name="AgentScriptId">AgentScriptId.</param>
        /// <param name="DivisionId">DivisionId.</param>
        /// <param name="OutboundContactListId">OutboundContactListId.</param>
        /// <param name="OutboundContactListFilterId">OutboundContactListFilterId.</param>
        /// <param name="OutboundQueueId">OutboundQueueId.</param>
        /// <param name="OutboundContactId">OutboundContactId.</param>
        /// <param name="IsCampaignAlwaysRunning">IsCampaignAlwaysRunning.</param>
        /// <param name="IsCampaignSkillBased">IsCampaignSkillBased.</param>
        /// <param name="IsCampaignDynamicSorting">IsCampaignDynamicSorting.</param>
        /// <param name="IsCampaignDynamicFiltering">IsCampaignDynamicFiltering.</param>
        /// <param name="OutboundCampaignHealthMask">OutboundCampaignHealthMask.</param>
        /// <param name="IsReCall">IsReCall.</param>
        /// <param name="ScheduledDateTime">ScheduledDateTime.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="IsRightPartyContact">IsRightPartyContact.</param>
        /// <param name="CallAnalysisDisposition">CallAnalysisDisposition.</param>
        /// <param name="AgentId">AgentId.</param>
        /// <param name="IsPreviewAutoEnded">IsPreviewAutoEnded.</param>
        public OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent(long? EventTime = null, OutboundPreviewCampaignPostContactVoiceAttributes VoiceAttributes = null, string WrapupCode = null, Guid? OutboundCampaignId = null, DialingModeEnum? DialingMode = null, Guid? AgentScriptId = null, Guid? DivisionId = null, Guid? OutboundContactListId = null, Guid? OutboundContactListFilterId = null, Guid? OutboundQueueId = null, string OutboundContactId = null, bool? IsCampaignAlwaysRunning = null, bool? IsCampaignSkillBased = null, bool? IsCampaignDynamicSorting = null, bool? IsCampaignDynamicFiltering = null, long? OutboundCampaignHealthMask = null, bool? IsReCall = null, string ScheduledDateTime = null, Guid? ConversationId = null, bool? IsRightPartyContact = null, string CallAnalysisDisposition = null, string AgentId = null, bool? IsPreviewAutoEnded = null)
        {
            this.EventTime = EventTime;
            this.VoiceAttributes = VoiceAttributes;
            this.WrapupCode = WrapupCode;
            this.OutboundCampaignId = OutboundCampaignId;
            this.DialingMode = DialingMode;
            this.AgentScriptId = AgentScriptId;
            this.DivisionId = DivisionId;
            this.OutboundContactListId = OutboundContactListId;
            this.OutboundContactListFilterId = OutboundContactListFilterId;
            this.OutboundQueueId = OutboundQueueId;
            this.OutboundContactId = OutboundContactId;
            this.IsCampaignAlwaysRunning = IsCampaignAlwaysRunning;
            this.IsCampaignSkillBased = IsCampaignSkillBased;
            this.IsCampaignDynamicSorting = IsCampaignDynamicSorting;
            this.IsCampaignDynamicFiltering = IsCampaignDynamicFiltering;
            this.OutboundCampaignHealthMask = OutboundCampaignHealthMask;
            this.IsReCall = IsReCall;
            this.ScheduledDateTime = ScheduledDateTime;
            this.ConversationId = ConversationId;
            this.IsRightPartyContact = IsRightPartyContact;
            this.CallAnalysisDisposition = CallAnalysisDisposition;
            this.AgentId = AgentId;
            this.IsPreviewAutoEnded = IsPreviewAutoEnded;
            
        }
        


        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public long? EventTime { get; set; }



        /// <summary>
        /// Gets or Sets VoiceAttributes
        /// </summary>
        [DataMember(Name="voiceAttributes", EmitDefaultValue=false)]
        public OutboundPreviewCampaignPostContactVoiceAttributes VoiceAttributes { get; set; }



        /// <summary>
        /// Gets or Sets WrapupCode
        /// </summary>
        [DataMember(Name="wrapupCode", EmitDefaultValue=false)]
        public string WrapupCode { get; set; }



        /// <summary>
        /// Gets or Sets OutboundCampaignId
        /// </summary>
        [DataMember(Name="outboundCampaignId", EmitDefaultValue=false)]
        public Guid? OutboundCampaignId { get; set; }





        /// <summary>
        /// Gets or Sets AgentScriptId
        /// </summary>
        [DataMember(Name="agentScriptId", EmitDefaultValue=false)]
        public Guid? AgentScriptId { get; set; }



        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public Guid? DivisionId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundContactListId
        /// </summary>
        [DataMember(Name="outboundContactListId", EmitDefaultValue=false)]
        public Guid? OutboundContactListId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundContactListFilterId
        /// </summary>
        [DataMember(Name="outboundContactListFilterId", EmitDefaultValue=false)]
        public Guid? OutboundContactListFilterId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundQueueId
        /// </summary>
        [DataMember(Name="outboundQueueId", EmitDefaultValue=false)]
        public Guid? OutboundQueueId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundContactId
        /// </summary>
        [DataMember(Name="outboundContactId", EmitDefaultValue=false)]
        public string OutboundContactId { get; set; }



        /// <summary>
        /// Gets or Sets IsCampaignAlwaysRunning
        /// </summary>
        [DataMember(Name="isCampaignAlwaysRunning", EmitDefaultValue=false)]
        public bool? IsCampaignAlwaysRunning { get; set; }



        /// <summary>
        /// Gets or Sets IsCampaignSkillBased
        /// </summary>
        [DataMember(Name="isCampaignSkillBased", EmitDefaultValue=false)]
        public bool? IsCampaignSkillBased { get; set; }



        /// <summary>
        /// Gets or Sets IsCampaignDynamicSorting
        /// </summary>
        [DataMember(Name="isCampaignDynamicSorting", EmitDefaultValue=false)]
        public bool? IsCampaignDynamicSorting { get; set; }



        /// <summary>
        /// Gets or Sets IsCampaignDynamicFiltering
        /// </summary>
        [DataMember(Name="isCampaignDynamicFiltering", EmitDefaultValue=false)]
        public bool? IsCampaignDynamicFiltering { get; set; }



        /// <summary>
        /// Gets or Sets OutboundCampaignHealthMask
        /// </summary>
        [DataMember(Name="outboundCampaignHealthMask", EmitDefaultValue=false)]
        public long? OutboundCampaignHealthMask { get; set; }



        /// <summary>
        /// Gets or Sets IsReCall
        /// </summary>
        [DataMember(Name="isReCall", EmitDefaultValue=false)]
        public bool? IsReCall { get; set; }



        /// <summary>
        /// Gets or Sets ScheduledDateTime
        /// </summary>
        [DataMember(Name="scheduledDateTime", EmitDefaultValue=false)]
        public string ScheduledDateTime { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets IsRightPartyContact
        /// </summary>
        [DataMember(Name="isRightPartyContact", EmitDefaultValue=false)]
        public bool? IsRightPartyContact { get; set; }



        /// <summary>
        /// Gets or Sets CallAnalysisDisposition
        /// </summary>
        [DataMember(Name="callAnalysisDisposition", EmitDefaultValue=false)]
        public string CallAnalysisDisposition { get; set; }



        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// Gets or Sets IsPreviewAutoEnded
        /// </summary>
        [DataMember(Name="isPreviewAutoEnded", EmitDefaultValue=false)]
        public bool? IsPreviewAutoEnded { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent {\n");

            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  VoiceAttributes: ").Append(VoiceAttributes).Append("\n");
            sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            sb.Append("  AgentScriptId: ").Append(AgentScriptId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            sb.Append("  OutboundContactListFilterId: ").Append(OutboundContactListFilterId).Append("\n");
            sb.Append("  OutboundQueueId: ").Append(OutboundQueueId).Append("\n");
            sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
            sb.Append("  IsCampaignAlwaysRunning: ").Append(IsCampaignAlwaysRunning).Append("\n");
            sb.Append("  IsCampaignSkillBased: ").Append(IsCampaignSkillBased).Append("\n");
            sb.Append("  IsCampaignDynamicSorting: ").Append(IsCampaignDynamicSorting).Append("\n");
            sb.Append("  IsCampaignDynamicFiltering: ").Append(IsCampaignDynamicFiltering).Append("\n");
            sb.Append("  OutboundCampaignHealthMask: ").Append(OutboundCampaignHealthMask).Append("\n");
            sb.Append("  IsReCall: ").Append(IsReCall).Append("\n");
            sb.Append("  ScheduledDateTime: ").Append(ScheduledDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  IsRightPartyContact: ").Append(IsRightPartyContact).Append("\n");
            sb.Append("  CallAnalysisDisposition: ").Append(CallAnalysisDisposition).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  IsPreviewAutoEnded: ").Append(IsPreviewAutoEnded).Append("\n");
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
            return this.Equals(obj as OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent);
        }

        /// <summary>
        /// Returns true if OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundPreviewCampaignPostContactOutboundPreviewCampaignPostContactEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.VoiceAttributes == other.VoiceAttributes ||
                    this.VoiceAttributes != null &&
                    this.VoiceAttributes.Equals(other.VoiceAttributes)
                ) &&
                (
                    this.WrapupCode == other.WrapupCode ||
                    this.WrapupCode != null &&
                    this.WrapupCode.Equals(other.WrapupCode)
                ) &&
                (
                    this.OutboundCampaignId == other.OutboundCampaignId ||
                    this.OutboundCampaignId != null &&
                    this.OutboundCampaignId.Equals(other.OutboundCampaignId)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.AgentScriptId == other.AgentScriptId ||
                    this.AgentScriptId != null &&
                    this.AgentScriptId.Equals(other.AgentScriptId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.OutboundContactListId == other.OutboundContactListId ||
                    this.OutboundContactListId != null &&
                    this.OutboundContactListId.Equals(other.OutboundContactListId)
                ) &&
                (
                    this.OutboundContactListFilterId == other.OutboundContactListFilterId ||
                    this.OutboundContactListFilterId != null &&
                    this.OutboundContactListFilterId.Equals(other.OutboundContactListFilterId)
                ) &&
                (
                    this.OutboundQueueId == other.OutboundQueueId ||
                    this.OutboundQueueId != null &&
                    this.OutboundQueueId.Equals(other.OutboundQueueId)
                ) &&
                (
                    this.OutboundContactId == other.OutboundContactId ||
                    this.OutboundContactId != null &&
                    this.OutboundContactId.Equals(other.OutboundContactId)
                ) &&
                (
                    this.IsCampaignAlwaysRunning == other.IsCampaignAlwaysRunning ||
                    this.IsCampaignAlwaysRunning != null &&
                    this.IsCampaignAlwaysRunning.Equals(other.IsCampaignAlwaysRunning)
                ) &&
                (
                    this.IsCampaignSkillBased == other.IsCampaignSkillBased ||
                    this.IsCampaignSkillBased != null &&
                    this.IsCampaignSkillBased.Equals(other.IsCampaignSkillBased)
                ) &&
                (
                    this.IsCampaignDynamicSorting == other.IsCampaignDynamicSorting ||
                    this.IsCampaignDynamicSorting != null &&
                    this.IsCampaignDynamicSorting.Equals(other.IsCampaignDynamicSorting)
                ) &&
                (
                    this.IsCampaignDynamicFiltering == other.IsCampaignDynamicFiltering ||
                    this.IsCampaignDynamicFiltering != null &&
                    this.IsCampaignDynamicFiltering.Equals(other.IsCampaignDynamicFiltering)
                ) &&
                (
                    this.OutboundCampaignHealthMask == other.OutboundCampaignHealthMask ||
                    this.OutboundCampaignHealthMask != null &&
                    this.OutboundCampaignHealthMask.Equals(other.OutboundCampaignHealthMask)
                ) &&
                (
                    this.IsReCall == other.IsReCall ||
                    this.IsReCall != null &&
                    this.IsReCall.Equals(other.IsReCall)
                ) &&
                (
                    this.ScheduledDateTime == other.ScheduledDateTime ||
                    this.ScheduledDateTime != null &&
                    this.ScheduledDateTime.Equals(other.ScheduledDateTime)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.IsRightPartyContact == other.IsRightPartyContact ||
                    this.IsRightPartyContact != null &&
                    this.IsRightPartyContact.Equals(other.IsRightPartyContact)
                ) &&
                (
                    this.CallAnalysisDisposition == other.CallAnalysisDisposition ||
                    this.CallAnalysisDisposition != null &&
                    this.CallAnalysisDisposition.Equals(other.CallAnalysisDisposition)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.IsPreviewAutoEnded == other.IsPreviewAutoEnded ||
                    this.IsPreviewAutoEnded != null &&
                    this.IsPreviewAutoEnded.Equals(other.IsPreviewAutoEnded)
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
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.VoiceAttributes != null)
                    hash = hash * 59 + this.VoiceAttributes.GetHashCode();

                if (this.WrapupCode != null)
                    hash = hash * 59 + this.WrapupCode.GetHashCode();

                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();

                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();

                if (this.AgentScriptId != null)
                    hash = hash * 59 + this.AgentScriptId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();

                if (this.OutboundContactListFilterId != null)
                    hash = hash * 59 + this.OutboundContactListFilterId.GetHashCode();

                if (this.OutboundQueueId != null)
                    hash = hash * 59 + this.OutboundQueueId.GetHashCode();

                if (this.OutboundContactId != null)
                    hash = hash * 59 + this.OutboundContactId.GetHashCode();

                if (this.IsCampaignAlwaysRunning != null)
                    hash = hash * 59 + this.IsCampaignAlwaysRunning.GetHashCode();

                if (this.IsCampaignSkillBased != null)
                    hash = hash * 59 + this.IsCampaignSkillBased.GetHashCode();

                if (this.IsCampaignDynamicSorting != null)
                    hash = hash * 59 + this.IsCampaignDynamicSorting.GetHashCode();

                if (this.IsCampaignDynamicFiltering != null)
                    hash = hash * 59 + this.IsCampaignDynamicFiltering.GetHashCode();

                if (this.OutboundCampaignHealthMask != null)
                    hash = hash * 59 + this.OutboundCampaignHealthMask.GetHashCode();

                if (this.IsReCall != null)
                    hash = hash * 59 + this.IsReCall.GetHashCode();

                if (this.ScheduledDateTime != null)
                    hash = hash * 59 + this.ScheduledDateTime.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.IsRightPartyContact != null)
                    hash = hash * 59 + this.IsRightPartyContact.GetHashCode();

                if (this.CallAnalysisDisposition != null)
                    hash = hash * 59 + this.CallAnalysisDisposition.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.IsPreviewAutoEnded != null)
                    hash = hash * 59 + this.IsPreviewAutoEnded.GetHashCode();

                return hash;
            }
        }
    }

}
