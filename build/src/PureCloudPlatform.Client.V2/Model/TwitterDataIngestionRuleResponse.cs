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
    /// TwitterDataIngestionRuleResponse
    /// </summary>
    [DataContract]
    public partial class TwitterDataIngestionRuleResponse :  IEquatable<TwitterDataIngestionRuleResponse>
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
        /// Initializes a new instance of the <see cref="TwitterDataIngestionRuleResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the data ingestion rule..</param>
        /// <param name="Name">The name of the data ingestion rule..</param>
        /// <param name="Description">A description of the data ingestion rule..</param>
        /// <param name="SearchTerms">Search terms for X (formally Twitter)..</param>
        /// <param name="Countries">ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide..</param>
        /// <param name="DateCreated">Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Status">The status of the data ingestion rule..</param>
        /// <param name="Version">The version number of the data ingestion rule..</param>
        public TwitterDataIngestionRuleResponse(string Id = null, string Name = null, string Description = null, string SearchTerms = null, List<string> Countries = null, DateTime? DateCreated = null, DateTime? DateModified = null, StatusEnum? Status = null, int? Version = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.SearchTerms = SearchTerms;
            this.Countries = Countries;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Status = Status;
            this.Version = Version;
            
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
        /// Search terms for X (formally Twitter).
        /// </summary>
        /// <value>Search terms for X (formally Twitter).</value>
        [DataMember(Name="searchTerms", EmitDefaultValue=false)]
        public string SearchTerms { get; set; }



        /// <summary>
        /// ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.
        /// </summary>
        /// <value>ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }



        /// <summary>
        /// Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }





        /// <summary>
        /// The version number of the data ingestion rule.
        /// </summary>
        /// <value>The version number of the data ingestion rule.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



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
            sb.Append("class TwitterDataIngestionRuleResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as TwitterDataIngestionRuleResponse);
        }

        /// <summary>
        /// Returns true if TwitterDataIngestionRuleResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterDataIngestionRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterDataIngestionRuleResponse other)
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
                    this.SearchTerms == other.SearchTerms ||
                    this.SearchTerms != null &&
                    this.SearchTerms.Equals(other.SearchTerms)
                ) &&
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
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

                if (this.SearchTerms != null)
                    hash = hash * 59 + this.SearchTerms.GetHashCode();

                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
