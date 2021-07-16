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
    /// DataSchema
    /// </summary>
    [DataContract]
    public partial class DataSchema :  IEquatable<DataSchema>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets AppliesTo
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AppliesToEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Contact for "CONTACT"
            /// </summary>
            [EnumMember(Value = "CONTACT")]
            Contact,
            
            /// <summary>
            /// Enum ExternalOrganization for "EXTERNAL_ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "EXTERNAL_ORGANIZATION")]
            ExternalOrganization
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSchema() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSchema" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">The schema&#39;s version, a positive integer. Required for updates. (required).</param>
        /// <param name="AppliesTo">One of \&quot;CONTACT\&quot; or \&quot;EXTERNAL_ORGANIZATION\&quot;.  Indicates the built-in entity type to which this schema applies..</param>
        /// <param name="Enabled">The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists..</param>
        /// <param name="CreatedBy">The URI of the user that created this schema..</param>
        /// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type. (required).</param>
        public DataSchema(string Name = null, int? Version = null, List<AppliesToEnum> AppliesTo = null, bool? Enabled = null, DomainEntityRef CreatedBy = null, JsonSchemaDocument JsonSchema = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.AppliesTo = AppliesTo;
            this.Enabled = Enabled;
            this.CreatedBy = CreatedBy;
            this.JsonSchema = JsonSchema;
            
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
        /// The schema&#39;s version, a positive integer. Required for updates.
        /// </summary>
        /// <value>The schema&#39;s version, a positive integer. Required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// One of \&quot;CONTACT\&quot; or \&quot;EXTERNAL_ORGANIZATION\&quot;.  Indicates the built-in entity type to which this schema applies.
        /// </summary>
        /// <value>One of \&quot;CONTACT\&quot; or \&quot;EXTERNAL_ORGANIZATION\&quot;.  Indicates the built-in entity type to which this schema applies.</value>
        [DataMember(Name="appliesTo", EmitDefaultValue=false)]
        public List<AppliesToEnum> AppliesTo { get; set; }
        
        
        
        /// <summary>
        /// The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.
        /// </summary>
        /// <value>The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The URI of the user that created this schema.
        /// </summary>
        /// <value>The URI of the user that created this schema.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// A JSON schema defining the extension to the built-in entity type.
        /// </summary>
        /// <value>A JSON schema defining the extension to the built-in entity type.</value>
        [DataMember(Name="jsonSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument JsonSchema { get; set; }
        
        
        
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
            sb.Append("class DataSchema {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  AppliesTo: ").Append(AppliesTo).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
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
            return this.Equals(obj as DataSchema);
        }

        /// <summary>
        /// Returns true if DataSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSchema other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.AppliesTo == other.AppliesTo ||
                    this.AppliesTo != null &&
                    this.AppliesTo.SequenceEqual(other.AppliesTo)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.JsonSchema == other.JsonSchema ||
                    this.JsonSchema != null &&
                    this.JsonSchema.Equals(other.JsonSchema)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.AppliesTo != null)
                    hash = hash * 59 + this.AppliesTo.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.JsonSchema != null)
                    hash = hash * 59 + this.JsonSchema.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
