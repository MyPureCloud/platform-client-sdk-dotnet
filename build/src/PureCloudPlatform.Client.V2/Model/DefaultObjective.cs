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
    /// DefaultObjective
    /// </summary>
    [DataContract]
    public partial class DefaultObjective :  IEquatable<DefaultObjective>
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
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message,
            
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
        /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
        /// </summary>
        /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TopicIdsFilterTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "and"
            /// </summary>
            [EnumMember(Value = "and")]
            And,
            
            /// <summary>
            /// Enum Or for "or"
            /// </summary>
            [EnumMember(Value = "or")]
            Or
        }
        /// <summary>
        /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
        /// </summary>
        /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
        [DataMember(Name="topicIdsFilterType", EmitDefaultValue=false)]
        public TopicIdsFilterTypeEnum? TopicIdsFilterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultObjective" /> class.
        /// </summary>
        /// <param name="TemplateId">The id of this objective's base template.</param>
        /// <param name="Zones">Objective zone specifies min,max points and values for the associated metric.</param>
        /// <param name="Enabled">A flag for whether this objective is enabled for the related metric.</param>
        /// <param name="MediaTypes">A list of media types for the metric.</param>
        /// <param name="Queues">A list of queues for the metric.</param>
        /// <param name="Topics">A list of topic ids for detected topic metrics.</param>
        /// <param name="TopicIdsFilterType">A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\"..</param>
        /// <param name="EvaluationFormContextIds">The ids of associated evaluation form context, for Quality Evaluation Score metrics.</param>
        public DefaultObjective(string TemplateId = null, List<ObjectiveZone> Zones = null, bool? Enabled = null, List<MediaTypesEnum> MediaTypes = null, List<AddressableEntityRef> Queues = null, List<AddressableEntityRef> Topics = null, TopicIdsFilterTypeEnum? TopicIdsFilterType = null, List<string> EvaluationFormContextIds = null)
        {
            this.TemplateId = TemplateId;
            this.Zones = Zones;
            this.Enabled = Enabled;
            this.MediaTypes = MediaTypes;
            this.Queues = Queues;
            this.Topics = Topics;
            this.TopicIdsFilterType = TopicIdsFilterType;
            this.EvaluationFormContextIds = EvaluationFormContextIds;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The id of this objective's base template
        /// </summary>
        /// <value>The id of this objective's base template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }



        /// <summary>
        /// Objective zone specifies min,max points and values for the associated metric
        /// </summary>
        /// <value>Objective zone specifies min,max points and values for the associated metric</value>
        [DataMember(Name="zones", EmitDefaultValue=false)]
        public List<ObjectiveZone> Zones { get; set; }



        /// <summary>
        /// A flag for whether this objective is enabled for the related metric
        /// </summary>
        /// <value>A flag for whether this objective is enabled for the related metric</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// A list of media types for the metric
        /// </summary>
        /// <value>A list of media types for the metric</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }



        /// <summary>
        /// A list of queues for the metric
        /// </summary>
        /// <value>A list of queues for the metric</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Queues { get; set; }



        /// <summary>
        /// A list of topic ids for detected topic metrics
        /// </summary>
        /// <value>A list of topic ids for detected topic metrics</value>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Topics { get; set; }





        /// <summary>
        /// The ids of associated evaluation form context, for Quality Evaluation Score metrics
        /// </summary>
        /// <value>The ids of associated evaluation form context, for Quality Evaluation Score metrics</value>
        [DataMember(Name="evaluationFormContextIds", EmitDefaultValue=false)]
        public List<string> EvaluationFormContextIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultObjective {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  TopicIdsFilterType: ").Append(TopicIdsFilterType).Append("\n");
            sb.Append("  EvaluationFormContextIds: ").Append(EvaluationFormContextIds).Append("\n");
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
            return this.Equals(obj as DefaultObjective);
        }

        /// <summary>
        /// Returns true if DefaultObjective instances are equal
        /// </summary>
        /// <param name="other">Instance of DefaultObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultObjective other)
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
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) &&
                (
                    this.Zones == other.Zones ||
                    this.Zones != null &&
                    this.Zones.SequenceEqual(other.Zones)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.Topics == other.Topics ||
                    this.Topics != null &&
                    this.Topics.SequenceEqual(other.Topics)
                ) &&
                (
                    this.TopicIdsFilterType == other.TopicIdsFilterType ||
                    this.TopicIdsFilterType != null &&
                    this.TopicIdsFilterType.Equals(other.TopicIdsFilterType)
                ) &&
                (
                    this.EvaluationFormContextIds == other.EvaluationFormContextIds ||
                    this.EvaluationFormContextIds != null &&
                    this.EvaluationFormContextIds.SequenceEqual(other.EvaluationFormContextIds)
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

                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();

                if (this.Zones != null)
                    hash = hash * 59 + this.Zones.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();

                if (this.Topics != null)
                    hash = hash * 59 + this.Topics.GetHashCode();

                if (this.TopicIdsFilterType != null)
                    hash = hash * 59 + this.TopicIdsFilterType.GetHashCode();

                if (this.EvaluationFormContextIds != null)
                    hash = hash * 59 + this.EvaluationFormContextIds.GetHashCode();

                return hash;
            }
        }
    }

}
