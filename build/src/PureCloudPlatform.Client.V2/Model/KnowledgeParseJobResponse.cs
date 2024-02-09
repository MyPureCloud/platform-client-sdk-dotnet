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
    /// KnowledgeParseJobResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseJobResponse :  IEquatable<KnowledgeParseJobResponse>
    {
        /// <summary>
        /// Status of the parse job
        /// </summary>
        /// <value>Status of the parse job</value>
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
            /// Enum Readytoparse for "ReadyToParse"
            /// </summary>
            [EnumMember(Value = "ReadyToParse")]
            Readytoparse,
            
            /// <summary>
            /// Enum Parseinprogress for "ParseInProgress"
            /// </summary>
            [EnumMember(Value = "ParseInProgress")]
            Parseinprogress,
            
            /// <summary>
            /// Enum Parsecompleted for "ParseCompleted"
            /// </summary>
            [EnumMember(Value = "ParseCompleted")]
            Parsecompleted,
            
            /// <summary>
            /// Enum Readytoimport for "ReadyToImport"
            /// </summary>
            [EnumMember(Value = "ReadyToImport")]
            Readytoimport,
            
            /// <summary>
            /// Enum Importinprogress for "ImportInProgress"
            /// </summary>
            [EnumMember(Value = "ImportInProgress")]
            Importinprogress,
            
            /// <summary>
            /// Enum Importcompleted for "ImportCompleted"
            /// </summary>
            [EnumMember(Value = "ImportCompleted")]
            Importcompleted,
            
            /// <summary>
            /// Enum Importpartialcompleted for "ImportPartialCompleted"
            /// </summary>
            [EnumMember(Value = "ImportPartialCompleted")]
            Importpartialcompleted,
            
            /// <summary>
            /// Enum Importfailed for "ImportFailed"
            /// </summary>
            [EnumMember(Value = "ImportFailed")]
            Importfailed
        }
        /// <summary>
        /// Status of the parse job
        /// </summary>
        /// <value>Status of the parse job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseJobResponse" /> class.
        /// </summary>
        /// <param name="DownloadURL">The URL of the location at which the caller can download the original html file..</param>
        /// <param name="Hints">Hinted titles for the parser..</param>
        /// <param name="CreatedBy">The user who created the operation.</param>
        public KnowledgeParseJobResponse(string DownloadURL = null, List<string> Hints = null, UserReference CreatedBy = null)
        {
            this.DownloadURL = DownloadURL;
            this.Hints = Hints;
            this.CreatedBy = CreatedBy;
            
        }
        


        /// <summary>
        /// Id of the parse job
        /// </summary>
        /// <value>Id of the parse job</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The URL of the location at which the caller can download the original html file.
        /// </summary>
        /// <value>The URL of the location at which the caller can download the original html file.</value>
        [DataMember(Name="downloadURL", EmitDefaultValue=false)]
        public string DownloadURL { get; set; }



        /// <summary>
        /// Hinted titles for the parser.
        /// </summary>
        /// <value>Hinted titles for the parser.</value>
        [DataMember(Name="hints", EmitDefaultValue=false)]
        public List<string> Hints { get; set; }





        /// <summary>
        /// Results of the parse
        /// </summary>
        /// <value>Results of the parse</value>
        [DataMember(Name="parseResults", EmitDefaultValue=false)]
        public List<KnowledgeParseRecord> ParseResults { get; private set; }



        /// <summary>
        /// Result of the import phase
        /// </summary>
        /// <value>Result of the import phase</value>
        [DataMember(Name="importResult", EmitDefaultValue=false)]
        public KnowledgeParseImportResult ImportResult { get; private set; }



        /// <summary>
        /// The user who created the operation
        /// </summary>
        /// <value>The user who created the operation</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



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
            sb.Append("class KnowledgeParseJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ParseResults: ").Append(ParseResults).Append("\n");
            sb.Append("  ImportResult: ").Append(ImportResult).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(obj as KnowledgeParseJobResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeParseJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseJobResponse other)
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
                    this.DownloadURL == other.DownloadURL ||
                    this.DownloadURL != null &&
                    this.DownloadURL.Equals(other.DownloadURL)
                ) &&
                (
                    this.Hints == other.Hints ||
                    this.Hints != null &&
                    this.Hints.SequenceEqual(other.Hints)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ParseResults == other.ParseResults ||
                    this.ParseResults != null &&
                    this.ParseResults.SequenceEqual(other.ParseResults)
                ) &&
                (
                    this.ImportResult == other.ImportResult ||
                    this.ImportResult != null &&
                    this.ImportResult.Equals(other.ImportResult)
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

                if (this.DownloadURL != null)
                    hash = hash * 59 + this.DownloadURL.GetHashCode();

                if (this.Hints != null)
                    hash = hash * 59 + this.Hints.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ParseResults != null)
                    hash = hash * 59 + this.ParseResults.GetHashCode();

                if (this.ImportResult != null)
                    hash = hash * 59 + this.ImportResult.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

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
