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
    /// CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification
    /// </summary>
    [DataContract]
    public partial class CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification :  IEquatable<CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Granularity
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Weekly for "Weekly"
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly
        }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Timedout for "TimedOut"
            /// </summary>
            [EnumMember(Value = "TimedOut")]
            Timedout,
            
            /// <summary>
            /// Enum Nodata for "NoData"
            /// </summary>
            [EnumMember(Value = "NoData")]
            Nodata,
            
            /// <summary>
            /// Enum Clientdatainvalid for "ClientDataInvalid"
            /// </summary>
            [EnumMember(Value = "ClientDataInvalid")]
            Clientdatainvalid,
            
            /// <summary>
            /// Enum Configurationinvalid for "ConfigurationInvalid"
            /// </summary>
            [EnumMember(Value = "ConfigurationInvalid")]
            Configurationinvalid,
            
            /// <summary>
            /// Enum Requirementsfailed for "RequirementsFailed"
            /// </summary>
            [EnumMember(Value = "RequirementsFailed")]
            Requirementsfailed
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Granularity
        /// </summary>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification" /> class.
        /// </summary>
        /// <param name="CapacityPlan">CapacityPlan.</param>
        /// <param name="BusinessUnit">BusinessUnit.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ReferenceBusinessUnitDate">ReferenceBusinessUnitDate.</param>
        /// <param name="Granularity">Granularity.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        public CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification(CapacityPlanningRequirementsResultTopicCapacityPlanReference CapacityPlan = null, CapacityPlanningRequirementsResultTopicBusinessUnit BusinessUnit = null, StatusEnum? Status = null, DateTime? ReferenceBusinessUnitDate = null, GranularityEnum? Granularity = null, string DownloadUrl = null, ErrorCodeEnum? ErrorCode = null)
        {
            this.CapacityPlan = CapacityPlan;
            this.BusinessUnit = BusinessUnit;
            this.Status = Status;
            this.ReferenceBusinessUnitDate = ReferenceBusinessUnitDate;
            this.Granularity = Granularity;
            this.DownloadUrl = DownloadUrl;
            this.ErrorCode = ErrorCode;
            
        }
        


        /// <summary>
        /// Gets or Sets CapacityPlan
        /// </summary>
        [DataMember(Name="capacityPlan", EmitDefaultValue=false)]
        public CapacityPlanningRequirementsResultTopicCapacityPlanReference CapacityPlan { get; set; }



        /// <summary>
        /// Gets or Sets BusinessUnit
        /// </summary>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public CapacityPlanningRequirementsResultTopicBusinessUnit BusinessUnit { get; set; }





        /// <summary>
        /// Gets or Sets ReferenceBusinessUnitDate
        /// </summary>
        [DataMember(Name="referenceBusinessUnitDate", EmitDefaultValue=false)]
        public DateTime? ReferenceBusinessUnitDate { get; set; }





        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification {\n");

            sb.Append("  CapacityPlan: ").Append(CapacityPlan).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReferenceBusinessUnitDate: ").Append(ReferenceBusinessUnitDate).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(obj as CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification);
        }

        /// <summary>
        /// Returns true if CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanningRequirementsResultTopicStaffingRequirementsNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CapacityPlan == other.CapacityPlan ||
                    this.CapacityPlan != null &&
                    this.CapacityPlan.Equals(other.CapacityPlan)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ReferenceBusinessUnitDate == other.ReferenceBusinessUnitDate ||
                    this.ReferenceBusinessUnitDate != null &&
                    this.ReferenceBusinessUnitDate.Equals(other.ReferenceBusinessUnitDate)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
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
                if (this.CapacityPlan != null)
                    hash = hash * 59 + this.CapacityPlan.GetHashCode();

                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ReferenceBusinessUnitDate != null)
                    hash = hash * 59 + this.ReferenceBusinessUnitDate.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                return hash;
            }
        }
    }

}
