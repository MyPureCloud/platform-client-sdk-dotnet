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
    /// SchemaQuantityLimits
    /// </summary>
    [DataContract]
    public partial class SchemaQuantityLimits :  IEquatable<SchemaQuantityLimits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaQuantityLimits" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        public SchemaQuantityLimits(string Name = null)
        {
            this.Name = Name;
            
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
        /// The minimum number of schema field name characters allowed.
        /// </summary>
        /// <value>The minimum number of schema field name characters allowed.</value>
        [DataMember(Name="minFieldNameCharacters", EmitDefaultValue=false)]
        public int? MinFieldNameCharacters { get; private set; }



        /// <summary>
        /// The maximum number of schema field name characters allowed.
        /// </summary>
        /// <value>The maximum number of schema field name characters allowed.</value>
        [DataMember(Name="maxFieldNameCharacters", EmitDefaultValue=false)]
        public int? MaxFieldNameCharacters { get; private set; }



        /// <summary>
        /// The minimum number of schema field description characters allowed.
        /// </summary>
        /// <value>The minimum number of schema field description characters allowed.</value>
        [DataMember(Name="minFieldDescriptionCharacters", EmitDefaultValue=false)]
        public int? MinFieldDescriptionCharacters { get; private set; }



        /// <summary>
        /// The maximum number of schema field description characters allowed.
        /// </summary>
        /// <value>The maximum number of schema field description characters allowed.</value>
        [DataMember(Name="maxFieldDescriptionCharacters", EmitDefaultValue=false)]
        public int? MaxFieldDescriptionCharacters { get; private set; }



        /// <summary>
        /// The minimum number of schema name characters allowed.
        /// </summary>
        /// <value>The minimum number of schema name characters allowed.</value>
        [DataMember(Name="minSchemaNameCharacters", EmitDefaultValue=false)]
        public int? MinSchemaNameCharacters { get; private set; }



        /// <summary>
        /// The maximum number of schema name characters allowed.
        /// </summary>
        /// <value>The maximum number of schema name characters allowed.</value>
        [DataMember(Name="maxSchemaNameCharacters", EmitDefaultValue=false)]
        public int? MaxSchemaNameCharacters { get; private set; }



        /// <summary>
        /// The minimum number of schema description characters allowed.
        /// </summary>
        /// <value>The minimum number of schema description characters allowed.</value>
        [DataMember(Name="minSchemaDescriptionCharacters", EmitDefaultValue=false)]
        public int? MinSchemaDescriptionCharacters { get; private set; }



        /// <summary>
        /// The maximum number of schema description characters allowed.
        /// </summary>
        /// <value>The maximum number of schema description characters allowed.</value>
        [DataMember(Name="maxSchemaDescriptionCharacters", EmitDefaultValue=false)]
        public int? MaxSchemaDescriptionCharacters { get; private set; }



        /// <summary>
        /// The maximum number of schema allowed per org.
        /// </summary>
        /// <value>The maximum number of schema allowed per org.</value>
        [DataMember(Name="maxNumberOfSchemasPerOrg", EmitDefaultValue=false)]
        public int? MaxNumberOfSchemasPerOrg { get; private set; }



        /// <summary>
        /// The maximum number of schema fields allowed per schema.
        /// </summary>
        /// <value>The maximum number of schema fields allowed per schema.</value>
        [DataMember(Name="maxNumberOfFieldsPerSchema", EmitDefaultValue=false)]
        public int? MaxNumberOfFieldsPerSchema { get; private set; }



        /// <summary>
        /// The maximum number of schema fields allowed per organization across all of their schemas.
        /// </summary>
        /// <value>The maximum number of schema fields allowed per organization across all of their schemas.</value>
        [DataMember(Name="maxNumberOfFieldsPerOrg", EmitDefaultValue=false)]
        public int? MaxNumberOfFieldsPerOrg { get; private set; }



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
            sb.Append("class SchemaQuantityLimits {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinFieldNameCharacters: ").Append(MinFieldNameCharacters).Append("\n");
            sb.Append("  MaxFieldNameCharacters: ").Append(MaxFieldNameCharacters).Append("\n");
            sb.Append("  MinFieldDescriptionCharacters: ").Append(MinFieldDescriptionCharacters).Append("\n");
            sb.Append("  MaxFieldDescriptionCharacters: ").Append(MaxFieldDescriptionCharacters).Append("\n");
            sb.Append("  MinSchemaNameCharacters: ").Append(MinSchemaNameCharacters).Append("\n");
            sb.Append("  MaxSchemaNameCharacters: ").Append(MaxSchemaNameCharacters).Append("\n");
            sb.Append("  MinSchemaDescriptionCharacters: ").Append(MinSchemaDescriptionCharacters).Append("\n");
            sb.Append("  MaxSchemaDescriptionCharacters: ").Append(MaxSchemaDescriptionCharacters).Append("\n");
            sb.Append("  MaxNumberOfSchemasPerOrg: ").Append(MaxNumberOfSchemasPerOrg).Append("\n");
            sb.Append("  MaxNumberOfFieldsPerSchema: ").Append(MaxNumberOfFieldsPerSchema).Append("\n");
            sb.Append("  MaxNumberOfFieldsPerOrg: ").Append(MaxNumberOfFieldsPerOrg).Append("\n");
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
            return this.Equals(obj as SchemaQuantityLimits);
        }

        /// <summary>
        /// Returns true if SchemaQuantityLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of SchemaQuantityLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaQuantityLimits other)
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
                    this.MinFieldNameCharacters == other.MinFieldNameCharacters ||
                    this.MinFieldNameCharacters != null &&
                    this.MinFieldNameCharacters.Equals(other.MinFieldNameCharacters)
                ) &&
                (
                    this.MaxFieldNameCharacters == other.MaxFieldNameCharacters ||
                    this.MaxFieldNameCharacters != null &&
                    this.MaxFieldNameCharacters.Equals(other.MaxFieldNameCharacters)
                ) &&
                (
                    this.MinFieldDescriptionCharacters == other.MinFieldDescriptionCharacters ||
                    this.MinFieldDescriptionCharacters != null &&
                    this.MinFieldDescriptionCharacters.Equals(other.MinFieldDescriptionCharacters)
                ) &&
                (
                    this.MaxFieldDescriptionCharacters == other.MaxFieldDescriptionCharacters ||
                    this.MaxFieldDescriptionCharacters != null &&
                    this.MaxFieldDescriptionCharacters.Equals(other.MaxFieldDescriptionCharacters)
                ) &&
                (
                    this.MinSchemaNameCharacters == other.MinSchemaNameCharacters ||
                    this.MinSchemaNameCharacters != null &&
                    this.MinSchemaNameCharacters.Equals(other.MinSchemaNameCharacters)
                ) &&
                (
                    this.MaxSchemaNameCharacters == other.MaxSchemaNameCharacters ||
                    this.MaxSchemaNameCharacters != null &&
                    this.MaxSchemaNameCharacters.Equals(other.MaxSchemaNameCharacters)
                ) &&
                (
                    this.MinSchemaDescriptionCharacters == other.MinSchemaDescriptionCharacters ||
                    this.MinSchemaDescriptionCharacters != null &&
                    this.MinSchemaDescriptionCharacters.Equals(other.MinSchemaDescriptionCharacters)
                ) &&
                (
                    this.MaxSchemaDescriptionCharacters == other.MaxSchemaDescriptionCharacters ||
                    this.MaxSchemaDescriptionCharacters != null &&
                    this.MaxSchemaDescriptionCharacters.Equals(other.MaxSchemaDescriptionCharacters)
                ) &&
                (
                    this.MaxNumberOfSchemasPerOrg == other.MaxNumberOfSchemasPerOrg ||
                    this.MaxNumberOfSchemasPerOrg != null &&
                    this.MaxNumberOfSchemasPerOrg.Equals(other.MaxNumberOfSchemasPerOrg)
                ) &&
                (
                    this.MaxNumberOfFieldsPerSchema == other.MaxNumberOfFieldsPerSchema ||
                    this.MaxNumberOfFieldsPerSchema != null &&
                    this.MaxNumberOfFieldsPerSchema.Equals(other.MaxNumberOfFieldsPerSchema)
                ) &&
                (
                    this.MaxNumberOfFieldsPerOrg == other.MaxNumberOfFieldsPerOrg ||
                    this.MaxNumberOfFieldsPerOrg != null &&
                    this.MaxNumberOfFieldsPerOrg.Equals(other.MaxNumberOfFieldsPerOrg)
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

                if (this.MinFieldNameCharacters != null)
                    hash = hash * 59 + this.MinFieldNameCharacters.GetHashCode();

                if (this.MaxFieldNameCharacters != null)
                    hash = hash * 59 + this.MaxFieldNameCharacters.GetHashCode();

                if (this.MinFieldDescriptionCharacters != null)
                    hash = hash * 59 + this.MinFieldDescriptionCharacters.GetHashCode();

                if (this.MaxFieldDescriptionCharacters != null)
                    hash = hash * 59 + this.MaxFieldDescriptionCharacters.GetHashCode();

                if (this.MinSchemaNameCharacters != null)
                    hash = hash * 59 + this.MinSchemaNameCharacters.GetHashCode();

                if (this.MaxSchemaNameCharacters != null)
                    hash = hash * 59 + this.MaxSchemaNameCharacters.GetHashCode();

                if (this.MinSchemaDescriptionCharacters != null)
                    hash = hash * 59 + this.MinSchemaDescriptionCharacters.GetHashCode();

                if (this.MaxSchemaDescriptionCharacters != null)
                    hash = hash * 59 + this.MaxSchemaDescriptionCharacters.GetHashCode();

                if (this.MaxNumberOfSchemasPerOrg != null)
                    hash = hash * 59 + this.MaxNumberOfSchemasPerOrg.GetHashCode();

                if (this.MaxNumberOfFieldsPerSchema != null)
                    hash = hash * 59 + this.MaxNumberOfFieldsPerSchema.GetHashCode();

                if (this.MaxNumberOfFieldsPerOrg != null)
                    hash = hash * 59 + this.MaxNumberOfFieldsPerOrg.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
