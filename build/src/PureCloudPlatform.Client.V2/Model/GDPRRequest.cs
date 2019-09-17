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
    /// GDPRRequest
    /// </summary>
    [DataContract]
    public partial class GDPRRequest :  IEquatable<GDPRRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of GDPR request
        /// </summary>
        /// <value>The type of GDPR request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RequestTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum GdprExport for "GDPR_EXPORT"
            /// </summary>
            [EnumMember(Value = "GDPR_EXPORT")]
            GdprExport,
            
            /// <summary>
            /// Enum GdprUpdate for "GDPR_UPDATE"
            /// </summary>
            [EnumMember(Value = "GDPR_UPDATE")]
            GdprUpdate,
            
            /// <summary>
            /// Enum GdprDelete for "GDPR_DELETE"
            /// </summary>
            [EnumMember(Value = "GDPR_DELETE")]
            GdprDelete
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the request
        /// </summary>
        /// <value>The status of the request</value>
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
            /// Enum Initiated for "INITIATED"
            /// </summary>
            [EnumMember(Value = "INITIATED")]
            Initiated,
            
            /// <summary>
            /// Enum Searching for "SEARCHING"
            /// </summary>
            [EnumMember(Value = "SEARCHING")]
            Searching,
            
            /// <summary>
            /// Enum Updating for "UPDATING"
            /// </summary>
            [EnumMember(Value = "UPDATING")]
            Updating,
            
            /// <summary>
            /// Enum Deleting for "DELETING"
            /// </summary>
            [EnumMember(Value = "DELETING")]
            Deleting,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Finalizing for "FINALIZING"
            /// </summary>
            [EnumMember(Value = "FINALIZING")]
            Finalizing
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of GDPR request
        /// </summary>
        /// <value>The type of GDPR request</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public RequestTypeEnum? RequestType { get; set; }
        
        
        
        
        
        /// <summary>
        /// The status of the request
        /// </summary>
        /// <value>The status of the request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GDPRRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRRequest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="CreatedBy">The user that created this request (required).</param>
        /// <param name="ReplacementTerms">The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request.</param>
        /// <param name="RequestType">The type of GDPR request (required).</param>
        /// <param name="Subject">The subject of the GDPR request (required).</param>
        public GDPRRequest(string Name = null, DomainEntityRef CreatedBy = null, List<ReplacementTerm> ReplacementTerms = null, RequestTypeEnum? RequestType = null, GDPRSubject Subject = null)
        {
            this.Name = Name;
            this.CreatedBy = CreatedBy;
            this.ReplacementTerms = ReplacementTerms;
            this.RequestType = RequestType;
            this.Subject = Subject;
            
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
        /// The user that created this request
        /// </summary>
        /// <value>The user that created this request</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request
        /// </summary>
        /// <value>The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request</value>
        [DataMember(Name="replacementTerms", EmitDefaultValue=false)]
        public List<ReplacementTerm> ReplacementTerms { get; set; }
        
        
        
        
        
        /// <summary>
        /// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        
        
        
        
        
        /// <summary>
        /// The subject of the GDPR request
        /// </summary>
        /// <value>The subject of the GDPR request</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public GDPRSubject Subject { get; set; }
        
        
        
        /// <summary>
        /// The location where the results of the request can be retrieved
        /// </summary>
        /// <value>The location where the results of the request can be retrieved</value>
        [DataMember(Name="resultsUrl", EmitDefaultValue=false)]
        public string ResultsUrl { get; private set; }
        
        
        
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
            sb.Append("class GDPRRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ReplacementTerms: ").Append(ReplacementTerms).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ResultsUrl: ").Append(ResultsUrl).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GDPRRequest);
        }

        /// <summary>
        /// Returns true if GDPRRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GDPRRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRRequest other)
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
                    this.ReplacementTerms == other.ReplacementTerms ||
                    this.ReplacementTerms != null &&
                    this.ReplacementTerms.SequenceEqual(other.ReplacementTerms)
                ) &&
                (
                    this.RequestType == other.RequestType ||
                    this.RequestType != null &&
                    this.RequestType.Equals(other.RequestType)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.ResultsUrl == other.ResultsUrl ||
                    this.ResultsUrl != null &&
                    this.ResultsUrl.Equals(other.ResultsUrl)
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
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.ReplacementTerms != null)
                    hash = hash * 59 + this.ReplacementTerms.GetHashCode();
                
                if (this.RequestType != null)
                    hash = hash * 59 + this.RequestType.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                
                if (this.ResultsUrl != null)
                    hash = hash * 59 + this.ResultsUrl.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
