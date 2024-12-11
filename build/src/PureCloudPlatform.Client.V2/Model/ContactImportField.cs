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
    /// ContactImportField
    /// </summary>
    [DataContract]
    public partial class ContactImportField :  IEquatable<ContactImportField>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImportField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactImportField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactImportField" /> class.
        /// </summary>
        /// <param name="Name">Field name (required).</param>
        /// <param name="Included">Should we import this field (required).</param>
        public ContactImportField(string Name = null, bool? Included = null)
        {
            this.Name = Name;
            this.Included = Included;
            
        }
        


        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Should we import this field
        /// </summary>
        /// <value>Should we import this field</value>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public bool? Included { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactImportField {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
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
            return this.Equals(obj as ContactImportField);
        }

        /// <summary>
        /// Returns true if ContactImportField instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactImportField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactImportField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Included == other.Included ||
                    this.Included != null &&
                    this.Included.Equals(other.Included)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Included != null)
                    hash = hash * 59 + this.Included.GetHashCode();

                return hash;
            }
        }
    }

}
