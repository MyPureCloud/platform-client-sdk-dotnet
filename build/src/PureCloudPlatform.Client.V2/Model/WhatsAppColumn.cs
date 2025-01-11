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
    /// WhatsAppColumn
    /// </summary>
    [DataContract]
    public partial class WhatsAppColumn :  IEquatable<WhatsAppColumn>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppColumn" /> class.
        /// </summary>
        /// <param name="ColumnName">The name of the whatsApp column. (required).</param>
        /// <param name="Type">Indicates the type of the whatsApp column. For example, 'work' or 'personal'. (required).</param>
        /// <param name="ContactableTimeColumn">A column that indicates the timezone to use for a given contact when checking contactable times..</param>
        public WhatsAppColumn(string ColumnName = null, string Type = null, string ContactableTimeColumn = null)
        {
            this.ColumnName = ColumnName;
            this.Type = Type;
            this.ContactableTimeColumn = ContactableTimeColumn;
            
        }
        


        /// <summary>
        /// The name of the whatsApp column.
        /// </summary>
        /// <value>The name of the whatsApp column.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }



        /// <summary>
        /// Indicates the type of the whatsApp column. For example, 'work' or 'personal'.
        /// </summary>
        /// <value>Indicates the type of the whatsApp column. For example, 'work' or 'personal'.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// A column that indicates the timezone to use for a given contact when checking contactable times.
        /// </summary>
        /// <value>A column that indicates the timezone to use for a given contact when checking contactable times.</value>
        [DataMember(Name="contactableTimeColumn", EmitDefaultValue=false)]
        public string ContactableTimeColumn { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppColumn {\n");

            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContactableTimeColumn: ").Append(ContactableTimeColumn).Append("\n");
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
            return this.Equals(obj as WhatsAppColumn);
        }

        /// <summary>
        /// Returns true if WhatsAppColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ContactableTimeColumn == other.ContactableTimeColumn ||
                    this.ContactableTimeColumn != null &&
                    this.ContactableTimeColumn.Equals(other.ContactableTimeColumn)
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
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ContactableTimeColumn != null)
                    hash = hash * 59 + this.ContactableTimeColumn.GetHashCode();

                return hash;
            }
        }
    }

}
