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
    /// SocialTopicWithDataIngestionRuleMetadataResponse
    /// </summary>
    [DataContract]
    public partial class SocialTopicWithDataIngestionRuleMetadataResponse :  IEquatable<SocialTopicWithDataIngestionRuleMetadataResponse>
    {
        /// <summary>
        /// The status of the social topic.
        /// </summary>
        /// <value>The status of the social topic.</value>
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
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// The status of the social topic.
        /// </summary>
        /// <value>The status of the social topic.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialTopicWithDataIngestionRuleMetadataResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the social topic..</param>
        /// <param name="Name">The name of the social topic..</param>
        /// <param name="Description">A description of the social topic..</param>
        /// <param name="DateCreated">Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DivisionId">The ID of the division to which the social topic belongs to..</param>
        /// <param name="Status">The status of the social topic..</param>
        /// <param name="DataIngestionRulesMetadata">The data ingestion rule metadata..</param>
        public SocialTopicWithDataIngestionRuleMetadataResponse(string Id = null, string Name = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string DivisionId = null, StatusEnum? Status = null, List<DataIngestionRulesMetadata> DataIngestionRulesMetadata = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DivisionId = DivisionId;
            this.Status = Status;
            this.DataIngestionRulesMetadata = DataIngestionRulesMetadata;
            
        }
        


        /// <summary>
        /// ID of the social topic.
        /// </summary>
        /// <value>ID of the social topic.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the social topic.
        /// </summary>
        /// <value>The name of the social topic.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the social topic.
        /// </summary>
        /// <value>A description of the social topic.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The ID of the division to which the social topic belongs to.
        /// </summary>
        /// <value>The ID of the division to which the social topic belongs to.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }





        /// <summary>
        /// The data ingestion rule metadata.
        /// </summary>
        /// <value>The data ingestion rule metadata.</value>
        [DataMember(Name="dataIngestionRulesMetadata", EmitDefaultValue=false)]
        public List<DataIngestionRulesMetadata> DataIngestionRulesMetadata { get; set; }



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
            sb.Append("class SocialTopicWithDataIngestionRuleMetadataResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataIngestionRulesMetadata: ").Append(DataIngestionRulesMetadata).Append("\n");
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
            return this.Equals(obj as SocialTopicWithDataIngestionRuleMetadataResponse);
        }

        /// <summary>
        /// Returns true if SocialTopicWithDataIngestionRuleMetadataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialTopicWithDataIngestionRuleMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialTopicWithDataIngestionRuleMetadataResponse other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DataIngestionRulesMetadata == other.DataIngestionRulesMetadata ||
                    this.DataIngestionRulesMetadata != null &&
                    this.DataIngestionRulesMetadata.SequenceEqual(other.DataIngestionRulesMetadata)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DataIngestionRulesMetadata != null)
                    hash = hash * 59 + this.DataIngestionRulesMetadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
