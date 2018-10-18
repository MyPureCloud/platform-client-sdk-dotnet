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
    /// ObservationQuery
    /// </summary>
    [DataContract]
    public partial class ObservationQuery :  IEquatable<ObservationQuery>
    {
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Tsegmentduration for "tSegmentDuration"
            /// </summary>
            [EnumMember(Value = "tSegmentDuration")]
            Tsegmentduration,
            
            /// <summary>
            /// Enum Tconversationduration for "tConversationDuration"
            /// </summary>
            [EnumMember(Value = "tConversationDuration")]
            Tconversationduration,
            
            /// <summary>
            /// Enum Ototalcriticalscore for "oTotalCriticalScore"
            /// </summary>
            [EnumMember(Value = "oTotalCriticalScore")]
            Ototalcriticalscore,
            
            /// <summary>
            /// Enum Ototalscore for "oTotalScore"
            /// </summary>
            [EnumMember(Value = "oTotalScore")]
            Ototalscore,
            
            /// <summary>
            /// Enum Nevaluations for "nEvaluations"
            /// </summary>
            [EnumMember(Value = "nEvaluations")]
            Nevaluations,
            
            /// <summary>
            /// Enum Tabandon for "tAbandon"
            /// </summary>
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            /// <summary>
            /// Enum Tivr for "tIvr"
            /// </summary>
            [EnumMember(Value = "tIvr")]
            Tivr,
            
            /// <summary>
            /// Enum Tanswered for "tAnswered"
            /// </summary>
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            /// <summary>
            /// Enum Tflowout for "tFlowOut"
            /// </summary>
            [EnumMember(Value = "tFlowOut")]
            Tflowout,
            
            /// <summary>
            /// Enum Tacd for "tAcd"
            /// </summary>
            [EnumMember(Value = "tAcd")]
            Tacd,
            
            /// <summary>
            /// Enum Ttalk for "tTalk"
            /// </summary>
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            /// <summary>
            /// Enum Theld for "tHeld"
            /// </summary>
            [EnumMember(Value = "tHeld")]
            Theld,
            
            /// <summary>
            /// Enum Ttalkcomplete for "tTalkComplete"
            /// </summary>
            [EnumMember(Value = "tTalkComplete")]
            Ttalkcomplete,
            
            /// <summary>
            /// Enum Theldcomplete for "tHeldComplete"
            /// </summary>
            [EnumMember(Value = "tHeldComplete")]
            Theldcomplete,
            
            /// <summary>
            /// Enum Tacw for "tAcw"
            /// </summary>
            [EnumMember(Value = "tAcw")]
            Tacw,
            
            /// <summary>
            /// Enum Thandle for "tHandle"
            /// </summary>
            [EnumMember(Value = "tHandle")]
            Thandle,
            
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
            /// Enum Twait for "tWait"
            /// </summary>
            [EnumMember(Value = "tWait")]
            Twait,
            
            /// <summary>
            /// Enum Tagentroutingstatus for "tAgentRoutingStatus"
            /// </summary>
            [EnumMember(Value = "tAgentRoutingStatus")]
            Tagentroutingstatus,
            
            /// <summary>
            /// Enum Torganizationpresence for "tOrganizationPresence"
            /// </summary>
            [EnumMember(Value = "tOrganizationPresence")]
            Torganizationpresence,
            
            /// <summary>
            /// Enum Tsystempresence for "tSystemPresence"
            /// </summary>
            [EnumMember(Value = "tSystemPresence")]
            Tsystempresence,
            
            /// <summary>
            /// Enum Tuserresponsetime for "tUserResponseTime"
            /// </summary>
            [EnumMember(Value = "tUserResponseTime")]
            Tuserresponsetime,
            
            /// <summary>
            /// Enum Tagentresponsetime for "tAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAgentResponseTime")]
            Tagentresponsetime,
            
            /// <summary>
            /// Enum Tvoicemail for "tVoicemail"
            /// </summary>
            [EnumMember(Value = "tVoicemail")]
            Tvoicemail,
            
            /// <summary>
            /// Enum Nstatetransitionerror for "nStateTransitionError"
            /// </summary>
            [EnumMember(Value = "nStateTransitionError")]
            Nstatetransitionerror,
            
            /// <summary>
            /// Enum Noffered for "nOffered"
            /// </summary>
            [EnumMember(Value = "nOffered")]
            Noffered,
            
            /// <summary>
            /// Enum Noversla for "nOverSla"
            /// </summary>
            [EnumMember(Value = "nOverSla")]
            Noversla,
            
            /// <summary>
            /// Enum Ntransferred for "nTransferred"
            /// </summary>
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            /// <summary>
            /// Enum Nblindtransferred for "nBlindTransferred"
            /// </summary>
            [EnumMember(Value = "nBlindTransferred")]
            Nblindtransferred,
            
            /// <summary>
            /// Enum Nconsulttransferred for "nConsultTransferred"
            /// </summary>
            [EnumMember(Value = "nConsultTransferred")]
            Nconsulttransferred,
            
            /// <summary>
            /// Enum Nconsult for "nConsult"
            /// </summary>
            [EnumMember(Value = "nConsult")]
            Nconsult,
            
            /// <summary>
            /// Enum Talert for "tAlert"
            /// </summary>
            [EnumMember(Value = "tAlert")]
            Talert,
            
            /// <summary>
            /// Enum Tnotresponding for "tNotResponding"
            /// </summary>
            [EnumMember(Value = "tNotResponding")]
            Tnotresponding,
            
            /// <summary>
            /// Enum Noutbound for "nOutbound"
            /// </summary>
            [EnumMember(Value = "nOutbound")]
            Noutbound,
            
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
            /// Enum Noutboundabandoned for "nOutboundAbandoned"
            /// </summary>
            [EnumMember(Value = "nOutboundAbandoned")]
            Noutboundabandoned,
            
            /// <summary>
            /// Enum Nerror for "nError"
            /// </summary>
            [EnumMember(Value = "nError")]
            Nerror,
            
            /// <summary>
            /// Enum Oservicetarget for "oServiceTarget"
            /// </summary>
            [EnumMember(Value = "oServiceTarget")]
            Oservicetarget,
            
            /// <summary>
            /// Enum Oservicelevel for "oServiceLevel"
            /// </summary>
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
            /// <summary>
            /// Enum Tactive for "tActive"
            /// </summary>
            [EnumMember(Value = "tActive")]
            Tactive,
            
            /// <summary>
            /// Enum Tinactive for "tInactive"
            /// </summary>
            [EnumMember(Value = "tInactive")]
            Tinactive,
            
            /// <summary>
            /// Enum Oactiveusers for "oActiveUsers"
            /// </summary>
            [EnumMember(Value = "oActiveUsers")]
            Oactiveusers,
            
            /// <summary>
            /// Enum Omemberusers for "oMemberUsers"
            /// </summary>
            [EnumMember(Value = "oMemberUsers")]
            Omemberusers,
            
            /// <summary>
            /// Enum Oactivequeues for "oActiveQueues"
            /// </summary>
            [EnumMember(Value = "oActiveQueues")]
            Oactivequeues,
            
            /// <summary>
            /// Enum Omemberqueues for "oMemberQueues"
            /// </summary>
            [EnumMember(Value = "oMemberQueues")]
            Omemberqueues,
            
            /// <summary>
            /// Enum Ointeracting for "oInteracting"
            /// </summary>
            [EnumMember(Value = "oInteracting")]
            Ointeracting,
            
            /// <summary>
            /// Enum Owaiting for "oWaiting"
            /// </summary>
            [EnumMember(Value = "oWaiting")]
            Owaiting,
            
            /// <summary>
            /// Enum Oonqueueusers for "oOnQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOnQueueUsers")]
            Oonqueueusers,
            
            /// <summary>
            /// Enum Ooffqueueusers for "oOffQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOffQueueUsers")]
            Ooffqueueusers,
            
            /// <summary>
            /// Enum Ouserpresences for "oUserPresences"
            /// </summary>
            [EnumMember(Value = "oUserPresences")]
            Ouserpresences,
            
            /// <summary>
            /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
            /// </summary>
            [EnumMember(Value = "oUserRoutingStatuses")]
            Ouserroutingstatuses,
            
            /// <summary>
            /// Enum Nsurveyssent for "nSurveysSent"
            /// </summary>
            [EnumMember(Value = "nSurveysSent")]
            Nsurveyssent,
            
            /// <summary>
            /// Enum Nsurveysstarted for "nSurveysStarted"
            /// </summary>
            [EnumMember(Value = "nSurveysStarted")]
            Nsurveysstarted,
            
            /// <summary>
            /// Enum Nsurveysabandoned for "nSurveysAbandoned"
            /// </summary>
            [EnumMember(Value = "nSurveysAbandoned")]
            Nsurveysabandoned,
            
            /// <summary>
            /// Enum Nsurveysexpired for "nSurveysExpired"
            /// </summary>
            [EnumMember(Value = "nSurveysExpired")]
            Nsurveysexpired,
            
            /// <summary>
            /// Enum Nsurveysbounced for "nSurveysBounced"
            /// </summary>
            [EnumMember(Value = "nSurveysBounced")]
            Nsurveysbounced,
            
            /// <summary>
            /// Enum Nsurveyresponses for "nSurveyResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyResponses")]
            Nsurveyresponses,
            
            /// <summary>
            /// Enum Nsurveyanswerresponses for "nSurveyAnswerResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyAnswerResponses")]
            Nsurveyanswerresponses,
            
            /// <summary>
            /// Enum Osurveytotalscore for "oSurveyTotalScore"
            /// </summary>
            [EnumMember(Value = "oSurveyTotalScore")]
            Osurveytotalscore,
            
            /// <summary>
            /// Enum Osurveyquestiongroupscore for "oSurveyQuestionGroupScore"
            /// </summary>
            [EnumMember(Value = "oSurveyQuestionGroupScore")]
            Osurveyquestiongroupscore,
            
            /// <summary>
            /// Enum Nsurveyquestiongroupresponses for "nSurveyQuestionGroupResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyQuestionGroupResponses")]
            Nsurveyquestiongroupresponses,
            
            /// <summary>
            /// Enum Osurveyquestionscore for "oSurveyQuestionScore"
            /// </summary>
            [EnumMember(Value = "oSurveyQuestionScore")]
            Osurveyquestionscore,
            
            /// <summary>
            /// Enum Nsurveyquestionresponses for "nSurveyQuestionResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyQuestionResponses")]
            Nsurveyquestionresponses,
            
            /// <summary>
            /// Enum Nsurveynpsresponses for "nSurveyNpsResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsResponses")]
            Nsurveynpsresponses,
            
            /// <summary>
            /// Enum Nsurveynpspromoters for "nSurveyNpsPromoters"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsPromoters")]
            Nsurveynpspromoters,
            
            /// <summary>
            /// Enum Nsurveynpsdetractors for "nSurveyNpsDetractors"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsDetractors")]
            Nsurveynpsdetractors,
            
            /// <summary>
            /// Enum Nflow for "nFlow"
            /// </summary>
            [EnumMember(Value = "nFlow")]
            Nflow,
            
            /// <summary>
            /// Enum Tflowhangup for "tFlowHangUp"
            /// </summary>
            [EnumMember(Value = "tFlowHangUp")]
            Tflowhangup,
            
            /// <summary>
            /// Enum Tflowexit for "tFlowExit"
            /// </summary>
            [EnumMember(Value = "tFlowExit")]
            Tflowexit,
            
            /// <summary>
            /// Enum Tflow for "tFlow"
            /// </summary>
            [EnumMember(Value = "tFlow")]
            Tflow,
            
            /// <summary>
            /// Enum Tflowoutcome for "tFlowOutcome"
            /// </summary>
            [EnumMember(Value = "tFlowOutcome")]
            Tflowoutcome,
            
            /// <summary>
            /// Enum Nflowoutcome for "nFlowOutcome"
            /// </summary>
            [EnumMember(Value = "nFlowOutcome")]
            Nflowoutcome
        }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationQuery() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationQuery" /> class.
        /// </summary>
        /// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters (required).</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *)..</param>
        public ObservationQuery(AnalyticsQueryFilter Filter = null, List<MetricsEnum> Metrics = null)
        {
            this.Filter = Filter;
            this.Metrics = Metrics;
            
        }
        
        
        
        /// <summary>
        /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public AnalyticsQueryFilter Filter { get; set; }
        
        
        
        /// <summary>
        /// Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *).</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObservationQuery {\n");
            
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
            return this.Equals(obj as ObservationQuery);
        }

        /// <summary>
        /// Returns true if ObservationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ObservationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
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
                
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                
                return hash;
            }
        }
    }

}
