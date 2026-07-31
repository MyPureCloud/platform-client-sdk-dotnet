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
    /// BuImportTimeOffLimitValuesSchema
    /// </summary>
    [DataContract]
    public partial class BuImportTimeOffLimitValuesSchema :  IEquatable<BuImportTimeOffLimitValuesSchema>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportTimeOffLimitValuesSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuImportTimeOffLimitValuesSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportTimeOffLimitValuesSchema" /> class.
        /// </summary>
        /// <param name="LimitValues">Time-off limit values to import. The list is collection of date and time interval for which allocated limit in minutes is imported.For a time-off limit with daily granularity, the only time interval that should be set for a given date is &#39;00:00&#39;For a time-off limit with fifteen minutes granularity, minimum of one time interval must be specified (required).</param>
        /// <param name="Metadata">Version metadata for the time-off limit (required).</param>
        public BuImportTimeOffLimitValuesSchema(List<BuImportTimeOffLimitValue> LimitValues = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.LimitValues = LimitValues;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Time-off limit values to import. The list is collection of date and time interval for which allocated limit in minutes is imported.For a time-off limit with daily granularity, the only time interval that should be set for a given date is &#39;00:00&#39;For a time-off limit with fifteen minutes granularity, minimum of one time interval must be specified
        /// </summary>
        /// <value>Time-off limit values to import. The list is collection of date and time interval for which allocated limit in minutes is imported.For a time-off limit with daily granularity, the only time interval that should be set for a given date is &#39;00:00&#39;For a time-off limit with fifteen minutes granularity, minimum of one time interval must be specified</value>
        [DataMember(Name="limitValues", EmitDefaultValue=false)]
        public List<BuImportTimeOffLimitValue> LimitValues { get; set; }



        /// <summary>
        /// Version metadata for the time-off limit
        /// </summary>
        /// <value>Version metadata for the time-off limit</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuImportTimeOffLimitValuesSchema {\n");

            sb.Append("  LimitValues: ").Append(LimitValues).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BuImportTimeOffLimitValuesSchema);
        }

        /// <summary>
        /// Returns true if BuImportTimeOffLimitValuesSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of BuImportTimeOffLimitValuesSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuImportTimeOffLimitValuesSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LimitValues == other.LimitValues ||
                    this.LimitValues != null &&
                    this.LimitValues.SequenceEqual(other.LimitValues)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.LimitValues != null)
                    hash = hash * 59 + this.LimitValues.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
