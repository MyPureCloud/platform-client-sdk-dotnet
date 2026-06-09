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
    /// OrganizationLinkResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationLinkResponse :  IEquatable<OrganizationLinkResponse>
    {
        /// <summary>
        /// Status of the linking.
        /// </summary>
        /// <value>Status of the linking.</value>
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
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Approvalpending for "ApprovalPending"
            /// </summary>
            [EnumMember(Value = "ApprovalPending")]
            Approvalpending,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected
        }
        /// <summary>
        /// Status of the linking.
        /// </summary>
        /// <value>Status of the linking.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkResponse" /> class.
        /// </summary>
        /// <param name="SourceOrganizationId">Organization Id for the login organization..</param>
        /// <param name="TargetOrganizationId">Organization Id for the linking organization..</param>
        /// <param name="SourceRegion">Region where context organization is hosted, ie. us-east-1.</param>
        /// <param name="TargetRegion">Region where linking organization is hosted, ie. us-east-2.</param>
        /// <param name="TargetName">Name for the linking organization..</param>
        /// <param name="Status">Status of the linking..</param>
        public OrganizationLinkResponse(string SourceOrganizationId = null, string TargetOrganizationId = null, string SourceRegion = null, string TargetRegion = null, string TargetName = null, StatusEnum? Status = null)
        {
            this.SourceOrganizationId = SourceOrganizationId;
            this.TargetOrganizationId = TargetOrganizationId;
            this.SourceRegion = SourceRegion;
            this.TargetRegion = TargetRegion;
            this.TargetName = TargetName;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// Organization Id for the login organization.
        /// </summary>
        /// <value>Organization Id for the login organization.</value>
        [DataMember(Name="sourceOrganizationId", EmitDefaultValue=false)]
        public string SourceOrganizationId { get; set; }



        /// <summary>
        /// Organization Id for the linking organization.
        /// </summary>
        /// <value>Organization Id for the linking organization.</value>
        [DataMember(Name="targetOrganizationId", EmitDefaultValue=false)]
        public string TargetOrganizationId { get; set; }



        /// <summary>
        /// Region where context organization is hosted, ie. us-east-1
        /// </summary>
        /// <value>Region where context organization is hosted, ie. us-east-1</value>
        [DataMember(Name="sourceRegion", EmitDefaultValue=false)]
        public string SourceRegion { get; set; }



        /// <summary>
        /// Region where linking organization is hosted, ie. us-east-2
        /// </summary>
        /// <value>Region where linking organization is hosted, ie. us-east-2</value>
        [DataMember(Name="targetRegion", EmitDefaultValue=false)]
        public string TargetRegion { get; set; }



        /// <summary>
        /// Name for the linking organization.
        /// </summary>
        /// <value>Name for the linking organization.</value>
        [DataMember(Name="targetName", EmitDefaultValue=false)]
        public string TargetName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationLinkResponse {\n");

            sb.Append("  SourceOrganizationId: ").Append(SourceOrganizationId).Append("\n");
            sb.Append("  TargetOrganizationId: ").Append(TargetOrganizationId).Append("\n");
            sb.Append("  SourceRegion: ").Append(SourceRegion).Append("\n");
            sb.Append("  TargetRegion: ").Append(TargetRegion).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as OrganizationLinkResponse);
        }

        /// <summary>
        /// Returns true if OrganizationLinkResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationLinkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationLinkResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceOrganizationId == other.SourceOrganizationId ||
                    this.SourceOrganizationId != null &&
                    this.SourceOrganizationId.Equals(other.SourceOrganizationId)
                ) &&
                (
                    this.TargetOrganizationId == other.TargetOrganizationId ||
                    this.TargetOrganizationId != null &&
                    this.TargetOrganizationId.Equals(other.TargetOrganizationId)
                ) &&
                (
                    this.SourceRegion == other.SourceRegion ||
                    this.SourceRegion != null &&
                    this.SourceRegion.Equals(other.SourceRegion)
                ) &&
                (
                    this.TargetRegion == other.TargetRegion ||
                    this.TargetRegion != null &&
                    this.TargetRegion.Equals(other.TargetRegion)
                ) &&
                (
                    this.TargetName == other.TargetName ||
                    this.TargetName != null &&
                    this.TargetName.Equals(other.TargetName)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.SourceOrganizationId != null)
                    hash = hash * 59 + this.SourceOrganizationId.GetHashCode();

                if (this.TargetOrganizationId != null)
                    hash = hash * 59 + this.TargetOrganizationId.GetHashCode();

                if (this.SourceRegion != null)
                    hash = hash * 59 + this.SourceRegion.GetHashCode();

                if (this.TargetRegion != null)
                    hash = hash * 59 + this.TargetRegion.GetHashCode();

                if (this.TargetName != null)
                    hash = hash * 59 + this.TargetName.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
