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
    /// EventLog
    /// </summary>
    [DataContract]
    public partial class EventLog :  IEquatable<EventLog>
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Info for "INFO"
            /// </summary>
            [EnumMember(Value = "INFO")]
            Info,
            
            /// <summary>
            /// Enum Warning for "WARNING"
            /// </summary>
            [EnumMember(Value = "WARNING")]
            Warning,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error
        }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum CallRestriction for "CALL_RESTRICTION"
            /// </summary>
            [EnumMember(Value = "CALL_RESTRICTION")]
            CallRestriction,
            
            /// <summary>
            /// Enum CallRule for "CALL_RULE"
            /// </summary>
            [EnumMember(Value = "CALL_RULE")]
            CallRule,
            
            /// <summary>
            /// Enum Campaign for "CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN")]
            Campaign,
            
            /// <summary>
            /// Enum CampaignRule for "CAMPAIGN_RULE"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_RULE")]
            CampaignRule,
            
            /// <summary>
            /// Enum Contact for "CONTACT"
            /// </summary>
            [EnumMember(Value = "CONTACT")]
            Contact,
            
            /// <summary>
            /// Enum ContactListFilter for "CONTACT_LIST_FILTER"
            /// </summary>
            [EnumMember(Value = "CONTACT_LIST_FILTER")]
            ContactListFilter,
            
            /// <summary>
            /// Enum DigitalRule for "DIGITAL_RULE"
            /// </summary>
            [EnumMember(Value = "DIGITAL_RULE")]
            DigitalRule,
            
            /// <summary>
            /// Enum DncList for "DNC_LIST"
            /// </summary>
            [EnumMember(Value = "DNC_LIST")]
            DncList,
            
            /// <summary>
            /// Enum EntityLimit for "ENTITY_LIMIT"
            /// </summary>
            [EnumMember(Value = "ENTITY_LIMIT")]
            EntityLimit,
            
            /// <summary>
            /// Enum ImportError for "IMPORT_ERROR"
            /// </summary>
            [EnumMember(Value = "IMPORT_ERROR")]
            ImportError,
            
            /// <summary>
            /// Enum MessageRestriction for "MESSAGE_RESTRICTION"
            /// </summary>
            [EnumMember(Value = "MESSAGE_RESTRICTION")]
            MessageRestriction,
            
            /// <summary>
            /// Enum MessagingCampaign for "MESSAGING_CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "MESSAGING_CAMPAIGN")]
            MessagingCampaign,
            
            /// <summary>
            /// Enum OrganizationConfiguration for "ORGANIZATION_CONFIGURATION"
            /// </summary>
            [EnumMember(Value = "ORGANIZATION_CONFIGURATION")]
            OrganizationConfiguration,
            
            /// <summary>
            /// Enum Schedule for "SCHEDULE"
            /// </summary>
            [EnumMember(Value = "SCHEDULE")]
            Schedule,
            
            /// <summary>
            /// Enum MessagingCampaignSchedule for "MESSAGING_CAMPAIGN_SCHEDULE"
            /// </summary>
            [EnumMember(Value = "MESSAGING_CAMPAIGN_SCHEDULE")]
            MessagingCampaignSchedule,
            
            /// <summary>
            /// Enum EmailCampaignSchedule for "EMAIL_CAMPAIGN_SCHEDULE"
            /// </summary>
            [EnumMember(Value = "EMAIL_CAMPAIGN_SCHEDULE")]
            EmailCampaignSchedule
        }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventLog" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ErrorEntity">ErrorEntity.</param>
        /// <param name="RelatedEntity">RelatedEntity.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Category">Category.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="EventMessage">EventMessage.</param>
        public EventLog(string Name = null, DomainEntityRef ErrorEntity = null, DomainEntityRef RelatedEntity = null, DateTime? Timestamp = null, LevelEnum? Level = null, CategoryEnum? Category = null, string CorrelationId = null, EventMessage EventMessage = null)
        {
            this.Name = Name;
            this.ErrorEntity = ErrorEntity;
            this.RelatedEntity = RelatedEntity;
            this.Timestamp = Timestamp;
            this.Level = Level;
            this.Category = Category;
            this.CorrelationId = CorrelationId;
            this.EventMessage = EventMessage;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets ErrorEntity
        /// </summary>
        [DataMember(Name="errorEntity", EmitDefaultValue=false)]
        public DomainEntityRef ErrorEntity { get; set; }



        /// <summary>
        /// Gets or Sets RelatedEntity
        /// </summary>
        [DataMember(Name="relatedEntity", EmitDefaultValue=false)]
        public DomainEntityRef RelatedEntity { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }







        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }



        /// <summary>
        /// Gets or Sets EventMessage
        /// </summary>
        [DataMember(Name="eventMessage", EmitDefaultValue=false)]
        public EventMessage EventMessage { get; set; }



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
            sb.Append("class EventLog {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ErrorEntity: ").Append(ErrorEntity).Append("\n");
            sb.Append("  RelatedEntity: ").Append(RelatedEntity).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  EventMessage: ").Append(EventMessage).Append("\n");
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
            return this.Equals(obj as EventLog);
        }

        /// <summary>
        /// Returns true if EventLog instances are equal
        /// </summary>
        /// <param name="other">Instance of EventLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventLog other)
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
                    this.ErrorEntity == other.ErrorEntity ||
                    this.ErrorEntity != null &&
                    this.ErrorEntity.Equals(other.ErrorEntity)
                ) &&
                (
                    this.RelatedEntity == other.RelatedEntity ||
                    this.RelatedEntity != null &&
                    this.RelatedEntity.Equals(other.RelatedEntity)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.EventMessage == other.EventMessage ||
                    this.EventMessage != null &&
                    this.EventMessage.Equals(other.EventMessage)
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

                if (this.ErrorEntity != null)
                    hash = hash * 59 + this.ErrorEntity.GetHashCode();

                if (this.RelatedEntity != null)
                    hash = hash * 59 + this.RelatedEntity.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.EventMessage != null)
                    hash = hash * 59 + this.EventMessage.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
