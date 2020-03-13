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
    /// State information for an export job of rows from a datatable
    /// </summary>
    [DataContract]
    public partial class DataTableExportJob :  IEquatable<DataTableExportJob>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the export job
        /// </summary>
        /// <value>The status of the export job</value>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the export job
        /// </summary>
        /// <value>The status of the export job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableExportJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataTableExportJob() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableExportJob" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">The PureCloud user who started the export job.</param>
        /// <param name="Status">The status of the export job (required).</param>
        /// <param name="DateCreated">The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateCompleted">The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DownloadURI">The URL of the location at which the caller can download the export file, when available.</param>
        /// <param name="ErrorInformation">Any error information, or null of the processing is not in an error state.</param>
        /// <param name="CountRecordsProcessed">The current count of the number of records processed.</param>
        public DataTableExportJob(string Name = null, AddressableEntityRef Owner = null, StatusEnum? Status = null, DateTime? DateCreated = null, DateTime? DateCompleted = null, string DownloadURI = null, ErrorBody ErrorInformation = null, int? CountRecordsProcessed = null)
        {
            this.Name = Name;
            this.Owner = Owner;
            this.Status = Status;
            this.DateCreated = DateCreated;
            this.DateCompleted = DateCompleted;
            this.DownloadURI = DownloadURI;
            this.ErrorInformation = ErrorInformation;
            this.CountRecordsProcessed = CountRecordsProcessed;
            
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
        /// The PureCloud user who started the export job
        /// </summary>
        /// <value>The PureCloud user who started the export job</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public AddressableEntityRef Owner { get; set; }
        
        
        
        
        
        /// <summary>
        /// The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }
        
        
        
        /// <summary>
        /// The URL of the location at which the caller can download the export file, when available
        /// </summary>
        /// <value>The URL of the location at which the caller can download the export file, when available</value>
        [DataMember(Name="downloadURI", EmitDefaultValue=false)]
        public string DownloadURI { get; set; }
        
        
        
        /// <summary>
        /// Any error information, or null of the processing is not in an error state
        /// </summary>
        /// <value>Any error information, or null of the processing is not in an error state</value>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public ErrorBody ErrorInformation { get; set; }
        
        
        
        /// <summary>
        /// The current count of the number of records processed
        /// </summary>
        /// <value>The current count of the number of records processed</value>
        [DataMember(Name="countRecordsProcessed", EmitDefaultValue=false)]
        public int? CountRecordsProcessed { get; set; }
        
        
        
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
            sb.Append("class DataTableExportJob {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  DownloadURI: ").Append(DownloadURI).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
            sb.Append("  CountRecordsProcessed: ").Append(CountRecordsProcessed).Append("\n");
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
            return this.Equals(obj as DataTableExportJob);
        }

        /// <summary>
        /// Returns true if DataTableExportJob instances are equal
        /// </summary>
        /// <param name="other">Instance of DataTableExportJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTableExportJob other)
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
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    this.DownloadURI == other.DownloadURI ||
                    this.DownloadURI != null &&
                    this.DownloadURI.Equals(other.DownloadURI)
                ) &&
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
                ) &&
                (
                    this.CountRecordsProcessed == other.CountRecordsProcessed ||
                    this.CountRecordsProcessed != null &&
                    this.CountRecordsProcessed.Equals(other.CountRecordsProcessed)
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
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                
                if (this.DownloadURI != null)
                    hash = hash * 59 + this.DownloadURI.GetHashCode();
                
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
                
                if (this.CountRecordsProcessed != null)
                    hash = hash * 59 + this.CountRecordsProcessed.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
