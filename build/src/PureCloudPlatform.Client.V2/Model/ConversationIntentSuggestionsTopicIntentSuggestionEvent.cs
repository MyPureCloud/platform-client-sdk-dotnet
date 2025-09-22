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
    /// ConversationIntentSuggestionsTopicIntentSuggestionEvent
    /// </summary>
    [DataContract]
    public partial class ConversationIntentSuggestionsTopicIntentSuggestionEvent :  IEquatable<ConversationIntentSuggestionsTopicIntentSuggestionEvent>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Suggested for "Suggested"
            /// </summary>
            [EnumMember(Value = "Suggested")]
            Suggested,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Dismissed for "Dismissed"
            /// </summary>
            [EnumMember(Value = "Dismissed")]
            Dismissed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Rated for "Rated"
            /// </summary>
            [EnumMember(Value = "Rated")]
            Rated
        }
        /// <summary>
        /// Gets or Sets TriggerType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Fallback for "Fallback"
            /// </summary>
            [EnumMember(Value = "Fallback")]
            Fallback,
            
            /// <summary>
            /// Enum Conversationstart for "ConversationStart"
            /// </summary>
            [EnumMember(Value = "ConversationStart")]
            Conversationstart,
            
            /// <summary>
            /// Enum Conversationtransfer for "ConversationTransfer"
            /// </summary>
            [EnumMember(Value = "ConversationTransfer")]
            Conversationtransfer,
            
            /// <summary>
            /// Enum Conversationend for "ConversationEnd"
            /// </summary>
            [EnumMember(Value = "ConversationEnd")]
            Conversationend,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent
        }
        /// <summary>
        /// Gets or Sets EngagementType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EngagementTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Dismissed for "Dismissed"
            /// </summary>
            [EnumMember(Value = "Dismissed")]
            Dismissed,
            
            /// <summary>
            /// Enum Copied for "Copied"
            /// </summary>
            [EnumMember(Value = "Copied")]
            Copied,
            
            /// <summary>
            /// Enum Opened for "Opened"
            /// </summary>
            [EnumMember(Value = "Opened")]
            Opened,
            
            /// <summary>
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets TriggerType
        /// </summary>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }
        /// <summary>
        /// Gets or Sets EngagementType
        /// </summary>
        [DataMember(Name="engagementType", EmitDefaultValue=false)]
        public EngagementTypeEnum? EngagementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationIntentSuggestionsTopicIntentSuggestionEvent" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="SuggestionId">SuggestionId.</param>
        /// <param name="State">State.</param>
        /// <param name="TriggerType">TriggerType.</param>
        /// <param name="EngagementType">EngagementType.</param>
        /// <param name="Feedback">Feedback.</param>
        /// <param name="ActiveIntent">ActiveIntent.</param>
        /// <param name="ConversationIntents">ConversationIntents.</param>
        /// <param name="Context">Context.</param>
        public ConversationIntentSuggestionsTopicIntentSuggestionEvent(DateTime? EventTime = null, Guid? ConversationId = null, Guid? SuggestionId = null, StateEnum? State = null, TriggerTypeEnum? TriggerType = null, EngagementTypeEnum? EngagementType = null, ConversationIntentSuggestionsTopicSuggestionFeedback Feedback = null, ConversationIntentSuggestionsTopicSuggestedIntent ActiveIntent = null, Dictionary<string, ConversationIntentSuggestionsTopicSuggestedIntent> ConversationIntents = null, ConversationIntentSuggestionsTopicSuggestionContext Context = null)
        {
            this.EventTime = EventTime;
            this.ConversationId = ConversationId;
            this.SuggestionId = SuggestionId;
            this.State = State;
            this.TriggerType = TriggerType;
            this.EngagementType = EngagementType;
            this.Feedback = Feedback;
            this.ActiveIntent = ActiveIntent;
            this.ConversationIntents = ConversationIntents;
            this.Context = Context;
            
        }
        


        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets SuggestionId
        /// </summary>
        [DataMember(Name="suggestionId", EmitDefaultValue=false)]
        public Guid? SuggestionId { get; set; }









        /// <summary>
        /// Gets or Sets Feedback
        /// </summary>
        [DataMember(Name="feedback", EmitDefaultValue=false)]
        public ConversationIntentSuggestionsTopicSuggestionFeedback Feedback { get; set; }



        /// <summary>
        /// Gets or Sets ActiveIntent
        /// </summary>
        [DataMember(Name="activeIntent", EmitDefaultValue=false)]
        public ConversationIntentSuggestionsTopicSuggestedIntent ActiveIntent { get; set; }



        /// <summary>
        /// Gets or Sets ConversationIntents
        /// </summary>
        [DataMember(Name="conversationIntents", EmitDefaultValue=false)]
        public Dictionary<string, ConversationIntentSuggestionsTopicSuggestedIntent> ConversationIntents { get; set; }



        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public ConversationIntentSuggestionsTopicSuggestionContext Context { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationIntentSuggestionsTopicIntentSuggestionEvent {\n");

            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SuggestionId: ").Append(SuggestionId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  ActiveIntent: ").Append(ActiveIntent).Append("\n");
            sb.Append("  ConversationIntents: ").Append(ConversationIntents).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as ConversationIntentSuggestionsTopicIntentSuggestionEvent);
        }

        /// <summary>
        /// Returns true if ConversationIntentSuggestionsTopicIntentSuggestionEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationIntentSuggestionsTopicIntentSuggestionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationIntentSuggestionsTopicIntentSuggestionEvent other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SuggestionId == other.SuggestionId ||
                    this.SuggestionId != null &&
                    this.SuggestionId.Equals(other.SuggestionId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.EngagementType == other.EngagementType ||
                    this.EngagementType != null &&
                    this.EngagementType.Equals(other.EngagementType)
                ) &&
                (
                    this.Feedback == other.Feedback ||
                    this.Feedback != null &&
                    this.Feedback.Equals(other.Feedback)
                ) &&
                (
                    this.ActiveIntent == other.ActiveIntent ||
                    this.ActiveIntent != null &&
                    this.ActiveIntent.Equals(other.ActiveIntent)
                ) &&
                (
                    this.ConversationIntents == other.ConversationIntents ||
                    this.ConversationIntents != null &&
                    this.ConversationIntents.SequenceEqual(other.ConversationIntents)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
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

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SuggestionId != null)
                    hash = hash * 59 + this.SuggestionId.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.EngagementType != null)
                    hash = hash * 59 + this.EngagementType.GetHashCode();

                if (this.Feedback != null)
                    hash = hash * 59 + this.Feedback.GetHashCode();

                if (this.ActiveIntent != null)
                    hash = hash * 59 + this.ActiveIntent.GetHashCode();

                if (this.ConversationIntents != null)
                    hash = hash * 59 + this.ConversationIntents.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                return hash;
            }
        }
    }

}
