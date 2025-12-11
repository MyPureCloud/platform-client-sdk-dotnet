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
    /// QualityEvaluationScoreItem
    /// </summary>
    [DataContract]
    public partial class QualityEvaluationScoreItem :  IEquatable<QualityEvaluationScoreItem>
    {
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Internalmessage for "internalmessage"
            /// </summary>
            [EnumMember(Value = "internalmessage")]
            Internalmessage,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message,
            
            /// <summary>
            /// Enum Screenmonitoring for "screenmonitoring"
            /// </summary>
            [EnumMember(Value = "screenmonitoring")]
            Screenmonitoring,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationScoreItem" /> class.
        /// </summary>
        /// <param name="MediaTypes">A list of media types for the metric.</param>
        public QualityEvaluationScoreItem(List<MediaTypesEnum> MediaTypes = null)
        {
            this.MediaTypes = MediaTypes;
            
        }
        


        /// <summary>
        /// The id of evaluation
        /// </summary>
        /// <value>The id of evaluation</value>
        [DataMember(Name="evaluationId", EmitDefaultValue=false)]
        public string EvaluationId { get; private set; }



        /// <summary>
        /// The id of conversation
        /// </summary>
        /// <value>The id of conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; private set; }



        /// <summary>
        /// The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationDate", EmitDefaultValue=false)]
        public DateTime? ConversationDate { get; private set; }



        /// <summary>
        /// The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationEndDate", EmitDefaultValue=false)]
        public DateTime? ConversationEndDate { get; private set; }



        /// <summary>
        /// The name of form
        /// </summary>
        /// <value>The name of form</value>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; private set; }



        /// <summary>
        /// Gamification points earned for this metric
        /// </summary>
        /// <value>Gamification points earned for this metric</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; private set; }



        /// <summary>
        /// The quality score of evaluation as a percentage
        /// </summary>
        /// <value>The quality score of evaluation as a percentage</value>
        [DataMember(Name="evaluationScore", EmitDefaultValue=false)]
        public double? EvaluationScore { get; private set; }



        /// <summary>
        /// The maximum Gamification points a user may earn for this metric
        /// </summary>
        /// <value>The maximum Gamification points a user may earn for this metric</value>
        [DataMember(Name="maxPoints", EmitDefaultValue=false)]
        public int? MaxPoints { get; private set; }



        /// <summary>
        /// A list of media types for the metric
        /// </summary>
        /// <value>A list of media types for the metric</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityEvaluationScoreItem {\n");

            sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
            sb.Append("  ConversationEndDate: ").Append(ConversationEndDate).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
            sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
            return this.Equals(obj as QualityEvaluationScoreItem);
        }

        /// <summary>
        /// Returns true if QualityEvaluationScoreItem instances are equal
        /// </summary>
        /// <param name="other">Instance of QualityEvaluationScoreItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityEvaluationScoreItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EvaluationId == other.EvaluationId ||
                    this.EvaluationId != null &&
                    this.EvaluationId.Equals(other.EvaluationId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConversationDate == other.ConversationDate ||
                    this.ConversationDate != null &&
                    this.ConversationDate.Equals(other.ConversationDate)
                ) &&
                (
                    this.ConversationEndDate == other.ConversationEndDate ||
                    this.ConversationEndDate != null &&
                    this.ConversationEndDate.Equals(other.ConversationEndDate)
                ) &&
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
                ) &&
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) &&
                (
                    this.EvaluationScore == other.EvaluationScore ||
                    this.EvaluationScore != null &&
                    this.EvaluationScore.Equals(other.EvaluationScore)
                ) &&
                (
                    this.MaxPoints == other.MaxPoints ||
                    this.MaxPoints != null &&
                    this.MaxPoints.Equals(other.MaxPoints)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
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
                if (this.EvaluationId != null)
                    hash = hash * 59 + this.EvaluationId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ConversationDate != null)
                    hash = hash * 59 + this.ConversationDate.GetHashCode();

                if (this.ConversationEndDate != null)
                    hash = hash * 59 + this.ConversationEndDate.GetHashCode();

                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();

                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();

                if (this.EvaluationScore != null)
                    hash = hash * 59 + this.EvaluationScore.GetHashCode();

                if (this.MaxPoints != null)
                    hash = hash * 59 + this.MaxPoints.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                return hash;
            }
        }
    }

}
