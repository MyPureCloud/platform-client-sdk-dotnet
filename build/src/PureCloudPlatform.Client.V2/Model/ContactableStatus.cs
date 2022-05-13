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
    /// ContactableStatus
    /// </summary>
    [DataContract]
    public partial class ContactableStatus :  IEquatable<ContactableStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactableStatus" /> class.
        /// </summary>
        /// <param name="Contactable">Indicates whether or not the entire contact is contactable for the associated media type..</param>
        /// <param name="ColumnStatus">A map of individual contact method columns to whether the individual column is contactable for the associated media type..</param>
        public ContactableStatus(bool? Contactable = null, Dictionary<string, ColumnStatus> ColumnStatus = null)
        {
            this.Contactable = Contactable;
            this.ColumnStatus = ColumnStatus;
            
        }
        


        /// <summary>
        /// Indicates whether or not the entire contact is contactable for the associated media type.
        /// </summary>
        /// <value>Indicates whether or not the entire contact is contactable for the associated media type.</value>
        [DataMember(Name="contactable", EmitDefaultValue=false)]
        public bool? Contactable { get; set; }



        /// <summary>
        /// A map of individual contact method columns to whether the individual column is contactable for the associated media type.
        /// </summary>
        /// <value>A map of individual contact method columns to whether the individual column is contactable for the associated media type.</value>
        [DataMember(Name="columnStatus", EmitDefaultValue=false)]
        public Dictionary<string, ColumnStatus> ColumnStatus { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactableStatus {\n");

            sb.Append("  Contactable: ").Append(Contactable).Append("\n");
            sb.Append("  ColumnStatus: ").Append(ColumnStatus).Append("\n");
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
            return this.Equals(obj as ContactableStatus);
        }

        /// <summary>
        /// Returns true if ContactableStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactableStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactableStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Contactable == other.Contactable ||
                    this.Contactable != null &&
                    this.Contactable.Equals(other.Contactable)
                ) &&
                (
                    this.ColumnStatus == other.ColumnStatus ||
                    this.ColumnStatus != null &&
                    this.ColumnStatus.SequenceEqual(other.ColumnStatus)
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
                if (this.Contactable != null)
                    hash = hash * 59 + this.Contactable.GetHashCode();

                if (this.ColumnStatus != null)
                    hash = hash * 59 + this.ColumnStatus.GetHashCode();

                return hash;
            }
        }
    }

}
