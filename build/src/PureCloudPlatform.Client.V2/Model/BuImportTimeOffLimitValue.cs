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
    /// BuImportTimeOffLimitValue
    /// </summary>
    [DataContract]
    public partial class BuImportTimeOffLimitValue :  IEquatable<BuImportTimeOffLimitValue>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportTimeOffLimitValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuImportTimeOffLimitValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportTimeOffLimitValue" /> class.
        /// </summary>
        /// <param name="ImportDateTime">The time-off limit interval UTC date time in ISO8601. (required).</param>
        /// <param name="ImportMinutes">The limit value in minutes specified for a given date and time interval.</param>
        public BuImportTimeOffLimitValue(DateTime? ImportDateTime = null, int? ImportMinutes = null)
        {
            this.ImportDateTime = ImportDateTime;
            this.ImportMinutes = ImportMinutes;
            
        }
        


        /// <summary>
        /// The time-off limit interval UTC date time in ISO8601.
        /// </summary>
        /// <value>The time-off limit interval UTC date time in ISO8601.</value>
        [DataMember(Name="importDateTime", EmitDefaultValue=false)]
        public DateTime? ImportDateTime { get; set; }



        /// <summary>
        /// The limit value in minutes specified for a given date and time interval
        /// </summary>
        /// <value>The limit value in minutes specified for a given date and time interval</value>
        [DataMember(Name="importMinutes", EmitDefaultValue=false)]
        public int? ImportMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuImportTimeOffLimitValue {\n");

            sb.Append("  ImportDateTime: ").Append(ImportDateTime).Append("\n");
            sb.Append("  ImportMinutes: ").Append(ImportMinutes).Append("\n");
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
            return this.Equals(obj as BuImportTimeOffLimitValue);
        }

        /// <summary>
        /// Returns true if BuImportTimeOffLimitValue instances are equal
        /// </summary>
        /// <param name="other">Instance of BuImportTimeOffLimitValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuImportTimeOffLimitValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ImportDateTime == other.ImportDateTime ||
                    this.ImportDateTime != null &&
                    this.ImportDateTime.Equals(other.ImportDateTime)
                ) &&
                (
                    this.ImportMinutes == other.ImportMinutes ||
                    this.ImportMinutes != null &&
                    this.ImportMinutes.Equals(other.ImportMinutes)
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
                if (this.ImportDateTime != null)
                    hash = hash * 59 + this.ImportDateTime.GetHashCode();

                if (this.ImportMinutes != null)
                    hash = hash * 59 + this.ImportMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
