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
    /// ContactsExportQueryConditions
    /// </summary>
    [DataContract]
    public partial class ContactsExportQueryConditions :  IEquatable<ContactsExportQueryConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsExportQueryConditions" /> class.
        /// </summary>
        /// <param name="Filters">Filters to apply on export.</param>
        /// <param name="Limit">Maximum result count in export, default is 180 000 000.</param>
        public ContactsExportQueryConditions(ContactsExportFilter Filters = null, int? Limit = null)
        {
            this.Filters = Filters;
            this.Limit = Limit;
            
        }
        


        /// <summary>
        /// Filters to apply on export
        /// </summary>
        /// <value>Filters to apply on export</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public ContactsExportFilter Filters { get; set; }



        /// <summary>
        /// Maximum result count in export, default is 180 000 000
        /// </summary>
        /// <value>Maximum result count in export, default is 180 000 000</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsExportQueryConditions {\n");

            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as ContactsExportQueryConditions);
        }

        /// <summary>
        /// Returns true if ContactsExportQueryConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactsExportQueryConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsExportQueryConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.Equals(other.Filters)
                ) &&
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();

                return hash;
            }
        }
    }

}
