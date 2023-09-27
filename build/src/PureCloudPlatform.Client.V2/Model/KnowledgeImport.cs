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
    /// KnowledgeImport
    /// </summary>
    [DataContract]
    public partial class KnowledgeImport :  IEquatable<KnowledgeImport>
    {
        /// <summary>
        /// file type of the document
        /// </summary>
        /// <value>file type of the document</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FileTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "Csv"
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv,
            
            /// <summary>
            /// Enum Jsonlines for "JsonLines"
            /// </summary>
            [EnumMember(Value = "JsonLines")]
            Jsonlines
        }
        /// <summary>
        /// Status of the operation
        /// </summary>
        /// <value>Status of the operation</value>
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
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Validationinprogress for "ValidationInProgress"
            /// </summary>
            [EnumMember(Value = "ValidationInProgress")]
            Validationinprogress,
            
            /// <summary>
            /// Enum Validationcompleted for "ValidationCompleted"
            /// </summary>
            [EnumMember(Value = "ValidationCompleted")]
            Validationcompleted,
            
            /// <summary>
            /// Enum Validationfailed for "ValidationFailed"
            /// </summary>
            [EnumMember(Value = "ValidationFailed")]
            Validationfailed,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>
            [EnumMember(Value = "Started")]
            Started,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Partialcompleted for "PartialCompleted"
            /// </summary>
            [EnumMember(Value = "PartialCompleted")]
            Partialcompleted,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Abortrequested for "AbortRequested"
            /// </summary>
            [EnumMember(Value = "AbortRequested")]
            Abortrequested,
            
            /// <summary>
            /// Enum Aborted for "Aborted"
            /// </summary>
            [EnumMember(Value = "Aborted")]
            Aborted
        }
        /// <summary>
        /// Language code
        /// </summary>
        /// <value>Language code</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Enuk for "en-UK"
            /// </summary>
            [EnumMember(Value = "en-UK")]
            Enuk,
            
            /// <summary>
            /// Enum Enau for "en-AU"
            /// </summary>
            [EnumMember(Value = "en-AU")]
            Enau,
            
            /// <summary>
            /// Enum Enca for "en-CA"
            /// </summary>
            [EnumMember(Value = "en-CA")]
            Enca,
            
            /// <summary>
            /// Enum Enhk for "en-HK"
            /// </summary>
            [EnumMember(Value = "en-HK")]
            Enhk,
            
            /// <summary>
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Enie for "en-IE"
            /// </summary>
            [EnumMember(Value = "en-IE")]
            Enie,
            
            /// <summary>
            /// Enum Ennz for "en-NZ"
            /// </summary>
            [EnumMember(Value = "en-NZ")]
            Ennz,
            
            /// <summary>
            /// Enum Enph for "en-PH"
            /// </summary>
            [EnumMember(Value = "en-PH")]
            Enph,
            
            /// <summary>
            /// Enum Ensg for "en-SG"
            /// </summary>
            [EnumMember(Value = "en-SG")]
            Ensg,
            
            /// <summary>
            /// Enum Enza for "en-ZA"
            /// </summary>
            [EnumMember(Value = "en-ZA")]
            Enza,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede,
            
            /// <summary>
            /// Enum Deat for "de-AT"
            /// </summary>
            [EnumMember(Value = "de-AT")]
            Deat,
            
            /// <summary>
            /// Enum Dech for "de-CH"
            /// </summary>
            [EnumMember(Value = "de-CH")]
            Dech,
            
            /// <summary>
            /// Enum Esar for "es-AR"
            /// </summary>
            [EnumMember(Value = "es-AR")]
            Esar,
            
            /// <summary>
            /// Enum Esco for "es-CO"
            /// </summary>
            [EnumMember(Value = "es-CO")]
            Esco,
            
            /// <summary>
            /// Enum Esmx for "es-MX"
            /// </summary>
            [EnumMember(Value = "es-MX")]
            Esmx,
            
            /// <summary>
            /// Enum Esus for "es-US"
            /// </summary>
            [EnumMember(Value = "es-US")]
            Esus,
            
            /// <summary>
            /// Enum Eses for "es-ES"
            /// </summary>
            [EnumMember(Value = "es-ES")]
            Eses,
            
            /// <summary>
            /// Enum Frfr for "fr-FR"
            /// </summary>
            [EnumMember(Value = "fr-FR")]
            Frfr,
            
            /// <summary>
            /// Enum Frbe for "fr-BE"
            /// </summary>
            [EnumMember(Value = "fr-BE")]
            Frbe,
            
            /// <summary>
            /// Enum Frca for "fr-CA"
            /// </summary>
            [EnumMember(Value = "fr-CA")]
            Frca,
            
            /// <summary>
            /// Enum Frch for "fr-CH"
            /// </summary>
            [EnumMember(Value = "fr-CH")]
            Frch,
            
            /// <summary>
            /// Enum Ptbr for "pt-BR"
            /// </summary>
            [EnumMember(Value = "pt-BR")]
            Ptbr,
            
            /// <summary>
            /// Enum Ptpt for "pt-PT"
            /// </summary>
            [EnumMember(Value = "pt-PT")]
            Ptpt,
            
            /// <summary>
            /// Enum Nlnl for "nl-NL"
            /// </summary>
            [EnumMember(Value = "nl-NL")]
            Nlnl,
            
            /// <summary>
            /// Enum Nlbe for "nl-BE"
            /// </summary>
            [EnumMember(Value = "nl-BE")]
            Nlbe,
            
            /// <summary>
            /// Enum Itit for "it-IT"
            /// </summary>
            [EnumMember(Value = "it-IT")]
            Itit,
            
            /// <summary>
            /// Enum Caes for "ca-ES"
            /// </summary>
            [EnumMember(Value = "ca-ES")]
            Caes,
            
            /// <summary>
            /// Enum Trtr for "tr-TR"
            /// </summary>
            [EnumMember(Value = "tr-TR")]
            Trtr,
            
            /// <summary>
            /// Enum Svse for "sv-SE"
            /// </summary>
            [EnumMember(Value = "sv-SE")]
            Svse,
            
            /// <summary>
            /// Enum Fifi for "fi-FI"
            /// </summary>
            [EnumMember(Value = "fi-FI")]
            Fifi,
            
            /// <summary>
            /// Enum Nbno for "nb-NO"
            /// </summary>
            [EnumMember(Value = "nb-NO")]
            Nbno,
            
            /// <summary>
            /// Enum Dadk for "da-DK"
            /// </summary>
            [EnumMember(Value = "da-DK")]
            Dadk
        }
        /// <summary>
        /// file type of the document
        /// </summary>
        /// <value>file type of the document</value>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// Status of the operation
        /// </summary>
        /// <value>Status of the operation</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Language code
        /// </summary>
        /// <value>Language code</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeImport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImport" /> class.
        /// </summary>
        /// <param name="Name">Name of the import operation.</param>
        /// <param name="UploadKey">Upload key (required).</param>
        /// <param name="FileType">file type of the document (required).</param>
        /// <param name="IgnoreHeaders">Ignore headers for the specified file.</param>
        public KnowledgeImport(string Name = null, string UploadKey = null, FileTypeEnum? FileType = null, bool? IgnoreHeaders = null)
        {
            this.Name = Name;
            this.UploadKey = UploadKey;
            this.FileType = FileType;
            this.IgnoreHeaders = IgnoreHeaders;
            
        }
        


        /// <summary>
        /// Id of the import operation
        /// </summary>
        /// <value>Id of the import operation</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Name of the import operation
        /// </summary>
        /// <value>Name of the import operation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Upload key
        /// </summary>
        /// <value>Upload key</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }





        /// <summary>
        /// Ignore headers for the specified file
        /// </summary>
        /// <value>Ignore headers for the specified file</value>
        [DataMember(Name="ignoreHeaders", EmitDefaultValue=false)]
        public bool? IgnoreHeaders { get; set; }





        /// <summary>
        /// Report of the import operation
        /// </summary>
        /// <value>Report of the import operation</value>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public ImportReport Report { get; private set; }



        /// <summary>
        /// Knowledge base which document import does belong to
        /// </summary>
        /// <value>Knowledge base which document import does belong to</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; private set; }





        /// <summary>
        /// Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
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
            sb.Append("class KnowledgeImport {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  IgnoreHeaders: ").Append(IgnoreHeaders).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(obj as KnowledgeImport);
        }

        /// <summary>
        /// Returns true if KnowledgeImport instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeImport other)
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
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.FileType == other.FileType ||
                    this.FileType != null &&
                    this.FileType.Equals(other.FileType)
                ) &&
                (
                    this.IgnoreHeaders == other.IgnoreHeaders ||
                    this.IgnoreHeaders != null &&
                    this.IgnoreHeaders.Equals(other.IgnoreHeaders)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Report == other.Report ||
                    this.Report != null &&
                    this.Report.Equals(other.Report)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
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

                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.FileType != null)
                    hash = hash * 59 + this.FileType.GetHashCode();

                if (this.IgnoreHeaders != null)
                    hash = hash * 59 + this.IgnoreHeaders.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Report != null)
                    hash = hash * 59 + this.Report.GetHashCode();

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

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
