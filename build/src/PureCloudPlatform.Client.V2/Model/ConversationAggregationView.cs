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
    /// ConversationAggregationView
    /// </summary>
    [DataContract]
    public partial class ConversationAggregationView :  IEquatable<ConversationAggregationView>
    {
        /// <summary>
        /// Target metric name
        /// </summary>
        /// <value>Target metric name</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TargetEnum
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
            /// Enum Oservicelevel for "oServiceLevel"
            /// </summary>
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
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
            /// Enum Tshortabandon for "tShortAbandon"
            /// </summary>
            [EnumMember(Value = "tShortAbandon")]
            Tshortabandon,
            
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
            Tvoicemail,
            
            /// <summary>
            /// Enum Twait for "tWait"
            /// </summary>
            [EnumMember(Value = "tWait")]
            Twait
        }
        /// <summary>
        /// Type of view you wish to create
        /// </summary>
        /// <value>Type of view you wish to create</value>
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
            /// Enum Rangebound for "rangeBound"
            /// </summary>
            [EnumMember(Value = "rangeBound")]
            Rangebound
        }
        /// <summary>
        /// Target metric name
        /// </summary>
        /// <value>Target metric name</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }
        /// <summary>
        /// Type of view you wish to create
        /// </summary>
        /// <value>Type of view you wish to create</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public FunctionEnum? Function { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAggregationView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationAggregationView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAggregationView" /> class.
        /// </summary>
        /// <param name="Target">Target metric name (required).</param>
        /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
        /// <param name="Function">Type of view you wish to create (required).</param>
        /// <param name="Range">Range of numbers for slicing up data.</param>
        public ConversationAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
        {
            this.Target = Target;
            this.Name = Name;
            this.Function = Function;
            this.Range = Range;
            
        }
        




        /// <summary>
        /// A unique name for this view. Must be distinct from other views and built-in metric names.
        /// </summary>
        /// <value>A unique name for this view. Must be distinct from other views and built-in metric names.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Range of numbers for slicing up data
        /// </summary>
        /// <value>Range of numbers for slicing up data</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public AggregationRange Range { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAggregationView {\n");

            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as ConversationAggregationView);
        }

        /// <summary>
        /// Returns true if ConversationAggregationView instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAggregationView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAggregationView other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                return hash;
            }
        }
    }

}
