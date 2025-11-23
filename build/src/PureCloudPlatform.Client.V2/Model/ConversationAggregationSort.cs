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
    /// ConversationAggregationSort
    /// </summary>
    [DataContract]
    public partial class ConversationAggregationSort :  IEquatable<ConversationAggregationSort>
    {
        /// <summary>
        /// Name of the metric used for sorting values.
        /// </summary>
        /// <value>Name of the metric used for sorting values.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Nblindtransferred for "nBlindTransferred"
            /// </summary>
            [EnumMember(Value = "nBlindTransferred")]
            Nblindtransferred,
            
            /// <summary>
            /// Enum Nbotinteractions for "nBotInteractions"
            /// </summary>
            [EnumMember(Value = "nBotInteractions")]
            Nbotinteractions,
            
            /// <summary>
            /// Enum Ncobrowsesessions for "nCobrowseSessions"
            /// </summary>
            [EnumMember(Value = "nCobrowseSessions")]
            Ncobrowsesessions,
            
            /// <summary>
            /// Enum Nconnected for "nConnected"
            /// </summary>
            [EnumMember(Value = "nConnected")]
            Nconnected,
            
            /// <summary>
            /// Enum Nconsult for "nConsult"
            /// </summary>
            [EnumMember(Value = "nConsult")]
            Nconsult,
            
            /// <summary>
            /// Enum Nconsulttransferred for "nConsultTransferred"
            /// </summary>
            [EnumMember(Value = "nConsultTransferred")]
            Nconsulttransferred,
            
            /// <summary>
            /// Enum Nconversations for "nConversations"
            /// </summary>
            [EnumMember(Value = "nConversations")]
            Nconversations,
            
            /// <summary>
            /// Enum Nerror for "nError"
            /// </summary>
            [EnumMember(Value = "nError")]
            Nerror,
            
            /// <summary>
            /// Enum Noffered for "nOffered"
            /// </summary>
            [EnumMember(Value = "nOffered")]
            Noffered,
            
            /// <summary>
            /// Enum Noutbound for "nOutbound"
            /// </summary>
            [EnumMember(Value = "nOutbound")]
            Noutbound,
            
            /// <summary>
            /// Enum Noutboundabandoned for "nOutboundAbandoned"
            /// </summary>
            [EnumMember(Value = "nOutboundAbandoned")]
            Noutboundabandoned,
            
            /// <summary>
            /// Enum Noutboundattempted for "nOutboundAttempted"
            /// </summary>
            [EnumMember(Value = "nOutboundAttempted")]
            Noutboundattempted,
            
            /// <summary>
            /// Enum Noutboundconnected for "nOutboundConnected"
            /// </summary>
            [EnumMember(Value = "nOutboundConnected")]
            Noutboundconnected,
            
            /// <summary>
            /// Enum Noversla for "nOverSla"
            /// </summary>
            [EnumMember(Value = "nOverSla")]
            Noversla,
            
            /// <summary>
            /// Enum Nstatetransitionerror for "nStateTransitionError"
            /// </summary>
            [EnumMember(Value = "nStateTransitionError")]
            Nstatetransitionerror,
            
            /// <summary>
            /// Enum Ntransferred for "nTransferred"
            /// </summary>
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            /// <summary>
            /// Enum Oaudiomessagecount for "oAudioMessageCount"
            /// </summary>
            [EnumMember(Value = "oAudioMessageCount")]
            Oaudiomessagecount,
            
            /// <summary>
            /// Enum Oexternalaudiomessagecount for "oExternalAudioMessageCount"
            /// </summary>
            [EnumMember(Value = "oExternalAudioMessageCount")]
            Oexternalaudiomessagecount,
            
            /// <summary>
            /// Enum Oexternalmediacount for "oExternalMediaCount"
            /// </summary>
            [EnumMember(Value = "oExternalMediaCount")]
            Oexternalmediacount,
            
            /// <summary>
            /// Enum Omediacount for "oMediaCount"
            /// </summary>
            [EnumMember(Value = "oMediaCount")]
            Omediacount,
            
            /// <summary>
            /// Enum Omessagecount for "oMessageCount"
            /// </summary>
            [EnumMember(Value = "oMessageCount")]
            Omessagecount,
            
            /// <summary>
            /// Enum Omessagesegmentcount for "oMessageSegmentCount"
            /// </summary>
            [EnumMember(Value = "oMessageSegmentCount")]
            Omessagesegmentcount,
            
            /// <summary>
            /// Enum Omessageturn for "oMessageTurn"
            /// </summary>
            [EnumMember(Value = "oMessageTurn")]
            Omessageturn,
            
            /// <summary>
            /// Enum Oservicetarget for "oServiceTarget"
            /// </summary>
            [EnumMember(Value = "oServiceTarget")]
            Oservicetarget,
            
            /// <summary>
            /// Enum Tabandon for "tAbandon"
            /// </summary>
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            /// <summary>
            /// Enum Tacd for "tAcd"
            /// </summary>
            [EnumMember(Value = "tAcd")]
            Tacd,
            
            /// <summary>
            /// Enum Tactivecallback for "tActiveCallback"
            /// </summary>
            [EnumMember(Value = "tActiveCallback")]
            Tactivecallback,
            
            /// <summary>
            /// Enum Tactivecallbackcomplete for "tActiveCallbackComplete"
            /// </summary>
            [EnumMember(Value = "tActiveCallbackComplete")]
            Tactivecallbackcomplete,
            
            /// <summary>
            /// Enum Tacw for "tAcw"
            /// </summary>
            [EnumMember(Value = "tAcw")]
            Tacw,
            
            /// <summary>
            /// Enum Tagentresponsetime for "tAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAgentResponseTime")]
            Tagentresponsetime,
            
            /// <summary>
            /// Enum Tagentvideoconnected for "tAgentVideoConnected"
            /// </summary>
            [EnumMember(Value = "tAgentVideoConnected")]
            Tagentvideoconnected,
            
            /// <summary>
            /// Enum Talert for "tAlert"
            /// </summary>
            [EnumMember(Value = "tAlert")]
            Talert,
            
            /// <summary>
            /// Enum Tanswered for "tAnswered"
            /// </summary>
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            /// <summary>
            /// Enum Taverageagentresponsetime for "tAverageAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAverageAgentResponseTime")]
            Taverageagentresponsetime,
            
            /// <summary>
            /// Enum Taveragecustomerresponsetime for "tAverageCustomerResponseTime"
            /// </summary>
            [EnumMember(Value = "tAverageCustomerResponseTime")]
            Taveragecustomerresponsetime,
            
            /// <summary>
            /// Enum Tbarging for "tBarging"
            /// </summary>
            [EnumMember(Value = "tBarging")]
            Tbarging,
            
            /// <summary>
            /// Enum Tcoaching for "tCoaching"
            /// </summary>
            [EnumMember(Value = "tCoaching")]
            Tcoaching,
            
            /// <summary>
            /// Enum Tcoachingcomplete for "tCoachingComplete"
            /// </summary>
            [EnumMember(Value = "tCoachingComplete")]
            Tcoachingcomplete,
            
            /// <summary>
            /// Enum Tconnected for "tConnected"
            /// </summary>
            [EnumMember(Value = "tConnected")]
            Tconnected,
            
            /// <summary>
            /// Enum Tcontacting for "tContacting"
            /// </summary>
            [EnumMember(Value = "tContacting")]
            Tcontacting,
            
            /// <summary>
            /// Enum Tdialing for "tDialing"
            /// </summary>
            [EnumMember(Value = "tDialing")]
            Tdialing,
            
            /// <summary>
            /// Enum Tfirstconnect for "tFirstConnect"
            /// </summary>
            [EnumMember(Value = "tFirstConnect")]
            Tfirstconnect,
            
            /// <summary>
            /// Enum Tfirstdial for "tFirstDial"
            /// </summary>
            [EnumMember(Value = "tFirstDial")]
            Tfirstdial,
            
            /// <summary>
            /// Enum Tfirstengagement for "tFirstEngagement"
            /// </summary>
            [EnumMember(Value = "tFirstEngagement")]
            Tfirstengagement,
            
            /// <summary>
            /// Enum Tfirstresponse for "tFirstResponse"
            /// </summary>
            [EnumMember(Value = "tFirstResponse")]
            Tfirstresponse,
            
            /// <summary>
            /// Enum Tflowout for "tFlowOut"
            /// </summary>
            [EnumMember(Value = "tFlowOut")]
            Tflowout,
            
            /// <summary>
            /// Enum Thandle for "tHandle"
            /// </summary>
            [EnumMember(Value = "tHandle")]
            Thandle,
            
            /// <summary>
            /// Enum Theld for "tHeld"
            /// </summary>
            [EnumMember(Value = "tHeld")]
            Theld,
            
            /// <summary>
            /// Enum Theldcomplete for "tHeldComplete"
            /// </summary>
            [EnumMember(Value = "tHeldComplete")]
            Theldcomplete,
            
            /// <summary>
            /// Enum Tivr for "tIvr"
            /// </summary>
            [EnumMember(Value = "tIvr")]
            Tivr,
            
            /// <summary>
            /// Enum Tmonitoring for "tMonitoring"
            /// </summary>
            [EnumMember(Value = "tMonitoring")]
            Tmonitoring,
            
            /// <summary>
            /// Enum Tmonitoringcomplete for "tMonitoringComplete"
            /// </summary>
            [EnumMember(Value = "tMonitoringComplete")]
            Tmonitoringcomplete,
            
            /// <summary>
            /// Enum Tnotresponding for "tNotResponding"
            /// </summary>
            [EnumMember(Value = "tNotResponding")]
            Tnotresponding,
            
            /// <summary>
            /// Enum Tpark for "tPark"
            /// </summary>
            [EnumMember(Value = "tPark")]
            Tpark,
            
            /// <summary>
            /// Enum Tparkcomplete for "tParkComplete"
            /// </summary>
            [EnumMember(Value = "tParkComplete")]
            Tparkcomplete,
            
            /// <summary>
            /// Enum Ttalk for "tTalk"
            /// </summary>
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            /// <summary>
            /// Enum Ttalkcomplete for "tTalkComplete"
            /// </summary>
            [EnumMember(Value = "tTalkComplete")]
            Ttalkcomplete,
            
            /// <summary>
            /// Enum Tuserresponsetime for "tUserResponseTime"
            /// </summary>
            [EnumMember(Value = "tUserResponseTime")]
            Tuserresponsetime,
            
            /// <summary>
            /// Enum Tvoicemail for "tVoicemail"
            /// </summary>
            [EnumMember(Value = "tVoicemail")]
            Tvoicemail
        }
        /// <summary>
        /// Aggregation function used for the sort metric.
        /// </summary>
        /// <value>Aggregation function used for the sort metric.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FunctionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Average for "average"
            /// </summary>
            [EnumMember(Value = "average")]
            Average,
            
            /// <summary>
            /// Enum Count for "count"
            /// </summary>
            [EnumMember(Value = "count")]
            Count,
            
            /// <summary>
            /// Enum Max for "max"
            /// </summary>
            [EnumMember(Value = "max")]
            Max,
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Sum for "sum"
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum
        }
        /// <summary>
        /// Name of the metric used for sorting values.
        /// </summary>
        /// <value>Name of the metric used for sorting values.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Aggregation function used for the sort metric.
        /// </summary>
        /// <value>Aggregation function used for the sort metric.</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public FunctionEnum? Function { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAggregationSort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationAggregationSort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAggregationSort" /> class.
        /// </summary>
        /// <param name="Name">Name of the metric used for sorting values. (required).</param>
        /// <param name="Function">Aggregation function used for the sort metric. (required).</param>
        public ConversationAggregationSort(NameEnum? Name = null, FunctionEnum? Function = null)
        {
            this.Name = Name;
            this.Function = Function;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAggregationSort {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
            return this.Equals(obj as ConversationAggregationSort);
        }

        /// <summary>
        /// Returns true if ConversationAggregationSort instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAggregationSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAggregationSort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();

                return hash;
            }
        }
    }

}
