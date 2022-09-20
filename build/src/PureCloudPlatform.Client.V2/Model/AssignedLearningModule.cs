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
    /// Learning module response
    /// </summary>
    [DataContract]
    public partial class AssignedLearningModule :  IEquatable<AssignedLearningModule>
    {
        /// <summary>
        /// The source of the learning module
        /// </summary>
        /// <value>The source of the learning module</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Usercreated for "UserCreated"
            /// </summary>
            [EnumMember(Value = "UserCreated")]
            Usercreated,
            
            /// <summary>
            /// Enum Genesysbeyond for "GenesysBeyond"
            /// </summary>
            [EnumMember(Value = "GenesysBeyond")]
            Genesysbeyond
        }
        /// <summary>
        /// The type for the learning module
        /// </summary>
        /// <value>The type for the learning module</value>
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
            /// Enum Informational for "Informational"
            /// </summary>
            [EnumMember(Value = "Informational")]
            Informational,
            
            /// <summary>
            /// Enum Assessedcontent for "AssessedContent"
            /// </summary>
            [EnumMember(Value = "AssessedContent")]
            Assessedcontent,
            
            /// <summary>
            /// Enum Assessment for "Assessment"
            /// </summary>
            [EnumMember(Value = "Assessment")]
            Assessment
        }
        /// <summary>
        /// The mode of archival for learning module
        /// </summary>
        /// <value>The mode of archival for learning module</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ArchivalModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Graceful for "Graceful"
            /// </summary>
            [EnumMember(Value = "Graceful")]
            Graceful,
            
            /// <summary>
            /// Enum Immediate for "Immediate"
            /// </summary>
            [EnumMember(Value = "Immediate")]
            Immediate
        }
        /// <summary>
        /// The source of the learning module
        /// </summary>
        /// <value>The source of the learning module</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; private set; }
        /// <summary>
        /// The type for the learning module
        /// </summary>
        /// <value>The type for the learning module</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The mode of archival for learning module
        /// </summary>
        /// <value>The mode of archival for learning module</value>
        [DataMember(Name="archivalMode", EmitDefaultValue=false)]
        public ArchivalModeEnum? ArchivalMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedLearningModule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignedLearningModule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedLearningModule" /> class.
        /// </summary>
        /// <param name="Name">The name of learning module (required).</param>
        /// <param name="CurrentAssignments">The current assignments for the requested users.</param>
        /// <param name="Description">The description of learning module.</param>
        /// <param name="CompletionTimeInDays">The completion time of learning module in days (required).</param>
        /// <param name="Type">The type for the learning module.</param>
        /// <param name="InformSteps">The list of inform steps in a learning module.</param>
        /// <param name="AssessmentForm">The assessment form for learning module.</param>
        /// <param name="SummaryData">The learning module summary data.</param>
        /// <param name="CoverArt">The cover art for the learning module.</param>
        /// <param name="ArchivalMode">The mode of archival for learning module.</param>
        public AssignedLearningModule(string Name = null, List<LearningAssignment> CurrentAssignments = null, string Description = null, int? CompletionTimeInDays = null, TypeEnum? Type = null, List<LearningModuleInformStep> InformSteps = null, AssessmentForm AssessmentForm = null, LearningModuleSummary SummaryData = null, LearningModuleCoverArtResponse CoverArt = null, ArchivalModeEnum? ArchivalMode = null)
        {
            this.Name = Name;
            this.CurrentAssignments = CurrentAssignments;
            this.Description = Description;
            this.CompletionTimeInDays = CompletionTimeInDays;
            this.Type = Type;
            this.InformSteps = InformSteps;
            this.AssessmentForm = AssessmentForm;
            this.SummaryData = SummaryData;
            this.CoverArt = CoverArt;
            this.ArchivalMode = ArchivalMode;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of learning module
        /// </summary>
        /// <value>The name of learning module</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The user who created learning module
        /// </summary>
        /// <value>The user who created learning module</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; private set; }



        /// <summary>
        /// The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The user who modified learning module
        /// </summary>
        /// <value>The user who modified learning module</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; private set; }



        /// <summary>
        /// The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The version of published learning module
        /// </summary>
        /// <value>The version of published learning module</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }



        /// <summary>
        /// The external ID of the learning module
        /// </summary>
        /// <value>The external ID of the learning module</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }





        /// <summary>
        /// The rule for learning module; read-only, and only populated when requested via expand param.
        /// </summary>
        /// <value>The rule for learning module; read-only, and only populated when requested via expand param.</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public LearningModuleRule Rule { get; private set; }



        /// <summary>
        /// The current assignments for the requested users
        /// </summary>
        /// <value>The current assignments for the requested users</value>
        [DataMember(Name="currentAssignments", EmitDefaultValue=false)]
        public List<LearningAssignment> CurrentAssignments { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// If true, learning module is archived
        /// </summary>
        /// <value>If true, learning module is archived</value>
        [DataMember(Name="isArchived", EmitDefaultValue=false)]
        public bool? IsArchived { get; private set; }



        /// <summary>
        /// If true, learning module is published
        /// </summary>
        /// <value>If true, learning module is published</value>
        [DataMember(Name="isPublished", EmitDefaultValue=false)]
        public bool? IsPublished { get; private set; }



        /// <summary>
        /// The description of learning module
        /// </summary>
        /// <value>The description of learning module</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The completion time of learning module in days
        /// </summary>
        /// <value>The completion time of learning module in days</value>
        [DataMember(Name="completionTimeInDays", EmitDefaultValue=false)]
        public int? CompletionTimeInDays { get; set; }





        /// <summary>
        /// The list of inform steps in a learning module
        /// </summary>
        /// <value>The list of inform steps in a learning module</value>
        [DataMember(Name="informSteps", EmitDefaultValue=false)]
        public List<LearningModuleInformStep> InformSteps { get; set; }



        /// <summary>
        /// The assessment form for learning module
        /// </summary>
        /// <value>The assessment form for learning module</value>
        [DataMember(Name="assessmentForm", EmitDefaultValue=false)]
        public AssessmentForm AssessmentForm { get; set; }



        /// <summary>
        /// The learning module summary data
        /// </summary>
        /// <value>The learning module summary data</value>
        [DataMember(Name="summaryData", EmitDefaultValue=false)]
        public LearningModuleSummary SummaryData { get; set; }



        /// <summary>
        /// The cover art for the learning module
        /// </summary>
        /// <value>The cover art for the learning module</value>
        [DataMember(Name="coverArt", EmitDefaultValue=false)]
        public LearningModuleCoverArtResponse CoverArt { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignedLearningModule {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  CurrentAssignments: ").Append(CurrentAssignments).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompletionTimeInDays: ").Append(CompletionTimeInDays).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InformSteps: ").Append(InformSteps).Append("\n");
            sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
            sb.Append("  SummaryData: ").Append(SummaryData).Append("\n");
            sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
            sb.Append("  ArchivalMode: ").Append(ArchivalMode).Append("\n");
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
            return this.Equals(obj as AssignedLearningModule);
        }

        /// <summary>
        /// Returns true if AssignedLearningModule instances are equal
        /// </summary>
        /// <param name="other">Instance of AssignedLearningModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignedLearningModule other)
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
                ) &&
                (
                    this.CurrentAssignments == other.CurrentAssignments ||
                    this.CurrentAssignments != null &&
                    this.CurrentAssignments.SequenceEqual(other.CurrentAssignments)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.IsArchived == other.IsArchived ||
                    this.IsArchived != null &&
                    this.IsArchived.Equals(other.IsArchived)
                ) &&
                (
                    this.IsPublished == other.IsPublished ||
                    this.IsPublished != null &&
                    this.IsPublished.Equals(other.IsPublished)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CompletionTimeInDays == other.CompletionTimeInDays ||
                    this.CompletionTimeInDays != null &&
                    this.CompletionTimeInDays.Equals(other.CompletionTimeInDays)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.InformSteps == other.InformSteps ||
                    this.InformSteps != null &&
                    this.InformSteps.SequenceEqual(other.InformSteps)
                ) &&
                (
                    this.AssessmentForm == other.AssessmentForm ||
                    this.AssessmentForm != null &&
                    this.AssessmentForm.Equals(other.AssessmentForm)
                ) &&
                (
                    this.SummaryData == other.SummaryData ||
                    this.SummaryData != null &&
                    this.SummaryData.Equals(other.SummaryData)
                ) &&
                (
                    this.CoverArt == other.CoverArt ||
                    this.CoverArt != null &&
                    this.CoverArt.Equals(other.CoverArt)
                ) &&
                (
                    this.ArchivalMode == other.ArchivalMode ||
                    this.ArchivalMode != null &&
                    this.ArchivalMode.Equals(other.ArchivalMode)
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

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();

                if (this.CurrentAssignments != null)
                    hash = hash * 59 + this.CurrentAssignments.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.IsArchived != null)
                    hash = hash * 59 + this.IsArchived.GetHashCode();

                if (this.IsPublished != null)
                    hash = hash * 59 + this.IsPublished.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.CompletionTimeInDays != null)
                    hash = hash * 59 + this.CompletionTimeInDays.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.InformSteps != null)
                    hash = hash * 59 + this.InformSteps.GetHashCode();

                if (this.AssessmentForm != null)
                    hash = hash * 59 + this.AssessmentForm.GetHashCode();

                if (this.SummaryData != null)
                    hash = hash * 59 + this.SummaryData.GetHashCode();

                if (this.CoverArt != null)
                    hash = hash * 59 + this.CoverArt.GetHashCode();

                if (this.ArchivalMode != null)
                    hash = hash * 59 + this.ArchivalMode.GetHashCode();

                return hash;
            }
        }
    }

}
