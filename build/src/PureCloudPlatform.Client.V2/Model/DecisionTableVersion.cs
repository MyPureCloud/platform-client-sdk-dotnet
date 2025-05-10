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
    /// DecisionTableVersion
    /// </summary>
    [DataContract]
    public partial class DecisionTableVersion :  IEquatable<DecisionTableVersion>
    {
        /// <summary>
        /// Current status of this decision table version
        /// </summary>
        /// <value>Current status of this decision table version</value>
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
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Preparing for "Preparing"
            /// </summary>
            [EnumMember(Value = "Preparing")]
            Preparing,
            
            /// <summary>
            /// Enum Superseded for "Superseded"
            /// </summary>
            [EnumMember(Value = "Superseded")]
            Superseded
        }
        /// <summary>
        /// Current status of this decision table version
        /// </summary>
        /// <value>Current status of this decision table version</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableVersion" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Version">The decision table version..</param>
        /// <param name="Status">Current status of this decision table version.</param>
        /// <param name="Description">The decision table description..</param>
        /// <param name="RowCount">The number of rows in this decision table version..</param>
        /// <param name="RowsUri">The rows URI for this decision table version..</param>
        /// <param name="Columns">The column definitions of this decision table version..</param>
        /// <param name="Contract">The contract information for this decision table version..</param>
        public DecisionTableVersion(string Name = null, Division Division = null, int? Version = null, StatusEnum? Status = null, string Description = null, int? RowCount = null, string RowsUri = null, DecisionTableColumns Columns = null, DecisionTableContract Contract = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Version = Version;
            this.Status = Status;
            this.Description = Description;
            this.RowCount = RowCount;
            this.RowsUri = RowsUri;
            this.Columns = Columns;
            this.Contract = Contract;
            
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
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }



        /// <summary>
        /// The decision table version.
        /// </summary>
        /// <value>The decision table version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }





        /// <summary>
        /// The decision table description.
        /// </summary>
        /// <value>The decision table description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The number of rows in this decision table version.
        /// </summary>
        /// <value>The number of rows in this decision table version.</value>
        [DataMember(Name="rowCount", EmitDefaultValue=false)]
        public int? RowCount { get; set; }



        /// <summary>
        /// The rows URI for this decision table version.
        /// </summary>
        /// <value>The rows URI for this decision table version.</value>
        [DataMember(Name="rowsUri", EmitDefaultValue=false)]
        public string RowsUri { get; set; }



        /// <summary>
        /// UTC date time indicating when this decision table version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC date time indicating when this decision table version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// UTC date time indicating when this decision table version was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC date time indicating when this decision table version was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// UTC date time indicating when this decision table version was published. Null if never published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC date time indicating when this decision table version was published. Null if never published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; private set; }



        /// <summary>
        /// The column definitions of this decision table version.
        /// </summary>
        /// <value>The column definitions of this decision table version.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public DecisionTableColumns Columns { get; set; }



        /// <summary>
        /// The contract information for this decision table version.
        /// </summary>
        /// <value>The contract information for this decision table version.</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public DecisionTableContract Contract { get; set; }



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
            sb.Append("class DecisionTableVersion {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RowCount: ").Append(RowCount).Append("\n");
            sb.Append("  RowsUri: ").Append(RowsUri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
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
            return this.Equals(obj as DecisionTableVersion);
        }

        /// <summary>
        /// Returns true if DecisionTableVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableVersion other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.RowCount == other.RowCount ||
                    this.RowCount != null &&
                    this.RowCount.Equals(other.RowCount)
                ) &&
                (
                    this.RowsUri == other.RowsUri ||
                    this.RowsUri != null &&
                    this.RowsUri.Equals(other.RowsUri)
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
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.Equals(other.Columns)
                ) &&
                (
                    this.Contract == other.Contract ||
                    this.Contract != null &&
                    this.Contract.Equals(other.Contract)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.RowCount != null)
                    hash = hash * 59 + this.RowCount.GetHashCode();

                if (this.RowsUri != null)
                    hash = hash * 59 + this.RowsUri.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();

                if (this.Contract != null)
                    hash = hash * 59 + this.Contract.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
