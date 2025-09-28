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
    /// Miner
    /// </summary>
    [DataContract]
    public partial class Miner :  IEquatable<Miner>
    {
        /// <summary>
        /// Language Localization code.
        /// </summary>
        /// <value>Language Localization code.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enus for "en-us"
            /// </summary>
            [EnumMember(Value = "en-us")]
            Enus,
            
            /// <summary>
            /// Enum Engb for "en-gb"
            /// </summary>
            [EnumMember(Value = "en-gb")]
            Engb,
            
            /// <summary>
            /// Enum Enau for "en-au"
            /// </summary>
            [EnumMember(Value = "en-au")]
            Enau,
            
            /// <summary>
            /// Enum Enin for "en-in"
            /// </summary>
            [EnumMember(Value = "en-in")]
            Enin,
            
            /// <summary>
            /// Enum Enza for "en-za"
            /// </summary>
            [EnumMember(Value = "en-za")]
            Enza,
            
            /// <summary>
            /// Enum Esus for "es-us"
            /// </summary>
            [EnumMember(Value = "es-us")]
            Esus,
            
            /// <summary>
            /// Enum Eses for "es-es"
            /// </summary>
            [EnumMember(Value = "es-es")]
            Eses,
            
            /// <summary>
            /// Enum Frfr for "fr-fr"
            /// </summary>
            [EnumMember(Value = "fr-fr")]
            Frfr,
            
            /// <summary>
            /// Enum Frca for "fr-ca"
            /// </summary>
            [EnumMember(Value = "fr-ca")]
            Frca,
            
            /// <summary>
            /// Enum Dede for "de-de"
            /// </summary>
            [EnumMember(Value = "de-de")]
            Dede,
            
            /// <summary>
            /// Enum Ptpt for "pt-pt"
            /// </summary>
            [EnumMember(Value = "pt-pt")]
            Ptpt,
            
            /// <summary>
            /// Enum Ptbr for "pt-br"
            /// </summary>
            [EnumMember(Value = "pt-br")]
            Ptbr,
            
            /// <summary>
            /// Enum Itit for "it-it"
            /// </summary>
            [EnumMember(Value = "it-it")]
            Itit,
            
            /// <summary>
            /// Enum Nlnl for "nl-nl"
            /// </summary>
            [EnumMember(Value = "nl-nl")]
            Nlnl,
            
            /// <summary>
            /// Enum Dech for "de-ch"
            /// </summary>
            [EnumMember(Value = "de-ch")]
            Dech,
            
            /// <summary>
            /// Enum Jajp for "ja-jp"
            /// </summary>
            [EnumMember(Value = "ja-jp")]
            Jajp,
            
            /// <summary>
            /// Enum Kokr for "ko-kr"
            /// </summary>
            [EnumMember(Value = "ko-kr")]
            Kokr,
            
            /// <summary>
            /// Enum Hiin for "hi-in"
            /// </summary>
            [EnumMember(Value = "hi-in")]
            Hiin,
            
            /// <summary>
            /// Enum Ar001 for "ar-001"
            /// </summary>
            [EnumMember(Value = "ar-001")]
            Ar001,
            
            /// <summary>
            /// Enum Arae for "ar-ae"
            /// </summary>
            [EnumMember(Value = "ar-ae")]
            Arae,
            
            /// <summary>
            /// Enum Arbh for "ar-bh"
            /// </summary>
            [EnumMember(Value = "ar-bh")]
            Arbh,
            
            /// <summary>
            /// Enum Areg for "ar-eg"
            /// </summary>
            [EnumMember(Value = "ar-eg")]
            Areg,
            
            /// <summary>
            /// Enum Aril for "ar-il"
            /// </summary>
            [EnumMember(Value = "ar-il")]
            Aril,
            
            /// <summary>
            /// Enum Arsa for "ar-sa"
            /// </summary>
            [EnumMember(Value = "ar-sa")]
            Arsa,
            
            /// <summary>
            /// Enum Artn for "ar-tn"
            /// </summary>
            [EnumMember(Value = "ar-tn")]
            Artn
        }
        /// <summary>
        /// Type of the miner, intent or topic.
        /// </summary>
        /// <value>Type of the miner, intent or topic.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MinerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic
        }
        /// <summary>
        /// Status of the miner.
        /// </summary>
        /// <value>Status of the miner.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Notstarted for "NotStarted"
            /// </summary>
            [EnumMember(Value = "NotStarted")]
            Notstarted,
            
            /// <summary>
            /// Enum Fetchingconversationids for "FetchingConversationIds"
            /// </summary>
            [EnumMember(Value = "FetchingConversationIds")]
            Fetchingconversationids,
            
            /// <summary>
            /// Enum Conversationidsfetched for "ConversationIdsFetched"
            /// </summary>
            [EnumMember(Value = "ConversationIdsFetched")]
            Conversationidsfetched,
            
            /// <summary>
            /// Enum Conversationidsfetcherror for "ConversationIdsFetchError"
            /// </summary>
            [EnumMember(Value = "ConversationIdsFetchError")]
            Conversationidsfetcherror,
            
            /// <summary>
            /// Enum Fetchingconversations for "FetchingConversations"
            /// </summary>
            [EnumMember(Value = "FetchingConversations")]
            Fetchingconversations,
            
            /// <summary>
            /// Enum Conversationsfetched for "ConversationsFetched"
            /// </summary>
            [EnumMember(Value = "ConversationsFetched")]
            Conversationsfetched,
            
            /// <summary>
            /// Enum Conversationsfetcherror for "ConversationsFetchError"
            /// </summary>
            [EnumMember(Value = "ConversationsFetchError")]
            Conversationsfetcherror,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Queuingerror for "QueuingError"
            /// </summary>
            [EnumMember(Value = "QueuingError")]
            Queuingerror,
            
            /// <summary>
            /// Enum Miningstarted for "MiningStarted"
            /// </summary>
            [EnumMember(Value = "MiningStarted")]
            Miningstarted,
            
            /// <summary>
            /// Enum Maskingutterances for "MaskingUtterances"
            /// </summary>
            [EnumMember(Value = "MaskingUtterances")]
            Maskingutterances,
            
            /// <summary>
            /// Enum Maskingerror for "MaskingError"
            /// </summary>
            [EnumMember(Value = "MaskingError")]
            Maskingerror,
            
            /// <summary>
            /// Enum Computinganalytics for "ComputingAnalytics"
            /// </summary>
            [EnumMember(Value = "ComputingAnalytics")]
            Computinganalytics,
            
            /// <summary>
            /// Enum Computinganalyticserror for "ComputingAnalyticsError"
            /// </summary>
            [EnumMember(Value = "ComputingAnalyticsError")]
            Computinganalyticserror,
            
            /// <summary>
            /// Enum Miningcompleted for "MiningCompleted"
            /// </summary>
            [EnumMember(Value = "MiningCompleted")]
            Miningcompleted,
            
            /// <summary>
            /// Enum Miningerror for "MiningError"
            /// </summary>
            [EnumMember(Value = "MiningError")]
            Miningerror,
            
            /// <summary>
            /// Enum Modelvalidationerror for "ModelValidationError"
            /// </summary>
            [EnumMember(Value = "ModelValidationError")]
            Modelvalidationerror,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// Media type for filtering conversations.
        /// </summary>
        /// <value>Media type for filtering conversations.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email
        }
        /// <summary>
        /// Type of the participant, either agent, customer or both.
        /// </summary>
        /// <value>Type of the participant, either agent, customer or both.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer,
            
            /// <summary>
            /// Enum Agent for "Agent"
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent,
            
            /// <summary>
            /// Enum Both for "Both"
            /// </summary>
            [EnumMember(Value = "Both")]
            Both
        }
        /// <summary>
        /// Language Localization code.
        /// </summary>
        /// <value>Language Localization code.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Type of the miner, intent or topic.
        /// </summary>
        /// <value>Type of the miner, intent or topic.</value>
        [DataMember(Name="minerType", EmitDefaultValue=false)]
        public MinerTypeEnum? MinerType { get; set; }
        /// <summary>
        /// Status of the miner.
        /// </summary>
        /// <value>Status of the miner.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Media type for filtering conversations.
        /// </summary>
        /// <value>Media type for filtering conversations.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; private set; }
        /// <summary>
        /// Type of the participant, either agent, customer or both.
        /// </summary>
        /// <value>Type of the participant, either agent, customer or both.</value>
        [DataMember(Name="participantType", EmitDefaultValue=false)]
        public ParticipantTypeEnum? ParticipantType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Miner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Miner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Miner" /> class.
        /// </summary>
        /// <param name="Name">Chat Corpus Name. (required).</param>
        /// <param name="Language">Language Localization code..</param>
        /// <param name="MinerType">Type of the miner, intent or topic..</param>
        /// <param name="Seeding">Flag to indicate whether seeding is supported for this miner..</param>
        public Miner(string Name = null, LanguageEnum? Language = null, MinerTypeEnum? MinerType = null, bool? Seeding = null)
        {
            this.Name = Name;
            this.Language = Language;
            this.MinerType = MinerType;
            this.Seeding = Seeding;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Chat Corpus Name.
        /// </summary>
        /// <value>Chat Corpus Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }







        /// <summary>
        /// Flag to indicate whether seeding is supported for this miner.
        /// </summary>
        /// <value>Flag to indicate whether seeding is supported for this miner.</value>
        [DataMember(Name="seeding", EmitDefaultValue=false)]
        public bool? Seeding { get; set; }



        /// <summary>
        /// Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }





        /// <summary>
        /// Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="conversationsDateRangeStart", EmitDefaultValue=false)]
        public String ConversationsDateRangeStart { get; private set; }



        /// <summary>
        /// Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="conversationsDateRangeEnd", EmitDefaultValue=false)]
        public String ConversationsDateRangeEnd { get; private set; }



        /// <summary>
        /// Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; private set; }



        /// <summary>
        /// Mining message if present.
        /// </summary>
        /// <value>Mining message if present.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }



        /// <summary>
        /// Error Information
        /// </summary>
        /// <value>Error Information</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public MinerErrorInfo ErrorInfo { get; private set; }



        /// <summary>
        /// Warning Information
        /// </summary>
        /// <value>Warning Information</value>
        [DataMember(Name="warningInfo", EmitDefaultValue=false)]
        public MinerErrorInfo WarningInfo { get; private set; }



        /// <summary>
        /// Flag to indicate whether data file to be mined was uploaded.
        /// </summary>
        /// <value>Flag to indicate whether data file to be mined was uploaded.</value>
        [DataMember(Name="conversationDataUploaded", EmitDefaultValue=false)]
        public bool? ConversationDataUploaded { get; private set; }







        /// <summary>
        /// List of queue IDs for filtering conversations.
        /// </summary>
        /// <value>List of queue IDs for filtering conversations.</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; private set; }



        /// <summary>
        /// Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTriggered", EmitDefaultValue=false)]
        public DateTime? DateTriggered { get; private set; }



        /// <summary>
        /// Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Latest draft details of the miner.
        /// </summary>
        /// <value>Latest draft details of the miner.</value>
        [DataMember(Name="latestDraftVersion", EmitDefaultValue=false)]
        public Draft LatestDraftVersion { get; private set; }



        /// <summary>
        /// Number of conversations/transcripts fetched.
        /// </summary>
        /// <value>Number of conversations/transcripts fetched.</value>
        [DataMember(Name="conversationsFetchedCount", EmitDefaultValue=false)]
        public int? ConversationsFetchedCount { get; private set; }



        /// <summary>
        /// Number of conversations/recordings/transcripts that were found valid for mining purposes.
        /// </summary>
        /// <value>Number of conversations/recordings/transcripts that were found valid for mining purposes.</value>
        [DataMember(Name="conversationsValidCount", EmitDefaultValue=false)]
        public int? ConversationsValidCount { get; private set; }



        /// <summary>
        /// Number of intents or topics based on the miner type.
        /// </summary>
        /// <value>Number of intents or topics based on the miner type.</value>
        [DataMember(Name="getminedItemCount", EmitDefaultValue=false)]
        public int? GetminedItemCount { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Miner {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MinerType: ").Append(MinerType).Append("\n");
            sb.Append("  Seeding: ").Append(Seeding).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ConversationsDateRangeStart: ").Append(ConversationsDateRangeStart).Append("\n");
            sb.Append("  ConversationsDateRangeEnd: ").Append(ConversationsDateRangeEnd).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  WarningInfo: ").Append(WarningInfo).Append("\n");
            sb.Append("  ConversationDataUploaded: ").Append(ConversationDataUploaded).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  DateTriggered: ").Append(DateTriggered).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  LatestDraftVersion: ").Append(LatestDraftVersion).Append("\n");
            sb.Append("  ConversationsFetchedCount: ").Append(ConversationsFetchedCount).Append("\n");
            sb.Append("  ConversationsValidCount: ").Append(ConversationsValidCount).Append("\n");
            sb.Append("  GetminedItemCount: ").Append(GetminedItemCount).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Miner);
        }

        /// <summary>
        /// Returns true if Miner instances are equal
        /// </summary>
        /// <param name="other">Instance of Miner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Miner other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.MinerType == other.MinerType ||
                    this.MinerType != null &&
                    this.MinerType.Equals(other.MinerType)
                ) &&
                (
                    this.Seeding == other.Seeding ||
                    this.Seeding != null &&
                    this.Seeding.Equals(other.Seeding)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ConversationsDateRangeStart == other.ConversationsDateRangeStart ||
                    this.ConversationsDateRangeStart != null &&
                    this.ConversationsDateRangeStart.Equals(other.ConversationsDateRangeStart)
                ) &&
                (
                    this.ConversationsDateRangeEnd == other.ConversationsDateRangeEnd ||
                    this.ConversationsDateRangeEnd != null &&
                    this.ConversationsDateRangeEnd.Equals(other.ConversationsDateRangeEnd)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.WarningInfo == other.WarningInfo ||
                    this.WarningInfo != null &&
                    this.WarningInfo.Equals(other.WarningInfo)
                ) &&
                (
                    this.ConversationDataUploaded == other.ConversationDataUploaded ||
                    this.ConversationDataUploaded != null &&
                    this.ConversationDataUploaded.Equals(other.ConversationDataUploaded)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ParticipantType == other.ParticipantType ||
                    this.ParticipantType != null &&
                    this.ParticipantType.Equals(other.ParticipantType)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.DateTriggered == other.DateTriggered ||
                    this.DateTriggered != null &&
                    this.DateTriggered.Equals(other.DateTriggered)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.LatestDraftVersion == other.LatestDraftVersion ||
                    this.LatestDraftVersion != null &&
                    this.LatestDraftVersion.Equals(other.LatestDraftVersion)
                ) &&
                (
                    this.ConversationsFetchedCount == other.ConversationsFetchedCount ||
                    this.ConversationsFetchedCount != null &&
                    this.ConversationsFetchedCount.Equals(other.ConversationsFetchedCount)
                ) &&
                (
                    this.ConversationsValidCount == other.ConversationsValidCount ||
                    this.ConversationsValidCount != null &&
                    this.ConversationsValidCount.Equals(other.ConversationsValidCount)
                ) &&
                (
                    this.GetminedItemCount == other.GetminedItemCount ||
                    this.GetminedItemCount != null &&
                    this.GetminedItemCount.Equals(other.GetminedItemCount)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.MinerType != null)
                    hash = hash * 59 + this.MinerType.GetHashCode();

                if (this.Seeding != null)
                    hash = hash * 59 + this.Seeding.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ConversationsDateRangeStart != null)
                    hash = hash * 59 + this.ConversationsDateRangeStart.GetHashCode();

                if (this.ConversationsDateRangeEnd != null)
                    hash = hash * 59 + this.ConversationsDateRangeEnd.GetHashCode();

                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.WarningInfo != null)
                    hash = hash * 59 + this.WarningInfo.GetHashCode();

                if (this.ConversationDataUploaded != null)
                    hash = hash * 59 + this.ConversationDataUploaded.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.ParticipantType != null)
                    hash = hash * 59 + this.ParticipantType.GetHashCode();

                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();

                if (this.DateTriggered != null)
                    hash = hash * 59 + this.DateTriggered.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.LatestDraftVersion != null)
                    hash = hash * 59 + this.LatestDraftVersion.GetHashCode();

                if (this.ConversationsFetchedCount != null)
                    hash = hash * 59 + this.ConversationsFetchedCount.GetHashCode();

                if (this.ConversationsValidCount != null)
                    hash = hash * 59 + this.ConversationsValidCount.GetHashCode();

                if (this.GetminedItemCount != null)
                    hash = hash * 59 + this.GetminedItemCount.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
