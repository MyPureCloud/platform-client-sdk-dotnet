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
    /// ExternalEventsConfiguration
    /// </summary>
    [DataContract]
    public partial class ExternalEventsConfiguration :  IEquatable<ExternalEventsConfiguration>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventsConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalEventsConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventsConfiguration" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier for the external event configuration. (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">A description of the external event configuration. (required).</param>
        /// <param name="DivisionId">The division ID (UUID) associated with this configuration. (required).</param>
        /// <param name="DivisionIdActive">Indicates whether the divisionId field is valid. (required).</param>
        /// <param name="SchemaId">The dynamic schema ID (UUID) that defines the structure of external events. (required).</param>
        /// <param name="SchemaActive">Indicates whether the schema is active or inactive. (required).</param>
        /// <param name="Source">The source of the external events e.g. Adobe, Salesforce. (required).</param>
        /// <param name="DateLastModified">The timestamp when the configuration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public ExternalEventsConfiguration(string Id = null, string Name = null, string Description = null, string DivisionId = null, bool? DivisionIdActive = null, string SchemaId = null, bool? SchemaActive = null, string Source = null, DateTime? DateLastModified = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.DivisionId = DivisionId;
            this.DivisionIdActive = DivisionIdActive;
            this.SchemaId = SchemaId;
            this.SchemaActive = SchemaActive;
            this.Source = Source;
            this.DateLastModified = DateLastModified;
            
        }
        


        /// <summary>
        /// The unique identifier for the external event configuration.
        /// </summary>
        /// <value>The unique identifier for the external event configuration.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the external event configuration.
        /// </summary>
        /// <value>A description of the external event configuration.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The division ID (UUID) associated with this configuration.
        /// </summary>
        /// <value>The division ID (UUID) associated with this configuration.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// Indicates whether the divisionId field is valid.
        /// </summary>
        /// <value>Indicates whether the divisionId field is valid.</value>
        [DataMember(Name="divisionIdActive", EmitDefaultValue=false)]
        public bool? DivisionIdActive { get; set; }



        /// <summary>
        /// The dynamic schema ID (UUID) that defines the structure of external events.
        /// </summary>
        /// <value>The dynamic schema ID (UUID) that defines the structure of external events.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; set; }



        /// <summary>
        /// Indicates whether the schema is active or inactive.
        /// </summary>
        /// <value>Indicates whether the schema is active or inactive.</value>
        [DataMember(Name="schemaActive", EmitDefaultValue=false)]
        public bool? SchemaActive { get; set; }



        /// <summary>
        /// The source of the external events e.g. Adobe, Salesforce.
        /// </summary>
        /// <value>The source of the external events e.g. Adobe, Salesforce.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// The timestamp when the configuration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the configuration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLastModified", EmitDefaultValue=false)]
        public DateTime? DateLastModified { get; set; }



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
            sb.Append("class ExternalEventsConfiguration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  DivisionIdActive: ").Append(DivisionIdActive).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  SchemaActive: ").Append(SchemaActive).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  DateLastModified: ").Append(DateLastModified).Append("\n");
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
            return this.Equals(obj as ExternalEventsConfiguration);
        }

        /// <summary>
        /// Returns true if ExternalEventsConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEventsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEventsConfiguration other)
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
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.DivisionIdActive == other.DivisionIdActive ||
                    this.DivisionIdActive != null &&
                    this.DivisionIdActive.Equals(other.DivisionIdActive)
                ) &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.SchemaActive == other.SchemaActive ||
                    this.SchemaActive != null &&
                    this.SchemaActive.Equals(other.SchemaActive)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.DateLastModified == other.DateLastModified ||
                    this.DateLastModified != null &&
                    this.DateLastModified.Equals(other.DateLastModified)
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

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.DivisionIdActive != null)
                    hash = hash * 59 + this.DivisionIdActive.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.SchemaActive != null)
                    hash = hash * 59 + this.SchemaActive.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.DateLastModified != null)
                    hash = hash * 59 + this.DateLastModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
