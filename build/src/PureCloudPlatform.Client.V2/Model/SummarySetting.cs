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
    /// SummarySetting
    /// </summary>
    [DataContract]
    public partial class SummarySetting :  IEquatable<SummarySetting>
    {
        /// <summary>
        /// Level of detail of the generated summary.
        /// </summary>
        /// <value>Level of detail of the generated summary.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SummaryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Concise for "Concise"
            /// </summary>
            [EnumMember(Value = "Concise")]
            Concise,
            
            /// <summary>
            /// Enum Detailed for "Detailed"
            /// </summary>
            [EnumMember(Value = "Detailed")]
            Detailed
        }
        /// <summary>
        /// Format of the generated summary.
        /// </summary>
        /// <value>Format of the generated summary.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Textblock for "TextBlock"
            /// </summary>
            [EnumMember(Value = "TextBlock")]
            Textblock,
            
            /// <summary>
            /// Enum Bulletpoints for "BulletPoints"
            /// </summary>
            [EnumMember(Value = "BulletPoints")]
            Bulletpoints,
            
            /// <summary>
            /// Enum Groupedtextblocks for "GroupedTextBlocks"
            /// </summary>
            [EnumMember(Value = "GroupedTextBlocks")]
            Groupedtextblocks,
            
            /// <summary>
            /// Enum Groupedbulletpoints for "GroupedBulletPoints"
            /// </summary>
            [EnumMember(Value = "GroupedBulletPoints")]
            Groupedbulletpoints
        }
        /// <summary>
        /// Gets or Sets PredefinedInsights
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PredefinedInsightsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Reasonforcall for "ReasonForCall"
            /// </summary>
            [EnumMember(Value = "ReasonForCall")]
            Reasonforcall,
            
            /// <summary>
            /// Enum Resolution for "Resolution"
            /// </summary>
            [EnumMember(Value = "Resolution")]
            Resolution,
            
            /// <summary>
            /// Enum Actionitems for "ActionItems"
            /// </summary>
            [EnumMember(Value = "ActionItems")]
            Actionitems
        }
        /// <summary>
        /// Type of the summary setting.
        /// </summary>
        /// <value>Type of the summary setting.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SettingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Basic for "Basic"
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic,
            
            /// <summary>
            /// Enum Prompt for "Prompt"
            /// </summary>
            [EnumMember(Value = "Prompt")]
            Prompt
        }
        /// <summary>
        /// Service type for summarization. Can be 'Native' for Genesys native summarization engine or 'External' for external service. If specified as 'External', integrationId must be provided.
        /// </summary>
        /// <value>Service type for summarization. Can be 'Native' for Genesys native summarization engine or 'External' for external service. If specified as 'External', integrationId must be provided.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Native for "Native"
            /// </summary>
            [EnumMember(Value = "Native")]
            Native,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External
        }
        /// <summary>
        /// Level of detail of the generated summary.
        /// </summary>
        /// <value>Level of detail of the generated summary.</value>
        [DataMember(Name="summaryType", EmitDefaultValue=false)]
        public SummaryTypeEnum? SummaryType { get; set; }
        /// <summary>
        /// Format of the generated summary.
        /// </summary>
        /// <value>Format of the generated summary.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Type of the summary setting.
        /// </summary>
        /// <value>Type of the summary setting.</value>
        [DataMember(Name="settingType", EmitDefaultValue=false)]
        public SettingTypeEnum? SettingType { get; set; }
        /// <summary>
        /// Service type for summarization. Can be 'Native' for Genesys native summarization engine or 'External' for external service. If specified as 'External', integrationId must be provided.
        /// </summary>
        /// <value>Service type for summarization. Can be 'Native' for Genesys native summarization engine or 'External' for external service. If specified as 'External', integrationId must be provided.</value>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public ServiceTypeEnum? ServiceType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySetting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SummarySetting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySetting" /> class.
        /// </summary>
        /// <param name="Name">Name of the summary setting. (required).</param>
        /// <param name="Language">Language of the generated summary, e.g. en-US, it-IT. (required).</param>
        /// <param name="SummaryType">Level of detail of the generated summary..</param>
        /// <param name="Format">Format of the generated summary..</param>
        /// <param name="MaskPII">Displaying PII in the generated summary..</param>
        /// <param name="ParticipantLabels">How to refer to interaction participants in the generated summary..</param>
        /// <param name="PredefinedInsights">Set which insights to include in the generated summary by default..</param>
        /// <param name="CustomEntities">Custom entity definition..</param>
        /// <param name="SettingType">Type of the summary setting..</param>
        /// <param name="Prompt">Custom prompt of summary setting..</param>
        /// <param name="ServiceType">Service type for summarization. Can be &#39;Native&#39; for Genesys native summarization engine or &#39;External&#39; for external service. If specified as &#39;External&#39;, integrationId must be provided..</param>
        /// <param name="IntegrationId">Integration ID for the external summarization service. Required when serviceType is External..</param>
        /// <param name="TimeoutDuration">Timeout duration in seconds for the external summarization service request..</param>
        public SummarySetting(string Name = null, string Language = null, SummaryTypeEnum? SummaryType = null, FormatEnum? Format = null, SummarySettingPII MaskPII = null, SummarySettingParticipantLabels ParticipantLabels = null, List<PredefinedInsightsEnum> PredefinedInsights = null, List<SummarySettingCustomEntity> CustomEntities = null, SettingTypeEnum? SettingType = null, string Prompt = null, ServiceTypeEnum? ServiceType = null, string IntegrationId = null, int? TimeoutDuration = null)
        {
            this.Name = Name;
            this.Language = Language;
            this.SummaryType = SummaryType;
            this.Format = Format;
            this.MaskPII = MaskPII;
            this.ParticipantLabels = ParticipantLabels;
            this.PredefinedInsights = PredefinedInsights;
            this.CustomEntities = CustomEntities;
            this.SettingType = SettingType;
            this.Prompt = Prompt;
            this.ServiceType = ServiceType;
            this.IntegrationId = IntegrationId;
            this.TimeoutDuration = TimeoutDuration;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Name of the summary setting.
        /// </summary>
        /// <value>Name of the summary setting.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Language of the generated summary, e.g. en-US, it-IT.
        /// </summary>
        /// <value>Language of the generated summary, e.g. en-US, it-IT.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }







        /// <summary>
        /// Displaying PII in the generated summary.
        /// </summary>
        /// <value>Displaying PII in the generated summary.</value>
        [DataMember(Name="maskPII", EmitDefaultValue=false)]
        public SummarySettingPII MaskPII { get; set; }



        /// <summary>
        /// How to refer to interaction participants in the generated summary.
        /// </summary>
        /// <value>How to refer to interaction participants in the generated summary.</value>
        [DataMember(Name="participantLabels", EmitDefaultValue=false)]
        public SummarySettingParticipantLabels ParticipantLabels { get; set; }



        /// <summary>
        /// Set which insights to include in the generated summary by default.
        /// </summary>
        /// <value>Set which insights to include in the generated summary by default.</value>
        [DataMember(Name="predefinedInsights", EmitDefaultValue=false)]
        public List<PredefinedInsightsEnum> PredefinedInsights { get; set; }



        /// <summary>
        /// Custom entity definition.
        /// </summary>
        /// <value>Custom entity definition.</value>
        [DataMember(Name="customEntities", EmitDefaultValue=false)]
        public List<SummarySettingCustomEntity> CustomEntities { get; set; }





        /// <summary>
        /// Custom prompt of summary setting.
        /// </summary>
        /// <value>Custom prompt of summary setting.</value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }





        /// <summary>
        /// Integration ID for the external summarization service. Required when serviceType is External.
        /// </summary>
        /// <value>Integration ID for the external summarization service. Required when serviceType is External.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// Timeout duration in seconds for the external summarization service request.
        /// </summary>
        /// <value>Timeout duration in seconds for the external summarization service request.</value>
        [DataMember(Name="timeoutDuration", EmitDefaultValue=false)]
        public int? TimeoutDuration { get; set; }



        /// <summary>
        /// The date and time the setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date and time the setting was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the setting was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



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
            sb.Append("class SummarySetting {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SummaryType: ").Append(SummaryType).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MaskPII: ").Append(MaskPII).Append("\n");
            sb.Append("  ParticipantLabels: ").Append(ParticipantLabels).Append("\n");
            sb.Append("  PredefinedInsights: ").Append(PredefinedInsights).Append("\n");
            sb.Append("  CustomEntities: ").Append(CustomEntities).Append("\n");
            sb.Append("  SettingType: ").Append(SettingType).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  TimeoutDuration: ").Append(TimeoutDuration).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as SummarySetting);
        }

        /// <summary>
        /// Returns true if SummarySetting instances are equal
        /// </summary>
        /// <param name="other">Instance of SummarySetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummarySetting other)
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
                    this.SummaryType == other.SummaryType ||
                    this.SummaryType != null &&
                    this.SummaryType.Equals(other.SummaryType)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) &&
                (
                    this.MaskPII == other.MaskPII ||
                    this.MaskPII != null &&
                    this.MaskPII.Equals(other.MaskPII)
                ) &&
                (
                    this.ParticipantLabels == other.ParticipantLabels ||
                    this.ParticipantLabels != null &&
                    this.ParticipantLabels.Equals(other.ParticipantLabels)
                ) &&
                (
                    this.PredefinedInsights == other.PredefinedInsights ||
                    this.PredefinedInsights != null &&
                    this.PredefinedInsights.SequenceEqual(other.PredefinedInsights)
                ) &&
                (
                    this.CustomEntities == other.CustomEntities ||
                    this.CustomEntities != null &&
                    this.CustomEntities.SequenceEqual(other.CustomEntities)
                ) &&
                (
                    this.SettingType == other.SettingType ||
                    this.SettingType != null &&
                    this.SettingType.Equals(other.SettingType)
                ) &&
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) &&
                (
                    this.ServiceType == other.ServiceType ||
                    this.ServiceType != null &&
                    this.ServiceType.Equals(other.ServiceType)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.TimeoutDuration == other.TimeoutDuration ||
                    this.TimeoutDuration != null &&
                    this.TimeoutDuration.Equals(other.TimeoutDuration)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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

                if (this.SummaryType != null)
                    hash = hash * 59 + this.SummaryType.GetHashCode();

                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();

                if (this.MaskPII != null)
                    hash = hash * 59 + this.MaskPII.GetHashCode();

                if (this.ParticipantLabels != null)
                    hash = hash * 59 + this.ParticipantLabels.GetHashCode();

                if (this.PredefinedInsights != null)
                    hash = hash * 59 + this.PredefinedInsights.GetHashCode();

                if (this.CustomEntities != null)
                    hash = hash * 59 + this.CustomEntities.GetHashCode();

                if (this.SettingType != null)
                    hash = hash * 59 + this.SettingType.GetHashCode();

                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();

                if (this.ServiceType != null)
                    hash = hash * 59 + this.ServiceType.GetHashCode();

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.TimeoutDuration != null)
                    hash = hash * 59 + this.TimeoutDuration.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
