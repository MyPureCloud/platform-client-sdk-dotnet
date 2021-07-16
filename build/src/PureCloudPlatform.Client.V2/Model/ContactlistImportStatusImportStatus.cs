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
    /// ContactlistImportStatusImportStatus
    /// </summary>
    [DataContract]
    public partial class ContactlistImportStatusImportStatus :  IEquatable<ContactlistImportStatusImportStatus>
    {
        
        
        /// <summary>
        /// Gets or Sets ImportState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImportStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ImportState
        /// </summary>
        [DataMember(Name="importState", EmitDefaultValue=false)]
        public ImportStateEnum? ImportState { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactlistImportStatusImportStatus" /> class.
        /// </summary>
        /// <param name="ImportState">ImportState.</param>
        /// <param name="TotalRecords">TotalRecords.</param>
        /// <param name="CompletedRecords">CompletedRecords.</param>
        /// <param name="PercentageComplete">PercentageComplete.</param>
        /// <param name="FailureReason">FailureReason.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public ContactlistImportStatusImportStatus(ImportStateEnum? ImportState = null, int? TotalRecords = null, int? CompletedRecords = null, int? PercentageComplete = null, string FailureReason = null, Object AdditionalProperties = null)
        {
            this.ImportState = ImportState;
            this.TotalRecords = TotalRecords;
            this.CompletedRecords = CompletedRecords;
            this.PercentageComplete = PercentageComplete;
            this.FailureReason = FailureReason;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public int? TotalRecords { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CompletedRecords
        /// </summary>
        [DataMember(Name="completedRecords", EmitDefaultValue=false)]
        public int? CompletedRecords { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PercentageComplete
        /// </summary>
        [DataMember(Name="percentageComplete", EmitDefaultValue=false)]
        public int? PercentageComplete { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactlistImportStatusImportStatus {\n");
            
            sb.Append("  ImportState: ").Append(ImportState).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
            sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as ContactlistImportStatusImportStatus);
        }

        /// <summary>
        /// Returns true if ContactlistImportStatusImportStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactlistImportStatusImportStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactlistImportStatusImportStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ImportState == other.ImportState ||
                    this.ImportState != null &&
                    this.ImportState.Equals(other.ImportState)
                ) &&
                (
                    this.TotalRecords == other.TotalRecords ||
                    this.TotalRecords != null &&
                    this.TotalRecords.Equals(other.TotalRecords)
                ) &&
                (
                    this.CompletedRecords == other.CompletedRecords ||
                    this.CompletedRecords != null &&
                    this.CompletedRecords.Equals(other.CompletedRecords)
                ) &&
                (
                    this.PercentageComplete == other.PercentageComplete ||
                    this.PercentageComplete != null &&
                    this.PercentageComplete.Equals(other.PercentageComplete)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.ImportState != null)
                    hash = hash * 59 + this.ImportState.GetHashCode();
                
                if (this.TotalRecords != null)
                    hash = hash * 59 + this.TotalRecords.GetHashCode();
                
                if (this.CompletedRecords != null)
                    hash = hash * 59 + this.CompletedRecords.GetHashCode();
                
                if (this.PercentageComplete != null)
                    hash = hash * 59 + this.PercentageComplete.GetHashCode();
                
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
