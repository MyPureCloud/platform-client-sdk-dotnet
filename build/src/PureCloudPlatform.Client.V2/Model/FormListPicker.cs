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
    /// List picker component configuration
    /// </summary>
    [DataContract]
    public partial class FormListPicker :  IEquatable<FormListPicker>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListPicker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormListPicker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormListPicker" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the list picker.</param>
        /// <param name="Sections">Sections in the list picker (required).</param>
        public FormListPicker(string Id = null, List<FormListPickerSection> Sections = null)
        {
            this.Id = Id;
            this.Sections = Sections;
            
        }
        


        /// <summary>
        /// Unique identifier for the list picker
        /// </summary>
        /// <value>Unique identifier for the list picker</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Sections in the list picker
        /// </summary>
        /// <value>Sections in the list picker</value>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<FormListPickerSection> Sections { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormListPicker {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
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
            return this.Equals(obj as FormListPicker);
        }

        /// <summary>
        /// Returns true if FormListPicker instances are equal
        /// </summary>
        /// <param name="other">Instance of FormListPicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormListPicker other)
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
                    this.Sections == other.Sections ||
                    this.Sections != null &&
                    this.Sections.SequenceEqual(other.Sections)
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

                if (this.Sections != null)
                    hash = hash * 59 + this.Sections.GetHashCode();

                return hash;
            }
        }
    }

}
