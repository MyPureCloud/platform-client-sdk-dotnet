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
    /// CsvMappingEntry
    /// </summary>
    [DataContract]
    public partial class CsvMappingEntry :  IEquatable<CsvMappingEntry>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvMappingEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsvMappingEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvMappingEntry" /> class.
        /// </summary>
        /// <param name="SourceField">CSV field to map data from (required).</param>
        /// <param name="TargetField">Json path to map data to (required).</param>
        public CsvMappingEntry(string SourceField = null, string TargetField = null)
        {
            this.SourceField = SourceField;
            this.TargetField = TargetField;
            
        }
        


        /// <summary>
        /// CSV field to map data from
        /// </summary>
        /// <value>CSV field to map data from</value>
        [DataMember(Name="sourceField", EmitDefaultValue=false)]
        public string SourceField { get; set; }



        /// <summary>
        /// Json path to map data to
        /// </summary>
        /// <value>Json path to map data to</value>
        [DataMember(Name="targetField", EmitDefaultValue=false)]
        public string TargetField { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsvMappingEntry {\n");

            sb.Append("  SourceField: ").Append(SourceField).Append("\n");
            sb.Append("  TargetField: ").Append(TargetField).Append("\n");
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
            return this.Equals(obj as CsvMappingEntry);
        }

        /// <summary>
        /// Returns true if CsvMappingEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of CsvMappingEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvMappingEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceField == other.SourceField ||
                    this.SourceField != null &&
                    this.SourceField.Equals(other.SourceField)
                ) &&
                (
                    this.TargetField == other.TargetField ||
                    this.TargetField != null &&
                    this.TargetField.Equals(other.TargetField)
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
                if (this.SourceField != null)
                    hash = hash * 59 + this.SourceField.GetHashCode();

                if (this.TargetField != null)
                    hash = hash * 59 + this.TargetField.GetHashCode();

                return hash;
            }
        }
    }

}
