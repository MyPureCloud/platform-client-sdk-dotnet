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
    /// EvaluationSearchCriteriaDTO
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchCriteriaDTO :  IEquatable<EvaluationSearchCriteriaDTO>
    {
        /// <summary>
        /// The type of query Operation to Perform
        /// </summary>
        /// <value>The type of query Operation to Perform</value>
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
            /// Enum Exact for "EXACT"
            /// </summary>
            [EnumMember(Value = "EXACT")]
            Exact,
            
            /// <summary>
            /// Enum DateRange for "DATE_RANGE"
            /// </summary>
            [EnumMember(Value = "DATE_RANGE")]
            DateRange,
            
            /// <summary>
            /// Enum GreaterThan for "GREATER_THAN"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            /// <summary>
            /// Enum GreaterThanEqualTo for "GREATER_THAN_EQUAL_TO"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN_EQUAL_TO")]
            GreaterThanEqualTo,
            
            /// <summary>
            /// Enum LessThan for "LESS_THAN"
            /// </summary>
            [EnumMember(Value = "LESS_THAN")]
            LessThan,
            
            /// <summary>
            /// Enum LessThanEqualTo for "LESS_THAN_EQUAL_TO"
            /// </summary>
            [EnumMember(Value = "LESS_THAN_EQUAL_TO")]
            LessThanEqualTo,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum RequiredFields for "REQUIRED_FIELDS"
            /// </summary>
            [EnumMember(Value = "REQUIRED_FIELDS")]
            RequiredFields
        }
        /// <summary>
        /// Field name to search against
        /// </summary>
        /// <value>Field name to search against</value>
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
            /// Enum Evaluationid for "evaluationId"
            /// </summary>
            [EnumMember(Value = "evaluationId")]
            Evaluationid,
            
            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Contextid for "contextId"
            /// </summary>
            [EnumMember(Value = "contextId")]
            Contextid,
            
            /// <summary>
            /// Enum Formid for "formId"
            /// </summary>
            [EnumMember(Value = "formId")]
            Formid,
            
            /// <summary>
            /// Enum Evaluationstatus for "evaluationStatus"
            /// </summary>
            [EnumMember(Value = "evaluationStatus")]
            Evaluationstatus,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Agentteamid for "agentTeamId"
            /// </summary>
            [EnumMember(Value = "agentTeamId")]
            Agentteamid,
            
            /// <summary>
            /// Enum Divisionid for "divisionId"
            /// </summary>
            [EnumMember(Value = "divisionId")]
            Divisionid,
            
            /// <summary>
            /// Enum Agentid for "agentId"
            /// </summary>
            [EnumMember(Value = "agentId")]
            Agentid,
            
            /// <summary>
            /// Enum Evaluatorid for "evaluatorId"
            /// </summary>
            [EnumMember(Value = "evaluatorId")]
            Evaluatorid,
            
            /// <summary>
            /// Enum Assigneeid for "assigneeId"
            /// </summary>
            [EnumMember(Value = "assigneeId")]
            Assigneeid,
            
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
            Releasedate,
            
            /// <summary>
            /// Enum Released for "released"
            /// </summary>
            [EnumMember(Value = "released")]
            Released,
            
            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            /// <summary>
            /// Enum Questiongroupid for "questionGroupId"
            /// </summary>
            [EnumMember(Value = "questionGroupId")]
            Questiongroupid,
            
            /// <summary>
            /// Enum Questiongroupmarkedna for "questionGroupMarkedNA"
            /// </summary>
            [EnumMember(Value = "questionGroupMarkedNA")]
            Questiongroupmarkedna,
            
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
            /// Enum Questionscore for "questionScore"
            /// </summary>
            [EnumMember(Value = "questionScore")]
            Questionscore,
            
            /// <summary>
            /// Enum Questionmarkedna for "questionMarkedNA"
            /// </summary>
            [EnumMember(Value = "questionMarkedNA")]
            Questionmarkedna,
            
            /// <summary>
            /// Enum Failedkillquestion for "failedKillQuestion"
            /// </summary>
            [EnumMember(Value = "failedKillQuestion")]
            Failedkillquestion
        }
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Not for "NOT"
            /// </summary>
            [EnumMember(Value = "NOT")]
            Not
        }
        /// <summary>
        /// The type of query Operation to Perform
        /// </summary>
        /// <value>The type of query Operation to Perform</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Field name to search against
        /// </summary>
        /// <value>Field name to search against</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchCriteriaDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationSearchCriteriaDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchCriteriaDTO" /> class.
        /// </summary>
        /// <param name="Type">The type of query Operation to Perform (required).</param>
        /// <param name="Field">Field name to search against (required).</param>
        /// <param name="EndValue">The end value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;..</param>
        /// <param name="Values">A list of values for the search to match against. Only for Type: EXACT.</param>
        /// <param name="StartValue">The start value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;..</param>
        /// <param name="Value">A value for the search to match against.</param>
        /// <param name="Operator">How to apply this search criteria against other criteria.</param>
        public EvaluationSearchCriteriaDTO(TypeEnum? Type = null, FieldEnum? Field = null, string EndValue = null, List<string> Values = null, string StartValue = null, string Value = null, OperatorEnum? Operator = null)
        {
            this.Type = Type;
            this.Field = Field;
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Value = Value;
            this.Operator = Operator;
            
        }
        






        /// <summary>
        /// The end value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.
        /// </summary>
        /// <value>The end value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.</value>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }



        /// <summary>
        /// A list of values for the search to match against. Only for Type: EXACT
        /// </summary>
        /// <value>A list of values for the search to match against. Only for Type: EXACT</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }



        /// <summary>
        /// The start value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.
        /// </summary>
        /// <value>The start value of the range. This field is used for range search types. Date values must be in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.</value>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }



        /// <summary>
        /// A value for the search to match against
        /// </summary>
        /// <value>A value for the search to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchCriteriaDTO {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as EvaluationSearchCriteriaDTO);
        }

        /// <summary>
        /// Returns true if EvaluationSearchCriteriaDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchCriteriaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchCriteriaDTO other)
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
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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

                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                return hash;
            }
        }
    }

}
