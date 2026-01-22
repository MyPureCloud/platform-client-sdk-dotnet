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
    /// EvaluationSearchAggregationDTO
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchAggregationDTO :  IEquatable<EvaluationSearchAggregationDTO>
    {
        /// <summary>
        /// The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate
        /// </summary>
        /// <value>The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Formid for "formId"
            /// </summary>
            [EnumMember(Value = "formId")]
            Formid,
            
            /// <summary>
            /// Enum Formidreleased for "formIdReleased"
            /// </summary>
            [EnumMember(Value = "formIdReleased")]
            Formidreleased,
            
            /// <summary>
            /// Enum Contextid for "contextId"
            /// </summary>
            [EnumMember(Value = "contextId")]
            Contextid,
            
            /// <summary>
            /// Enum Questiongroupid for "questionGroupId"
            /// </summary>
            [EnumMember(Value = "questionGroupId")]
            Questiongroupid,
            
            /// <summary>
            /// Enum Questionid for "questionId"
            /// </summary>
            [EnumMember(Value = "questionId")]
            Questionid,
            
            /// <summary>
            /// Enum Questionanswerid for "questionAnswerId"
            /// </summary>
            [EnumMember(Value = "questionAnswerId")]
            Questionanswerid,
            
            /// <summary>
            /// Enum Evaluationstatus for "evaluationStatus"
            /// </summary>
            [EnumMember(Value = "evaluationStatus")]
            Evaluationstatus,
            
            /// <summary>
            /// Enum Aiscoringfailuretype for "aiScoringFailureType"
            /// </summary>
            [EnumMember(Value = "aiScoringFailureType")]
            Aiscoringfailuretype,
            
            /// <summary>
            /// Enum Questionaianswerfailuretype for "questionAiAnswerFailureType"
            /// </summary>
            [EnumMember(Value = "questionAiAnswerFailureType")]
            Questionaianswerfailuretype,
            
            /// <summary>
            /// Enum Released for "released"
            /// </summary>
            [EnumMember(Value = "released")]
            Released,
            
            /// <summary>
            /// Enum Questiongroupmarkedna for "questionGroupMarkedNA"
            /// </summary>
            [EnumMember(Value = "questionGroupMarkedNA")]
            Questiongroupmarkedna,
            
            /// <summary>
            /// Enum Questionmarkedna for "questionMarkedNA"
            /// </summary>
            [EnumMember(Value = "questionMarkedNA")]
            Questionmarkedna,
            
            /// <summary>
            /// Enum Questionaiscored for "questionAiScored"
            /// </summary>
            [EnumMember(Value = "questionAiScored")]
            Questionaiscored,
            
            /// <summary>
            /// Enum Questioneascored for "questionEaScored"
            /// </summary>
            [EnumMember(Value = "questionEaScored")]
            Questioneascored,
            
            /// <summary>
            /// Enum Totalscore for "totalScore"
            /// </summary>
            [EnumMember(Value = "totalScore")]
            Totalscore,
            
            /// <summary>
            /// Enum Totalcriticalscore for "totalCriticalScore"
            /// </summary>
            [EnumMember(Value = "totalCriticalScore")]
            Totalcriticalscore,
            
            /// <summary>
            /// Enum Questiongroupscorepercentage for "questionGroupScorePercentage"
            /// </summary>
            [EnumMember(Value = "questionGroupScorePercentage")]
            Questiongroupscorepercentage,
            
            /// <summary>
            /// Enum Criticalquestiongroupscorepercentage for "criticalQuestionGroupScorePercentage"
            /// </summary>
            [EnumMember(Value = "criticalQuestionGroupScorePercentage")]
            Criticalquestiongroupscorepercentage,
            
            /// <summary>
            /// Enum Questiongroupscore for "questionGroupScore"
            /// </summary>
            [EnumMember(Value = "questionGroupScore")]
            Questiongroupscore,
            
            /// <summary>
            /// Enum Criticalquestiongroupscore for "criticalQuestionGroupScore"
            /// </summary>
            [EnumMember(Value = "criticalQuestionGroupScore")]
            Criticalquestiongroupscore,
            
            /// <summary>
            /// Enum Questionscore for "questionScore"
            /// </summary>
            [EnumMember(Value = "questionScore")]
            Questionscore,
            
            /// <summary>
            /// Enum Disputecount for "disputeCount"
            /// </summary>
            [EnumMember(Value = "disputeCount")]
            Disputecount,
            
            /// <summary>
            /// Enum Rescorecount for "rescoreCount"
            /// </summary>
            [EnumMember(Value = "rescoreCount")]
            Rescorecount,
            
            /// <summary>
            /// Enum Easuggestioncount for "eaSuggestionCount"
            /// </summary>
            [EnumMember(Value = "eaSuggestionCount")]
            Easuggestioncount,
            
            /// <summary>
            /// Enum Eaacceptedsuggestioncount for "eaAcceptedSuggestionCount"
            /// </summary>
            [EnumMember(Value = "eaAcceptedSuggestionCount")]
            Eaacceptedsuggestioncount,
            
            /// <summary>
            /// Enum Aisuggestioncount for "aiSuggestionCount"
            /// </summary>
            [EnumMember(Value = "aiSuggestionCount")]
            Aisuggestioncount,
            
            /// <summary>
            /// Enum Aiacceptedsuggestioncount for "aiAcceptedSuggestionCount"
            /// </summary>
            [EnumMember(Value = "aiAcceptedSuggestionCount")]
            Aiacceptedsuggestioncount,
            
            /// <summary>
            /// Enum Conversationdate for "conversationDate"
            /// </summary>
            [EnumMember(Value = "conversationDate")]
            Conversationdate,
            
            /// <summary>
            /// Enum Createddate for "createdDate"
            /// </summary>
            [EnumMember(Value = "createdDate")]
            Createddate,
            
            /// <summary>
            /// Enum Submitteddate for "submittedDate"
            /// </summary>
            [EnumMember(Value = "submittedDate")]
            Submitteddate,
            
            /// <summary>
            /// Enum Releasedate for "releaseDate"
            /// </summary>
            [EnumMember(Value = "releaseDate")]
            Releasedate
        }
        /// <summary>
        /// The Type of Aggregation to Perform
        /// </summary>
        /// <value>The Type of Aggregation to Perform</value>
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
            /// Enum Term for "TERM"
            /// </summary>
            [EnumMember(Value = "TERM")]
            Term,
            
            /// <summary>
            /// Enum Stats for "STATS"
            /// </summary>
            [EnumMember(Value = "STATS")]
            Stats,
            
            /// <summary>
            /// Enum Sum for "SUM"
            /// </summary>
            [EnumMember(Value = "SUM")]
            Sum,
            
            /// <summary>
            /// Enum Count for "COUNT"
            /// </summary>
            [EnumMember(Value = "COUNT")]
            Count,
            
            /// <summary>
            /// Enum Average for "AVERAGE"
            /// </summary>
            [EnumMember(Value = "AVERAGE")]
            Average,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum DateHistogram for "DATE_HISTOGRAM"
            /// </summary>
            [EnumMember(Value = "DATE_HISTOGRAM")]
            DateHistogram
        }
        /// <summary>
        /// The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate
        /// </summary>
        /// <value>The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// The Type of Aggregation to Perform
        /// </summary>
        /// <value>The Type of Aggregation to Perform</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchAggregationDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationSearchAggregationDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchAggregationDTO" /> class.
        /// </summary>
        /// <param name="Name">The name of the aggregation (required).</param>
        /// <param name="Field">The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate (required).</param>
        /// <param name="Type">The Type of Aggregation to Perform (required).</param>
        /// <param name="Size">The size limit for term aggregations, 100 size limit for all fields.</param>
        /// <param name="CalendarInterval">The calendar interval for date histogram aggregations.</param>
        /// <param name="Format">The format for date histogram aggregations.</param>
        /// <param name="Ranges">The ranges for range aggregations.</param>
        /// <param name="SubAggregations">Sub-aggregations to be computed within this aggregation.</param>
        public EvaluationSearchAggregationDTO(string Name = null, FieldEnum? Field = null, TypeEnum? Type = null, int? Size = null, string CalendarInterval = null, string Format = null, List<QueryApiSearchAggregationRange> Ranges = null, List<EvaluationSearchSubAggregationDTO> SubAggregations = null)
        {
            this.Name = Name;
            this.Field = Field;
            this.Type = Type;
            this.Size = Size;
            this.CalendarInterval = CalendarInterval;
            this.Format = Format;
            this.Ranges = Ranges;
            this.SubAggregations = SubAggregations;
            
        }
        


        /// <summary>
        /// The name of the aggregation
        /// </summary>
        /// <value>The name of the aggregation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }







        /// <summary>
        /// The size limit for term aggregations, 100 size limit for all fields
        /// </summary>
        /// <value>The size limit for term aggregations, 100 size limit for all fields</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }



        /// <summary>
        /// The calendar interval for date histogram aggregations
        /// </summary>
        /// <value>The calendar interval for date histogram aggregations</value>
        [DataMember(Name="calendarInterval", EmitDefaultValue=false)]
        public string CalendarInterval { get; set; }



        /// <summary>
        /// The format for date histogram aggregations
        /// </summary>
        /// <value>The format for date histogram aggregations</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }



        /// <summary>
        /// The ranges for range aggregations
        /// </summary>
        /// <value>The ranges for range aggregations</value>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<QueryApiSearchAggregationRange> Ranges { get; set; }



        /// <summary>
        /// Sub-aggregations to be computed within this aggregation
        /// </summary>
        /// <value>Sub-aggregations to be computed within this aggregation</value>
        [DataMember(Name="subAggregations", EmitDefaultValue=false)]
        public List<EvaluationSearchSubAggregationDTO> SubAggregations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchAggregationDTO {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  CalendarInterval: ").Append(CalendarInterval).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  SubAggregations: ").Append(SubAggregations).Append("\n");
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
            return this.Equals(obj as EvaluationSearchAggregationDTO);
        }

        /// <summary>
        /// Returns true if EvaluationSearchAggregationDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchAggregationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchAggregationDTO other)
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
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.CalendarInterval == other.CalendarInterval ||
                    this.CalendarInterval != null &&
                    this.CalendarInterval.Equals(other.CalendarInterval)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) &&
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(other.Ranges)
                ) &&
                (
                    this.SubAggregations == other.SubAggregations ||
                    this.SubAggregations != null &&
                    this.SubAggregations.SequenceEqual(other.SubAggregations)
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

                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.CalendarInterval != null)
                    hash = hash * 59 + this.CalendarInterval.GetHashCode();

                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();

                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();

                if (this.SubAggregations != null)
                    hash = hash * 59 + this.SubAggregations.GetHashCode();

                return hash;
            }
        }
    }

}
