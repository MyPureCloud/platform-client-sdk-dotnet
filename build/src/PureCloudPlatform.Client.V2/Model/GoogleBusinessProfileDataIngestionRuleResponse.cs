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
    /// GoogleBusinessProfileDataIngestionRuleResponse
    /// </summary>
    [DataContract]
    public partial class GoogleBusinessProfileDataIngestionRuleResponse :  IEquatable<GoogleBusinessProfileDataIngestionRuleResponse>
    {
        /// <summary>
        /// The status of the data ingestion rule.
        /// </summary>
        /// <value>The status of the data ingestion rule.</value>
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
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Paused for "Paused"
            /// </summary>
            [EnumMember(Value = "Paused")]
            Paused,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Systempaused for "SystemPaused"
            /// </summary>
            [EnumMember(Value = "SystemPaused")]
            Systempaused
        }
        /// <summary>
        /// The status of the data ingestion rule.
        /// </summary>
        /// <value>The status of the data ingestion rule.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleBusinessProfileDataIngestionRuleResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the data ingestion rule..</param>
        /// <param name="Name">The name of the data ingestion rule..</param>
        /// <param name="Description">A description of the data ingestion rule..</param>
        /// <param name="Status">The status of the data ingestion rule..</param>
        /// <param name="Version">The version number of the data ingestion rule..</param>
        /// <param name="IntegrationId">The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource.</param>
        /// <param name="ExternalSource">The external source associated with this data ingestion rule, which is used when performing identity resolution.</param>
        public GoogleBusinessProfileDataIngestionRuleResponse(string Id = null, string Name = null, string Description = null, StatusEnum? Status = null, int? Version = null, string IntegrationId = null, DomainEntityRef ExternalSource = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Status = Status;
            this.Version = Version;
            this.IntegrationId = IntegrationId;
            this.ExternalSource = ExternalSource;
            
        }
        


        /// <summary>
        /// ID of the data ingestion rule.
        /// </summary>
        /// <value>ID of the data ingestion rule.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the data ingestion rule.
        /// </summary>
        /// <value>The name of the data ingestion rule.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the data ingestion rule.
        /// </summary>
        /// <value>A description of the data ingestion rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// The version number of the data ingestion rule.
        /// </summary>
        /// <value>The version number of the data ingestion rule.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The platform of the data ingestion rule.
        /// </summary>
        /// <value>The platform of the data ingestion rule.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; private set; }



        /// <summary>
        /// The countries is available only on twitter data ingestion rule. ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.
        /// </summary>
        /// <value>The countries is available only on twitter data ingestion rule. ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; private set; }



        /// <summary>
        /// The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource
        /// </summary>
        /// <value>The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// The external source associated with this data ingestion rule, which is used when performing identity resolution
        /// </summary>
        /// <value>The external source associated with this data ingestion rule, which is used when performing identity resolution</value>
        [DataMember(Name="externalSource", EmitDefaultValue=false)]
        public DomainEntityRef ExternalSource { get; set; }



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
            sb.Append("class GoogleBusinessProfileDataIngestionRuleResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
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
            return this.Equals(obj as GoogleBusinessProfileDataIngestionRuleResponse);
        }

        /// <summary>
        /// Returns true if GoogleBusinessProfileDataIngestionRuleResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleBusinessProfileDataIngestionRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleBusinessProfileDataIngestionRuleResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.ExternalSource == other.ExternalSource ||
                    this.ExternalSource != null &&
                    this.ExternalSource.Equals(other.ExternalSource)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();

                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.ExternalSource != null)
                    hash = hash * 59 + this.ExternalSource.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
