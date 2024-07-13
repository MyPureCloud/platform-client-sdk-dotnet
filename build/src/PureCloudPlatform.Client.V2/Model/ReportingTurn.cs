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
    /// ReportingTurn
    /// </summary>
    [DataContract]
    public partial class ReportingTurn :  IEquatable<ReportingTurn>
    {
        /// <summary>
        /// Result of the bot flow 'ask' action.
        /// </summary>
        /// <value>Result of the bot flow 'ask' action.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AskActionResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Successcollection for "SuccessCollection"
            /// </summary>
            [EnumMember(Value = "SuccessCollection")]
            Successcollection,
            
            /// <summary>
            /// Enum Successconfirmationyes for "SuccessConfirmationYes"
            /// </summary>
            [EnumMember(Value = "SuccessConfirmationYes")]
            Successconfirmationyes,
            
            /// <summary>
            /// Enum Successconfirmationno for "SuccessConfirmationNo"
            /// </summary>
            [EnumMember(Value = "SuccessConfirmationNo")]
            Successconfirmationno,
            
            /// <summary>
            /// Enum Skippedcollection for "SkippedCollection"
            /// </summary>
            [EnumMember(Value = "SkippedCollection")]
            Skippedcollection,
            
            /// <summary>
            /// Enum Nomatchcollection for "NoMatchCollection"
            /// </summary>
            [EnumMember(Value = "NoMatchCollection")]
            Nomatchcollection,
            
            /// <summary>
            /// Enum Nomatchconfirmation for "NoMatchConfirmation"
            /// </summary>
            [EnumMember(Value = "NoMatchConfirmation")]
            Nomatchconfirmation,
            
            /// <summary>
            /// Enum Agentrequestedbyuser for "AgentRequestedByUser"
            /// </summary>
            [EnumMember(Value = "AgentRequestedByUser")]
            Agentrequestedbyuser,
            
            /// <summary>
            /// Enum Confirmationrequired for "ConfirmationRequired"
            /// </summary>
            [EnumMember(Value = "ConfirmationRequired")]
            Confirmationrequired,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Expressionerror for "ExpressionError"
            /// </summary>
            [EnumMember(Value = "ExpressionError")]
            Expressionerror,
            
            /// <summary>
            /// Enum Noinputcollection for "NoInputCollection"
            /// </summary>
            [EnumMember(Value = "NoInputCollection")]
            Noinputcollection,
            
            /// <summary>
            /// Enum Noinputconfirmation for "NoInputConfirmation"
            /// </summary>
            [EnumMember(Value = "NoInputConfirmation")]
            Noinputconfirmation,
            
            /// <summary>
            /// Enum Disambiguationrequired for "DisambiguationRequired"
            /// </summary>
            [EnumMember(Value = "DisambiguationRequired")]
            Disambiguationrequired,
            
            /// <summary>
            /// Enum Successdisambiguation for "SuccessDisambiguation"
            /// </summary>
            [EnumMember(Value = "SuccessDisambiguation")]
            Successdisambiguation,
            
            /// <summary>
            /// Enum Successdisambiguationnone for "SuccessDisambiguationNone"
            /// </summary>
            [EnumMember(Value = "SuccessDisambiguationNone")]
            Successdisambiguationnone,
            
            /// <summary>
            /// Enum Nomatchdisambiguation for "NoMatchDisambiguation"
            /// </summary>
            [EnumMember(Value = "NoMatchDisambiguation")]
            Nomatchdisambiguation,
            
            /// <summary>
            /// Enum Noinputdisambiguation for "NoInputDisambiguation"
            /// </summary>
            [EnumMember(Value = "NoInputDisambiguation")]
            Noinputdisambiguation
        }
        /// <summary>
        /// Result of the bot flow 'ask' action.
        /// </summary>
        /// <value>Result of the bot flow 'ask' action.</value>
        [DataMember(Name="askActionResult", EmitDefaultValue=false)]
        public AskActionResultEnum? AskActionResult { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurn" /> class.
        /// </summary>
        /// <param name="UserInput">The chosen user input associated with this reporting turn..</param>
        /// <param name="BotPrompts">The bot prompts associated with this reporting turn..</param>
        /// <param name="SessionId">The bot session ID that this reporting turn is grouped under..</param>
        /// <param name="AskAction">The bot flow 'ask' action associated with this reporting turn (e.g. AskForIntent)..</param>
        /// <param name="Intent">The intent and associated slots detected during this reporting turn..</param>
        /// <param name="Knowledge">The knowledge data captured during this reporting turn..</param>
        /// <param name="KnowledgeBaseEvents">The knowledge data captured during this reporting turn..</param>
        /// <param name="DateCreated">Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCompleted">Timestamp indicating when the original turn was completed. Note: The 'interval' query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AskActionResult">Result of the bot flow 'ask' action..</param>
        /// <param name="SessionEndDetails">The details related to end of bot flow session..</param>
        public ReportingTurn(string UserInput = null, List<string> BotPrompts = null, string SessionId = null, ReportingTurnAction AskAction = null, ReportingTurnIntent Intent = null, ReportingTurnKnowledge Knowledge = null, ReportingTurnKnowledgeEvents KnowledgeBaseEvents = null, DateTime? DateCreated = null, DateTime? DateCompleted = null, AskActionResultEnum? AskActionResult = null, SessionEndDetails SessionEndDetails = null)
        {
            this.UserInput = UserInput;
            this.BotPrompts = BotPrompts;
            this.SessionId = SessionId;
            this.AskAction = AskAction;
            this.Intent = Intent;
            this.Knowledge = Knowledge;
            this.KnowledgeBaseEvents = KnowledgeBaseEvents;
            this.DateCreated = DateCreated;
            this.DateCompleted = DateCompleted;
            this.AskActionResult = AskActionResult;
            this.SessionEndDetails = SessionEndDetails;
            
        }
        


        /// <summary>
        /// The chosen user input associated with this reporting turn.
        /// </summary>
        /// <value>The chosen user input associated with this reporting turn.</value>
        [DataMember(Name="userInput", EmitDefaultValue=false)]
        public string UserInput { get; set; }



        /// <summary>
        /// The bot prompts associated with this reporting turn.
        /// </summary>
        /// <value>The bot prompts associated with this reporting turn.</value>
        [DataMember(Name="botPrompts", EmitDefaultValue=false)]
        public List<string> BotPrompts { get; set; }



        /// <summary>
        /// The bot session ID that this reporting turn is grouped under.
        /// </summary>
        /// <value>The bot session ID that this reporting turn is grouped under.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// The bot flow 'ask' action associated with this reporting turn (e.g. AskForIntent).
        /// </summary>
        /// <value>The bot flow 'ask' action associated with this reporting turn (e.g. AskForIntent).</value>
        [DataMember(Name="askAction", EmitDefaultValue=false)]
        public ReportingTurnAction AskAction { get; set; }



        /// <summary>
        /// The intent and associated slots detected during this reporting turn.
        /// </summary>
        /// <value>The intent and associated slots detected during this reporting turn.</value>
        [DataMember(Name="intent", EmitDefaultValue=false)]
        public ReportingTurnIntent Intent { get; set; }



        /// <summary>
        /// The knowledge data captured during this reporting turn.
        /// </summary>
        /// <value>The knowledge data captured during this reporting turn.</value>
        [DataMember(Name="knowledge", EmitDefaultValue=false)]
        public ReportingTurnKnowledge Knowledge { get; set; }



        /// <summary>
        /// The knowledge data captured during this reporting turn.
        /// </summary>
        /// <value>The knowledge data captured during this reporting turn.</value>
        [DataMember(Name="knowledgeBaseEvents", EmitDefaultValue=false)]
        public ReportingTurnKnowledgeEvents KnowledgeBaseEvents { get; set; }



        /// <summary>
        /// Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Timestamp indicating when the original turn was completed. Note: The 'interval' query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the original turn was completed. Note: The 'interval' query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }





        /// <summary>
        /// The details related to end of bot flow session.
        /// </summary>
        /// <value>The details related to end of bot flow session.</value>
        [DataMember(Name="sessionEndDetails", EmitDefaultValue=false)]
        public SessionEndDetails SessionEndDetails { get; set; }



        /// <summary>
        /// The conversation details, across potentially multiple Bot Flow sessions.
        /// </summary>
        /// <value>The conversation details, across potentially multiple Bot Flow sessions.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurn {\n");

            sb.Append("  UserInput: ").Append(UserInput).Append("\n");
            sb.Append("  BotPrompts: ").Append(BotPrompts).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  AskAction: ").Append(AskAction).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Knowledge: ").Append(Knowledge).Append("\n");
            sb.Append("  KnowledgeBaseEvents: ").Append(KnowledgeBaseEvents).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  AskActionResult: ").Append(AskActionResult).Append("\n");
            sb.Append("  SessionEndDetails: ").Append(SessionEndDetails).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
            return this.Equals(obj as ReportingTurn);
        }

        /// <summary>
        /// Returns true if ReportingTurn instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserInput == other.UserInput ||
                    this.UserInput != null &&
                    this.UserInput.Equals(other.UserInput)
                ) &&
                (
                    this.BotPrompts == other.BotPrompts ||
                    this.BotPrompts != null &&
                    this.BotPrompts.SequenceEqual(other.BotPrompts)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.AskAction == other.AskAction ||
                    this.AskAction != null &&
                    this.AskAction.Equals(other.AskAction)
                ) &&
                (
                    this.Intent == other.Intent ||
                    this.Intent != null &&
                    this.Intent.Equals(other.Intent)
                ) &&
                (
                    this.Knowledge == other.Knowledge ||
                    this.Knowledge != null &&
                    this.Knowledge.Equals(other.Knowledge)
                ) &&
                (
                    this.KnowledgeBaseEvents == other.KnowledgeBaseEvents ||
                    this.KnowledgeBaseEvents != null &&
                    this.KnowledgeBaseEvents.Equals(other.KnowledgeBaseEvents)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.AskActionResult == other.AskActionResult ||
                    this.AskActionResult != null &&
                    this.AskActionResult.Equals(other.AskActionResult)
                ) &&
                (
                    this.SessionEndDetails == other.SessionEndDetails ||
                    this.SessionEndDetails != null &&
                    this.SessionEndDetails.Equals(other.SessionEndDetails)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
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
                if (this.UserInput != null)
                    hash = hash * 59 + this.UserInput.GetHashCode();

                if (this.BotPrompts != null)
                    hash = hash * 59 + this.BotPrompts.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.AskAction != null)
                    hash = hash * 59 + this.AskAction.GetHashCode();

                if (this.Intent != null)
                    hash = hash * 59 + this.Intent.GetHashCode();

                if (this.Knowledge != null)
                    hash = hash * 59 + this.Knowledge.GetHashCode();

                if (this.KnowledgeBaseEvents != null)
                    hash = hash * 59 + this.KnowledgeBaseEvents.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();

                if (this.AskActionResult != null)
                    hash = hash * 59 + this.AskActionResult.GetHashCode();

                if (this.SessionEndDetails != null)
                    hash = hash * 59 + this.SessionEndDetails.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                return hash;
            }
        }
    }

}
