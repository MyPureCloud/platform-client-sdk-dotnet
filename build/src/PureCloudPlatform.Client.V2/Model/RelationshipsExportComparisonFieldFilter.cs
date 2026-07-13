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
    /// RelationshipsExportComparisonFieldFilter
    /// </summary>
    [DataContract]
    public partial class RelationshipsExportComparisonFieldFilter :  IEquatable<RelationshipsExportComparisonFieldFilter>
    {
        /// <summary>
        /// Field name to apply the filter
        /// </summary>
        /// <value>Field name to apply the filter</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Createdate for "CreateDate"
            /// </summary>
            [EnumMember(Value = "CreateDate")]
            Createdate,
            
            /// <summary>
            /// Enum Modifydate for "ModifyDate"
            /// </summary>
            [EnumMember(Value = "ModifyDate")]
            Modifydate
        }
        /// <summary>
        /// Field name to apply the filter
        /// </summary>
        /// <value>Field name to apply the filter</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipsExportComparisonFieldFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelationshipsExportComparisonFieldFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipsExportComparisonFieldFilter" /> class.
        /// </summary>
        /// <param name="Field">Field name to apply the filter (required).</param>
        /// <param name="Value">Value to compare field&#39;s value against (required).</param>
        public RelationshipsExportComparisonFieldFilter(FieldEnum? Field = null, string Value = null)
        {
            this.Field = Field;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// Value to compare field&#39;s value against
        /// </summary>
        /// <value>Value to compare field&#39;s value against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationshipsExportComparisonFieldFilter {\n");

            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as RelationshipsExportComparisonFieldFilter);
        }

        /// <summary>
        /// Returns true if RelationshipsExportComparisonFieldFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of RelationshipsExportComparisonFieldFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationshipsExportComparisonFieldFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
